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
            this.btnGetKrankheitsbilder = new System.Windows.Forms.Button();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.txtAusgabe = new System.Windows.Forms.TextBox();
            this.btnAddKrankheitsbild = new System.Windows.Forms.Button();
            this.btnModifyKrankheitsbild = new System.Windows.Forms.Button();
            this.btnDeleteKrankheitsbild = new System.Windows.Forms.Button();
            this.btnAddTermin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 59);
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
            // btnGetKrankheitsbilder
            // 
            this.btnGetKrankheitsbilder.Location = new System.Drawing.Point(640, 240);
            this.btnGetKrankheitsbilder.Name = "btnGetKrankheitsbilder";
            this.btnGetKrankheitsbilder.Size = new System.Drawing.Size(182, 42);
            this.btnGetKrankheitsbilder.TabIndex = 4;
            this.btnGetKrankheitsbilder.Text = "Krankheitsbilder auslesen";
            this.btnGetKrankheitsbilder.UseVisualStyleBackColor = true;
            this.btnGetKrankheitsbilder.Click += new System.EventHandler(this.btnGetKrankheitsbilder_Click);
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.Location = new System.Drawing.Point(448, 253);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(62, 16);
            this.lblAusgabe.TabIndex = 5;
            this.lblAusgabe.Text = "Ausgabe";
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.Location = new System.Drawing.Point(397, 298);
            this.txtAusgabe.Multiline = true;
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.ReadOnly = true;
            this.txtAusgabe.Size = new System.Drawing.Size(176, 73);
            this.txtAusgabe.TabIndex = 6;
            // 
            // btnAddKrankheitsbild
            // 
            this.btnAddKrankheitsbild.Location = new System.Drawing.Point(842, 240);
            this.btnAddKrankheitsbild.Name = "btnAddKrankheitsbild";
            this.btnAddKrankheitsbild.Size = new System.Drawing.Size(182, 42);
            this.btnAddKrankheitsbild.TabIndex = 7;
            this.btnAddKrankheitsbild.Text = "Krankheitsbild erstellen";
            this.btnAddKrankheitsbild.UseVisualStyleBackColor = true;
            this.btnAddKrankheitsbild.Click += new System.EventHandler(this.btnAddKrankheitsbild_Click);
            // 
            // btnModifyKrankheitsbild
            // 
            this.btnModifyKrankheitsbild.Location = new System.Drawing.Point(640, 313);
            this.btnModifyKrankheitsbild.Name = "btnModifyKrankheitsbild";
            this.btnModifyKrankheitsbild.Size = new System.Drawing.Size(182, 42);
            this.btnModifyKrankheitsbild.TabIndex = 8;
            this.btnModifyKrankheitsbild.Text = "Krankheitsbild bearbeiten";
            this.btnModifyKrankheitsbild.UseVisualStyleBackColor = true;
            this.btnModifyKrankheitsbild.Click += new System.EventHandler(this.btnModifyKrankheitsbild_Click);
            // 
            // btnDeleteKrankheitsbild
            // 
            this.btnDeleteKrankheitsbild.Location = new System.Drawing.Point(842, 313);
            this.btnDeleteKrankheitsbild.Name = "btnDeleteKrankheitsbild";
            this.btnDeleteKrankheitsbild.Size = new System.Drawing.Size(182, 42);
            this.btnDeleteKrankheitsbild.TabIndex = 9;
            this.btnDeleteKrankheitsbild.Text = "Krankheitsbild löschen";
            this.btnDeleteKrankheitsbild.UseVisualStyleBackColor = true;
            this.btnDeleteKrankheitsbild.Click += new System.EventHandler(this.btnDeleteKrankheitsbild_Click);
            // 
            // btnAddTermin
            // 
            this.btnAddTermin.Location = new System.Drawing.Point(851, 59);
            this.btnAddTermin.Name = "btnAddTermin";
            this.btnAddTermin.Size = new System.Drawing.Size(182, 42);
            this.btnAddTermin.TabIndex = 10;
            this.btnAddTermin.Text = "Termin erstellen";
            this.btnAddTermin.UseVisualStyleBackColor = true;
            this.btnAddTermin.Click += new System.EventHandler(this.btnAddTermin_Click);
            // 
            // IntegrationTest
            // 
            this.ClientSize = new System.Drawing.Size(1061, 408);
            this.Controls.Add(this.btnAddTermin);
            this.Controls.Add(this.btnDeleteKrankheitsbild);
            this.Controls.Add(this.btnModifyKrankheitsbild);
            this.Controls.Add(this.btnAddKrankheitsbild);
            this.Controls.Add(this.txtAusgabe);
            this.Controls.Add(this.lblAusgabe);
            this.Controls.Add(this.btnGetKrankheitsbilder);
            this.Controls.Add(this.btnPatientBearbeiten);
            this.Controls.Add(this.addPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "IntegrationTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPatient;
        private System.Windows.Forms.Button btnPatientBearbeiten;
        private System.Windows.Forms.Button btnGetKrankheitsbilder;
        private System.Windows.Forms.Label lblAusgabe;
        private System.Windows.Forms.TextBox txtAusgabe;
        private System.Windows.Forms.Button btnAddKrankheitsbild;
        private System.Windows.Forms.Button btnModifyKrankheitsbild;
        private System.Windows.Forms.Button btnDeleteKrankheitsbild;
        private System.Windows.Forms.Button btnAddTermin;
    }
}

