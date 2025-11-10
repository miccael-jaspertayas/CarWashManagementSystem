using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashManagement.UI
{
    partial class VehicleManagementForm
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
        /// 
        private void InitializeComponent()
        {
            this.lsvVehicles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblBaseFee = new System.Windows.Forms.Label();
            this.txtBaseFee = new System.Windows.Forms.TextBox();
            this.lblOwnerShare = new System.Windows.Forms.Label();
            this.txtOwnerShare = new System.Windows.Forms.TextBox();
            this.lblEmployeeShare = new System.Windows.Forms.Label();
            this.txtEmployeeShare = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvVehicles
            // 
            this.lsvVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvVehicles.FullRowSelect = true;
            this.lsvVehicles.GridLines = true;
            this.lsvVehicles.HideSelection = false;
            this.lsvVehicles.Location = new System.Drawing.Point(15, 15);
            this.lsvVehicles.Name = "lsvVehicles";
            this.lsvVehicles.Size = new System.Drawing.Size(550, 200);
            this.lsvVehicles.TabIndex = 0;
            this.lsvVehicles.UseCompatibleStateImageBehavior = false;
            this.lsvVehicles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Vehicle Type";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Base Fee";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Owner Share";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Employee Share";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 120;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 243);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(72, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Vehicle Type:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(120, 240);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(150, 20);
            this.txtType.TabIndex = 2;
            // 
            // lblBaseFee
            // 
            this.lblBaseFee.AutoSize = true;
            this.lblBaseFee.Location = new System.Drawing.Point(12, 278);
            this.lblBaseFee.Name = "lblBaseFee";
            this.lblBaseFee.Size = new System.Drawing.Size(55, 13);
            this.lblBaseFee.TabIndex = 3;
            this.lblBaseFee.Text = "Base Fee:";
            // 
            // txtBaseFee
            // 
            this.txtBaseFee.Location = new System.Drawing.Point(120, 275);
            this.txtBaseFee.Name = "txtBaseFee";
            this.txtBaseFee.Size = new System.Drawing.Size(150, 20);
            this.txtBaseFee.TabIndex = 4;
            // 
            // lblOwnerShare
            // 
            this.lblOwnerShare.AutoSize = true;
            this.lblOwnerShare.Location = new System.Drawing.Point(12, 313);
            this.lblOwnerShare.Name = "lblOwnerShare";
            this.lblOwnerShare.Size = new System.Drawing.Size(72, 13);
            this.lblOwnerShare.TabIndex = 5;
            this.lblOwnerShare.Text = "Owner Share:";
            // 
            // txtOwnerShare
            // 
            this.txtOwnerShare.Location = new System.Drawing.Point(120, 310);
            this.txtOwnerShare.Name = "txtOwnerShare";
            this.txtOwnerShare.Size = new System.Drawing.Size(150, 20);
            this.txtOwnerShare.TabIndex = 6;
            // 
            // lblEmployeeShare
            // 
            this.lblEmployeeShare.AutoSize = true;
            this.lblEmployeeShare.Location = new System.Drawing.Point(12, 348);
            this.lblEmployeeShare.Name = "lblEmployeeShare";
            this.lblEmployeeShare.Size = new System.Drawing.Size(88, 13);
            this.lblEmployeeShare.TabIndex = 7;
            this.lblEmployeeShare.Text = "Employee Share:";
            // 
            // txtEmployeeShare
            // 
            this.txtEmployeeShare.Location = new System.Drawing.Point(120, 345);
            this.txtEmployeeShare.Name = "txtEmployeeShare";
            this.txtEmployeeShare.Size = new System.Drawing.Size(150, 20);
            this.txtEmployeeShare.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(300, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(435, 238);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 30);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update Selected";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(435, 318);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 30);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(300, 278);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 30);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // VehicleManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEmployeeShare);
            this.Controls.Add(this.lblEmployeeShare);
            this.Controls.Add(this.txtOwnerShare);
            this.Controls.Add(this.lblOwnerShare);
            this.Controls.Add(this.txtBaseFee);
            this.Controls.Add(this.lblBaseFee);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lsvVehicles);
            this.Name = "VehicleManagementForm";
            this.Text = "Vehicle Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvVehicles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblBaseFee;
        private System.Windows.Forms.TextBox txtBaseFee;
        private System.Windows.Forms.Label lblOwnerShare;
        private System.Windows.Forms.TextBox txtOwnerShare;
        private System.Windows.Forms.Label lblEmployeeShare;
        private System.Windows.Forms.TextBox txtEmployeeShare;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}
