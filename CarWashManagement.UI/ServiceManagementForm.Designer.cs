using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.lsvServices = new System.Windows.Forms.ListView();
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
            this.lsvServices.FullRowSelect = true;
            this.lsvServices.GridLines = true;
            this.lsvServices.Location = new System.Drawing.Point(15, 15);
            this.lsvServices.Name = "lsvServices";
            this.lsvServices.Size = new System.Drawing.Size(550, 200);
            this.lsvServices.TabIndex = 0;
            this.lsvServices.UseCompatibleStateImageBehavior = false;
            this.lsvServices.View = System.Windows.Forms.View.Details;
            this.lsvServices.Columns.Add("Service Name", 150);
            this.lsvServices.Columns.Add("Pricing Type", 140);
            this.lsvServices.Columns.Add("Fee", 120, System.Windows.Forms.HorizontalAlignment.Right);
            this.lsvServices.Columns.Add("Multiplier", 120, System.Windows.Forms.HorizontalAlignment.Right);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 240);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Service Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 237);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 23);
            this.txtName.TabIndex = 2;
            // 
            // lblPricingType
            // 
            this.lblPricingType.AutoSize = true;
            this.lblPricingType.Location = new System.Drawing.Point(15, 275);
            this.lblPricingType.Name = "lblPricingType";
            this.lblPricingType.Size = new System.Drawing.Size(75, 15);
            this.lblPricingType.TabIndex = 3;
            this.lblPricingType.Text = "Pricing Type:";
            // 
            // cmbPricingType
            // 
            this.cmbPricingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPricingType.FormattingEnabled = true;
            this.cmbPricingType.Location = new System.Drawing.Point(120, 272);
            this.cmbPricingType.Name = "cmbPricingType";
            this.cmbPricingType.Size = new System.Drawing.Size(150, 23);
            this.cmbPricingType.TabIndex = 4;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(15, 310);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(28, 15);
            this.lblFee.TabIndex = 5;
            this.lblFee.Text = "Fee:";
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(120, 307);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(150, 23);
            this.txtFee.TabIndex = 6;
            this.txtFee.Text = "0.00";
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Location = new System.Drawing.Point(15, 345);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(63, 15);
            this.lblMultiplier.TabIndex = 7;
            this.lblMultiplier.Text = "Multiplier:";
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Location = new System.Drawing.Point(120, 342);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(150, 23);
            this.txtMultiplier.TabIndex = 8;
            this.txtMultiplier.Text = "1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(300, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(435, 237);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 30);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update Selected";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(435, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 30);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(300, 277);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 30);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // ServiceManagementForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 420);
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
            this.Name = "ServiceManagementForm";
            this.Text = "Service Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView lsvServices;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPricingType;
        private System.Windows.Forms.ComboBox cmbPricingType;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.TextBox txtMultiplier;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}