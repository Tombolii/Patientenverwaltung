using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patientenverwaltung.Datenbank;

namespace Patientenverwaltung
{
    public partial class Form1 : Form
    {

        MySQLConnector mySqlConnector;

        public Form1()
        {
            InitializeComponent();
            mySqlConnector = new MySQLConnector("patientenverwaltung");
            mySqlConnector.DBUser = "Arzt";
            mySqlConnector.DBPassword = "";
            mySqlConnector.DBHost = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = mySqlConnector.TestConnection();
        }
    }
}
