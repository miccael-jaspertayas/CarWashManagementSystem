using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using CarWashManagement.Core;
using CarWashManagement.Core.Managers;
using CarWashManagement.Core.FileHandlers;

namespace CarWashManagement.UI
{
    // Form that allows admin to create, unlock, activate, and deactivate accounts.
    public class UserManagementForm : BaseForm
    {
        private ListView lsvUsers;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblRole;
        private ComboBox cmbRole;
        private Button btnCreateUser;
        private Button btnToggleStatus;

        private readonly AccountManager accountManager;

        public UserManagementForm()
        {
            accountManager = new AccountManager(
                new UserFileHandler(),
                new AuditFileHandler()
                );

            SetUpControls();
            LoadUserList();
        }

        // Method to set up the form and its controls.
        public void SetUpControls()
        {
            Text = "User Management";
            Size = new Size(600, 350);

            // --- User List View ---
            lsvUsers = new ListView
            {
                Location = new Point(15, 15),
                Size = new Size(550, 200),
                View = View.Details,
                FullRowSelect = true
            };
            lsvUsers.Columns.Add("Username", 100);
            lsvUsers.Columns.Add("Full Name", 150);
            lsvUsers.Columns.Add("Role", 80);
            lsvUsers.Columns.Add("Status", 80);
            lsvUsers.Columns.Add("Failed Attempts", 110);
            Controls.Add(lsvUsers);

            // - - - - - Account Creation Controls - - - - -

            int formY = 230;

            // --- Username ---
            lblUsername = new Label
            {
                Text = "Username:",
                Location = new Point(15, formY),
                AutoSize = true
            };
            Controls.Add(lblUsername);

            txtUsername = new TextBox
            {
                Location = new Point(80, formY - 3),
                Size = new Size(120, 23)
            };
            Controls.Add(txtUsername);

            // --- Password ---
            lblPassword = new Label
            {
                Text = "Password:",
                Location = new Point(215, formY),
                AutoSize = true
            };
            Controls.Add(lblPassword);

            txtPassword = new TextBox
            {
                Location = new Point(280, formY - 3),
                Size = new Size(120, 23),
                PasswordChar = '*'
            };
            Controls.Add(txtPassword);

            // --- Full Name ---
            lblFullName = new Label
            {
                Text = "Full Name:",
                Location = new Point(15, formY + 30),
                AutoSize = true
            };
            Controls.Add(lblFullName);

            txtFullName = new TextBox
            {
                Location = new Point(80, formY + 27),
                Size = new Size(120, 23)
            };
            Controls.Add(txtFullName);

            // --- Role ---
            lblRole = new Label
            {
                Text = "Role:",
                Location = new Point(215, formY + 30),
                AutoSize = true
            };
            Controls.Add(lblRole);

            cmbRole = new ComboBox
            {
                Location = new Point(280, formY + 27),
                Size = new Size(120, 23),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Recorder");
            cmbRole.SelectedIndex = 1; // Default to Recorder
            Controls.Add(cmbRole);

            // --- Buttons ---
            btnCreateUser = new Button
            {
                Text = "Create User",
                Location = new Point(420, formY),
                Size = new Size(140, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(41, 128, 185),
                ForeColor = Color.White
            };
            btnCreateUser.Click += btnCreateUser_Click;
            Controls.Add(btnCreateUser);

            btnToggleStatus = new Button
            {
                Text = "Activate / Deactivate Selected",
                Location = new Point(420, formY + 30),
                Size = new Size(140, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(41, 128, 185),
                ForeColor = Color.White
            };
            btnToggleStatus.Click += btnToggleStatus_Click;
            Controls.Add(btnToggleStatus);
        }

        // Method to load all users using the account manager into the ListView.
        public void LoadUserList()
        {
            lsvUsers.Items.Clear();

            List<User> users = accountManager.GetAllUsers();

            foreach (User user in users)
            {
                ListViewItem row = new ListViewItem(user.Username);
                row.SubItems.Add(user.FullName);
                row.SubItems.Add(user.Role);
                row.SubItems.Add(user.Status);
                row.SubItems.Add(user.FailedLoginAttempts.ToString());
                row.Tag = user;

                lsvUsers.Items.Add(row);
            }
        }

        // Method to create a new user when the "Create User" button is clicked.
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string role = cmbRole.SelectedItem.ToString().ToUpper();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Please fill in all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = accountManager.CreateUser(username, password, role, fullName);

            if (success)
            {
                MessageBox.Show("User created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserList(); // Refresh the list

                // Clear input fields
                txtUsername.Clear();
                txtPassword.Clear();
                txtFullName.Clear();
                cmbRole.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("A user with this username already exists.", "Account Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to toggle account status of the user when the button is clicked.
        private void btnToggleStatus_Click(object sender, EventArgs e)
        {
            if (lsvUsers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user from the list.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User selectedUser = lsvUsers.SelectedItems[0].Tag as User;

            if (selectedUser.Username.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("The default admin account cannot be deactivated.", "Action Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (selectedUser.Status == "ACTIVE")
            {
                accountManager.DeactivateUser(selectedUser.Username);
                MessageBox.Show($"User '{selectedUser.Username}' has been deactivated.", "User Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string originalStatus = selectedUser.Status;

                accountManager.ActivateUser(selectedUser.Username);

                if (originalStatus == "LOCKED")
                {
                    MessageBox.Show($"User '{selectedUser.Username}' has been unlocked and activated.", "User Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show($"User '{selectedUser.Username}' has been activated.", "User Activated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            LoadUserList(); // Refresh the list
        }
    }
}
