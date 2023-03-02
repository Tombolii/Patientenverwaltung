namespace Patientenverwaltung.Gui
{
    partial class PatientBearbeitenForm
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
            this.components = new System.ComponentModel.Container();
            this.btn_AenderungUebernehmen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Ort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Geburtsdatum = new System.Windows.Forms.TextBox();
            this.txt_Vorname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nachname = new System.Windows.Forms.TextBox();
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.box_Krankenkasse = new System.Windows.Forms.ComboBox();
            this.boxSelectableVorerkrankungen = new System.Windows.Forms.ListBox();
            this.txt_HausNr = new System.Windows.Forms.TextBox();
            this.txt_Plz = new System.Windows.Forms.TextBox();
            this.lblPLZ = new System.Windows.Forms.Label();
            this.txt_Straße = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Telefonnummer = new System.Windows.Forms.Label();
            this.txt_Telefonnummer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.boxSelectedVorerkrankungen = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddSelectedVorerkrankungen = new System.Windows.Forms.Button();
            this.btnRemoveSelectedVorerkrankungen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AenderungUebernehmen
            // 
            this.btn_AenderungUebernehmen.Location = new System.Drawing.Point(10, 323);
            this.btn_AenderungUebernehmen.Name = "btn_AenderungUebernehmen";
            this.btn_AenderungUebernehmen.Size = new System.Drawing.Size(140, 23);
            this.btn_AenderungUebernehmen.TabIndex = 34;
            this.btn_AenderungUebernehmen.Text = "Änderungen Übernehmen";
            this.btn_AenderungUebernehmen.UseVisualStyleBackColor = true;
            this.btn_AenderungUebernehmen.Click += new System.EventHandler(this.btn_AenderungUebernehmen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Vorerkrankungen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Krankenkasse";
            // 
            // txt_Ort
            // 
            this.txt_Ort.Location = new System.Drawing.Point(317, 44);
            this.txt_Ort.Name = "txt_Ort";
            this.txt_Ort.Size = new System.Drawing.Size(100, 20);
            this.txt_Ort.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Geburtsdatum";
            // 
            // txt_Geburtsdatum
            // 
            this.txt_Geburtsdatum.Location = new System.Drawing.Point(102, 44);
            this.txt_Geburtsdatum.Name = "txt_Geburtsdatum";
            this.txt_Geburtsdatum.Size = new System.Drawing.Size(100, 20);
            this.txt_Geburtsdatum.TabIndex = 25;
            // 
            // txt_Vorname
            // 
            this.txt_Vorname.Location = new System.Drawing.Point(317, 9);
            this.txt_Vorname.Name = "txt_Vorname";
            this.txt_Vorname.Size = new System.Drawing.Size(100, 20);
            this.txt_Vorname.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Vorname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nachname";
            // 
            // txt_Nachname
            // 
            this.txt_Nachname.Location = new System.Drawing.Point(102, 9);
            this.txt_Nachname.Name = "txt_Nachname";
            this.txt_Nachname.Size = new System.Drawing.Size(100, 20);
            this.txt_Nachname.TabIndex = 21;
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(158, 323);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(103, 23);
            this.btn_Abbrechen.TabIndex = 35;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // box_Krankenkasse
            // 
            this.box_Krankenkasse.FormattingEnabled = true;
            this.box_Krankenkasse.Location = new System.Drawing.Point(102, 79);
            this.box_Krankenkasse.Name = "box_Krankenkasse";
            this.box_Krankenkasse.Size = new System.Drawing.Size(100, 21);
            this.box_Krankenkasse.TabIndex = 53;
            this.box_Krankenkasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // boxSelectableVorerkrankungen
            // 
            this.boxSelectableVorerkrankungen.FormattingEnabled = true;
            this.boxSelectableVorerkrankungen.Location = new System.Drawing.Point(10, 236);
            this.boxSelectableVorerkrankungen.Name = "boxSelectableVorerkrankungen";
            this.boxSelectableVorerkrankungen.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.boxSelectableVorerkrankungen.Size = new System.Drawing.Size(141, 69);
            this.boxSelectableVorerkrankungen.TabIndex = 54;
            // 
            // txt_HausNr
            // 
            this.txt_HausNr.Location = new System.Drawing.Point(423, 80);
            this.txt_HausNr.Name = "txt_HausNr";
            this.txt_HausNr.Size = new System.Drawing.Size(31, 20);
            this.txt_HausNr.TabIndex = 61;
            // 
            // txt_Plz
            // 
            this.txt_Plz.Location = new System.Drawing.Point(317, 117);
            this.txt_Plz.Name = "txt_Plz";
            this.txt_Plz.Size = new System.Drawing.Size(100, 20);
            this.txt_Plz.TabIndex = 60;
            // 
            // lblPLZ
            // 
            this.lblPLZ.AutoSize = true;
            this.lblPLZ.Location = new System.Drawing.Point(227, 117);
            this.lblPLZ.Name = "lblPLZ";
            this.lblPLZ.Size = new System.Drawing.Size(21, 13);
            this.lblPLZ.TabIndex = 59;
            this.lblPLZ.Text = "Plz";
            // 
            // txt_Straße
            // 
            this.txt_Straße.Location = new System.Drawing.Point(317, 80);
            this.txt_Straße.Name = "txt_Straße";
            this.txt_Straße.Size = new System.Drawing.Size(100, 20);
            this.txt_Straße.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Straße + Nr.";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 117);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 13);
            this.lblEmail.TabIndex = 62;
            this.lblEmail.Text = "E-Mail";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(102, 117);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(100, 20);
            this.txt_Email.TabIndex = 63;
            // 
            // lbl_Telefonnummer
            // 
            this.lbl_Telefonnummer.AutoSize = true;
            this.lbl_Telefonnummer.Location = new System.Drawing.Point(12, 152);
            this.lbl_Telefonnummer.Name = "lbl_Telefonnummer";
            this.lbl_Telefonnummer.Size = new System.Drawing.Size(80, 13);
            this.lbl_Telefonnummer.TabIndex = 64;
            this.lbl_Telefonnummer.Text = "Telefonnummer";
            // 
            // txt_Telefonnummer
            // 
            this.txt_Telefonnummer.Location = new System.Drawing.Point(102, 152);
            this.txt_Telefonnummer.Name = "txt_Telefonnummer";
            this.txt_Telefonnummer.Size = new System.Drawing.Size(100, 20);
            this.txt_Telefonnummer.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Bitte Vorerkrankungen auswählen";
            // 
            // boxSelectedVorerkrankungen
            // 
            this.boxSelectedVorerkrankungen.FormattingEnabled = true;
            this.boxSelectedVorerkrankungen.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.boxSelectedVorerkrankungen.Location = new System.Drawing.Point(183, 236);
            this.boxSelectedVorerkrankungen.Name = "boxSelectedVorerkrankungen";
            this.boxSelectedVorerkrankungen.Size = new System.Drawing.Size(150, 69);
            this.boxSelectedVorerkrankungen.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Aktuelle Voerkerkrankung";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAddSelectedVorerkrankungen
            // 
            this.btnAddSelectedVorerkrankungen.Location = new System.Drawing.Point(156, 236);
            this.btnAddSelectedVorerkrankungen.Name = "btnAddSelectedVorerkrankungen";
            this.btnAddSelectedVorerkrankungen.Size = new System.Drawing.Size(21, 23);
            this.btnAddSelectedVorerkrankungen.TabIndex = 69;
            this.btnAddSelectedVorerkrankungen.Text = "+";
            this.btnAddSelectedVorerkrankungen.UseVisualStyleBackColor = true;
            this.btnAddSelectedVorerkrankungen.Click += new System.EventHandler(this.btnAddSelectedVorerkrankungen_Click);
            // 
            // btnRemoveSelectedVorerkrankungen
            // 
            this.btnRemoveSelectedVorerkrankungen.Location = new System.Drawing.Point(156, 265);
            this.btnRemoveSelectedVorerkrankungen.Name = "btnRemoveSelectedVorerkrankungen";
            this.btnRemoveSelectedVorerkrankungen.Size = new System.Drawing.Size(21, 23);
            this.btnRemoveSelectedVorerkrankungen.TabIndex = 70;
            this.btnRemoveSelectedVorerkrankungen.Text = "-";
            this.btnRemoveSelectedVorerkrankungen.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedVorerkrankungen.Click += new System.EventHandler(this.btnRemoveSelectedVorerkrankungen_Click);
            // 
            // PatientBearbeitenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 356);
            this.Controls.Add(this.btnRemoveSelectedVorerkrankungen);
            this.Controls.Add(this.btnAddSelectedVorerkrankungen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boxSelectedVorerkrankungen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Telefonnummer);
            this.Controls.Add(this.lbl_Telefonnummer);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txt_HausNr);
            this.Controls.Add(this.txt_Plz);
            this.Controls.Add(this.lblPLZ);
            this.Controls.Add(this.txt_Straße);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxSelectableVorerkrankungen);
            this.Controls.Add(this.box_Krankenkasse);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.btn_AenderungUebernehmen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Ort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Geburtsdatum);
            this.Controls.Add(this.txt_Vorname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nachname);
            this.Name = "PatientBearbeitenForm";
            this.Text = "Patient bearbeiten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AenderungUebernehmen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Ort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Geburtsdatum;
        private System.Windows.Forms.TextBox txt_Vorname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nachname;
        private System.Windows.Forms.Button btn_Abbrechen;
        private System.Windows.Forms.ComboBox box_Krankenkasse;
        private System.Windows.Forms.ListBox boxSelectableVorerkrankungen;
        private System.Windows.Forms.TextBox txt_HausNr;
        private System.Windows.Forms.TextBox txt_Plz;
        private System.Windows.Forms.Label lblPLZ;
        private System.Windows.Forms.TextBox txt_Straße;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Telefonnummer;
        private System.Windows.Forms.TextBox txt_Telefonnummer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button btnAddSelectedVorerkrankungen;
        private System.Windows.Forms.Button btnRemoveSelectedVorerkrankungen;
        private System.Windows.Forms.ListBox boxSelectedVorerkrankungen;
    }
}