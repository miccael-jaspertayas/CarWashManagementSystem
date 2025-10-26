using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using CarWashManagement.Core.FileHandlers;
using CarWashManagement.Core.Managers;
using CarWashManagement.Core;

namespace CarWashManagement.UI
{
    public class LoginForm : BaseForm 
    {
        private readonly AccountManager accountManager;

        // Declaration of the UI control variables.
        private Label usernameLabel;
        private TextBox usernameTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Button loginButton;

        public LoginForm()
        {
            UserFileHandler userFileHandler = new UserFileHandler();
            AuditFileHandler auditFileHandler = new AuditFileHandler();

            accountManager = new AccountManager(userFileHandler, auditFileHandler);

            SetUpControls();
        }

        // Method to create and position all UI controls.
        private void SetUpControls()
        {
            // - - - - - Form set up - - - - -
            Text = "Car Wash Management - Login";
            Size = new Size(300, 200);
            Name = "LoginForm";

            // - - - - - Username Label - - - - -
            usernameLabel = new Label();
            usernameLabel.Text = "Username: ";
            usernameLabel.Location = new Point(30, 30);
            usernameLabel.Size = new Size(70, 20);
            Controls.Add(usernameLabel);

            // - - - - - Username TextBox - - - - -
            usernameTextBox = new TextBox();
            usernameTextBox.Location = new Point(110, 30);
            usernameTextBox.Size = new Size(140, 20);
            Controls.Add(usernameTextBox);

            // - - - - - Password Label - - - - -
            passwordLabel = new Label();
            passwordLabel.Text = "Password:";
            passwordLabel.Location = new Point(30, 70);
            passwordLabel.Size = new Size(70, 20);
            Controls.Add(passwordLabel);

            // - - - - - Password TextBox - - - - -
            passwordTextBox = new TextBox();
            passwordTextBox.Location = new Point(110, 70);
            passwordTextBox.Size = new Size(140, 20);
            passwordTextBox.PasswordChar = '*';
            Controls.Add(passwordTextBox);

            // - - - - - Login Button - - - - -
            loginButton = new Button();
            loginButton.Text = "Login";
            loginButton.Location = new Point(110, 110);
            loginButton.Size = new Size(75, 30);
            loginButton.Click += LoginButton_Click;
            Controls.Add(loginButton);
        }

        // Method that is executed when the login button is clicked.
        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Get the text from the text boxes.
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all required fields before proceeding.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            try
            {
                // Call the account manager to try to login using the given credentials.
                // It will return the loggedInUser object if successful.
                string loginResult = accountManager.Login(username, password, out User loggedInUser);

                if (loginResult == "SUCCESS")
                {
                    MessageBox.Show($"Welcome, {loggedInUser.FullName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Create the new dashboard and pass in the logged-in user.
                    DashboardForm dashboard = new DashboardForm(loggedInUser);
                    dashboard.Show();

                    // Hide the login form.
                    Hide();

                } else
                {
                    MessageBox.Show(loginResult, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occured: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void ClearFields()
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            usernameTextBox.Focus();
        }

        // Override method to manage the behaviour when closing the Login form.
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Check if the application is still running forms
            // Only exit the entire application if no other forms are running.
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }

            base.OnFormClosed(e);
        }
    }
}
