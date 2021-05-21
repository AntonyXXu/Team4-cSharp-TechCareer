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
