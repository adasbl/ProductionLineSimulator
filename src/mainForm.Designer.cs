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
            cpuBackgroudPanel.SuspendLayout();
            ramBackgroudPanel.SuspendLayout();
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
            cpuUsageLabel.Location = new Point(33, 19);
            cpuUsageLabel.Name = "cpuUsageLabel";
            cpuUsageLabel.Size = new Size(104, 15);
            cpuUsageLabel.TabIndex = 1;
            cpuUsageLabel.Text = "no cpu usage data";
            // 
            // ramUsageLabel
            // 
            ramUsageLabel.AutoSize = true;
            ramUsageLabel.Location = new Point(33, 73);
            ramUsageLabel.Name = "ramUsageLabel";
            ramUsageLabel.Size = new Size(110, 15);
            ramUsageLabel.TabIndex = 2;
            ramUsageLabel.Text = "no RAM usage data";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(778, 19);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(47, 15);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "no data";
            // 
            // accessLabel
            // 
            accessLabel.AutoSize = true;
            accessLabel.Location = new Point(778, 47);
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
            usernameTitleLabel.Location = new Point(735, 19);
            usernameTitleLabel.Name = "usernameTitleLabel";
            usernameTitleLabel.Size = new Size(33, 15);
            usernameTitleLabel.TabIndex = 5;
            usernameTitleLabel.Text = "User:";
            // 
            // accessTitleLabel
            // 
            accessTitleLabel.AutoSize = true;
            accessTitleLabel.Enabled = false;
            accessTitleLabel.Location = new Point(691, 47);
            accessTitleLabel.Name = "accessTitleLabel";
            accessTitleLabel.Size = new Size(82, 15);
            accessTitleLabel.TabIndex = 6;
            accessTitleLabel.Text = "Authorization:";
            // 
            // cpuBackgroudPanel
            // 
            cpuBackgroudPanel.BackColor = Color.Gray;
            cpuBackgroudPanel.Controls.Add(cpuFillPanel);
            cpuBackgroudPanel.Location = new Point(35, 37);
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
            ramBackgroudPanel.Location = new Point(35, 91);
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
            userAttentionButton.BackColor = Color.IndianRed;
            userAttentionButton.FlatStyle = FlatStyle.Flat;
            userAttentionButton.Location = new Point(304, 338);
            userAttentionButton.Margin = new Padding(2);
            userAttentionButton.Name = "userAttentionButton";
            userAttentionButton.Size = new Size(247, 66);
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
            engineStartButton.Location = new Point(735, 209);
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
            resetButton.Location = new Point(632, 308);
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
            eStopButton.Location = new Point(735, 308);
            eStopButton.Name = "eStopButton";
            eStopButton.Size = new Size(70, 70);
            eStopButton.TabIndex = 14;
            eStopButton.UseVisualStyleBackColor = true;
            eStopButton.Click += eStopButton_Click;
            // 
            // processPanel
            // 
            processPanel.BackColor = Color.Silver;
            processPanel.Location = new Point(304, 157);
            processPanel.Name = "processPanel";
            processPanel.Size = new Size(247, 100);
            processPanel.TabIndex = 15;
            // 
            // engineStopButton
            // 
            engineStopButton.BackgroundImage = (Image)resources.GetObject("engineStopButton.BackgroundImage");
            engineStopButton.BackgroundImageLayout = ImageLayout.Stretch;
            engineStopButton.Location = new Point(632, 209);
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
            engineStopLabel.Location = new Point(632, 192);
            engineStopLabel.Name = "engineStopLabel";
            engineStopLabel.Size = new Size(70, 15);
            engineStopLabel.TabIndex = 17;
            engineStopLabel.Text = "Engine Stop";
            // 
            // engineStartLabel
            // 
            engineStartLabel.AutoSize = true;
            engineStartLabel.Location = new Point(735, 192);
            engineStartLabel.Name = "engineStartLabel";
            engineStartLabel.Size = new Size(70, 15);
            engineStartLabel.TabIndex = 18;
            engineStartLabel.Text = "Engine Start";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(648, 290);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 19;
            label3.Text = "RESET";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(747, 290);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 20;
            label4.Text = "E-STOP";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 434);
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
            Margin = new Padding(2);
            Name = "mainForm";
            Text = "Production Line Symulation";
            Load += mainForm_Load;
            cpuBackgroudPanel.ResumeLayout(false);
            ramBackgroudPanel.ResumeLayout(false);
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
    }
}
