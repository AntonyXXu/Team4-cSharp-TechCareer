
namespace Travel
{
    partial class frmPackageList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEditPackage = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.dataGVPackages = new System.Windows.Forms.DataGridView();
            this.PackageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgBasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgAgencyCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(767, 342);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 57);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.Location = new System.Drawing.Point(227, 342);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(166, 57);
            this.btnEditPackage.TabIndex = 4;
            this.btnEditPackage.Text = "Edit Package";
            this.btnEditPackage.UseVisualStyleBackColor = true;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(30, 342);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(166, 57);
            this.btnAddPackage.TabIndex = 5;
            this.btnAddPackage.Text = "Add New Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // dataGVPackages
            // 
            this.dataGVPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGVPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVPackages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageID,
            this.PkgName,
            this.PkgStartDate,
            this.PkgEndDate,
            this.PkgDesc,
            this.PkgBasePrice,
            this.PkgAgencyCommission});
            this.dataGVPackages.Location = new System.Drawing.Point(30, 35);
            this.dataGVPackages.MultiSelect = false;
            this.dataGVPackages.Name = "dataGVPackages";
            this.dataGVPackages.RowTemplate.Height = 25;
            this.dataGVPackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVPackages.Size = new System.Drawing.Size(904, 281);
            this.dataGVPackages.TabIndex = 2;
            // 
            // PackageID
            // 
            this.PackageID.DataPropertyName = "PackageID";
            this.PackageID.HeaderText = "PackageID";
            this.PackageID.Name = "PackageID";
            this.PackageID.ReadOnly = true;
            this.PackageID.Width = 80;
            // 
            // PkgName
            // 
            this.PkgName.DataPropertyName = "PkgName";
            this.PkgName.HeaderText = "Name";
            this.PkgName.Name = "PkgName";
            this.PkgName.ReadOnly = true;
            this.PkgName.Width = 160;
            // 
            // PkgStartDate
            // 
            this.PkgStartDate.DataPropertyName = "PkgStartDate";
            this.PkgStartDate.HeaderText = "Start Date";
            this.PkgStartDate.Name = "PkgStartDate";
            this.PkgStartDate.ReadOnly = true;
            // 
            // PkgEndDate
            // 
            this.PkgEndDate.DataPropertyName = "PkgEndDate";
            this.PkgEndDate.HeaderText = "End Date";
            this.PkgEndDate.Name = "PkgEndDate";
            this.PkgEndDate.ReadOnly = true;
            // 
            // PkgDesc
            // 
            this.PkgDesc.DataPropertyName = "PkgDesc";
            this.PkgDesc.HeaderText = "Description";
            this.PkgDesc.Name = "PkgDesc";
            this.PkgDesc.ReadOnly = true;
            this.PkgDesc.Width = 240;
            // 
            // PkgBasePrice
            // 
            this.PkgBasePrice.DataPropertyName = "PkgBasePrice";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.PkgBasePrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.PkgBasePrice.HeaderText = "Base Price";
            this.PkgBasePrice.Name = "PkgBasePrice";
            this.PkgBasePrice.ReadOnly = true;
            // 
            // PkgAgencyCommission
            // 
            this.PkgAgencyCommission.DataPropertyName = "PkgAgencyCommission";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.PkgAgencyCommission.DefaultCellStyle = dataGridViewCellStyle2;
            this.PkgAgencyCommission.HeaderText = "Commission";
            this.PkgAgencyCommission.Name = "PkgAgencyCommission";
            this.PkgAgencyCommission.ReadOnly = true;
            this.PkgAgencyCommission.Width = 80;
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Location = new System.Drawing.Point(425, 342);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(166, 57);
            this.btnAddProducts.TabIndex = 4;
            this.btnAddProducts.Text = "Add/Edit Package Products";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // frmPackageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.btnEditPackage);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.dataGVPackages);
            this.Name = "frmPackageList";
            this.Text = "Package List";
            this.Load += new System.EventHandler(this.frmPackageList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPackages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEditPackage;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.DataGridView dataGVPackages;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgBasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgAgencyCommission;
        private System.Windows.Forms.Button btnAddProducts;
    }
}