using System.Drawing;
using System.Windows.Forms;

namespace CarWashManagement.UI
{
    partial class ServiceManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceManagementForm));
            this.lsvServices = new System.Windows.Forms.ListView();
            this.columnServiceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPricingType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMultiplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPricingType = new System.Windows.Forms.Label();
            this.cmbPricingType = new System.Windows.Forms.ComboBox();
            this.lblFee = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvServices
            // 
            this.lsvServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnServiceName,
            this.columnPricingType,
            this.columnFee,
            this.columnMultiplier});
            this.lsvServices.FullRowSelect = true;
            this.lsvServices.GridLines = true;
            this.lsvServices.HideSelection = false;
            this.lsvServices.Location = new System.Drawing.Point(18, 17);
            this.lsvServices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lsvServices.Name = "lsvServices";
            this.lsvServices.Size = new System.Drawing.Size(641, 230);
            this.lsvServices.TabIndex = 0;
            this.lsvServices.UseCompatibleStateImageBehavior = false;
            this.lsvServices.View = System.Windows.Forms.View.Details;
            this.lsvServices.SelectedIndexChanged += new System.EventHandler(this.lsvServices_SelectedIndexChanged);
            // 
            // columnServiceName
            // 
            this.columnServiceName.Text = "Service Name";
            this.columnServiceName.Width = 150;
            // 
            // columnPricingType
            // 
            this.columnPricingType.Text = "Pricing Type";
            this.columnPricingType.Width = 140;
            // 
            // columnFee
            // 
            this.columnFee.Text = "Fee";
            this.columnFee.Width = 120;
            // 
            // columnMultiplier
            // 
            this.columnMultiplier.Text = "Multiplier";
            this.columnMultiplier.Width = 120;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 277);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Loại dịch vụ:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 273);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblPricingType
            // 
            this.lblPricingType.AutoSize = true;
            this.lblPricingType.Location = new System.Drawing.Point(18, 317);
            this.lblPricingType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPricingType.Name = "lblPricingType";
            this.lblPricingType.Size = new System.Drawing.Size(67, 15);
            this.lblPricingType.TabIndex = 3;
            this.lblPricingType.Text = "Kiểu giá cả:";
            // 
            // cmbPricingType
            // 
            this.cmbPricingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPricingType.FormattingEnabled = true;
            this.cmbPricingType.Location = new System.Drawing.Point(140, 314);
            this.cmbPricingType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbPricingType.Name = "cmbPricingType";
            this.cmbPricingType.Size = new System.Drawing.Size(174, 23);
            this.cmbPricingType.TabIndex = 2;
            this.cmbPricingType.SelectedIndexChanged += new System.EventHandler(this.cmbPricingType_SelectedIndexChanged);
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(18, 358);
            this.lblFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(27, 15);
            this.lblFee.TabIndex = 5;
            this.lblFee.Text = "Phí:";
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(140, 354);
            this.txtFee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(174, 23);
            this.txtFee.TabIndex = 3;
            this.txtFee.Text = "0.00";
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Location = new System.Drawing.Point(18, 398);
            this.lblMultiplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(70, 15);
            this.lblMultiplier.TabIndex = 7;
            this.lblMultiplier.Text = "Hệ số nhân:";
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Location = new System.Drawing.Point(140, 395);
            this.txtMultiplier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(174, 23);
            this.txtMultiplier.TabIndex = 4;
            this.txtMultiplier.Text = "1";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(350, 273);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(507, 273);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 35);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Cập nhật mục được chọn";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(507, 366);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 35);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa mục được chọn";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(350, 320);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 35);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Xóa bảng";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ServiceManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 474);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMultiplier);
            this.Controls.Add(this.lblMultiplier);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.cmbPricingType);
            this.Controls.Add(this.lblPricingType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lsvServices);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ServiceManagementForm";
            this.Text = "Service Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lsvServices;
        private ColumnHeader columnServiceName;
        private ColumnHeader columnPricingType;
        private ColumnHeader columnFee;
        private ColumnHeader columnMultiplier;
        private Label lblName;
        private TextBox txtName;
        private Label lblPricingType;
        private ComboBox cmbPricingType;
        private Label lblFee;
        private TextBox txtFee;
        private Label lblMultiplier;
        private TextBox txtMultiplier;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}