using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using DBModels.Models;
using System.Windows.Forms;

namespace Travel
{
    public partial class formEditPackageProducts : Form
    {
        
        public formEditPackageProducts(Package curr, TravelExpertsContext con )
        {
            InitializeComponent();
            current = curr;
            context = con;
        }
        private Package current;
        private TravelExpertsContext context;

        private void formEditPackageProducts_Load(object sender, EventArgs e)
        {
            lblPackageNameVal.Text = current.PkgName;
            comboProduct.DataSource = context.Products.ToList();
            comboProduct.DisplayMember = "ProdName";
            comboProduct.ValueMember = "ProductID";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSupplier.DataSource = context.ProductsSuppliers
                .Where( supp => supp.ProductId == Convert.ToInt32(comboProduct.ValueMember))
        }
    }
}
