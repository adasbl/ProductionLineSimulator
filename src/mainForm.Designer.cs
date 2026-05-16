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
            engineStopButton = new Button();
            engineStopLabel = new Label();
            engineStartLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            segmentTempLabel = new Label();
            engineTimer = new System.Windows.Forms.Timer(components);
            coolingLabel = new Label();
            coolingButton = new Button();
            button1 = new Button();
            button2 = new Button();
            infoLabel = new Label();
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
            cpuUsageLabel.Location = new Point(47, 32);
            cpuUsageLabel.Margin = new Padding(4, 0, 4, 0);
            cpuUsageLabel.Name = "cpuUsageLabel";
            cpuUsageLabel.Size = new Size(159, 25);
            cpuUsageLabel.TabIndex = 1;
            cpuUsageLabel.Text = "no cpu usage data";
            // 
            // ramUsageLabel
            // 
            ramUsageLabel.AutoSize = true;
            ramUsageLabel.Location = new Point(47, 122);
            ramUsageLabel.Margin = new Padding(4, 0, 4, 0);
            ramUsageLabel.Name = "ramUsageLabel";
            ramUsageLabel.Size = new Size(169, 25);
            ramUsageLabel.TabIndex = 2;
            ramUsageLabel.Text = "no RAM usage data";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(930, 32);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(73, 25);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "no data";
            // 
            // accessLabel
            // 
            accessLabel.AutoSize = true;
            accessLabel.Location = new Point(930, 78);
            accessLabel.Name = "accessLabel";
            accessLabel.Size = new Size(73, 25);
            accessLabel.TabIndex = 4;
            accessLabel.Text = "no data";
            // 
            // usernameTitleLabel
            // 
            usernameTitleLabel.AutoSize = true;
            usernameTitleLabel.Enabled = false;
            usernameTitleLabel.Location = new Point(869, 32);
            usernameTitleLabel.Margin = new Padding(4, 0, 4, 0);
            usernameTitleLabel.Name = "usernameTitleLabel";
            usernameTitleLabel.Size = new Size(51, 25);
            usernameTitleLabel.TabIndex = 5;
            usernameTitleLabel.Text = "User:";
            // 
            // accessTitleLabel
            // 
            accessTitleLabel.AutoSize = true;
            accessTitleLabel.Enabled = false;
            accessTitleLabel.Location = new Point(806, 78);
            accessTitleLabel.Margin = new Padding(4, 0, 4, 0);
            accessTitleLabel.Name = "accessTitleLabel";
            accessTitleLabel.Size = new Size(123, 25);
            accessTitleLabel.TabIndex = 6;
            accessTitleLabel.Text = "Authorization:";
            // 
            // cpuBackgroudPanel
            // 
            cpuBackgroudPanel.BackColor = Color.Gray;
            cpuBackgroudPanel.Controls.Add(cpuFillPanel);
            cpuBackgroudPanel.Location = new Point(50, 62);
            cpuBackgroudPanel.Margin = new Padding(4, 5, 4, 5);
            cpuBackgroudPanel.Name = "cpuBackgroudPanel";
            cpuBackgroudPanel.Size = new Size(229, 30);
            cpuBackgroudPanel.TabIndex = 7;
            // 
            // cpuFillPanel
            // 
            cpuFillPanel.BackColor = Color.LimeGreen;
            cpuFillPanel.Location = new Point(0, 0);
            cpuFillPanel.Margin = new Padding(4, 5, 4, 5);
            cpuFillPanel.Name = "cpuFillPanel";
            cpuFillPanel.Size = new Size(114, 30);
            cpuFillPanel.TabIndex = 9;
            // 
            // ramBackgroudPanel
            // 
            ramBackgroudPanel.BackColor = Color.Gray;
            ramBackgroudPanel.Controls.Add(ramFillPanel);
            ramBackgroudPanel.Location = new Point(50, 152);
            ramBackgroudPanel.Margin = new Padding(4, 5, 4, 5);
            ramBackgroudPanel.Name = "ramBackgroudPanel";
            ramBackgroudPanel.Size = new Size(229, 30);
            ramBackgroudPanel.TabIndex = 8;
            // 
            // ramFillPanel
            // 
            ramFillPanel.BackColor = Color.LimeGreen;
            ramFillPanel.Location = new Point(0, 0);
            ramFillPanel.Margin = new Padding(4, 5, 4, 5);
            ramFillPanel.Name = "ramFillPanel";
            ramFillPanel.Size = new Size(114, 30);
            ramFillPanel.TabIndex = 10;
            // 
            // userAttentionButton
            // 
            userAttentionButton.BackColor = Color.IndianRed;
            userAttentionButton.FlatStyle = FlatStyle.Flat;
            userAttentionButton.Location = new Point(434, 563);
            userAttentionButton.Name = "userAttentionButton";
            userAttentionButton.Size = new Size(353, 110);
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
            engineStartButton.Location = new Point(1050, 348);
            engineStartButton.Name = "engineStartButton";
            engineStartButton.Size = new Size(100, 100);
            engineStartButton.TabIndex = 12;
            engineStartButton.UseVisualStyleBackColor = true;
            engineStartButton.Click += engineStartButton_Click;
            // 
            // resetButton
            // 
            resetButton.BackgroundImage = (Image)resources.GetObject("resetButton.BackgroundImage");
            resetButton.BackgroundImageLayout = ImageLayout.Stretch;
            resetButton.Location = new Point(903, 513);
            resetButton.Margin = new Padding(4, 5, 4, 5);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(100, 100);
            resetButton.TabIndex = 13;
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // eStopButton
            // 
            eStopButton.BackgroundImage = (Image)resources.GetObject("eStopButton.BackgroundImage");
            eStopButton.BackgroundImageLayout = ImageLayout.Stretch;
            eStopButton.Location = new Point(1050, 513);
            eStopButton.Margin = new Padding(4, 5, 4, 5);
            eStopButton.Name = "eStopButton";
            eStopButton.Size = new Size(100, 100);
            eStopButton.TabIndex = 14;
            eStopButton.UseVisualStyleBackColor = true;
            eStopButton.Click += eStopButton_Click;
            // 
            // processPanel
            // 
            processPanel.BackColor = Color.Silver;
            processPanel.Controls.Add(infoLabel);
            processPanel.Location = new Point(434, 262);
            processPanel.Margin = new Padding(4, 5, 4, 5);
            processPanel.Name = "processPanel";
            processPanel.Size = new Size(353, 167);
            processPanel.TabIndex = 15;
            // 
            // engineStopButton
            // 
            engineStopButton.BackgroundImage = (Image)resources.GetObject("engineStopButton.BackgroundImage");
            engineStopButton.BackgroundImageLayout = ImageLayout.Stretch;
            engineStopButton.Location = new Point(903, 348);
            engineStopButton.Name = "engineStopButton";
            engineStopButton.Size = new Size(100, 100);
            engineStopButton.TabIndex = 16;
            engineStopButton.UseVisualStyleBackColor = true;
            engineStopButton.Click += engineStopButton_Click;
            // 
            // engineStopLabel
            // 
            engineStopLabel.AutoSize = true;
            engineStopLabel.Location = new Point(903, 320);
            engineStopLabel.Margin = new Padding(4, 0, 4, 0);
            engineStopLabel.Name = "engineStopLabel";
            engineStopLabel.Size = new Size(107, 25);
            engineStopLabel.TabIndex = 17;
            engineStopLabel.Text = "Engine Stop";
            // 
            // engineStartLabel
            // 
            engineStartLabel.AutoSize = true;
            engineStartLabel.Location = new Point(1050, 320);
            engineStartLabel.Margin = new Padding(4, 0, 4, 0);
            engineStartLabel.Name = "engineStartLabel";
            engineStartLabel.Size = new Size(106, 25);
            engineStartLabel.TabIndex = 18;
            engineStartLabel.Text = "Engine Start";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(926, 483);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 19;
            label3.Text = "RESET";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1067, 483);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 20;
            label4.Text = "E-STOP";
            // 
            // segmentTempLabel
            // 
            segmentTempLabel.BackColor = SystemColors.ActiveCaptionText;
            segmentTempLabel.BorderStyle = BorderStyle.Fixed3D;
            segmentTempLabel.Font = new Font("Source Han Sans JP", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            segmentTempLabel.ForeColor = Color.LightGreen;
            segmentTempLabel.Location = new Point(50, 320);
            segmentTempLabel.Name = "segmentTempLabel";
            segmentTempLabel.Padding = new Padding(5);
            segmentTempLabel.Size = new Size(287, 157);
            segmentTempLabel.TabIndex = 21;
            segmentTempLabel.Text = "60°";
            segmentTempLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // engineTimer
            // 
            engineTimer.Enabled = true;
            engineTimer.Interval = 250;
            engineTimer.Tick += engineTimer_Tick;
            // 
            // coolingLabel
            // 
            coolingLabel.AutoSize = true;
            coolingLabel.Location = new Point(133, 495);
            coolingLabel.Margin = new Padding(4, 0, 4, 0);
            coolingLabel.Name = "coolingLabel";
            coolingLabel.Size = new Size(106, 25);
            coolingLabel.TabIndex = 23;
            coolingLabel.Text = "Cooling Fan";
            // 
            // coolingButton
            // 
            coolingButton.BackgroundImage = (Image)resources.GetObject("coolingButton.BackgroundImage");
            coolingButton.BackgroundImageLayout = ImageLayout.Stretch;
            coolingButton.Location = new Point(133, 523);
            coolingButton.Name = "coolingButton";
            coolingButton.Size = new Size(100, 100);
            coolingButton.TabIndex = 22;
            coolingButton.UseVisualStyleBackColor = true;
            coolingButton.Click += coolingButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1040, 32);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 24;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1129, 32);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 25;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(50, 72);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(127, 25);
            infoLabel.TabIndex = 0;
            infoLabel.Text = "no engine info";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 723);
            Controls.Add(button2);
            Controls.Add(button1);
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
            Name = "mainForm";
            Text = "2";
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
        private System.Windows.Forms.Timer engineTimer;
        private Label coolingLabel;
        private Button coolingButton;
        private Button button1;
        private Button button2;
        private Label infoLabel;
    }
}
