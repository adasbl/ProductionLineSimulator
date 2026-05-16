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
        private int attentionCounter = 31;
        private int engineShutdownCounter = 11;
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
                    userAttentionButton.Text = $"{attentionCounter}";
                }
                else if (attentionCounter < 0)
                {
                    engineShutdownCounter -= 1;
                    userAttentionButton.Text = $"USER INPUT NEEDED : {engineShutdownCounter}";
                    userAttentionButton.ForeColor = Color.IndianRed;
                    if (engineShutdownCounter <= 0)
                    {
                        machineStop();
                    }
                }
            }
        }

        private void engineTimer_Tick(object sender, EventArgs e)
        {
            if (engineOn)
            {
                if (engineTemperature < 90.0)
                {
                    engineTemperature += randomGenerator.NextDouble() * 3.0;
                }
                else
                {
                    engineTemperature += (randomGenerator.NextDouble() * 2.0) - 1.0;
                }
            }
            else
            {
                if (engineTemperature > 20.0)
                {
                    engineTemperature -= randomGenerator.NextDouble() * 1.5;
                }
                else
                {
                    engineTemperature = 20.0;
                }
            }
            segmentTempLabel.Text = $"{engineTemperature:0.0} °C";

            if (engineTemperature > 85.0) segmentTempLabel.ForeColor = Color.Red;
            else if (engineTemperature < 60.0 && engineOn) segmentTempLabel.ForeColor = Color.Blue;
            else segmentTempLabel.ForeColor = Color.LimeGreen;
        }

        private void userAttentionButton_Click(object sender, EventArgs e)
        {
            resetTimers();
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
            attentionCounter = 31;
            engineShutdownCounter = 11;
        }
    }
}
