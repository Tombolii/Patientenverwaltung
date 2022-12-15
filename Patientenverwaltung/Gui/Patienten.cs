using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientenverwaltungOberfläche
{
    public partial class Patienten : Form
    {
        private Button button1;

        public Patienten()
        {
            InitializeComponent();
        }

        private void btn_PatientHinzufuegen_Click(object sender, EventArgs e)
        {
            this.Hide();
            NeuerPatient addPatient = new NeuerPatient();
            addPatient.Show();
        }

        private void btn_Startseite_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ärzteseite aerzteSeite = new Ärzteseite();
            aerzteSeite.Show();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Patienten
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button1);
            this.Name = "Patienten";
            this.ResumeLayout(false);

        }
    }
}
