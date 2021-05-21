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
        TravelExpertsContext context = new TravelExpertsContext();
        SupplierContact newContact;
        public SuppliersInfo()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            supplierGridView();
        }

        //private void supplierGrid
        private void supplierGridView()
        {
            context = new TravelExpertsContext();
            supplierGrid.AutoGenerateColumns = false;
            supplierGrid.DataSource = context.Suppliers.ToList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            newContact = new SupplierContact();
            SuppliersAddNew addNewContact = new SuppliersAddNew()
            {
                newContact = newContact
            };
            var r = addNewContact.ShowDialog();
            if (r == DialogResult.OK)
            {
                newContact = addNewContact.newContact;
                context.SupplierContacts.Add(newContact);
                context.SaveChanges();
                supplierGridView();
            }
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
