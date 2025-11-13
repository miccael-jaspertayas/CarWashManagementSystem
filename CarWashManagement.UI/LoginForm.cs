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
using CarWashManagement.UI.Properties;

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
        private PictureBox eyeIcon;
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

            // --- Login Picture ---
            loginPicture = new PictureBox
            {
                Image = Resources.login_image,
                Location = new Point(0, 0),
                Size = new Size(300, 530),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            Controls.Add(loginPicture);

            // --- Login Label ---
            lblLogin = new Label
            {
                Text = "Login to your account",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(41, 128, 185),
                Location = new Point(340, 100),
                AutoSize = true
            };
            Controls.Add(lblLogin);

            // --- Username ---
            lblUsername = new Label
            {
                Text = "Username: ",
                Location = new Point(340, 160),
                Font = new Font("Segoe UI", 12),
                AutoSize = true
            };
            Controls.Add(lblUsername);

            txtUsername = new TextBox
            {
                Location = new Point(340, 190),
                Multiline = true,
                Height = 30,
                Width = 270,
                WordWrap = false,
                ScrollBars = ScrollBars.None,
                Font = new Font("Segoe UI", 12),
                BorderStyle = BorderStyle.None,
            };
            Controls.Add(txtUsername);

            // --- Password ---
            lblPassword = new Label
            {
                Text = "Password:",
                Location = new Point(340, 230),
                Font = new Font("Segoe UI", 12),
                AutoSize = true,
            };
            Controls.Add(lblPassword);

            txtPassword = new TextBox
            {
                Location = new Point(340, 260),
                Multiline = true,
                Height = 30,
                Width = 270,
                WordWrap = false,
                ScrollBars = ScrollBars.None,
                Font = new Font("Segoe UI", 12),
                PasswordChar = '•',
                BorderStyle = BorderStyle.None,
            };
            Controls.Add(txtPassword);

            // --- Eye Icon ---
            eyeIcon = new PictureBox
            {
                Image = Resources.eye_hide,
                Location = new Point(620, 260),
                Size = new Size(30, 30),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            eyeIcon.Click += eyeIcon_Click;
            Controls.Add(eyeIcon);

            // --- Login Button ---
            btnLogin = new Button
            {
                Text = "LOGIN",
                Font = new Font("Segoe UI", 12),
                Location = new Point(340, 320),
                Size = new Size(100, 40),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(41, 128, 185),
                ForeColor = Color.White
            };
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Click += btnLogin_Click;
            Controls.Add(btnLogin);

            Label lblInfo = new Label
            {
                Text = "No account yet? Ask an administrator to create an account for you.",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.Gray,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Size = new Size(300, 100),
                Location = new Point(340, 420),
            }; 
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
            txtPassword.UseSystemPasswordChar = false;
            eyeIcon.Image = Resources.eye_hide;
            txtUsername.Focus();
        }

        private void eyeIcon_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            eyeIcon.Image = txtPassword.UseSystemPasswordChar ? Resources.eye_show : Resources.eye_hide;
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
