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
    public partial class Form1 : Form
    {

        TravelExpertsContext context;

        public Form1()
        {
            InitializeComponent();
            context = new TravelExpertsContext();
            TravelExpertsContext.connectString =
                ConfigurationManager.ConnectionStrings["TravelExperts"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            return;
        }
    }
}
