using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DBModels.Models;

namespace Travel
{
    public partial class EditProductSupplier : Form
    {

        private TravelExpertsContext context;
        private bool add;
        ProductsSupplier currProdSupp;
        public EditProductSupplier(bool added, ProductsSupplier current, TravelExpertsContext ctx)
        {
            InitializeComponent();
            context = ctx;
            add = added;
            currProdSupp = current;
            if (add)
            {
                this.Text = "Add New Product and Supplier Link";
            }
        }

        private void EditProductSupplier_Load(object sender, EventArgs e)
        {
            comboProduct.DisplayMember = "ProdName";
            comboProduct.ValueMember = "ProductID";
            comboProduct.DataSource = context.Products.ToList();
            comboSupplier.DisplayMember = "ProdName";
            comboSupplier.ValueMember = "ProductID";
            comboSupplier.DataSource = context.Products.ToList();
            if (add)
            {
                comboProduct.SelectedIndex = 0;
            }
            else
            {
                comboProduct.SelectedItem = currProdSupp.ProductId;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            this.Close();
        }


    }
}
