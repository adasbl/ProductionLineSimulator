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
        private int attentionCounter = 31;
        private int engineShutdownCounter = 11;

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
                    if (engineShutdownCounter < 0)
                    {
                        engineOn = false;
                        attentionCounter = 31;
                        engineShutdownCounter = 11;
                        userAttentionButton.Enabled = false;
                        userAttentionButton.Text = string.Empty;
                    }
                }
            }
        }

        private void userAttentionButton_Click(object sender, EventArgs e)
        {
            attentionCounter = 31;
            engineShutdownCounter = 11;
        }

        private void engineButton_Click(object sender, EventArgs e)
        {
            engineOn = true;
        }
    }
}
