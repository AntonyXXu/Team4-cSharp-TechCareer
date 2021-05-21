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
using System.Configuration;


namespace Travel
{
    public partial class formSupplierProducts : Form
    {

        TravelExpertsContext context;

        public formSupplierProducts(TravelExpertsContext ctx)
        {
            InitializeComponent();
            context = ctx;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsFrm newForm = new ProductsFrm(context);
            newForm.ShowDialog();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SuppliersFrm newForm = new SuppliersFrm(context);
            newForm.ShowDialog();
        }

        private void formSupplierProducts_Load(object sender, EventArgs e)
        {
            display();
        }

        private void display()
        {
            //List<int> prodSupplierIDs = current.PackagesProductsSuppliers
            //   .Select(productPkg => productPkg.ProductSupplierId).ToList();

            List<ProductsSupplier> productsSuppliers = context.ProductsSuppliers.ToList();

            var prodSuppList = (from prodSupp in context.ProductsSuppliers.ToList()
                                join product in context.Products
                                    on prodSupp.ProductId equals product.ProductId
                                join supplier in context.Suppliers
                                    on prodSupp.SupplierId equals supplier.SupplierId
                                select new
                                {
                                    ProductSupplierID = prodSupp.ProductSupplierId,
                                    ProdName = product.ProdName,
                                    SupName = supplier.SupName
                                }
                                ).ToList();

            dataGVProdSupp.DataSource = prodSuppList;
            try
            {
                dataGVProdSupp.Rows[0].Selected = true;
            }
            catch
            {
                btnEditProdSupp.Enabled = false;
            }
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProdSupp_Click(object sender, EventArgs e)
        {

        }
    }
}
