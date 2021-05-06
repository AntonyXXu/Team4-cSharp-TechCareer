
namespace Travel
{
    partial class formAddPackage
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
            this.lblPkgID = new System.Windows.Forms.Label();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.lblPkgStartDate = new System.Windows.Forms.Label();
            this.lblPkgEndDate = new System.Windows.Forms.Label();
            this.lblPkgDesc = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.txtPkgID = new System.Windows.Forms.TextBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.rtxtPkgName = new System.Windows.Forms.RichTextBox();
            this.rtxtDesc = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.mtxtStart = new System.Windows.Forms.MaskedTextBox();
            this.mtxtEnd = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblPkgID
            // 
            this.lblPkgID.AutoSize = true;
            this.lblPkgID.Location = new System.Drawing.Point(37, 33);
            this.lblPkgID.Name = "lblPkgID";
            this.lblPkgID.Size = new System.Drawing.Size(65, 15);
            this.lblPkgID.TabIndex = 0;
            this.lblPkgID.Text = "Package ID";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Location = new System.Drawing.Point(37, 73);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(86, 15);
            this.lblPkgName.TabIndex = 0;
            this.lblPkgName.Text = "Package Name";
            // 
            // lblPkgStartDate
            // 
            this.lblPkgStartDate.AutoSize = true;
            this.lblPkgStartDate.Location = new System.Drawing.Point(37, 151);
            this.lblPkgStartDate.Name = "lblPkgStartDate";
            this.lblPkgStartDate.Size = new System.Drawing.Size(139, 15);
            this.lblPkgStartDate.TabIndex = 0;
            this.lblPkgStartDate.Text = "Start Date (yyyy-mm-dd)";
            // 
            // lblPkgEndDate
            // 
            this.lblPkgEndDate.AutoSize = true;
            this.lblPkgEndDate.Location = new System.Drawing.Point(37, 192);
            this.lblPkgEndDate.Name = "lblPkgEndDate";
            this.lblPkgEndDate.Size = new System.Drawing.Size(135, 15);
            this.lblPkgEndDate.TabIndex = 0;
            this.lblPkgEndDate.Text = "End Date (yyyy-mm-dd)";
            // 
            // lblPkgDesc
            // 
            this.lblPkgDesc.AutoSize = true;
            this.lblPkgDesc.Location = new System.Drawing.Point(37, 235);
            this.lblPkgDesc.Name = "lblPkgDesc";
            this.lblPkgDesc.Size = new System.Drawing.Size(67, 15);
            this.lblPkgDesc.TabIndex = 0;
            this.lblPkgDesc.Text = "Description";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(37, 319);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(60, 15);
            this.lblBasePrice.TabIndex = 0;
            this.lblBasePrice.Text = "Base Price";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(37, 364);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(74, 15);
            this.lblCommission.TabIndex = 0;
            this.lblCommission.Text = "Commission";
            // 
            // txtPkgID
            // 
            this.txtPkgID.Location = new System.Drawing.Point(189, 30);
            this.txtPkgID.Name = "txtPkgID";
            this.txtPkgID.ReadOnly = true;
            this.txtPkgID.Size = new System.Drawing.Size(186, 23);
            this.txtPkgID.TabIndex = 1;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(189, 316);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(186, 23);
            this.txtBasePrice.TabIndex = 1;
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(189, 361);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(186, 23);
            this.txtCommission.TabIndex = 1;
            // 
            // rtxtPkgName
            // 
            this.rtxtPkgName.Location = new System.Drawing.Point(189, 73);
            this.rtxtPkgName.MaxLength = 50;
            this.rtxtPkgName.Name = "rtxtPkgName";
            this.rtxtPkgName.Size = new System.Drawing.Size(186, 59);
            this.rtxtPkgName.TabIndex = 2;
            this.rtxtPkgName.Text = "";
            // 
            // rtxtDesc
            // 
            this.rtxtDesc.Location = new System.Drawing.Point(189, 232);
            this.rtxtDesc.MaxLength = 50;
            this.rtxtDesc.Name = "rtxtDesc";
            this.rtxtDesc.Size = new System.Drawing.Size(186, 59);
            this.rtxtDesc.TabIndex = 2;
            this.rtxtDesc.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(189, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(289, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // mtxtStart
            // 
            this.mtxtStart.Location = new System.Drawing.Point(189, 148);
            this.mtxtStart.Mask = "0000/00/00";
            this.mtxtStart.Name = "mtxtStart";
            this.mtxtStart.Size = new System.Drawing.Size(186, 23);
            this.mtxtStart.TabIndex = 4;
            // 
            // mtxtEnd
            // 
            this.mtxtEnd.Location = new System.Drawing.Point(189, 189);
            this.mtxtEnd.Mask = "0000/00/00";
            this.mtxtEnd.Name = "mtxtEnd";
            this.mtxtEnd.Size = new System.Drawing.Size(186, 23);
            this.mtxtEnd.TabIndex = 4;
            // 
            // formAddPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 465);
            this.Controls.Add(this.mtxtEnd);
            this.Controls.Add(this.mtxtStart);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtxtDesc);
            this.Controls.Add(this.rtxtPkgName);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.txtPkgID);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.lblPkgDesc);
            this.Controls.Add(this.lblPkgEndDate);
            this.Controls.Add(this.lblPkgStartDate);
            this.Controls.Add(this.lblPkgName);
            this.Controls.Add(this.lblPkgID);
            this.Name = "formAddPackage";
            this.Text = "Add New Package";
            this.Load += new System.EventHandler(this.formAddPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPkgID;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.Label lblPkgStartDate;
        private System.Windows.Forms.Label lblPkgEndDate;
        private System.Windows.Forms.Label lblPkgDesc;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.TextBox txtPkgID;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.RichTextBox rtxtPkgName;
        private System.Windows.Forms.RichTextBox rtxtDesc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox mtxtStart;
        private System.Windows.Forms.MaskedTextBox mtxtEnd;
    }
}