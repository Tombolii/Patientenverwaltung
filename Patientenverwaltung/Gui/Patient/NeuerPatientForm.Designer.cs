namespace Patientenverwaltung.Gui
{
    partial class NeuerPatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.btn_PatientHinzufuegen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Straße = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Ort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Geburtsdatum = new System.Windows.Forms.TextBox();
            this.txt_Vorname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nachname = new System.Windows.Forms.TextBox();
            this.box_Krankenkasse = new System.Windows.Forms.ComboBox();
            this.txt_Plz = new System.Windows.Forms.TextBox();
            this.lblPLZ = new System.Windows.Forms.Label();
            this.txt_HausNr = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTelefonnummer = new System.Windows.Forms.Label();
            this.txt_Telefonnummer = new System.Windows.Forms.TextBox();
            this.btnRemoveSelectedVorerkrankungen = new System.Windows.Forms.Button();
            this.btnAddSelectedVorerkrankungen = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.boxSelectedVorerkrankungen = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.boxSelectableVorerkrankungen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(212, 404);
            this.btn_Abbrechen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(137, 28);
            this.btn_Abbrechen.TabIndex = 51;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // btn_PatientHinzufuegen
            // 
            this.btn_PatientHinzufuegen.Location = new System.Drawing.Point(17, 404);
            this.btn_PatientHinzufuegen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PatientHinzufuegen.Name = "btn_PatientHinzufuegen";
            this.btn_PatientHinzufuegen.Size = new System.Drawing.Size(187, 28);
            this.btn_PatientHinzufuegen.TabIndex = 50;
            this.btn_PatientHinzufuegen.Text = "Patient hinzufügen";
            this.btn_PatientHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_PatientHinzufuegen.Click += new System.EventHandler(this.btn_PatientHinzufuegen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 247);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 49;
            this.label7.Text = "Vorerkrankungen";
            // 
            // txt_Straße
            // 
            this.txt_Straße.Location = new System.Drawing.Point(423, 97);
            this.txt_Straße.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Straße.Name = "txt_Straße";
            this.txt_Straße.Size = new System.Drawing.Size(132, 22);
            this.txt_Straße.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Straße + Nr.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "Krankenkasse";
            // 
            // txt_Ort
            // 
            this.txt_Ort.Location = new System.Drawing.Point(423, 54);
            this.txt_Ort.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ort.Name = "txt_Ort";
            this.txt_Ort.Size = new System.Drawing.Size(132, 22);
            this.txt_Ort.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Geburtsdatum";
            // 
            // txt_Geburtsdatum
            // 
            this.txt_Geburtsdatum.Location = new System.Drawing.Point(136, 54);
            this.txt_Geburtsdatum.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Geburtsdatum.Name = "txt_Geburtsdatum";
            this.txt_Geburtsdatum.Size = new System.Drawing.Size(132, 22);
            this.txt_Geburtsdatum.TabIndex = 41;
            // 
            // txt_Vorname
            // 
            this.txt_Vorname.Location = new System.Drawing.Point(423, 11);
            this.txt_Vorname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Vorname.Name = "txt_Vorname";
            this.txt_Vorname.Size = new System.Drawing.Size(132, 22);
            this.txt_Vorname.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Vorname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nachname";
            // 
            // txt_Nachname
            // 
            this.txt_Nachname.Location = new System.Drawing.Point(136, 11);
            this.txt_Nachname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nachname.Name = "txt_Nachname";
            this.txt_Nachname.Size = new System.Drawing.Size(132, 22);
            this.txt_Nachname.TabIndex = 37;
            // 
            // box_Krankenkasse
            // 
            this.box_Krankenkasse.FormattingEnabled = true;
            this.box_Krankenkasse.Location = new System.Drawing.Point(136, 97);
            this.box_Krankenkasse.Margin = new System.Windows.Forms.Padding(4);
            this.box_Krankenkasse.Name = "box_Krankenkasse";
            this.box_Krankenkasse.Size = new System.Drawing.Size(132, 24);
            this.box_Krankenkasse.TabIndex = 52;
            this.box_Krankenkasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // txt_Plz
            // 
            this.txt_Plz.Location = new System.Drawing.Point(423, 142);
            this.txt_Plz.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Plz.Name = "txt_Plz";
            this.txt_Plz.Size = new System.Drawing.Size(132, 22);
            this.txt_Plz.TabIndex = 55;
            // 
            // lblPLZ
            // 
            this.lblPLZ.AutoSize = true;
            this.lblPLZ.Location = new System.Drawing.Point(303, 142);
            this.lblPLZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPLZ.Name = "lblPLZ";
            this.lblPLZ.Size = new System.Drawing.Size(25, 16);
            this.lblPLZ.TabIndex = 54;
            this.lblPLZ.Text = "Plz";
            // 
            // txt_HausNr
            // 
            this.txt_HausNr.Location = new System.Drawing.Point(564, 98);
            this.txt_HausNr.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HausNr.Name = "txt_HausNr";
            this.txt_HausNr.Size = new System.Drawing.Size(40, 22);
            this.txt_HausNr.TabIndex = 56;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(136, 142);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(132, 22);
            this.txt_Email.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 58;
            this.label8.Text = "E-Mail";
            // 
            // lblTelefonnummer
            // 
            this.lblTelefonnummer.AutoSize = true;
            this.lblTelefonnummer.Location = new System.Drawing.Point(16, 181);
            this.lblTelefonnummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonnummer.Name = "lblTelefonnummer";
            this.lblTelefonnummer.Size = new System.Drawing.Size(101, 16);
            this.lblTelefonnummer.TabIndex = 59;
            this.lblTelefonnummer.Text = "Telefonnummer";
            // 
            // txt_Telefonnummer
            // 
            this.txt_Telefonnummer.Location = new System.Drawing.Point(136, 181);
            this.txt_Telefonnummer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Telefonnummer.Name = "txt_Telefonnummer";
            this.txt_Telefonnummer.Size = new System.Drawing.Size(132, 22);
            this.txt_Telefonnummer.TabIndex = 60;
            // 
            // btnRemoveSelectedVorerkrankungen
            // 
            this.btnRemoveSelectedVorerkrankungen.Location = new System.Drawing.Point(212, 332);
            this.btnRemoveSelectedVorerkrankungen.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveSelectedVorerkrankungen.Name = "btnRemoveSelectedVorerkrankungen";
            this.btnRemoveSelectedVorerkrankungen.Size = new System.Drawing.Size(28, 28);
            this.btnRemoveSelectedVorerkrankungen.TabIndex = 76;
            this.btnRemoveSelectedVorerkrankungen.Text = "-";
            this.btnRemoveSelectedVorerkrankungen.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedVorerkrankungen.Click += new System.EventHandler(this.btnRemoveSelectedVorerkrankungen_Click);
            // 
            // btnAddSelectedVorerkrankungen
            // 
            this.btnAddSelectedVorerkrankungen.Location = new System.Drawing.Point(212, 296);
            this.btnAddSelectedVorerkrankungen.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSelectedVorerkrankungen.Name = "btnAddSelectedVorerkrankungen";
            this.btnAddSelectedVorerkrankungen.Size = new System.Drawing.Size(28, 28);
            this.btnAddSelectedVorerkrankungen.TabIndex = 75;
            this.btnAddSelectedVorerkrankungen.Text = "+";
            this.btnAddSelectedVorerkrankungen.UseVisualStyleBackColor = true;
            this.btnAddSelectedVorerkrankungen.Click += new System.EventHandler(this.btnAddSelectedVorerkrankungen_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 276);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 16);
            this.label9.TabIndex = 74;
            this.label9.Text = "Aktuelle Voerkerkrankung";
            // 
            // boxSelectedVorerkrankungen
            // 
            this.boxSelectedVorerkrankungen.FormattingEnabled = true;
            this.boxSelectedVorerkrankungen.ItemHeight = 16;
            this.boxSelectedVorerkrankungen.Location = new System.Drawing.Point(248, 296);
            this.boxSelectedVorerkrankungen.Margin = new System.Windows.Forms.Padding(4);
            this.boxSelectedVorerkrankungen.Name = "boxSelectedVorerkrankungen";
            this.boxSelectedVorerkrankungen.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.boxSelectedVorerkrankungen.Size = new System.Drawing.Size(199, 84);
            this.boxSelectedVorerkrankungen.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 276);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 16);
            this.label10.TabIndex = 72;
            this.label10.Text = "Bitte Vorerkrankungen auswählen";
            // 
            // boxSelectableVorerkrankungen
            // 
            this.boxSelectableVorerkrankungen.FormattingEnabled = true;
            this.boxSelectableVorerkrankungen.ItemHeight = 16;
            this.boxSelectableVorerkrankungen.Location = new System.Drawing.Point(17, 296);
            this.boxSelectableVorerkrankungen.Margin = new System.Windows.Forms.Padding(4);
            this.boxSelectableVorerkrankungen.Name = "boxSelectableVorerkrankungen";
            this.boxSelectableVorerkrankungen.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.boxSelectableVorerkrankungen.Size = new System.Drawing.Size(187, 84);
            this.boxSelectableVorerkrankungen.TabIndex = 71;
            // 
            // NeuerPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 454);
            this.Controls.Add(this.btnRemoveSelectedVorerkrankungen);
            this.Controls.Add(this.btnAddSelectedVorerkrankungen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boxSelectedVorerkrankungen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.boxSelectableVorerkrankungen);
            this.Controls.Add(this.txt_Telefonnummer);
            this.Controls.Add(this.lblTelefonnummer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_HausNr);
            this.Controls.Add(this.txt_Plz);
            this.Controls.Add(this.lblPLZ);
            this.Controls.Add(this.box_Krankenkasse);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.btn_PatientHinzufuegen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Straße);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Ort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Geburtsdatum);
            this.Controls.Add(this.txt_Vorname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nachname);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NeuerPatientForm";
            this.Text = "Neuen Patienten anlegen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NeuerPatientForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Abbrechen;
        private System.Windows.Forms.Button btn_PatientHinzufuegen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Straße;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Ort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Geburtsdatum;
        private System.Windows.Forms.TextBox txt_Vorname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nachname;
        private System.Windows.Forms.ComboBox box_Krankenkasse;
        private System.Windows.Forms.TextBox txt_Plz;
        private System.Windows.Forms.Label lblPLZ;
        private System.Windows.Forms.TextBox txt_HausNr;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTelefonnummer;
        private System.Windows.Forms.TextBox txt_Telefonnummer;
        private System.Windows.Forms.Button btnRemoveSelectedVorerkrankungen;
        private System.Windows.Forms.Button btnAddSelectedVorerkrankungen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox boxSelectedVorerkrankungen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox boxSelectableVorerkrankungen;
    }
}