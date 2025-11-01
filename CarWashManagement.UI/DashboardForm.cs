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
        private Button logoutButton;

        // Declaration of panels for layout.
        private Panel washEntryPanel;
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

        public DashboardForm(User loggedInUser)
        {
            this.loggedInUser = loggedInUser;

            // Initialize manager instances.
            carManager = new CarManager(
                new VehicleFileHandler(),
                new ServiceFileHandler()
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
        }

        private void SetUpControls()
        {
            // - - - - - Form set up - - - - -
            Text = "Car Wash Management - Daily Dashboard";
            Size = new Size(800, 600);

            // - - - - - Welcome Label - - - - -
            welcomeLabel = new Label
            {
                Text = $"Welcome, {loggedInUser.FullName} ({loggedInUser.Role})",
                Location = new Point(10, 10),
                AutoSize = true // Makes label resize to fit text
            };
            Controls.Add(welcomeLabel);

            // - - - - - Logout Button - - - - -
            logoutButton = new Button
            {
                Text = "Logout",
                Location = new Point(ClientSize.Width - 85, 10),
                Size = new Size(75, 30),
            };
            logoutButton.Click += LogoutButton_Click;
            Controls.Add(logoutButton);

            // - - - - - Wash Entry Panel - - - - -
            washEntryPanel = new Panel
            {
                Location = new Point(10, 50),
                Size = new Size(300, 500),
                BorderStyle = BorderStyle.FixedSingle
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
                DropDownStyle = ComboBoxStyle.DropDownList // Prevents user from typing
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
                TextAlign = HorizontalAlignment.Right
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
                TextAlign = HorizontalAlignment.Right
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
                TextAlign = HorizontalAlignment.Right
            };
            washEntryPanel.Controls.Add(txtEmployeeShare);

            currentY += 60;

            // --- Additional Services ---
            lblAdditionalServices = new Label
            {
                Text = "Additional Services:",
                Location = new Point(10, currentY),
                Font = new Font(Font, FontStyle.Bold),
                AutoSize = true
            };
            washEntryPanel.Controls.Add(lblAdditionalServices);

            int serviceShareY = washEntryPanel.Height - 160;
            
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
                TextAlign = HorizontalAlignment.Right
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
                TextAlign = HorizontalAlignment.Right
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
                TextAlign = HorizontalAlignment.Right
            };
            washEntryPanel.Controls.Add(txtServiceEmpShare);

            // --- Is Paid Checkbox ---
            chkIsPaid = new CheckBox
            {
                Text = "Paid by Employee",
                Location = new Point(10, washEntryPanel.Height - 120),
                AutoSize = true
            };
            washEntryPanel.Controls.Add(chkIsPaid);

            // --- Wash Status Checkbox ---
            chkWashStatus = new CheckBox
            {
                Text = "Mark as Completed", // Unchecked = Ongoing, Checked = Completed
                Location = new Point(10, washEntryPanel.Height - 98),
                AutoSize = true
            };
            washEntryPanel.Controls.Add(chkWashStatus);

            // --- Discount ComboBox ---
            lblDiscount = new Label
            {
                Text = "Discount:",
                Location = new Point(160, washEntryPanel.Height - 120),
                AutoSize = true
            };
            washEntryPanel.Controls.Add(lblDiscount);

            cmbDiscount = new ComboBox
            {
                Location = new Point(220, washEntryPanel.Height - 123),
                Size = new Size(60, 23),
                DropDownStyle = ComboBoxStyle.DropDownList,
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
                Location = new Point(10, washEntryPanel.Height - 60),
                Font = new Font(Font, FontStyle.Bold),
                AutoSize = true
            };
            washEntryPanel.Controls.Add(lblTotalAmount);

            txtTotalAmount = new TextBox
            {
                Location = new Point(110, washEntryPanel.Height - 63),
                Size = new Size(170, 23),
                ReadOnly = true, // Total amount is auto-calculated
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = HorizontalAlignment.Right
            };
            washEntryPanel.Controls.Add(txtTotalAmount);

            // --- Add Transaction Button ---
            btnAddTransaction = new Button
            {
                Text = "Add Entry",
                Location = new Point(10, washEntryPanel.Height - 35),
                Size = new Size(270, 25),
            };
            btnAddTransaction.Click += btnAddTransaction_Click;
            washEntryPanel.Controls.Add(btnAddTransaction);

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

        // Method to load the vehicle types in the dropdown combo box.
        private void LoadVehicleComboBox()
        {
            // ComboBox configuration
            cmbVehicleType.DataSource = vehicleTypes;
            cmbVehicleType.DisplayMember = "Type";
            cmbVehicleType.ValueMember = "Type";
            cmbVehicleType.SelectedIndex = -1; // Start with no selection.

        }

        // Method to load the service controls.
        private void LoadServiceControls()
        {
            int currentY = 180;

            foreach(Control c in serviceControls)
            {
                washEntryPanel.Controls.Remove(c);
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
                washEntryPanel.Controls.Add(chk);
                serviceControls.Add(chk);

                // Create the Textbox
                TextBox txt = new TextBox();
                txt.Location = new Point(190, currentY - 3);
                txt.Size = new Size(80, 23);
                txt.Enabled = false;
                txt.Tag = service; // Store the service object in the tag.
                washEntryPanel.Controls.Add(txt);
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
                // TODO: Refresh the Today's Entries panel (in a later step)
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
  
            base.OnFormClosed(e);
        }
    }
}
