using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using CarWashManagement.Core;

namespace CarWashManagement.UI
{
    public class DashboardForm : BaseForm
    {
        private readonly User loggedInUser;

        // Declaration of the UI control variables.
        private Label welcomeLabel;
        private Button logoutButton;

        // Declaration of Panels for layout.
        private Panel washEntryPanel;
        private Panel todaysEntriesPanel;
        private Panel dailySummaryPanel;

        public DashboardForm(User loggedInUser)
        {
            this.loggedInUser = loggedInUser;
            SetUpControls();
        }

        private void SetUpControls()
        {
            // - - - - - Form set up - - - - -
            Text = "Car Wash Management - Daily Dashboard";
            Size = new Size(800, 600);

            // - - - - - Welcome Label - - - - -
            welcomeLabel = new Label();
            welcomeLabel.Text = $"Welcome, {loggedInUser.FullName} ({loggedInUser.Role})";
            welcomeLabel.Location = new Point(10, 10);
            welcomeLabel.AutoSize = true; // Makes label resize to fit text
            Controls.Add(welcomeLabel);

            // - - - - - Logout Button - - - - -
            logoutButton = new Button();
            logoutButton.Text = "Logout";
            logoutButton.Location = new Point(ClientSize.Width - 85, 10);
            logoutButton.Size = new Size(75, 30);
            logoutButton.Click += LogoutButton_Click;
            Controls.Add(logoutButton);

            // - - - - - Wash Entry Panel - - - - -
            washEntryPanel = new Panel();
            washEntryPanel.Location = new Point(10, 50);
            washEntryPanel.Size = new Size(300, 500);
            washEntryPanel.BorderStyle = BorderStyle.FixedSingle;

            washEntryPanel.Controls.Add(new Label { Text = "Wash Entry Area", Location = new Point(10, 10) });
            Controls.Add(washEntryPanel);

            // - - - - - Today's Entry Panel - - - - -
            todaysEntriesPanel = new Panel();
            todaysEntriesPanel.Location = new Point(320, 50);
            todaysEntriesPanel.Size = new Size(450, 250);
            todaysEntriesPanel.BorderStyle = BorderStyle.FixedSingle;
            todaysEntriesPanel.Controls.Add(new Label { Text = "Today's Entries Area", Location = new Point(10, 10) });
            this.Controls.Add(todaysEntriesPanel);

            // - - - - - Daily Summary Panel - - - - -
            dailySummaryPanel = new Panel();
            dailySummaryPanel.Location = new Point(320, 310);
            dailySummaryPanel.Size = new Size(450, 240);
            dailySummaryPanel.BorderStyle = BorderStyle.FixedSingle;
            dailySummaryPanel.Controls.Add(new Label { Text = "Daily Summary Area", Location = new Point(10, 10) });
            this.Controls.Add(dailySummaryPanel);
        }

        // Method that allow users to logout from the main dashboard.
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult isLogout = MessageBox.Show("Are you sure you want to log out?", "Logout?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (isLogout == DialogResult.Yes)
            {
                Form loginForm = Application.OpenForms["LoginForm"];

                if (loginForm != null)
                {
                    // Clear textboxes on login form.
                    ((LoginForm)loginForm).ClearFields();
                    loginForm.Show();

                    Close();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Form loginForm = Application.OpenForms["LoginForm"];

            if (loginForm != null)
            {
                // Clear textboxes on login form.
                ((LoginForm)loginForm).ClearFields();
                loginForm.Show();
            }
  
            base.OnFormClosed(e);
        }
    }
}
