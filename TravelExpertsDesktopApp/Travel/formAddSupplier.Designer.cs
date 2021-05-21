
namespace Travel
{
    partial class formAddSupplier
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.SupplierNameLbl = new System.Windows.Forms.Label();
            this.SupplierIdLbl = new System.Windows.Forms.Label();
            this.SupplierNametxt = new System.Windows.Forms.TextBox();
            this.SupplierIdtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.Location = new System.Drawing.Point(257, 153);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 32);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.acceptBtn.Location = new System.Drawing.Point(111, 153);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 32);
            this.acceptBtn.TabIndex = 10;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // SupplierNameLbl
            // 
            this.SupplierNameLbl.AutoSize = true;
            this.SupplierNameLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SupplierNameLbl.Location = new System.Drawing.Point(16, 92);
            this.SupplierNameLbl.Name = "SupplierNameLbl";
            this.SupplierNameLbl.Size = new System.Drawing.Size(89, 15);
            this.SupplierNameLbl.TabIndex = 9;
            this.SupplierNameLbl.Text = "Supplier Name";
            // 
            // SupplierIdLbl
            // 
            this.SupplierIdLbl.AutoSize = true;
            this.SupplierIdLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SupplierIdLbl.Location = new System.Drawing.Point(16, 44);
            this.SupplierIdLbl.Name = "SupplierIdLbl";
            this.SupplierIdLbl.Size = new System.Drawing.Size(69, 15);
            this.SupplierIdLbl.TabIndex = 8;
            this.SupplierIdLbl.Text = "Supplier ID";
            // 
            // SupplierNametxt
            // 
            this.SupplierNametxt.Location = new System.Drawing.Point(108, 89);
            this.SupplierNametxt.MaxLength = 255;
            this.SupplierNametxt.Name = "SupplierNametxt";
            this.SupplierNametxt.Size = new System.Drawing.Size(221, 23);
            this.SupplierNametxt.TabIndex = 7;
            this.SupplierNametxt.Tag = "Product Name";
            // 
            // SupplierIdtxt
            // 
            this.SupplierIdtxt.Location = new System.Drawing.Point(108, 41);
            this.SupplierIdtxt.Name = "SupplierIdtxt";
            this.SupplierIdtxt.ReadOnly = true;
            this.SupplierIdtxt.Size = new System.Drawing.Size(78, 23);
            this.SupplierIdtxt.TabIndex = 6;
            this.SupplierIdtxt.Tag = "Product ID";
            // 
            // formAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 223);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.SupplierNameLbl);
            this.Controls.Add(this.SupplierIdLbl);
            this.Controls.Add(this.SupplierNametxt);
            this.Controls.Add(this.SupplierIdtxt);
            this.Name = "formAddSupplier";
            this.Text = "Add/Edit Supplier";
            this.Load += new System.EventHandler(this.formAddSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Label SupplierNameLbl;
        private System.Windows.Forms.Label SupplierIdLbl;
        private System.Windows.Forms.TextBox SupplierNametxt;
        private System.Windows.Forms.TextBox SupplierIdtxt;
    }
}