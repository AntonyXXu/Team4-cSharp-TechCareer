
namespace Travel
{
    partial class ProductFrm
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
            this.modifyBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.supplierGrid = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(450, 326);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(82, 22);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(140, 326);
            this.modifyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(82, 22);
            this.modifyBtn.TabIndex = 7;
            this.modifyBtn.Text = "&Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(25, 326);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(82, 22);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "&Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // supplierGrid
            // 
            this.supplierGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProdName});
            this.supplierGrid.Location = new System.Drawing.Point(25, 24);
            this.supplierGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supplierGrid.Name = "supplierGrid";
            this.supplierGrid.RowHeadersWidth = 51;
            this.supplierGrid.Size = new System.Drawing.Size(508, 252);
            this.supplierGrid.TabIndex = 5;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 200;
            // 
            // ProdName
            // 
            this.ProdName.DataPropertyName = "ProdName";
            this.ProdName.HeaderText = "Product Name";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            this.ProdName.Width = 250;
            // 
            // ProductFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 390);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.supplierGrid);
            this.Name = "ProductFrm";
            this.Text = "ProductFrm";
            ((System.ComponentModel.ISupportInitialize)(this.supplierGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView supplierGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
    }
}