using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DBModels.Models;

namespace Travel
{
    public partial class SuppliersAddNew : Form
    {
        TravelExpertsContext context = new TravelExpertsContext();
        public SupplierContact newContact { get; set; }
        public SuppliersAddNew()
        {
            InitializeComponent();
        }

        private void SuppliersAddNew_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            SupConFirstName_txt.Text = newContact.SupConFirstName;
            SupConLastName_txt.Text = newContact.SupConLastName;
            SupConCompany_txt.Text = newContact.SupConCompany;
            SupConAddress_txt.Text = newContact.SupConAddress;
            SupConCity_txt.Text = newContact.SupConCity;
            SupConProv_txt.Text = newContact.SupConProv;
            SupConPostal_txt.Text = newContact.SupConPostal;
            SupConCountry_txt.Text = newContact.SupConCountry;
            SupConBusPhone_txt.Text = newContact.SupConBusPhone;
            SupConFax_txt.Text = newContact.SupConFax;
            SupConEmails_txt.Text = newContact.SupConEmail;
            SupConUrl_txt.Text = newContact.SupConUrl;
        }

        private void addNewSup_btn_Click(object sender, EventArgs e)
        {
            newContact.SupConFirstName = SupConFirstName_txt.Text;
            newContact.SupConLastName = SupConLastName_txt.Text;
            newContact.SupConCompany = SupConCompany_txt.Text;
            newContact.SupConAddress = SupConAddress_txt.Text;
            newContact.SupConCity = SupConCity_txt.Text;
            newContact.SupConProv = SupConProv_txt.Text;
            newContact.SupConPostal = SupConPostal_txt.Text;
            newContact.SupConCountry = SupConCountry_txt.Text;
            newContact.SupConBusPhone = SupConBusPhone_txt.Text;
            newContact.SupConFax = SupConFax_txt.Text;
            newContact.SupConEmail = SupConEmails_txt.Text;
            newContact.SupConUrl = SupConUrl_txt.Text;
            DialogResult = DialogResult.OK;
        }

        private void cancelNewSup_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
