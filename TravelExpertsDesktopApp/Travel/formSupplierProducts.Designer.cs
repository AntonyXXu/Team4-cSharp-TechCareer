
namespace Travel
{
    partial class formSupplierProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.dataGVProdSupp = new System.Windows.Forms.DataGridView();
            this.btnEditProdSupp = new System.Windows.Forms.Button();
            this.ProductSupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVProdSupp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(645, 380);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 57);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Location = new System.Drawing.Point(307, 380);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(136, 57);
            this.btnAddProducts.TabIndex = 9;
            this.btnAddProducts.Text = "Add Product Supplier";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(173, 380);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(114, 57);
            this.btnSuppliers.TabIndex = 10;
            this.btnSuppliers.Text = "View/Edit List of Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(28, 380);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(121, 57);
            this.btnProducts.TabIndex = 11;
            this.btnProducts.Text = "View/Edit List of Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // dataGVProdSupp
            // 
            this.dataGVProdSupp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGVProdSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVProdSupp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductSupplierID,
            this.ProductName,
            this.SupplierName});
            this.dataGVProdSupp.Location = new System.Drawing.Point(28, 26);
            this.dataGVProdSupp.MultiSelect = false;
            this.dataGVProdSupp.Name = "dataGVProdSupp";
            this.dataGVProdSupp.RowTemplate.Height = 25;
            this.dataGVProdSupp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVProdSupp.Size = new System.Drawing.Size(726, 317);
            this.dataGVProdSupp.TabIndex = 6;
            // 
            // btnEditProdSupp
            // 
            this.btnEditProdSupp.Location = new System.Drawing.Point(468, 380);
            this.btnEditProdSupp.Name = "btnEditProdSupp";
            this.btnEditProdSupp.Size = new System.Drawing.Size(147, 57);
            this.btnEditProdSupp.TabIndex = 10;
            this.btnEditProdSupp.Text = "Edit Product Suppliers";
            this.btnEditProdSupp.UseVisualStyleBackColor = true;
            this.btnEditProdSupp.Click += new System.EventHandler(this.btnEditProdSupp_Click);
            // 
            // ProductSupplierID
            // 
            this.ProductSupplierID.DataPropertyName = "ProductSupplierID";
            this.ProductSupplierID.HeaderText = "ID";
            this.ProductSupplierID.Name = "ProductSupplierID";
            this.ProductSupplierID.ReadOnly = true;
            this.ProductSupplierID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductSupplierID.Width = 80;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProdName";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductName.HeaderText = "Product";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductName.Width = 275;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupName";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.SupplierName.DefaultCellStyle = dataGridViewCellStyle4;
            this.SupplierName.HeaderText = "Supplier";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SupplierName.Width = 275;
            // 
            // formSupplierProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.btnEditProdSupp);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.dataGVProdSupp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formSupplierProducts";
            this.Text = "Products and Suppliers";
            this.Load += new System.EventHandler(this.formSupplierProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVProdSupp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.DataGridView dataGVProdSupp;
        private System.Windows.Forms.Button btnEditProdSupp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
    }
}

