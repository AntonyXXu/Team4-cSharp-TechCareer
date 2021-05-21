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
    public partial class SuppliersInfo : Form
    {

        public TravelExpertsContext context { get; set; }
        public Supplier supplier { get; set; }
        public SuppliersInfo()
        {
            InitializeComponent();
            context = new TravelExpertsContext();
        }
        private Supplier getSelected()
        {
            int selection = Convert.ToInt32(supplierGrid.CurrentRow.Cells[0].FormattedValue);
            return context.Suppliers.Find(selection);
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            supplierGridView();
        }

        //private void supplierGrid
        private void supplierGridView()
        {
            supplierGrid.AutoGenerateColumns = false;
            supplierGrid.DataSource = context.Suppliers.ToList();
            supplierGrid.Rows[0].Selected = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            formAddSuppliers newForm = new formAddSuppliers(true, null, context);
            newForm.ShowDialog();
            supplierGridView();

            //newContact = new SupplierContact();
            //SuppliersAddNew addNewContact = new SuppliersAddNew()
            //{
            //    newContact = newContact
            //};
            //var r = addNewContact.ShowDialog();
            //if (r == DialogResult.OK)
            //{
            //    newContact = addNewContact.newContact;
            //    context.SupplierContacts.Add(newContact);
            //    context.SaveChanges();
            //    supplierGridView();
            //}
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            //Supplier current = getSelected();
            //formAddSuppliers newForm = new formAddSuppliers(false, current, context);

            //DialogResult result = newForm.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    supplierGridView();
            //}
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
