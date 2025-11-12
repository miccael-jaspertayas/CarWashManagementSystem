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
        private PictureBox loginPicture;
        private Label lblLogin;
        private Label lblInfo;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;

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
            Size = new Size(700, 560);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";

            loginPicture = new PictureBox
            {
                Image = Properties.Resources.CarWash_Login_Image,
                Location = new Point(0, 0),
                Size = new Size(300, 530),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            Controls.Add(loginPicture);

            lblLogin = new Label
            {
                Text = "Login to your account",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(41, 128, 185),
                Location = new Point(340, 120),
                AutoSize = true
            };
            Controls.Add(lblLogin);

            // --- Username ---
            lblUsername = new Label();
            lblUsername.Text = "Username: ";
            lblUsername.Location = new Point(340, 180);
            lblUsername.Font = new Font("Segoe UI", 12);
            lblUsername.AutoSize = true;
            Controls.Add(lblUsername);

            txtUsername = new TextBox();
            txtUsername.Location = new Point(440, 180);
            txtUsername.Size = new Size(190, 60);
            txtUsername.Font = new Font("Segoe UI", 14);
            txtUsername.BorderStyle = BorderStyle.None;
            Controls.Add(txtUsername);

            // --- Password ---
            lblPassword = new Label();
            lblPassword.Text = "Password:";
            lblPassword.Location = new Point(340, 220);
            lblPassword.Font = new Font("Segoe UI", 12);
            lblPassword.AutoSize = true;
            Controls.Add(lblPassword);

            txtPassword = new TextBox();
            txtPassword.Location = new Point(440, 220);
            txtPassword.Size = new Size(190, 60);
            txtPassword.Font = new Font("Segoe UI", 14);
            txtPassword.PasswordChar = '*';
            txtPassword.BorderStyle = BorderStyle.None;
            Controls.Add(txtPassword);

            // --- Login Button ---
            btnLogin = new Button();
            btnLogin.Text = "LOGIN";
            btnLogin.Font = new Font("Segoe UI", 12);
            btnLogin.Location = new Point(530, 270);
            btnLogin.Size = new Size(100, 40);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.BackColor = Color.FromArgb(41, 128, 185);
            btnLogin.ForeColor = Color.White;
            btnLogin.Click += btnLogin_Click;
            Controls.Add(btnLogin);

            Label lblInfo = new Label();
            lblInfo.Text = "No account yet? Ask an administrator to create an account for you.";
            lblInfo.Font = new Font("Segoe UI", 10);
            lblInfo.ForeColor = Color.Gray;
            lblInfo.AutoSize = true;
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            lblInfo.AutoSize = false;
            lblInfo.Size = new Size(300, 100);
            lblInfo.Location = new Point(340, 420);
            Controls.Add(lblInfo);
        }

        // Method that is executed when the login button is clicked.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get the text from the text boxes.
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            
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
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
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
