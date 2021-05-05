using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            lblProductNameVal.Text = current.PkgName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
