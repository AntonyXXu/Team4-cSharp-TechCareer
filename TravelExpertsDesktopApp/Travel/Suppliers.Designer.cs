﻿
namespace Travel
{
    partial class SuppliersInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.supplierGrid = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.supplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierGrid
            // 
            this.supplierGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierID,
            this.supplierName});
            this.supplierGrid.Location = new System.Drawing.Point(29, 34);
            this.supplierGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supplierGrid.Name = "supplierGrid";
            this.supplierGrid.RowHeadersWidth = 51;
            this.supplierGrid.Size = new System.Drawing.Size(508, 252);
            this.supplierGrid.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(29, 336);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(82, 22);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "&Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(144, 336);
            this.modifyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(82, 22);
            this.modifyBtn.TabIndex = 2;
            this.modifyBtn.Text = "&Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(454, 336);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(82, 22);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // supplierID
            // 
            this.supplierID.DataPropertyName = "SupplierId";
            this.supplierID.HeaderText = "Supplier ID";
            this.supplierID.MinimumWidth = 6;
            this.supplierID.Name = "supplierID";
            this.supplierID.ReadOnly = true;
            this.supplierID.Width = 200;
            // 
            // supplierName
            // 
            this.supplierName.DataPropertyName = "SupName";
            this.supplierName.HeaderText = "Supplier Name";
            this.supplierName.MinimumWidth = 6;
            this.supplierName.Name = "supplierName";
            this.supplierName.Width = 250;
            // 
            // SuppliersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 390);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.supplierGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SuppliersInfo";
            this.Text = "Suppliers Info";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView supplierGrid;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierName;
    }
}

