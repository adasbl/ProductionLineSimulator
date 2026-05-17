using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace productionLine
{
    public partial class editUsersForm : Form
    {
        private List<User> _usersList = new List<User>();
        private readonly string _filePath = "users.json";

        public editUsersForm()
        {
            InitializeComponent();
            InitializeFormLayout();
            LoadUsersData();
        }

        private void InitializeFormLayout()
        {
            authorizationComboBox.Items.Clear();
            authorizationComboBox.Items.Add("1 - Viewer");
            authorizationComboBox.Items.Add("2 - Operator");
            authorizationComboBox.Items.Add("3 - Admin");
            authorizationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            userListComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            userListComboBox.SelectedIndexChanged += userListComboBox_SelectedIndexChanged;
        }

        private void LoadUsersData()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    string jsonString = File.ReadAllText(_filePath);
                    _usersList = JsonSerializer.Deserialize<List<User>>(jsonString) ?? new List<User>();
                }

                userListComboBox.Items.Clear();
                foreach (var user in _usersList)
                {
                    userListComboBox.Items.Add(user.Username);
                }

                if (userListComboBox.Items.Count > 0)
                {
                    userListComboBox.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No users available to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void userListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userListComboBox.SelectedIndex == -1) return;

            string selectedUsername = userListComboBox.SelectedItem.ToString();
            User selectedUser = _usersList.FirstOrDefault(u => u.Username == selectedUsername);

            if (selectedUser != null)
            {
                usernameBox.Text = selectedUser.Username;
                passwordBox.Text = selectedUser.Password;

                int authIndex = selectedUser.AuthorizationLvl - 1;
                if (authIndex >= 0 && authIndex < authorizationComboBox.Items.Count)
                {
                    authorizationComboBox.SelectedIndex = authIndex;
                }
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (userListComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select a user to delete.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedUsername = userListComboBox.SelectedItem.ToString();

            if (selectedUsername.Equals(confirmedUser.Username, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You cannot delete your own account while logged in!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                $"Are you sure you want to permanently delete user '{selectedUsername}'?\nThis action cannot be undone.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                User userToDelete = _usersList.FirstOrDefault(u => u.Username == selectedUsername);

                if (userToDelete != null)
                {
                    _usersList.Remove(userToDelete);

                    try
                    {
                        JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                        string updatedJson = JsonSerializer.Serialize(_usersList, options);
                        File.WriteAllText(_filePath, updatedJson);

                        MessageBox.Show($"User '{selectedUsername}' has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error during deletion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            if (userListComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select a user to modify.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(usernameBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Username and password cannot be empty.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string originalUsername = userListComboBox.SelectedItem.ToString();
            string newUsername = usernameBox.Text.Trim();

            if (!originalUsername.Equals(newUsername, StringComparison.OrdinalIgnoreCase))
            {
                if (_usersList.Any(u => u.Username.Equals(newUsername, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("A user with this new name already exists! Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            User userToModify = _usersList.FirstOrDefault(u => u.Username == originalUsername);

            if (userToModify != null)
            {
                userToModify.Username = newUsername;
                userToModify.Password = passwordBox.Text;
                userToModify.AuthorizationLvl = authorizationComboBox.SelectedIndex + 1;

                try
                {
                    JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                    string updatedJson = JsonSerializer.Serialize(_usersList, options);
                    File.WriteAllText(_filePath, updatedJson);

                    MessageBox.Show("User data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Save Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}