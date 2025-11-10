using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarWashManagement.Core;
using CarWashManagement.Core.Managers;
using CarWashManagement.Core.FileHandlers;

namespace CarWashManagement.UI
{
    public partial class ChangePasswordForm : BaseForm
    {
        private readonly AccountManager accountManager;
        private readonly User loggedInUser;

        public ChangePasswordForm(User user)
        {
            InitializeComponent();

            loggedInUser = user;

            accountManager = new AccountManager(
                new UserFileHandler(),
                new AuditFileHandler()
            );

            this.btnSubmit.Click += btnSubmit_Click;
            this.btnCancel.Click += (sender, e) => { this.Close(); };
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Check if the inputs are null or whitespace.
            if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hasUpper = newPassword.Any(char.IsUpper);
            bool hasLower = newPassword.Any(char.IsLower);
            bool hasDigit = newPassword.Any(char.IsDigit);

            // Check password if it satisfy the requierments.
            if (newPassword.Length < 8 || !hasUpper || !hasLower || !hasDigit)
            {
                string message = "Password must meet the following requirements:\n" +
                                 "• At least 8 characters long\n" +
                                 "• Contains at least one uppercase letter\n" +
                                 "• Contains at least one lowercase letter\n" +
                                 "• Contains at least one digit\n";

                MessageBox.Show(message, "Password Requirements", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Check if new password matches the confirm password.
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("The new passwords do not match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = accountManager.ChangePassword(loggedInUser.Username, oldPassword, newPassword);

            if (success)
            {
                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close(); // Close this form.
            }
            else
            {
                MessageBox.Show("The 'Old Password' was incorrect. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPassword.Clear();
                txtOldPassword.Focus();
            }
        }
    }
}
