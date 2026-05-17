using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace productionLine
{
    public partial class addUserForm : Form
    {
        public addUserForm()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            authorizationComboBox.Items.Add("1 - Viewer");
            authorizationComboBox.Items.Add("2 - Operator");
            authorizationComboBox.Items.Add("3 - Admin");

            authorizationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            authorizationComboBox.SelectedIndex = 0;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Missing username or password", "Not enough data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newUsername = usernameBox.Text.Trim();
            string newPassword = passwordBox.Text;
            string filePath = "users.json";

            int selectedAuthLevel = 1;
            if (authorizationComboBox.SelectedIndex == 1)
            {
                selectedAuthLevel = 2;
            }
            else if (authorizationComboBox.SelectedIndex == 2)
            {
                selectedAuthLevel = 3;
            }

            try
            {
                List<User> users = new List<User>();

                if (File.Exists(filePath))
                {
                    string jsonString = File.ReadAllText(filePath);
                    users = JsonSerializer.Deserialize<List<User>>(jsonString) ?? new List<User>();
                }

                if (users.Any(u => u.Username.Equals(newUsername, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("User already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User newUser = new User
                {
                    Username = newUsername,
                    Password = newPassword,
                    AuthorizationLvl = selectedAuthLevel
                };

                users.Add(newUser);

                JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                string updatedJson = JsonSerializer.Serialize(users, options);
                File.WriteAllText(filePath, updatedJson);

                MessageBox.Show($"User {newUsername} succesfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
