namespace Patientenverwaltung.Gui
{
    partial class PatientenDatenForm
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
            this.boxVorerkrankungen = new System.Windows.Forms.ListBox();
            this.txt_Nachname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Vorname = new System.Windows.Forms.TextBox();
            this.btn_Berichte = new System.Windows.Forms.Button();
            this.txt_Ort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Geburtstag = new System.Windows.Forms.TextBox();
            this.txt_Adresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Kasse = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_PatientBearbeiten = new System.Windows.Forms.Button();
            this.btn_Zurueck = new System.Windows.Forms.Button();
            this.btn_TerminHinzufuegen = new System.Windows.Forms.Button();
            this.btn_PatientLoeschen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Telefonnummer = new System.Windows.Forms.Label();
            this.txt_Telefonnummer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boxVorerkrankungen
            // 
            this.boxVorerkrankungen.Enabled = false;
            this.boxVorerkrankungen.FormattingEnabled = true;
            this.boxVorerkrankungen.Location = new System.Drawing.Point(10, 170);
            this.boxVorerkrankungen.Name = "boxVorerkrankungen";
            this.boxVorerkrankungen.Size = new System.Drawing.Size(230, 108);
            this.boxVorerkrankungen.TabIndex = 0;
            // 
            // txt_Nachname
            // 
            this.txt_Nachname.Enabled = false;
            this.txt_Nachname.Location = new System.Drawing.Point(100, 10);
            this.txt_Nachname.Name = "txt_Nachname";
            this.txt_Nachname.Size = new System.Drawing.Size(171, 20);
            this.txt_Nachname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nachname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vorname";
            // 
            // txt_Vorname
            // 
            this.txt_Vorname.Enabled = false;
            this.txt_Vorname.Location = new System.Drawing.Point(396, 10);
            this.txt_Vorname.Name = "txt_Vorname";
            this.txt_Vorname.Size = new System.Drawing.Size(154, 20);
            this.txt_Vorname.TabIndex = 4;
            // 
            // btn_Berichte
            // 
            this.btn_Berichte.Location = new System.Drawing.Point(258, 168);
            this.btn_Berichte.Name = "btn_Berichte";
            this.btn_Berichte.Size = new System.Drawing.Size(108, 23);
            this.btn_Berichte.TabIndex = 5;
            this.btn_Berichte.Text = "Berichte ansehen";
            this.btn_Berichte.UseVisualStyleBackColor = true;
            this.btn_Berichte.Click += new System.EventHandler(this.btn_Berichte_Click);
            // 
            // txt_Ort
            // 
            this.txt_Ort.Enabled = false;
            this.txt_Ort.Location = new System.Drawing.Point(396, 45);
            this.txt_Ort.Name = "txt_Ort";
            this.txt_Ort.Size = new System.Drawing.Size(154, 20);
            this.txt_Ort.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Geburtsdatum";
            // 
            // txt_Geburtstag
            // 
            this.txt_Geburtstag.Enabled = false;
            this.txt_Geburtstag.Location = new System.Drawing.Point(100, 45);
            this.txt_Geburtstag.Name = "txt_Geburtstag";
            this.txt_Geburtstag.Size = new System.Drawing.Size(171, 20);
            this.txt_Geburtstag.TabIndex = 6;
            // 
            // txt_Adresse
            // 
            this.txt_Adresse.Enabled = false;
            this.txt_Adresse.Location = new System.Drawing.Point(396, 80);
            this.txt_Adresse.Name = "txt_Adresse";
            this.txt_Adresse.Size = new System.Drawing.Size(154, 20);
            this.txt_Adresse.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Krankenkasse";
            // 
            // txt_Kasse
            // 
            this.txt_Kasse.Enabled = false;
            this.txt_Kasse.Location = new System.Drawing.Point(100, 80);
            this.txt_Kasse.Name = "txt_Kasse";
            this.txt_Kasse.Size = new System.Drawing.Size(171, 20);
            this.txt_Kasse.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Vorerkrankungen";
            // 
            // btn_PatientBearbeiten
            // 
            this.btn_PatientBearbeiten.Location = new System.Drawing.Point(10, 291);
            this.btn_PatientBearbeiten.Name = "btn_PatientBearbeiten";
            this.btn_PatientBearbeiten.Size = new System.Drawing.Size(109, 23);
            this.btn_PatientBearbeiten.TabIndex = 15;
            this.btn_PatientBearbeiten.Text = "Patient bearbeiten";
            this.btn_PatientBearbeiten.UseVisualStyleBackColor = true;
            this.btn_PatientBearbeiten.Click += new System.EventHandler(this.btn_PatientBearbeiten_Click);
            // 
            // btn_Zurueck
            // 
            this.btn_Zurueck.Location = new System.Drawing.Point(460, 291);
            this.btn_Zurueck.Name = "btn_Zurueck";
            this.btn_Zurueck.Size = new System.Drawing.Size(90, 23);
            this.btn_Zurueck.TabIndex = 36;
            this.btn_Zurueck.Text = "Zurück";
            this.btn_Zurueck.UseVisualStyleBackColor = true;
            this.btn_Zurueck.Click += new System.EventHandler(this.btn_Zurueck_Click);
            // 
            // btn_TerminHinzufuegen
            // 
            this.btn_TerminHinzufuegen.Location = new System.Drawing.Point(258, 213);
            this.btn_TerminHinzufuegen.Name = "btn_TerminHinzufuegen";
            this.btn_TerminHinzufuegen.Size = new System.Drawing.Size(108, 23);
            this.btn_TerminHinzufuegen.TabIndex = 37;
            this.btn_TerminHinzufuegen.Text = "Termin hinzufügen";
            this.btn_TerminHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_TerminHinzufuegen.Click += new System.EventHandler(this.btn_TerminHinzufuegen_Click);
            // 
            // btn_PatientLoeschen
            // 
            this.btn_PatientLoeschen.Location = new System.Drawing.Point(125, 291);
            this.btn_PatientLoeschen.Name = "btn_PatientLoeschen";
            this.btn_PatientLoeschen.Size = new System.Drawing.Size(109, 23);
            this.btn_PatientLoeschen.TabIndex = 38;
            this.btn_PatientLoeschen.Text = "Patient löschen";
            this.btn_PatientLoeschen.UseVisualStyleBackColor = true;
            this.btn_PatientLoeschen.Click += new System.EventHandler(this.btn_PatientLoeschen_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "E-Mail";
            // 
            // txt_Email
            // 
            this.txt_Email.Enabled = false;
            this.txt_Email.Location = new System.Drawing.Point(100, 113);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(171, 20);
            this.txt_Email.TabIndex = 40;
            // 
            // lbl_Telefonnummer
            // 
            this.lbl_Telefonnummer.AutoSize = true;
            this.lbl_Telefonnummer.Location = new System.Drawing.Point(306, 116);
            this.lbl_Telefonnummer.Name = "lbl_Telefonnummer";
            this.lbl_Telefonnummer.Size = new System.Drawing.Size(80, 13);
            this.lbl_Telefonnummer.TabIndex = 41;
            this.lbl_Telefonnummer.Text = "Telefonnummer";
            // 
            // txt_Telefonnummer
            // 
            this.txt_Telefonnummer.Enabled = false;
            this.txt_Telefonnummer.Location = new System.Drawing.Point(396, 116);
            this.txt_Telefonnummer.Name = "txt_Telefonnummer";
            this.txt_Telefonnummer.Size = new System.Drawing.Size(154, 20);
            this.txt_Telefonnummer.TabIndex = 42;
            // 
            // PatientenDatenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 326);
            this.Controls.Add(this.txt_Telefonnummer);
            this.Controls.Add(this.lbl_Telefonnummer);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_PatientLoeschen);
            this.Controls.Add(this.btn_TerminHinzufuegen);
            this.Controls.Add(this.btn_Zurueck);
            this.Controls.Add(this.btn_PatientBearbeiten);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Adresse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Kasse);
            this.Controls.Add(this.txt_Ort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Geburtstag);
            this.Controls.Add(this.btn_Berichte);
            this.Controls.Add(this.txt_Vorname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nachname);
            this.Controls.Add(this.boxVorerkrankungen);
            this.Name = "PatientenDatenForm";
            this.Text = "Patientendaten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox boxVorerkrankungen;
        private System.Windows.Forms.TextBox txt_Nachname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Vorname;
        private System.Windows.Forms.Button btn_Berichte;
        private System.Windows.Forms.TextBox txt_Ort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Geburtstag;
        private System.Windows.Forms.TextBox txt_Adresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Kasse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_PatientBearbeiten;
        private System.Windows.Forms.Button btn_Zurueck;
        private System.Windows.Forms.Button btn_TerminHinzufuegen;
        private System.Windows.Forms.Button btn_PatientLoeschen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Telefonnummer;
        private System.Windows.Forms.TextBox txt_Telefonnummer;
    }
}

