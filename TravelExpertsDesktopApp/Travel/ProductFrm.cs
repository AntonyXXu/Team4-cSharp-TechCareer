using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBModels.Models;

namespace Travel
{
    public partial class ProductFrm : Form
    {
        TravelExpertsContext context = new TravelExpertsContext();
        Product product;

        public ProductFrm()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            supplierGridView();
        }

        private void supplierGridView()
        {
            context = new TravelExpertsContext();
            supplierGrid.AutoGenerateColumns = false;
            supplierGrid.DataSource = context.Suppliers.ToList();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
