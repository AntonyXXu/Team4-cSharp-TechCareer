
namespace Travel
{
    partial class formEditPackageProducts
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPackageNameVal = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGVPackageSuppProdList = new System.Windows.Forms.DataGridView();
            this.pkgSupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboProduct = new System.Windows.Forms.ComboBox();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.dataGVSuppliers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPackageSuppProdList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(440, 61);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(49, 15);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product";
            // 
            // lblPackageNameVal
            // 
            this.lblPackageNameVal.AutoSize = true;
            this.lblPackageNameVal.Location = new System.Drawing.Point(156, 24);
            this.lblPackageNameVal.Name = "lblPackageNameVal";
            this.lblPackageNameVal.Size = new System.Drawing.Size(0, 15);
            this.lblPackageNameVal.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(604, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 49);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGVPackageSuppProdList
            // 
            this.dataGVPackageSuppProdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVPackageSuppProdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkgSupID,
            this.colSupplier,
            this.colProduct});
            this.dataGVPackageSuppProdList.Location = new System.Drawing.Point(26, 62);
            this.dataGVPackageSuppProdList.MultiSelect = false;
            this.dataGVPackageSuppProdList.Name = "dataGVPackageSuppProdList";
            this.dataGVPackageSuppProdList.RowTemplate.Height = 25;
            this.dataGVPackageSuppProdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVPackageSuppProdList.Size = new System.Drawing.Size(393, 388);
            this.dataGVPackageSuppProdList.TabIndex = 3;
            // 
            // pkgSupID
            // 
            this.pkgSupID.DataPropertyName = "psID";
            this.pkgSupID.HeaderText = "ID";
            this.pkgSupID.Name = "pkgSupID";
            this.pkgSupID.ReadOnly = true;
            this.pkgSupID.Width = 50;
            // 
            // colSupplier
            // 
            this.colSupplier.DataPropertyName = "sName";
            this.colSupplier.HeaderText = "Supplier";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.ReadOnly = true;
            this.colSupplier.Width = 150;
            // 
            // colProduct
            // 
            this.colProduct.DataPropertyName = "pName";
            this.colProduct.HeaderText = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            this.colProduct.Width = 150;
            // 
            // comboProduct
            // 
            this.comboProduct.FormattingEnabled = true;
            this.comboProduct.Location = new System.Drawing.Point(440, 79);
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(259, 23);
            this.comboProduct.TabIndex = 4;
            this.comboProduct.SelectedIndexChanged += new System.EventHandler(this.comboProduct_SelectedIndexChanged);
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Location = new System.Drawing.Point(26, 24);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(86, 15);
            this.lblPackageName.TabIndex = 0;
            this.lblPackageName.Text = "Package Name";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(440, 151);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(50, 15);
            this.lblSupplierName.TabIndex = 0;
            this.lblSupplierName.Text = "Supplier";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(440, 401);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(64, 49);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(523, 401);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(64, 49);
            this.btnDeleteSelected.TabIndex = 2;
            this.btnDeleteSelected.Text = "Delete";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // dataGVSuppliers
            // 
            this.dataGVSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVSuppliers.Location = new System.Drawing.Point(440, 170);
            this.dataGVSuppliers.Name = "dataGVSuppliers";
            this.dataGVSuppliers.RowTemplate.Height = 25;
            this.dataGVSuppliers.Size = new System.Drawing.Size(259, 202);
            this.dataGVSuppliers.TabIndex = 5;
            // 
            // formEditPackageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 491);
            this.Controls.Add(this.dataGVSuppliers);
            this.Controls.Add(this.comboProduct);
            this.Controls.Add(this.dataGVPackageSuppProdList);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPackageNameVal);
            this.Controls.Add(this.lblPackageName);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblProductName);
            this.Name = "formEditPackageProducts";
            this.Text = "Add Products to the selected package";
            this.Load += new System.EventHandler(this.formEditPackageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPackageSuppProdList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPackageNameVal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGVPackageSuppProdList;
        private System.Windows.Forms.ComboBox comboProduct;
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgSupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridView dataGVSuppliers;
    }
}