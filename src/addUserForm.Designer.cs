namespace productionLine
{
    partial class addUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addUserButton = new Button();
            passwordLabel = new Label();
            usernameLabel = new Label();
            passwordBox = new TextBox();
            usernameBox = new TextBox();
            label1 = new Label();
            authorizationComboBox = new ComboBox();
            authorizationLabel = new Label();
            SuspendLayout();
            // 
            // addUserButton
            // 
            addUserButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUserButton.Location = new Point(113, 184);
            addUserButton.Margin = new Padding(2);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(80, 26);
            addUserButton.TabIndex = 9;
            addUserButton.Text = "Finish";
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(188, 74);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(62, 15);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.FlatStyle = FlatStyle.System;
            usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(188, 29);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(67, 15);
            usernameLabel.TabIndex = 7;
            usernameLabel.Text = "Username:";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(164, 90);
            passwordBox.Margin = new Padding(2);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(121, 23);
            passwordBox.TabIndex = 6;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(164, 46);
            usernameBox.Margin = new Padding(2);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(121, 23);
            usernameBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 87);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 10;
            label1.Text = "Add user:";
            // 
            // authorizationComboBox
            // 
            authorizationComboBox.FormattingEnabled = true;
            authorizationComboBox.Location = new Point(164, 137);
            authorizationComboBox.Name = "authorizationComboBox";
            authorizationComboBox.Size = new Size(121, 23);
            authorizationComboBox.TabIndex = 11;
            // 
            // authorizationLabel
            // 
            authorizationLabel.AutoSize = true;
            authorizationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            authorizationLabel.Location = new Point(178, 119);
            authorizationLabel.Margin = new Padding(2, 0, 2, 0);
            authorizationLabel.Name = "authorizationLabel";
            authorizationLabel.Size = new Size(86, 15);
            authorizationLabel.TabIndex = 12;
            authorizationLabel.Text = "Authorization:";
            // 
            // addUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 237);
            Controls.Add(authorizationLabel);
            Controls.Add(authorizationComboBox);
            Controls.Add(label1);
            Controls.Add(addUserButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "addUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "addUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addUserButton;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordBox;
        private TextBox usernameBox;
        private Label label1;
        private ComboBox authorizationComboBox;
        private Label authorizationLabel;
    }
}