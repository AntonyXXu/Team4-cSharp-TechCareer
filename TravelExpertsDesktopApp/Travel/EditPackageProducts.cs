﻿using System;
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
            comboProduct.DataSource = context.Products.ToList();
            comboProduct.DisplayMember = "ProdName";
            comboProduct.ValueMember = "ProductID";
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
                                        join product in context.Products.ToList()
                                           on prodSupplier.ProductId equals product.ProductId
                                        join supplier in context.Suppliers.ToList()
                                            on prodSupplier.SupplierId equals supplier.SupplierId
                                        select new { pName = product.ProdName, 
                                                sName = supplier.SupName,
                                                psID = prodSupplier.ProductSupplierId}).ToList();

            dataGridView1.DataSource = packageProdSupp;                     
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSupplier.DataSource = context.ProductsSuppliers
                .Where(supp => supp.ProductId == Convert.ToInt32(comboProduct.ValueMember));

        }
    }
}