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

        public formEditPackageProducts(Package curr, TravelExpertsContext con)
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
            comboProduct.DisplayMember = "ProdName";
            comboProduct.ValueMember = "ProductID";
            comboProduct.DataSource = context.Products.ToList();
            display();
        }

        private void display()
        {
            List<int> prodSupplierIDs = current.PackagesProductsSuppliers
                .Select(productPkg => productPkg.ProductSupplierId).ToList();

            List<ProductsSupplier> prodSuppliers = context.ProductsSuppliers
                .Where(prodSupplier => prodSupplierIDs
                    .Any(prodSupplierID => prodSupplierID == prodSupplier.ProductSupplierId)
                    ).ToList();

            var packageProdSupp = (from prodSupplier in prodSuppliers
                                   join product in context.Products
                                       on prodSupplier.ProductId equals product.ProductId
                                   join supplier in context.Suppliers
                                       on prodSupplier.SupplierId equals supplier.SupplierId
                                   select new
                                   {
                                       pName = product.ProdName,
                                       sName = supplier.SupName,
                                       psID = prodSupplier.ProductSupplierId
                                   }).ToList();

            dataGVPackageSuppProdList.DataSource = packageProdSupp;
            try
            {
                dataGVPackageSuppProdList.Rows[0].Selected = true;
            }
            catch
            {
                btnDeleteSelected.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prod = comboProduct.SelectedValue;

            Product currProd = context.Products.Find(prod);

            List<int> productSupplierID = currProd.ProductsSuppliers
               .Select(product => product.ProductSupplierId).ToList();

            var supplierData = (from ProductsSupplier in currProd.ProductsSuppliers
                                join supplier in context.Suppliers
                                    on ProductsSupplier.SupplierId equals supplier.SupplierId
                                select new
                                {
                                    sName = supplier.SupName,
                                    psID = ProductsSupplier.ProductSupplierId
                                }).ToList();
            dataGVSuppliers.DataSource = supplierData;
            try
            {
                dataGVSuppliers.Rows[0].Selected = true;
            }
            catch
            {
                btnAddProduct.Enabled = false;
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            PackagesProductsSupplier del = getSelected();
            context.PackagesProductsSuppliers.Remove(del);
            context.SaveChanges();
            display();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int selection = Convert.ToInt32(dataGVSuppliers.CurrentRow.Cells[1].FormattedValue);
            PackagesProductsSupplier add = new PackagesProductsSupplier();
            add.PackageId = current.PackageId;
            add.ProductSupplierId = selection;
            try
            {
                if (context.PackagesProductsSuppliers.Contains(add))
                {
                    MessageBox.Show("This product already exists within this package");
                    return;
                }
                
                context.PackagesProductsSuppliers.Add(add);
                context.SaveChanges();
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update: " + ex.Message,
                   ex.GetType().ToString());
                return;
            }

        }
        private PackagesProductsSupplier getSelected()
        {
            int selection = Convert.ToInt32(dataGVPackageSuppProdList.CurrentRow.Cells[2].FormattedValue);
            return context.PackagesProductsSuppliers.Find(current.PackageId, selection);
        }

    }
}
