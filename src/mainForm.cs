using System.Diagnostics;
using System.Net;
using LibreHardwareMonitor.Hardware;

namespace productionLine
{
    public partial class mainForm : Form
    {
        private PerformanceCounter cpuUsageCounter;
        private PerformanceCounter ramUsageCounter;

        private Computer computer;

        private bool engineOn = false;
        private bool resetState = false;
        private bool stopState = false;
        private bool fanState = false;
        private int attentionCounter = 30;
        private int engineShutdownCounter = 11;
        private int tempWarningCounter = 10;
        private double engineTemperature = 30.0;
        private Random randomGenerator = new Random();

        public mainForm()
        {
            InitializeComponent();
            cpuUsageCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramUsageCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");

            computer = new Computer
            {
                IsCpuEnabled = true,
                IsMotherboardEnabled = true
            };
            computer.Open();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = confirmedUser.Username;
            if (confirmedUser.AuthorizationLvl == 3) { accessLabel.Text = "admin"; }
            else if (confirmedUser.AuthorizationLvl == 2) { accessLabel.Text = "operator"; }
            else if (confirmedUser.AuthorizationLvl == 1) { accessLabel.Text = "viewer"; }
            else { accessLabel.Text = "error"; }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            computer.Close();
            base.OnFormClosing(e);
        }

        private void parametersUpdate(float usage, Label label, string textPrefix, Panel fillPanel, Panel backgroudPanel, int colourThreshold1, int colourThreshold2)
        {
            label.Text = textPrefix + $"{usage:0.0}%";
            fillPanel.Width = ((int)usage * backgroudPanel.Width) / 100;

            if ((int)usage > colourThreshold2) fillPanel.BackColor = Color.Red;
            else if ((int)usage > colourThreshold1) fillPanel.BackColor = Color.Yellow;
            else fillPanel.BackColor = Color.LimeGreen;
        }

        private void parametersTimer_Tick(object sender, EventArgs e)
        {
            parametersUpdate(cpuUsageCounter.NextValue(), cpuUsageLabel, "CPU usage: ", cpuFillPanel, cpuBackgroudPanel, 20, 80);
            parametersUpdate(ramUsageCounter.NextValue(), ramUsageLabel, "RAM usage: ", ramFillPanel, ramBackgroudPanel, 60, 80);
        }
        private void userAttentionTimer_Tick(object sender, EventArgs e)
        {
            if (engineOn == true)
            {
                attentionCounter -= 1;
                if (attentionCounter >= 0)
                {
                    timerLabel.Text = $"{attentionCounter}";
                }
                else if (attentionCounter < 0)
                {
                    engineShutdownCounter -= 1;
                    timerLabel.Text = $"{engineShutdownCounter}";
                    userAttentionButton.Text = $"USER INPUT NEEDED : {engineShutdownCounter}";
                    userAttentionButton.ForeColor = Color.IndianRed;
                    if (engineShutdownCounter <= 0)
                    {
                        machineStop();
                    }
                }
            }
        }

        private void engineTempTimer_Tick(object sender, EventArgs e)
        {
            double targetWorkTemp = 85.0;

            double randomNoise = (randomGenerator.NextDouble() * 0.4) - 0.2;

            if (engineOn)
            {
                if (fanState)
                {
                    double coolingPower = (engineTemperature / 30.0);
                    engineTemperature -= coolingPower + randomNoise;
                }
                else
                {
                    if (engineTemperature < targetWorkTemp)
                    {
                        double heatingPower = (targetWorkTemp - engineTemperature) / 20.0;

                        if (heatingPower < 0.2) heatingPower = 0.2;

                        engineTemperature += heatingPower + randomNoise;
                    }
                    else
                    {
                        double overheatingPower = (engineTemperature - targetWorkTemp) / 15.0;

                        if (overheatingPower < 0.2) overheatingPower = 0.2;

                        engineTemperature += overheatingPower + randomNoise;
                    }
                }
            }
            else
            {
                if (fanState)
                {
                    double coolingPower = (engineTemperature / 20.0);
                    engineTemperature -= coolingPower + randomNoise;
                }
                else
                {
                    double coolingPower = (engineTemperature - 20.0) / 40.0;

                    if (engineTemperature > 21.0 && coolingPower < 0.05)
                    {
                        coolingPower = 0.05;
                    }
                    engineTemperature -= coolingPower + randomNoise;
                }
            }

            if (engineTemperature < 19.5)
            {
                engineTemperature = 19.5 + (randomGenerator.NextDouble() * 0.3);
            }

            segmentTempLabel.Text = $"{engineTemperature:0.0} °C";

            if (engineTemperature >= 140)
            {
                machineStop();
                engineTemperature = 130.0;
                MessageBox.Show("EMERGENCY STOP!\n\nExtreme temperature detected. Engine failure.", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void engineControlTimer_Tick(object sender, EventArgs e)
        {
            if (tempWarningCounter <= 0)
            {
                machineStop();
                MessageBox.Show("EMERGENCY STOP!\n\nCritical engine temperature warning ignored.", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (engineTemperature >= 95.0)
            {
                tempInfoLabel.Text = $"Temperature: TOO HIGH {tempWarningCounter}";
                if (engineOn) tempWarningCounter--;

                segmentTempLabel.ForeColor = Color.Red;

            }
            else if (engineTemperature <= 45.0)
            {
                tempInfoLabel.Text = $"Temperature: TOO LOW {tempWarningCounter}";
                if (engineOn)
                {
                    tempWarningCounter--;
                    segmentTempLabel.ForeColor = Color.DeepSkyBlue;
                }
                else
                {
                    segmentTempLabel.ForeColor = Color.White;
                }
            }
            else
            {
                tempWarningCounter = 10;
                tempInfoLabel.Text = "Temperature: NORMAL";

                if (engineOn) segmentTempLabel.ForeColor = Color.Gray;
                else segmentTempLabel.ForeColor = Color.White;
            }
        }

        private void userAttentionButton_Click(object sender, EventArgs e)
        {
            resetTimers();
            userAttentionButton.Text = string.Empty;
            userAttentionButton.ForeColor = SystemColors.ControlText;
            timerLabel.Text = $"{attentionCounter}";

        }

        private void engineStartButton_Click(object sender, EventArgs e)
        {
            if (resetState == false && stopState == false)
            {
                engineOn = true;
                engineStateLabel.Text = "Engine: WORKING";
                processPanel.BackColor = Color.Honeydew;
                userAttentionButton.Enabled = true;
                resetTimers();
            }
        }
        private void engineStopButton_Click(object sender, EventArgs e)
        {
            if (engineOn == true)
            {
                engineOn = false;
                engineStateLabel.Text = "Engine: OFF";
                processPanel.BackColor = Color.DarkGray;
                userAttentionButton.Enabled = false;
                userAttentionButton.Text = "Engine off";
                resetTimers();
            }
        }


        private void resetButton_Click(object sender, EventArgs e)
        {
            if (stopState == false)
            {
                resetState = false;
                resetButton.BackColor = SystemColors.Control;
            }
        }

        private void eStopButton_Click(object sender, EventArgs e)
        {
            stopState = !stopState;
            if (stopState == true)
            {
                machineStop();
                eStopButton.BackColor = Color.Red;
            }
            else
            {
                eStopButton.BackColor = SystemColors.Control;
            }

        }

        private void machineStop()
        {
            engineOn = false;
            engineStateLabel.Text = "Engine: OFF";
            resetState = true;
            resetButton.BackColor = Color.Red;
            resetTimers();
            userAttentionButton.Enabled = false;
            userAttentionButton.Text = string.Empty;
            timerLabel.Text = "--";
            processPanel.BackColor = Color.Silver;
        }

        private void coolingButton_Click(object sender, EventArgs e)
        {
            if (fanState == true)
            {
                coolingButton.BackColor = SystemColors.Control;
                fanInfoLabel.Text = "Cooling: OFF";
            }
            else
            {
                coolingButton.BackColor = Color.GreenYellow;
                fanInfoLabel.Text = "Cooling: ON";
            }
            fanState = !fanState;
        }

        private void resetTimers()
        {
            attentionCounter = 30;
            engineShutdownCounter = 11;
            tempWarningCounter = 10;
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            clockLabel.Text = currentDateTime.ToString("HH:mm:ss");
            dateLabel.Text = currentDateTime.ToString("dd.MM.yyyy");
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            addUserForm addUserWindow = new addUserForm();
            addUserWindow.ShowDialog();
        }

        private void modifyUsersButton_Click(object sender, EventArgs e)
        {
            editUsersForm editUsersWindow = new editUsersForm();
            editUsersWindow.ShowDialog();
        }
    }
}
