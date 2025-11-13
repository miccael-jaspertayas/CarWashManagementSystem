using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using CarWashManagement.Core.Managers;
using CarWashManagement.Core.FileHandlers;
using CarWashManagement.Core.Enums;
using CarWashManagement.Core;

namespace CarWashManagement.UI
{
    public class DashboardForm : BaseForm
    {
        private readonly User loggedInUser;

        // Declaration of manager instances.
        private readonly CarManager carManager;
        private readonly TransactionManager transactionManager;

        // Declaration of data lists.
        private List<Vehicle> vehicleTypes;
        private List<Service> services;

        // Declaration of header controls.
        private Label welcomeLabel;
        private Button btnChangePassword;
        private Button logoutButton;
        private MenuStrip mainMenu;
        private ToolStripMenuItem adminMenuItem;

        // Declaration of panels for layout.
        private Panel headerPanel;
        private Panel washEntryPanel;
        private Panel servicePanel;
        private Panel todaysEntriesPanel;
        private Panel dailySummaryPanel;

        // Declaration of Wash Entry Controls.
        private Label lblEmployee;
        private TextBox txtEmployeeName;
        private Label lblVehicleType;
        private ComboBox cmbVehicleType;
        private Label lblBaseFee;
        private TextBox txtBaseFee;
        private Label lblOwnerShare;
        private TextBox txtOwnerShare;
        private Label lblEmployeeShare;
        private TextBox txtEmployeeShare;
        private Label lblAdditionalServices;
        private Label lblTotalServiceFee;
        private TextBox txtTotalServiceFee;
        private Label lblServiceOwnerShare;
        private TextBox txtServiceOwnerShare;
        private Label lblServiceEmpShare;
        private TextBox txtServiceEmpShare;
        private CheckBox chkIsPaid;
        private CheckBox chkWashStatus;
        private Label lblDiscount;
        private ComboBox cmbDiscount;
        private Button btnAddTransaction;
        private Label lblTotalAmount;
        private TextBox txtTotalAmount;
        private List<Control> serviceControls = new List<Control>(); // To hold created service checkboxes and fee textboxes.

        // Declaration of Today's Entries Controls.
        private ListView lsvTodayEntries;
        private ContextMenuStrip lsvContextMenu;

        // Declaration of Daily Summary Controls.
        private Label lblDailySummary;
        private Label lblSummaryTotalRevenue;
        private TextBox txtSummaryTotalRevenue;
        private Label lblSummaryTotalOwnerShare;
        private TextBox txtSummaryTotalOwnerShare;
        private Label lblSummaryTotalEmpShare;
        private TextBox txtSummaryTotalEmpShare;
        private Label lblSummaryTotalWashes;
        private TextBox txtSummaryTotalWashes;
        private Label lblSummaryMostWashedVehicle;
        private TextBox txtSummaryMostWashedVehicle;

        public DashboardForm(User loggedInUser)
        {
            this.loggedInUser = loggedInUser;

            // Initialize manager instances.
            carManager = new CarManager(
                new VehicleFileHandler(),
                new ServiceFileHandler(),
                new AuditFileHandler()
                );
            transactionManager = new TransactionManager(
                new TransactionFileHandler(),
                new AuditFileHandler()
                );

            // Load data lists.
            vehicleTypes = carManager.GetVehicleTypes();
            services = carManager.GetServices();

            SetUpControls();
            LoadVehicleComboBox();
            LoadServiceControls();
            RefreshTodaysEntries();

            if (loggedInUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                adminMenuItem.Visible = true;
            }
        }

        private void SetUpControls()
        {
            // - - - - - Form set up - - - - -
            Text = "Car Wash Management - Daily Dashboard";
            Size = new Size(800, 700);

            // - - - - - Header Panel - - - - -
            headerPanel = new Panel
            {
                Size = new Size(785, 40),
                Location = new Point(0,0),
                BackColor = Color.FromArgb(41, 128, 185)
            };
            Controls.Add(headerPanel);

            // --- Welcome Label ---
            welcomeLabel = new Label
            {
                Text = $"Welcome, {loggedInUser.FullName} ({loggedInUser.Role})",
                Location = new Point(10, 10),
                AutoSize = true,
                Height = 30,
                BackColor = Color.White,
                ForeColor = Color.FromArgb(41, 128, 185),
                Font = new Font("Segoe UI", 11, FontStyle.Bold)
            };
            headerPanel.Controls.Add(welcomeLabel);

            // --- Logout Button ---
            logoutButton = new Button
            {
                Text = "Logout",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = loggedInUser.Role == "ADMIN" ? new Point(665, 5) : new Point(700, 5),
                Size = new Size(75, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Color.FromArgb(41, 128, 185)
            };
            logoutButton.Click += LogoutButton_Click;
            logoutButton.BringToFront();
            headerPanel.Controls.Add(logoutButton);

            // --- Change Password Button ---
            btnChangePassword = new Button
            {
                Text = "Change Password",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = loggedInUser.Role == "ADMIN" ? new Point(535, 5) : new Point(570, 5),
                Size = new Size(125, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Color.FromArgb(41, 128, 185)
            };
            btnChangePassword.Click += btnChangePassword_Click;
            headerPanel.Controls.Add(btnChangePassword);

            // --- Main Menu ---
            mainMenu = new MenuStrip();
            mainMenu.Location = new Point(0, 15);
            mainMenu.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            mainMenu.BackColor = Color.FromArgb(41, 128, 185);
            mainMenu.ForeColor = Color.White;

            // - Admin Menu Item -
            adminMenuItem = new ToolStripMenuItem("•••");
            adminMenuItem.Alignment = ToolStripItemAlignment.Right;
            adminMenuItem.Visible = false; // Hidden by default

            adminMenuItem.DropDownItems.Add("Manage Users", null, ManageUsers_Click);
            adminMenuItem.DropDownItems.Add("Manage Vehicles", null, ManageVehicles_Click);
            adminMenuItem.DropDownItems.Add("Manage Services", null, ManageServices_Click);
            adminMenuItem.DropDownItems.Add("Manage Expenses", null, ManageExpenses_Click);
            adminMenuItem.DropDownItems.Add("Monthly/Yearly Report", null, ShowMonthlyReport_Click);

            mainMenu.Items.Add(adminMenuItem);
            headerPanel.Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;

            int labelY = mainMenu.Height + 5;

            // - - - - - Wash Entry Panel - - - - -
            washEntryPanel = new Panel
            {
                Location = new Point(10, 60),
                Size = new Size(300, 590),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };
            Controls.Add(washEntryPanel);

            // --- Employee Name ---
            int currentY = 15;
            lblEmployee = new Label
            {
                Text = "Employee Name:",
                Location = new Point(10, currentY),
                AutoSize = true
            };
            washEntryPanel.Controls.Add(lblEmployee);

            txtEmployeeName = new TextBox
            {
                Location = new Point(110, currentY - 3),
                Size = new Size(170, 23)
            };
            washEntryPanel.Controls.Add(txtEmployeeName);

            currentY += 35;

            // --- Vehicle Type ---
            lblVehicleType = new Label
            {
                Text = "Vehicle Type:",
                Location = new Point(10, currentY),
                AutoSize = true
            };
            washEntryPanel.Controls.Add(lblVehicleType);

            cmbVehicleType = new ComboBox
            {
                Location = new Point(110, currentY - 3),
                Size = new Size(170, 23),
                DropDownStyle = ComboBoxStyle.DropDownList, // Prevents user from typing
                FlatStyle = FlatStyle.Standard
            };
            cmbVehicleType.SelectedIndexChanged += cmbVehicleType_SelectedIndexChanged;
            washEntryPanel.Controls.Add(cmbVehicleType);

            currentY += 35;

            // --- Base Fee ---
            lblBaseFee = new Label
            {
                Text = "Base Fee:",
                Location = new Point(10, currentY),
                AutoSize = true
            };
            washEntryPanel.Controls.Add(lblBaseFee);

            txtBaseFee = new TextBox
            {
                Location = new Point(10, currentY + 20),
                Size = new Size(80, 23),
                ReadOnly = true, // Base fee is auto-filled based on vehicle type
                TextAlign = HorizontalAlignment.Right,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };
            washEntryPanel.Controls.Add(txtBaseFee);

            // --- Owner Share ---
            lblOwnerShare = new Label
            {
                Text = "Owner Share:",
                Location = new Point(100, currentY),
                AutoSize = true
            };
            washEntryPanel.Controls.Add(lblOwnerShare);

            txtOwnerShare = new TextBox
            {
                Location = new Point(100, currentY + 20),
                Size = new Size(80, 23),
                ReadOnly = true, // Owner share is auto-filled based on vehicle type
                TextAlign = HorizontalAlignment.Right,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };
            washEntryPanel.Controls.Add(txtOwnerShare);

            // --- Employee Share ---
            lblEmployeeShare = new Label
            {
                Text = "Employee Share:",
                Location = new Point(190, currentY),
                AutoSize = true
            };
            washEntryPanel.Controls.Add(lblEmployeeShare);

            txtEmployeeShare = new TextBox
            {
                Location = new Point(190, currentY + 20),
                Size = new Size(80, 23),
                ReadOnly = true, // Employee share is auto-filled based on vehicle type.
                TextAlign = HorizontalAlignment.Right,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };
            washEntryPanel.Controls.Add(txtEmployeeShare);

            currentY += 60;

            // --- Additional Services ---
            lblAdditionalServices = new Label
            {
                Text = "Additional Services:",
                Location = new Point(10, currentY),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(41, 128, 185),
                AutoSize = true
            };
            washEntryPanel.Controls.Add(lblAdditionalServices);

            // --- Service Panel ---
            servicePanel = new Panel
            {
                Location = new Point(10, currentY + 20),
                Size = new Size(280, 200),
                BorderStyle = BorderStyle.None,
                AutoScroll = true
            };
            washEntryPanel.Controls.Add(servicePanel);

            int serviceShareY = washEntryPanel.Height - 190;
            
            // --- Total Service Fee ---
            lblTotalServiceFee = new Label
            {
                Text = "Service/s Fee:",
                Location = new Point(10, serviceShareY - 20),
                AutoSize = true
            };
            washEntryPanel.Controls.Add(lblTotalServiceFee);

            txtTotalServiceFee = new TextBox
            {
                Location = new Point(10, serviceShareY),
                Size = new Size(80, 23),
                ReadOnly = true, // Total service fee is auto-calculated
                TextAlign = HorizontalAlignment.Right,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };
            washEntryPanel.Controls.Add(txtTotalServiceFee);

            // --- Service Owner Share ---
            lblServiceOwnerShare = new Label
            {
                Text = "Owner Share:",
                Location = new Point(100, serviceShareY - 20),
                AutoSize = true
            };
            washEntryPanel.Controls.Add(lblServiceOwnerShare);

            txtServiceOwnerShare = new TextBox
            {
                Location = new Point(100, serviceShareY),
                Size = new Size(80, 23),
                ReadOnly = true, // Service owner share is auto-calculated
                TextAlign = HorizontalAlignment.Right,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };
            washEntryPanel.Controls.Add(txtServiceOwnerShare);

            // --- Service Employee Share ---
            lblServiceEmpShare = new Label
            {
                Text = "Employee Share:",
                Location = new Point(190, serviceShareY - 20),
                AutoSize = true
            };
            washEntryPanel.Controls.Add(lblServiceEmpShare);

            txtServiceEmpShare = new TextBox
            {
                Location = new Point(190, serviceShareY),
                Size = new Size(80, 23),
                ReadOnly = true, // Service employee share is auto-calculated
                TextAlign = HorizontalAlignment.Right,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };
            washEntryPanel.Controls.Add(txtServiceEmpShare);

            // --- Is Paid Checkbox ---
            chkIsPaid = new CheckBox
            {
                Text = "Paid by Employee",
                Location = new Point(10, washEntryPanel.Height - 140),
                AutoSize = true
            };
            washEntryPanel.Controls.Add(chkIsPaid);

            // --- Wash Status Checkbox ---
            chkWashStatus = new CheckBox
            {
                Text = "Mark as Completed", // Unchecked = Ongoing, Checked = Completed
                Location = new Point(10, washEntryPanel.Height - 113),
                AutoSize = true
            };
            washEntryPanel.Controls.Add(chkWashStatus);

            // --- Discount ComboBox ---
            lblDiscount = new Label
            {
                Text = "Discount:",
                Location = new Point(160, washEntryPanel.Height - 140),
                AutoSize = true
            };
            washEntryPanel.Controls.Add(lblDiscount);

            cmbDiscount = new ComboBox
            {
                Location = new Point(220, washEntryPanel.Height - 140),
                Size = new Size(60, 23),
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Popup
            };
            cmbDiscount.Items.Add("N/A");
            cmbDiscount.Items.Add("PWD");
            cmbDiscount.Items.Add("Senior");
            cmbDiscount.SelectedIndex = 0; // Default to N/A
            cmbDiscount.SelectedIndexChanged += (sender, e) => UpdateTotalAmount();
            washEntryPanel.Controls.Add(cmbDiscount);


            // --- Total Amount ---
            lblTotalAmount = new Label
            {
                Text = "Total Amount:",
                Location = new Point(10, washEntryPanel.Height - 75),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(41, 128, 185),
                AutoSize = true
            };
            washEntryPanel.Controls.Add(lblTotalAmount);

            txtTotalAmount = new TextBox
            {
                Location = new Point(120, washEntryPanel.Height - 78),
                Size = new Size(160, 23),
                ReadOnly = true, // Total amount is auto-calculated
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = HorizontalAlignment.Right,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };
            washEntryPanel.Controls.Add(txtTotalAmount);

            // --- Add Transaction Button ---
            btnAddTransaction = new Button
            {
                Text = "Add Entry",
                Location = new Point(10, washEntryPanel.Height - 40),
                Size = new Size(270, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(41, 128, 185),
                ForeColor = Color.White
            };
            btnAddTransaction.FlatAppearance.BorderSize = 0;
            btnAddTransaction.Click += btnAddTransaction_Click;
            washEntryPanel.Controls.Add(btnAddTransaction);

            // - - - - - Today's Entry Panel - - - - -
            todaysEntriesPanel = new Panel();
            todaysEntriesPanel.Location = new Point(320, 60);
            todaysEntriesPanel.Size = new Size(455, 380);
            todaysEntriesPanel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(todaysEntriesPanel);

            // --- ListView for Today's Entries ---
            lsvTodayEntries = new ListView
            {
                Dock = DockStyle.Fill, // Fill the entire panel
                View = View.Details, // Set view to show columns
                FullRowSelect = true, // Select the entire row
                GridLines = true,
            };
            lsvTodayEntries.Columns.Add("Time", 50, HorizontalAlignment.Left);
            lsvTodayEntries.Columns.Add("Vehicle", 80, HorizontalAlignment.Left);
            lsvTodayEntries.Columns.Add("Employee", 90, HorizontalAlignment.Left);
            lsvTodayEntries.Columns.Add("Total", 70, HorizontalAlignment.Right);
            lsvTodayEntries.Columns.Add("Paid", 50, HorizontalAlignment.Center);
            lsvTodayEntries.Columns.Add("Wash Status", 85, HorizontalAlignment.Left);
            todaysEntriesPanel.Controls.Add(lsvTodayEntries);

            // --- Context Menu for ListView ---
            lsvContextMenu = new ContextMenuStrip();
            lsvContextMenu.Items.Add("Toggle Paid Status", null, TogglePaidStatus_Click);
            lsvContextMenu.Items.Add("Toggle Wash Status", null, ToggleWashStatus_Click);
            lsvTodayEntries.ContextMenuStrip = lsvContextMenu;

            // - - - - - Daily Summary Panel - - - - -
            dailySummaryPanel = new Panel();
            dailySummaryPanel.Location = new Point(320, 450);
            dailySummaryPanel.Size = new Size(455, 200);
            dailySummaryPanel.BorderStyle = BorderStyle.FixedSingle;
            dailySummaryPanel.BackColor = Color.White;
            this.Controls.Add(dailySummaryPanel);

            // --- Daily Summary Label ---
            lblDailySummary = new Label
            {
                Text = "Daily Summary",
                Location = new Point(15, 10),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(41, 128, 185),
                AutoSize = true
            };
            dailySummaryPanel.Controls.Add(lblDailySummary);

            int col1X = 15;
            int col2X = 240;
            int currentSummaryY = 40;

            // --- Total Revenue ---
            lblSummaryTotalRevenue = new Label
            {
                Text = "Total Revenue:",
                Location = new Point(col1X, currentSummaryY),
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.FromArgb(41, 128, 185),
                AutoSize = true
            };
            dailySummaryPanel.Controls.Add(lblSummaryTotalRevenue);

            txtSummaryTotalRevenue = new TextBox
            {
                Location = new Point(col1X, currentSummaryY + 20),
                Size = new Size(180, 23),
                ReadOnly = true,
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = HorizontalAlignment.Right,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            dailySummaryPanel.Controls.Add(txtSummaryTotalRevenue);

            currentSummaryY += 50;

            // --- Total Owner Share ---
            lblSummaryTotalOwnerShare = new Label
            {
                Text = "Total Owner Share:",
                Location = new Point(col1X, currentSummaryY),
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.FromArgb(41, 128, 185),
                AutoSize = true
            };
            dailySummaryPanel.Controls.Add(lblSummaryTotalOwnerShare);

            txtSummaryTotalOwnerShare = new TextBox
            {
                Location = new Point(col1X, currentSummaryY + 20),
                Size = new Size(180, 23),
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Right,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            dailySummaryPanel.Controls.Add(txtSummaryTotalOwnerShare);

            // --- Total Employee Share ---
            lblSummaryTotalEmpShare = new Label
            {
                Text = "Total Employee Share:",
                Location = new Point(col2X, currentSummaryY),
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.FromArgb(41, 128, 185),
                AutoSize = true
            };
            dailySummaryPanel.Controls.Add(lblSummaryTotalEmpShare);

            txtSummaryTotalEmpShare = new TextBox
            {
                Location = new Point(col2X, currentSummaryY + 20),
                Size = new Size(180, 23),
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Right,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            dailySummaryPanel.Controls.Add(txtSummaryTotalEmpShare);

            currentSummaryY += 50;

            // --- Total Washes ---
            lblSummaryTotalWashes = new Label
            {
                Text = "Total Washes:",
                Location = new Point(col1X, currentSummaryY),
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.FromArgb(41, 128, 185),
                AutoSize = true
            };
            dailySummaryPanel.Controls.Add(lblSummaryTotalWashes);

            txtSummaryTotalWashes = new TextBox
            {
                Location = new Point(col1X, currentSummaryY + 20),
                Size = new Size(180, 23),
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Right,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            dailySummaryPanel.Controls.Add(txtSummaryTotalWashes);

            // --- Most Washed Vehicle ---
            lblSummaryMostWashedVehicle = new Label
            {
                Text = "Most Washed Vehicle:",
                Location = new Point(col2X, currentSummaryY),
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.FromArgb(41, 128, 185),
                AutoSize = true
            };
            dailySummaryPanel.Controls.Add(lblSummaryMostWashedVehicle);

            txtSummaryMostWashedVehicle = new TextBox
            {
                Location = new Point(col2X, currentSummaryY + 20),
                Size = new Size(180, 23),
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Right,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            dailySummaryPanel.Controls.Add(txtSummaryMostWashedVehicle);

        }

        // Method to load the vehicle types in the dropdown combo box.
        private void LoadVehicleComboBox()
        {
            // ComboBox configuration
            cmbVehicleType.DataSource = null; // Reset the DataSource.
            cmbVehicleType.DataSource = vehicleTypes;
            cmbVehicleType.DisplayMember = "Type";
            cmbVehicleType.ValueMember = "Type";
            cmbVehicleType.SelectedIndex = -1; // Start with no selection.

        }

        // Method to load the service controls.
        private void LoadServiceControls()
        {
            int currentY = 10;

            foreach(Control c in serviceControls)
            {
                servicePanel.Controls.Remove(c);
            }
            serviceControls.Clear();

            foreach(Service service in services)
            {
                // Create the CheckBox.
                CheckBox chk = new CheckBox();
                chk.Text = service.Name;
                chk.Location = new Point(10, currentY);
                chk.AutoSize = true;
                chk.Tag = service; // Store the service object in the tag.
                chk.CheckedChanged += ServiceCheckbox_CheckedChanged;
                servicePanel.Controls.Add(chk);
                serviceControls.Add(chk);

                // Create the Textbox
                TextBox txt = new TextBox();
                txt.Location = new Point(180, currentY - 3);
                txt.Size = new Size(80, 23);
                txt.Enabled = false;
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.BackColor = Color.White;
                txt.Tag = service; // Store the service object in the tag.
                servicePanel.Controls.Add(txt);
                serviceControls.Add(txt);

                if (service.PricingType == ServicePricingType.ManualInput)
                {
                    txt.Text = "0.00";
                    txt.ReadOnly = false; // Allow user input.
                    txt.Enabled = false; // Initially disabled until checkbox is checked.
                    txt.TextChanged += ServiceTextBox_TextChanged;
                    txt.TextAlign = HorizontalAlignment.Right;

                } else if (service.PricingType == ServicePricingType.FixedPrice)
                {
                    txt.Text = service.Fee.ToString("N2");
                    txt.ReadOnly = true;
                    txt.Enabled = false; // Initially disabled until checkbox is checked.
                    txt.TextAlign = HorizontalAlignment.Right;
                } 
                else if (service.PricingType == ServicePricingType.VehicleBaseFeeMultiplier)
                {
                    txt.Text = "0.00"; // Will be calculated based on vehicle base fee.
                    txt.ReadOnly = true;
                    txt.Enabled = false; // Initially disabled until checkbox is checked.
                    txt.TextAlign = HorizontalAlignment.Right;
                }

                currentY += 30;
            }
        }

        // Method to update the total amount based on selected services and vehicle type.
        private void UpdateTotalAmount()
        {
            // Get the base fee from the selected vehicle.
            Vehicle selectedVehicle = cmbVehicleType.SelectedItem as Vehicle;
            decimal baseFee = (selectedVehicle != null) ? selectedVehicle.BaseFee : 0.00m;

            // Initialize total services fee.
            decimal servicesTotal = 0.00m;

            // Iterate through service controls to calculate total.
            foreach (Control control in serviceControls)
            {
                // Only process checked services.
                if (control is CheckBox chk && chk.Checked)
                {
                    Service service = chk.Tag as Service;
                    if (service == null) { continue; }

                    // Find the corresponding textbox for this service.
                    TextBox txt = serviceControls.FirstOrDefault(c => c is TextBox && c.Tag == service) as TextBox;

                    switch (service.PricingType)
                    {
                        case ServicePricingType.FixedPrice:
                            servicesTotal += service.Fee;
                            break;
                        case ServicePricingType.ManualInput:
                            if (txt != null && decimal.TryParse(txt.Text, out decimal manualFee))
                            {
                                servicesTotal += manualFee;
                            }
                            break;
                        case ServicePricingType.VehicleBaseFeeMultiplier:
                            decimal multiplierServiceFee = baseFee * service.Multiplier;
                            txt.Text = multiplierServiceFee.ToString("N2");
                            servicesTotal += multiplierServiceFee;
                            break;
                    }
                }
            }

            // Calculate shares for services (50% each).
            decimal serviceOwnerShare = servicesTotal * 0.5m;
            decimal serviceEmployeeShare = servicesTotal * 0.5m;

            // Update the service fee textboxes.
            txtTotalServiceFee.Text = servicesTotal.ToString("N2");
            txtServiceOwnerShare.Text = serviceOwnerShare.ToString("N2");
            txtServiceEmpShare.Text = serviceEmployeeShare.ToString("N2");

            decimal subTotal = baseFee + servicesTotal;
            decimal discountPercentage = 0.00m;

            if (cmbDiscount.SelectedItem.ToString() == "PWD" || cmbDiscount.SelectedItem.ToString() == "Senior")
            {
                discountPercentage = 0.20m; // 20% discount
            }

            decimal discountAmount = subTotal * discountPercentage;

            decimal totalAmount = subTotal - discountAmount;
            txtTotalAmount.Text = totalAmount.ToString("N2");
        }

        private void UpdateDailySummary()
        {
            List<Transaction> todaysTransaction = transactionManager.GetTodaysTransactions()
                .Where(txn => txn.WashStatus == "Completed")
                .ToList();

            decimal totalRevenue = todaysTransaction.Sum(txn => txn.TotalAmount);
            decimal totalOwnerShare = todaysTransaction.Sum (txn => txn.OwnerShare);
            decimal totalEmpShare = todaysTransaction.Sum(txn => txn.EmployeeShare);
            int totalWashes = todaysTransaction.Count();

            string mostWashedVehicle = "N/A";

            if (totalWashes > 0)
            {
                mostWashedVehicle = todaysTransaction
                    .GroupBy(txn => txn.VehicleType) // Group by vehicle type.
                    .OrderByDescending(group => group.Count()) // Order groups by count (descending).
                    .Select(group => group.Key) // Select the vehicle type (key) of the group.
                    .FirstOrDefault(); // Get the first element in the ordered list.
            }

            txtSummaryTotalRevenue.Text = totalRevenue.ToString("N2");
            txtSummaryTotalOwnerShare.Text = totalOwnerShare.ToString("N2");
            txtSummaryTotalEmpShare.Text = totalEmpShare.ToString("N2");
            txtSummaryTotalWashes.Text = totalWashes.ToString();
            txtSummaryMostWashedVehicle.Text = mostWashedVehicle;
        }

        // Method to refresh today's entries in the ListView.
        private void RefreshTodaysEntries()
        {
            // Clear existing items.
            lsvTodayEntries.Items.Clear();

            // Get today's transactions from the manager.
            List<Transaction> todaysTransactions = transactionManager.GetTodaysTransactions();

            foreach (Transaction txn in todaysTransactions)
            {
                // Create a new row (ListViewItem)
                ListViewItem row = new ListViewItem(txn.Timestamp.ToString("HH:mm"));

                // Store transaction ID in the Tag for reference when updating the Paid and Status properties.
                row.Tag = txn.ID; 

                // Add the other columns (sub-items).
                row.SubItems.Add(txn.VehicleType);
                row.SubItems.Add(txn.EmployeeName);
                row.SubItems.Add(txn.TotalAmount.ToString("N2"));
                row.SubItems.Add(txn.IsPaid ? "Yes" : "No");
                row.SubItems.Add(txn.WashStatus);

                // Add the completed row to the list view.
                lsvTodayEntries.Items.Add(row);
            }

            // Update the summary panel when the transaction list is refreshed.
            UpdateDailySummary();
        }

        // Method to reset the wash entry form after adding a transaction.
        private void ResetWashEntryForm()
        {
            txtEmployeeName.Clear();
            cmbVehicleType.SelectedIndex = -1; // Triggers the SelectedIndexChanged event to clear fees
            cmbVehicleType.SelectedIndex = -1; // There is a bug in setting SelectedIndex = -1 with data-bound ComboBoxes. The work-around is to set the property twice.
            cmbDiscount.SelectedIndex = 0;

            foreach (Control control in serviceControls)
            {
                if (control is CheckBox chk)
                {
                    chk.Checked = false; // Triggers Checkbox_CheckedChanged to reset state
                }
                // Textboxes for ManualInput will be cleared by the Checkbox_CheckedChanged event.
                // Textboxes for Fixed/Multiplier will be cleared by the cmbVehicleType_SelectedIndexChanged event (since SelectedIndex = -1).
            }

            chkIsPaid.Checked = false;
            txtTotalServiceFee.Clear();
            txtServiceOwnerShare.Clear();
            txtServiceEmpShare.Clear();
            txtTotalAmount.Text = "0.00";
        }

        // Method to reload all vehicle and service data and refreshes the UI controls.
        private void RefreshCarManagerData()
        {
            // Get the data again from the manager to reflect changes made.
            vehicleTypes = carManager.GetVehicleTypes();
            services = carManager.GetServices();

            // Reload the controls.
            LoadVehicleComboBox();
            LoadServiceControls();
        }

        // Method that opens the change password form.
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(loggedInUser);
            changePasswordForm.ShowDialog();
        }
        
        // Method that opens the Manage Users form (Admin Only).
        private void ManageUsers_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.ShowDialog();
        }

        // Method that opens the Manage Vehicles form (Admin Only).
        private void ManageVehicles_Click(object sender, EventArgs e)
        {
            VehicleManagementForm vehicleManagementForm = new VehicleManagementForm(loggedInUser, carManager);
            vehicleManagementForm.ShowDialog();

            // After the Vehicle Management Form closes, refresh the dashboard's data in case there are changes.
            RefreshCarManagerData();
        }

        // Method that opens the Manage Services form (Admin Only).
        private void ManageServices_Click(object sender, EventArgs e)
        {
            ServiceManagementForm serviceManagementForm = new ServiceManagementForm(loggedInUser, carManager);
            serviceManagementForm.ShowDialog();

            // Refresh the dashboard data in case services were changed
            RefreshCarManagerData();
        }

        // Method that opens the Manage Expenses form (Admin Only).
        private void ManageExpenses_Click(object sender, EventArgs e)
        {
            ExpenseManagementForm expenseManagementForm = new ExpenseManagementForm(loggedInUser);
            expenseManagementForm.ShowDialog();

            // Refresh daily summary to reflect any changes in expenses (in case I add the expenses in the daily summary in the future).
            UpdateDailySummary();
        }

        // Method that opens the Monthly Report dashboard form (Admin Only)
        private void ShowMonthlyReport_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }

        // Method that allow users to logout from the main dashboard.
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult isLogout = MessageBox.Show("Are you sure you want to log out?", "Logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        // Method to handle toggling paid status of a transaction from the context menu.
        private void TogglePaidStatus_Click(object sender, EventArgs e)
        {
            // Check if any item is selected in the ListView.
            if (lsvTodayEntries.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a transaction row to toggle its Paid Status.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get all the selected items from the ListView.
            ListView.SelectedListViewItemCollection selectedRows = lsvTodayEntries.SelectedItems;

            // Iterate through each selected row to toggle the IsPaid property.
            foreach (ListViewItem selectedRow in selectedRows)
            {
                string transactionID = selectedRow.Tag as string;

                Transaction txnToUpdate = transactionManager.GetTransactionByID(transactionID);

                if (txnToUpdate == null)
                {
                    MessageBox.Show("Transaction not found. Please refresh the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txnToUpdate.IsPaid = !txnToUpdate.IsPaid; // Toggle the IsPaid property.
            }

            // Save the modified list of transactions back to the file. 
            transactionManager.UpdateTransaction();

            RefreshTodaysEntries();
        }

        // Method to handle toggling wash status of a transaction from the context menu.
        private void ToggleWashStatus_Click(object sender, EventArgs e)
        {
            if (lsvTodayEntries.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a transaction row to toggle its Wash Status.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListView.SelectedListViewItemCollection selectedRows = lsvTodayEntries.SelectedItems;

            foreach (ListViewItem row in selectedRows)
            {
                string transactionID = row.Tag as string;

                Transaction txnToUpdate = transactionManager.GetTransactionByID(transactionID);

                if (txnToUpdate == null)
                {
                    MessageBox.Show("Transaction not found. Please refresh the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txnToUpdate.WashStatus = (txnToUpdate.WashStatus == "Ongoing") ? "Completed" : "Ongoing"; // Toggle the wash status.
            }

            transactionManager.UpdateTransaction();
            RefreshTodaysEntries();
        }

        // Method to handle when the "Add Entry" button is clicked.
        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the employee name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbVehicleType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vehicle type.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (Control control in serviceControls)
            {
                if (control is CheckBox chk && chk.Checked)
                {
                    Service service = chk.Tag as Service;
                    if (service != null && service.PricingType == ServicePricingType.ManualInput)
                    {
                        TextBox txt = serviceControls.FirstOrDefault(c => c is TextBox && c.Tag == service) as TextBox;

                        if (txt == null || !decimal.TryParse(txt.Text, out decimal manualFee) || manualFee <= 0)
                        {
                            MessageBox.Show($"Please enter a valid fee for the service: {service.Name}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }

            Vehicle selectedVehicle = cmbVehicleType.SelectedItem as Vehicle;
            string employeeName = txtEmployeeName.Text.Trim();
            bool isPaid = chkIsPaid.Checked;
            string washStatus = chkWashStatus.Checked ? "Completed" : "Ongoing";
            decimal discountPercentage = (cmbDiscount.SelectedItem.ToString() == "PWD" || cmbDiscount.SelectedItem.ToString() == "Senior") ? 0.20m : 0.00m;
            List<Service> selectedServices = new List<Service>();

            // Gather selected services and get their final fees.
            foreach (Control control in serviceControls)
            {
                // Only process checked services.
                if (control is CheckBox chk && chk.Checked)
                {
                    Service service = chk.Tag as Service;
                    TextBox txt = serviceControls.FirstOrDefault(c => c is TextBox && c.Tag == service) as TextBox;

                    // Get the final service fee from the textbox (it's either fixed, calculated, or manual input).
                    decimal.TryParse(txt.Text, out decimal serviceFee);

                    // Add to selected services list.
                    selectedServices.Add(new Service
                    {
                        Name = service.Name,
                        Fee = serviceFee,
                        PricingType = service.PricingType,
                        Multiplier = service.Multiplier
                    });
                }
            }

            if (!decimal.TryParse(txtTotalAmount.Text, out decimal totalAmount) || totalAmount <= 0)
            {
                MessageBox.Show("Total amount must be greater than zero. Please check vehicle selection and services.", "Invalid Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Transaction newTransaction = transactionManager.CreateTransaction(
                    employeeName,
                    selectedVehicle,
                    selectedServices,
                    isPaid,
                    washStatus,
                    discountPercentage,
                    loggedInUser.Username
                    );

                MessageBox.Show($"Transaction {newTransaction.ID} added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetWashEntryForm();
                RefreshTodaysEntries();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the transaction: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to handle vehicle type selection change.
        private void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehicle selectedVehicle = cmbVehicleType.SelectedItem as Vehicle;
            decimal baseFee = 0.00m;

            if (selectedVehicle != null)
            {
                baseFee = selectedVehicle.BaseFee;
                txtBaseFee.Text = selectedVehicle.BaseFee.ToString("N2");
                txtOwnerShare.Text = selectedVehicle.OwnerShare.ToString("N2");
                txtEmployeeShare.Text = selectedVehicle.EmployeeShare.ToString("N2");
            }
            else
            {
                // Clear the fee textboxes if no vehicle is selected.
                txtBaseFee.Clear();
                txtOwnerShare.Clear();
                txtEmployeeShare.Clear();
            }

            foreach (Control control in serviceControls)
            {
                if (control is TextBox txt)
                {
                    Service service = txt.Tag as Service;
                    if (service != null && service.PricingType == ServicePricingType.VehicleBaseFeeMultiplier)
                    {
                        decimal serviceFee = baseFee * service.Multiplier;
                        txt.Text = serviceFee.ToString("N2");
                    }
                }
            }

            // Recalculate total if the selected vehicle is changed.
            // Because services with pricing type "VehicleBaseFeeMultiplier" depends on the vehicle's base fee. 
            UpdateTotalAmount();
        }

        // Method to handle services checkbox state changes.
        private void ServiceCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            Service service = chk.Tag as Service;

            // Find the corresponding textbox for this service.
            TextBox txt = serviceControls.FirstOrDefault(c => c is TextBox && c.Tag == service) as TextBox;
            
            if (service.PricingType == ServicePricingType.ManualInput)
            {
                txt.Enabled = chk.Checked;
                if (!chk.Checked)
                {
                    txt.Text = "0.00";
                }
            } else if (service.PricingType == ServicePricingType.VehicleBaseFeeMultiplier)
            {
                txt.Enabled = chk.Checked;

            } else if (service.PricingType == ServicePricingType.ManualInput)
            {
                txt.Enabled = chk.Checked;
            }

            // Recalculate total amount whenever a service checkbox is ticked.
            UpdateTotalAmount();
        }

        // Method to update the total amount when the text changes in a service textbox manual input.
        private void ServiceTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
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
            
            Console.WriteLine("Car Wash Management System\nMiccael Jasper Tayas\nFinal Project Requirement\nCIS202 - Object Oriented Programming\nNovember 2025\n\nThank you for using the system!");
            base.OnFormClosed(e);
        }
    }
}
