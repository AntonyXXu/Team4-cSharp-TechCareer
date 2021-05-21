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
    public partial class formAddSupplier : Form
    {
        public Supplier p { get; set; }
        public bool AddProduct { get; set; }


        public formAddSupplier()
        {
            InitializeComponent();
        }



        private void acceptBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void formAddSupplier_Load(object sender, EventArgs e)
        {

            if (AddProduct)
            {
                this.Text = "Add product";
                productIdtxt.ReadOnly = true; // allow entry of new product code

            }
            else
            {
                this.Text = " Edit Product";
                productIdtxt.ReadOnly = true; // do not aloow to change  new product code
                this.DisplayProduct();
            }

        }
    }
}
