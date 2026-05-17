namespace productionLine
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            parametersTimer = new System.Windows.Forms.Timer(components);
            cpuUsageLabel = new Label();
            ramUsageLabel = new Label();
            usernameLabel = new Label();
            accessLabel = new Label();
            usernameTitleLabel = new Label();
            accessTitleLabel = new Label();
            cpuBackgroudPanel = new Panel();
            cpuFillPanel = new Panel();
            ramBackgroudPanel = new Panel();
            ramFillPanel = new Panel();
            userAttentionButton = new Button();
            userAttentionTimer = new System.Windows.Forms.Timer(components);
            engineStartButton = new Button();
            resetButton = new Button();
            eStopButton = new Button();
            processPanel = new Panel();
            engineStateLabel = new Label();
            fanInfoLabel = new Label();
            tempInfoLabel = new Label();
            engineStopButton = new Button();
            engineStopLabel = new Label();
            engineStartLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            segmentTempLabel = new Label();
            engineTempTimer = new System.Windows.Forms.Timer(components);
            coolingLabel = new Label();
            coolingButton = new Button();
            addUserButton = new Button();
            modifyUsersButton = new Button();
            timerLabel = new Label();
            engineControlTimer = new System.Windows.Forms.Timer(components);
            clockLabel = new Label();
            clockTimer = new System.Windows.Forms.Timer(components);
            clockTitleLabel = new Label();
            dateTitleLabel = new Label();
            dateLabel = new Label();
            cpuBackgroudPanel.SuspendLayout();
            ramBackgroudPanel.SuspendLayout();
            processPanel.SuspendLayout();
            SuspendLayout();
            // 
            // parametersTimer
            // 
            parametersTimer.Enabled = true;
            parametersTimer.Interval = 500;
            parametersTimer.Tick += parametersTimer_Tick;
            // 
            // cpuUsageLabel
            // 
            cpuUsageLabel.AutoSize = true;
            cpuUsageLabel.Location = new Point(67, 47);
            cpuUsageLabel.Name = "cpuUsageLabel";
            cpuUsageLabel.Size = new Size(104, 15);
            cpuUsageLabel.TabIndex = 1;
            cpuUsageLabel.Text = "no cpu usage data";
            // 
            // ramUsageLabel
            // 
            ramUsageLabel.AutoSize = true;
            ramUsageLabel.Location = new Point(67, 101);
            ramUsageLabel.Name = "ramUsageLabel";
            ramUsageLabel.Size = new Size(110, 15);
            ramUsageLabel.TabIndex = 2;
            ramUsageLabel.Text = "no RAM usage data";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(612, 30);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(47, 15);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "no data";
            // 
            // accessLabel
            // 
            accessLabel.AutoSize = true;
            accessLabel.Location = new Point(612, 58);
            accessLabel.Margin = new Padding(2, 0, 2, 0);
            accessLabel.Name = "accessLabel";
            accessLabel.Size = new Size(47, 15);
            accessLabel.TabIndex = 4;
            accessLabel.Text = "no data";
            // 
            // usernameTitleLabel
            // 
            usernameTitleLabel.AutoSize = true;
            usernameTitleLabel.Enabled = false;
            usernameTitleLabel.Location = new Point(570, 30);
            usernameTitleLabel.Name = "usernameTitleLabel";
            usernameTitleLabel.Size = new Size(33, 15);
            usernameTitleLabel.TabIndex = 5;
            usernameTitleLabel.Text = "User:";
            // 
            // accessTitleLabel
            // 
            accessTitleLabel.AutoSize = true;
            accessTitleLabel.Enabled = false;
            accessTitleLabel.Location = new Point(525, 58);
            accessTitleLabel.Name = "accessTitleLabel";
            accessTitleLabel.Size = new Size(82, 15);
            accessTitleLabel.TabIndex = 6;
            accessTitleLabel.Text = "Authorization:";
            // 
            // cpuBackgroudPanel
            // 
            cpuBackgroudPanel.BackColor = Color.Gray;
            cpuBackgroudPanel.Controls.Add(cpuFillPanel);
            cpuBackgroudPanel.Location = new Point(69, 65);
            cpuBackgroudPanel.Name = "cpuBackgroudPanel";
            cpuBackgroudPanel.Size = new Size(160, 18);
            cpuBackgroudPanel.TabIndex = 7;
            // 
            // cpuFillPanel
            // 
            cpuFillPanel.BackColor = Color.LimeGreen;
            cpuFillPanel.Location = new Point(0, 0);
            cpuFillPanel.Name = "cpuFillPanel";
            cpuFillPanel.Size = new Size(80, 18);
            cpuFillPanel.TabIndex = 9;
            // 
            // ramBackgroudPanel
            // 
            ramBackgroudPanel.BackColor = Color.Gray;
            ramBackgroudPanel.Controls.Add(ramFillPanel);
            ramBackgroudPanel.Location = new Point(69, 119);
            ramBackgroudPanel.Name = "ramBackgroudPanel";
            ramBackgroudPanel.Size = new Size(160, 18);
            ramBackgroudPanel.TabIndex = 8;
            // 
            // ramFillPanel
            // 
            ramFillPanel.BackColor = Color.LimeGreen;
            ramFillPanel.Location = new Point(0, 0);
            ramFillPanel.Name = "ramFillPanel";
            ramFillPanel.Size = new Size(80, 18);
            ramFillPanel.TabIndex = 10;
            // 
            // userAttentionButton
            // 
            userAttentionButton.BackColor = Color.Gainsboro;
            userAttentionButton.FlatStyle = FlatStyle.Flat;
            userAttentionButton.Location = new Point(326, 342);
            userAttentionButton.Margin = new Padding(2);
            userAttentionButton.Name = "userAttentionButton";
            userAttentionButton.Size = new Size(250, 70);
            userAttentionButton.TabIndex = 9;
            userAttentionButton.UseVisualStyleBackColor = false;
            userAttentionButton.Click += userAttentionButton_Click;
            // 
            // userAttentionTimer
            // 
            userAttentionTimer.Enabled = true;
            userAttentionTimer.Interval = 1000;
            userAttentionTimer.Tick += userAttentionTimer_Tick;
            // 
            // engineStartButton
            // 
            engineStartButton.BackgroundImage = (Image)resources.GetObject("engineStartButton.BackgroundImage");
            engineStartButton.BackgroundImageLayout = ImageLayout.Stretch;
            engineStartButton.Location = new Point(747, 198);
            engineStartButton.Margin = new Padding(2);
            engineStartButton.Name = "engineStartButton";
            engineStartButton.Size = new Size(70, 70);
            engineStartButton.TabIndex = 12;
            engineStartButton.UseVisualStyleBackColor = true;
            engineStartButton.Click += engineStartButton_Click;
            // 
            // resetButton
            // 
            resetButton.BackgroundImage = (Image)resources.GetObject("resetButton.BackgroundImage");
            resetButton.BackgroundImageLayout = ImageLayout.Stretch;
            resetButton.Location = new Point(644, 297);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(70, 70);
            resetButton.TabIndex = 13;
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // eStopButton
            // 
            eStopButton.BackgroundImage = (Image)resources.GetObject("eStopButton.BackgroundImage");
            eStopButton.BackgroundImageLayout = ImageLayout.Stretch;
            eStopButton.Location = new Point(747, 297);
            eStopButton.Name = "eStopButton";
            eStopButton.Size = new Size(70, 70);
            eStopButton.TabIndex = 14;
            eStopButton.UseVisualStyleBackColor = true;
            eStopButton.Click += eStopButton_Click;
            // 
            // processPanel
            // 
            processPanel.BackColor = Color.DarkGray;
            processPanel.BorderStyle = BorderStyle.Fixed3D;
            processPanel.Controls.Add(engineStateLabel);
            processPanel.Controls.Add(fanInfoLabel);
            processPanel.Controls.Add(tempInfoLabel);
            processPanel.Location = new Point(326, 158);
            processPanel.Name = "processPanel";
            processPanel.Size = new Size(250, 100);
            processPanel.TabIndex = 15;
            // 
            // engineStateLabel
            // 
            engineStateLabel.AutoSize = true;
            engineStateLabel.Location = new Point(27, 11);
            engineStateLabel.Margin = new Padding(2, 0, 2, 0);
            engineStateLabel.Name = "engineStateLabel";
            engineStateLabel.Size = new Size(70, 15);
            engineStateLabel.TabIndex = 2;
            engineStateLabel.Text = "Engine: OFF";
            // 
            // fanInfoLabel
            // 
            fanInfoLabel.AutoSize = true;
            fanInfoLabel.Location = new Point(27, 42);
            fanInfoLabel.Margin = new Padding(2, 0, 2, 0);
            fanInfoLabel.Name = "fanInfoLabel";
            fanInfoLabel.Size = new Size(76, 15);
            fanInfoLabel.TabIndex = 1;
            fanInfoLabel.Text = "Cooling: OFF";
            // 
            // tempInfoLabel
            // 
            tempInfoLabel.AutoSize = true;
            tempInfoLabel.Location = new Point(27, 70);
            tempInfoLabel.Margin = new Padding(2, 0, 2, 0);
            tempInfoLabel.Name = "tempInfoLabel";
            tempInfoLabel.Size = new Size(130, 15);
            tempInfoLabel.TabIndex = 0;
            tempInfoLabel.Text = "Temperature: NORMAL";
            // 
            // engineStopButton
            // 
            engineStopButton.BackgroundImage = (Image)resources.GetObject("engineStopButton.BackgroundImage");
            engineStopButton.BackgroundImageLayout = ImageLayout.Stretch;
            engineStopButton.Location = new Point(644, 198);
            engineStopButton.Margin = new Padding(2);
            engineStopButton.Name = "engineStopButton";
            engineStopButton.Size = new Size(70, 70);
            engineStopButton.TabIndex = 16;
            engineStopButton.UseVisualStyleBackColor = true;
            engineStopButton.Click += engineStopButton_Click;
            // 
            // engineStopLabel
            // 
            engineStopLabel.AutoSize = true;
            engineStopLabel.Location = new Point(644, 181);
            engineStopLabel.Name = "engineStopLabel";
            engineStopLabel.Size = new Size(70, 15);
            engineStopLabel.TabIndex = 17;
            engineStopLabel.Text = "Engine Stop";
            // 
            // engineStartLabel
            // 
            engineStartLabel.AutoSize = true;
            engineStartLabel.Location = new Point(747, 181);
            engineStartLabel.Name = "engineStartLabel";
            engineStartLabel.Size = new Size(70, 15);
            engineStartLabel.TabIndex = 18;
            engineStartLabel.Text = "Engine Start";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(661, 279);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 19;
            label3.Text = "RESET";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(759, 279);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 20;
            label4.Text = "E-STOP";
            // 
            // segmentTempLabel
            // 
            segmentTempLabel.BackColor = SystemColors.ActiveCaptionText;
            segmentTempLabel.BorderStyle = BorderStyle.Fixed3D;
            segmentTempLabel.Font = new Font("Source Han Sans JP", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            segmentTempLabel.ForeColor = Color.Ivory;
            segmentTempLabel.Location = new Point(52, 189);
            segmentTempLabel.Margin = new Padding(2, 0, 2, 0);
            segmentTempLabel.Name = "segmentTempLabel";
            segmentTempLabel.Padding = new Padding(4, 3, 4, 3);
            segmentTempLabel.Size = new Size(201, 116);
            segmentTempLabel.TabIndex = 21;
            segmentTempLabel.Text = "60°";
            segmentTempLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // engineTempTimer
            // 
            engineTempTimer.Enabled = true;
            engineTempTimer.Interval = 250;
            engineTempTimer.Tick += engineTempTimer_Tick;
            // 
            // coolingLabel
            // 
            coolingLabel.AutoSize = true;
            coolingLabel.Location = new Point(117, 325);
            coolingLabel.Name = "coolingLabel";
            coolingLabel.Size = new Size(71, 15);
            coolingLabel.TabIndex = 23;
            coolingLabel.Text = "Cooling Fan";
            // 
            // coolingButton
            // 
            coolingButton.BackgroundImage = (Image)resources.GetObject("coolingButton.BackgroundImage");
            coolingButton.BackgroundImageLayout = ImageLayout.Stretch;
            coolingButton.Location = new Point(117, 342);
            coolingButton.Margin = new Padding(2);
            coolingButton.Name = "coolingButton";
            coolingButton.Size = new Size(70, 70);
            coolingButton.TabIndex = 22;
            coolingButton.UseVisualStyleBackColor = true;
            coolingButton.Click += coolingButton_Click;
            // 
            // addUserButton
            // 
            addUserButton.AccessibleDescription = "";
            addUserButton.BackgroundImage = (Image)resources.GetObject("addUserButton.BackgroundImage");
            addUserButton.BackgroundImageLayout = ImageLayout.Stretch;
            addUserButton.Location = new Point(713, 30);
            addUserButton.Margin = new Padding(2);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(42, 42);
            addUserButton.TabIndex = 24;
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // modifyUsersButton
            // 
            modifyUsersButton.BackgroundImage = (Image)resources.GetObject("modifyUsersButton.BackgroundImage");
            modifyUsersButton.BackgroundImageLayout = ImageLayout.Stretch;
            modifyUsersButton.Location = new Point(775, 30);
            modifyUsersButton.Margin = new Padding(2);
            modifyUsersButton.Name = "modifyUsersButton";
            modifyUsersButton.Size = new Size(42, 42);
            modifyUsersButton.TabIndex = 25;
            modifyUsersButton.UseVisualStyleBackColor = true;
            modifyUsersButton.Click += modifyUsersButton_Click;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.BackColor = Color.White;
            timerLabel.BorderStyle = BorderStyle.Fixed3D;
            timerLabel.Location = new Point(435, 312);
            timerLabel.Margin = new Padding(2, 0, 2, 0);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(19, 17);
            timerLabel.TabIndex = 26;
            timerLabel.Text = "--";
            timerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // engineControlTimer
            // 
            engineControlTimer.Enabled = true;
            engineControlTimer.Interval = 1000;
            engineControlTimer.Tick += engineControlTimer_Tick;
            // 
            // clockLabel
            // 
            clockLabel.AutoSize = true;
            clockLabel.Location = new Point(382, 30);
            clockLabel.Margin = new Padding(2, 0, 2, 0);
            clockLabel.Name = "clockLabel";
            clockLabel.Size = new Size(49, 15);
            clockLabel.TabIndex = 27;
            clockLabel.Text = "00:00:00";
            // 
            // clockTimer
            // 
            clockTimer.Enabled = true;
            clockTimer.Interval = 1000;
            clockTimer.Tick += clockTimer_Tick;
            // 
            // clockTitleLabel
            // 
            clockTitleLabel.AutoSize = true;
            clockTitleLabel.Enabled = false;
            clockTitleLabel.Location = new Point(328, 30);
            clockTitleLabel.Margin = new Padding(2, 0, 2, 0);
            clockTitleLabel.Name = "clockTitleLabel";
            clockTitleLabel.Size = new Size(37, 15);
            clockTitleLabel.TabIndex = 28;
            clockTitleLabel.Text = "Time:";
            // 
            // dateTitleLabel
            // 
            dateTitleLabel.AutoSize = true;
            dateTitleLabel.Enabled = false;
            dateTitleLabel.Location = new Point(328, 58);
            dateTitleLabel.Margin = new Padding(2, 0, 2, 0);
            dateTitleLabel.Name = "dateTitleLabel";
            dateTitleLabel.Size = new Size(34, 15);
            dateTitleLabel.TabIndex = 29;
            dateTitleLabel.Text = "Date:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(382, 58);
            dateLabel.Margin = new Padding(2, 0, 2, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(49, 15);
            dateLabel.TabIndex = 30;
            dateLabel.Text = "00:00:00";
            // 
            // mainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(880, 487);
            Controls.Add(dateLabel);
            Controls.Add(dateTitleLabel);
            Controls.Add(clockTitleLabel);
            Controls.Add(clockLabel);
            Controls.Add(timerLabel);
            Controls.Add(modifyUsersButton);
            Controls.Add(addUserButton);
            Controls.Add(coolingLabel);
            Controls.Add(coolingButton);
            Controls.Add(segmentTempLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(engineStartLabel);
            Controls.Add(engineStopLabel);
            Controls.Add(engineStopButton);
            Controls.Add(processPanel);
            Controls.Add(eStopButton);
            Controls.Add(resetButton);
            Controls.Add(engineStartButton);
            Controls.Add(userAttentionButton);
            Controls.Add(ramBackgroudPanel);
            Controls.Add(cpuBackgroudPanel);
            Controls.Add(accessTitleLabel);
            Controls.Add(usernameTitleLabel);
            Controls.Add(accessLabel);
            Controls.Add(usernameLabel);
            Controls.Add(ramUsageLabel);
            Controls.Add(cpuUsageLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Production Console Simulator";
            Load += mainForm_Load;
            cpuBackgroudPanel.ResumeLayout(false);
            ramBackgroudPanel.ResumeLayout(false);
            processPanel.ResumeLayout(false);
            processPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer parametersTimer;
        private Label cpuUsageLabel;
        private Label ramUsageLabel;
        private Label usernameLabel;
        private Label accessLabel;
        private Label usernameTitleLabel;
        private Label accessTitleLabel;
        private Panel cpuBackgroudPanel;
        private Panel cpuFillPanel;
        private Panel ramBackgroudPanel;
        private Panel ramFillPanel;
        private Button userAttentionButton;
        private System.Windows.Forms.Timer userAttentionTimer;
        private Button engineStartButton;
        private Button resetButton;
        private Button eStopButton;
        private Panel processPanel;
        private Button engineStopButton;
        private Label engineStopLabel;
        private Label engineStartLabel;
        private Label label3;
        private Label label4;
        private Label segmentTempLabel;
        private System.Windows.Forms.Timer engineTempTimer;
        private Label coolingLabel;
        private Button coolingButton;
        private Button addUserButton;
        private Button modifyUsersButton;
        private Label tempInfoLabel;
        private Label engineStateLabel;
        private Label fanInfoLabel;
        private Label timerLabel;
        private System.Windows.Forms.Timer engineControlTimer;
        private Label clockLabel;
        private System.Windows.Forms.Timer clockTimer;
        private Label clockTitleLabel;
        private Label dateTitleLabel;
        private Label dateLabel;
    }
}
