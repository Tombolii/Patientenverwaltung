namespace Patientenverwaltung
{
    partial class IntegrationTest
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addPatient = new System.Windows.Forms.Button();
            this.btnPatientBearbeiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "DB-Verbindung testen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // addPatient
            // 
            this.addPatient.Location = new System.Drawing.Point(64, 59);
            this.addPatient.Name = "addPatient";
            this.addPatient.Size = new System.Drawing.Size(182, 42);
            this.addPatient.TabIndex = 2;
            this.addPatient.Text = "Patient anlegen";
            this.addPatient.UseVisualStyleBackColor = true;
            this.addPatient.Click += new System.EventHandler(this.btnPatientErstellen_Click);
            // 
            // btnPatientBearbeiten
            // 
            this.btnPatientBearbeiten.Location = new System.Drawing.Point(64, 131);
            this.btnPatientBearbeiten.Name = "btnPatientBearbeiten";
            this.btnPatientBearbeiten.Size = new System.Drawing.Size(182, 42);
            this.btnPatientBearbeiten.TabIndex = 3;
            this.btnPatientBearbeiten.Text = "Patient bearbeiten";
            this.btnPatientBearbeiten.UseVisualStyleBackColor = true;
            this.btnPatientBearbeiten.Click += new System.EventHandler(this.btnPatientBearbeiten_Click);
            // 
            // Tests
            // 
            this.ClientSize = new System.Drawing.Size(1061, 408);
            this.Controls.Add(this.btnPatientBearbeiten);
            this.Controls.Add(this.addPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "Tests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPatient;
        private System.Windows.Forms.Button btnPatientBearbeiten;
    }
}

