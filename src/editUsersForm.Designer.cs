namespace productionLine
{
    partial class editUsersForm
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
            authorizationLabel = new Label();
            authorizationComboBox = new ComboBox();
            editUserLabel = new Label();
            editUserButton = new Button();
            passwordLabel = new Label();
            usernameLabel = new Label();
            passwordBox = new TextBox();
            usernameBox = new TextBox();
            userListComboBox = new ComboBox();
            deleteUserButton = new Button();
            SuspendLayout();
            // 
            // authorizationLabel
            // 
            authorizationLabel.AutoSize = true;
            authorizationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            authorizationLabel.Location = new Point(195, 123);
            authorizationLabel.Margin = new Padding(2, 0, 2, 0);
            authorizationLabel.Name = "authorizationLabel";
            authorizationLabel.Size = new Size(86, 15);
            authorizationLabel.TabIndex = 20;
            authorizationLabel.Text = "Authorization:";
            // 
            // authorizationComboBox
            // 
            authorizationComboBox.FormattingEnabled = true;
            authorizationComboBox.Location = new Point(181, 141);
            authorizationComboBox.Name = "authorizationComboBox";
            authorizationComboBox.Size = new Size(121, 23);
            authorizationComboBox.TabIndex = 19;
            // 
            // editUserLabel
            // 
            editUserLabel.AutoSize = true;
            editUserLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editUserLabel.Location = new Point(30, 72);
            editUserLabel.Margin = new Padding(2, 0, 2, 0);
            editUserLabel.Name = "editUserLabel";
            editUserLabel.Size = new Size(81, 21);
            editUserLabel.TabIndex = 18;
            editUserLabel.Text = "Edit user:";
            // 
            // editUserButton
            // 
            editUserButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editUserButton.Location = new Point(201, 186);
            editUserButton.Margin = new Padding(2);
            editUserButton.Name = "editUserButton";
            editUserButton.Size = new Size(80, 26);
            editUserButton.TabIndex = 17;
            editUserButton.Text = "Save";
            editUserButton.UseVisualStyleBackColor = true;
            editUserButton.Click += editUserButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(205, 78);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(62, 15);
            passwordLabel.TabIndex = 16;
            passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.FlatStyle = FlatStyle.System;
            usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(205, 33);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(67, 15);
            usernameLabel.TabIndex = 15;
            usernameLabel.Text = "Username:";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(181, 94);
            passwordBox.Margin = new Padding(2);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(121, 23);
            passwordBox.TabIndex = 14;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(181, 50);
            usernameBox.Margin = new Padding(2);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(121, 23);
            usernameBox.TabIndex = 13;
            // 
            // userListComboBox
            // 
            userListComboBox.FormattingEnabled = true;
            userListComboBox.Location = new Point(30, 96);
            userListComboBox.Name = "userListComboBox";
            userListComboBox.Size = new Size(121, 23);
            userListComboBox.TabIndex = 21;
            // 
            // deleteUserButton
            // 
            deleteUserButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteUserButton.ForeColor = Color.IndianRed;
            deleteUserButton.Location = new Point(58, 186);
            deleteUserButton.Margin = new Padding(2);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(80, 26);
            deleteUserButton.TabIndex = 22;
            deleteUserButton.Text = "Delete user";
            deleteUserButton.UseVisualStyleBackColor = true;
            deleteUserButton.Click += deleteUserButton_Click;
            // 
            // editUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 237);
            Controls.Add(deleteUserButton);
            Controls.Add(userListComboBox);
            Controls.Add(authorizationLabel);
            Controls.Add(authorizationComboBox);
            Controls.Add(editUserLabel);
            Controls.Add(editUserButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "editUsersForm";
            Text = "editUsersForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label authorizationLabel;
        private ComboBox authorizationComboBox;
        private Label editUserLabel;
        private Button editUserButton;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordBox;
        private TextBox usernameBox;
        private ComboBox userListComboBox;
        private Button deleteUserButton;
    }
}