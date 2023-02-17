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
            this.box_Vorerkrankungen = new System.Windows.Forms.ListBox();
            this.txt_Plz = new System.Windows.Forms.TextBox();
            this.lblPLZ = new System.Windows.Forms.Label();
            this.txt_HausNr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(158, 290);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(103, 23);
            this.btn_Abbrechen.TabIndex = 51;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // btn_PatientHinzufuegen
            // 
            this.btn_PatientHinzufuegen.Location = new System.Drawing.Point(12, 290);
            this.btn_PatientHinzufuegen.Name = "btn_PatientHinzufuegen";
            this.btn_PatientHinzufuegen.Size = new System.Drawing.Size(140, 23);
            this.btn_PatientHinzufuegen.TabIndex = 50;
            this.btn_PatientHinzufuegen.Text = "Patient hinzufügen";
            this.btn_PatientHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_PatientHinzufuegen.Click += new System.EventHandler(this.btn_PatientHinzufuegen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Vorerkrankungen";
            // 
            // txt_Straße
            // 
            this.txt_Straße.Location = new System.Drawing.Point(317, 79);
            this.txt_Straße.Name = "txt_Straße";
            this.txt_Straße.Size = new System.Drawing.Size(100, 20);
            this.txt_Straße.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Straße + Nr.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Krankenkasse";
            // 
            // txt_Ort
            // 
            this.txt_Ort.Location = new System.Drawing.Point(317, 44);
            this.txt_Ort.Name = "txt_Ort";
            this.txt_Ort.Size = new System.Drawing.Size(100, 20);
            this.txt_Ort.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Geburtsdatum";
            // 
            // txt_Geburtsdatum
            // 
            this.txt_Geburtsdatum.Location = new System.Drawing.Point(102, 44);
            this.txt_Geburtsdatum.Name = "txt_Geburtsdatum";
            this.txt_Geburtsdatum.Size = new System.Drawing.Size(100, 20);
            this.txt_Geburtsdatum.TabIndex = 41;
            // 
            // txt_Vorname
            // 
            this.txt_Vorname.Location = new System.Drawing.Point(317, 9);
            this.txt_Vorname.Name = "txt_Vorname";
            this.txt_Vorname.Size = new System.Drawing.Size(100, 20);
            this.txt_Vorname.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Vorname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nachname";
            // 
            // txt_Nachname
            // 
            this.txt_Nachname.Location = new System.Drawing.Point(102, 9);
            this.txt_Nachname.Name = "txt_Nachname";
            this.txt_Nachname.Size = new System.Drawing.Size(100, 20);
            this.txt_Nachname.TabIndex = 37;
            // 
            // box_Krankenkasse
            // 
            this.box_Krankenkasse.FormattingEnabled = true;
            this.box_Krankenkasse.Location = new System.Drawing.Point(102, 79);
            this.box_Krankenkasse.Name = "box_Krankenkasse";
            this.box_Krankenkasse.Size = new System.Drawing.Size(100, 21);
            this.box_Krankenkasse.TabIndex = 52;
            // 
            // box_Vorerkrankungen
            // 
            this.box_Vorerkrankungen.FormattingEnabled = true;
            this.box_Vorerkrankungen.Location = new System.Drawing.Point(12, 139);
            this.box_Vorerkrankungen.Name = "box_Vorerkrankungen";
            this.box_Vorerkrankungen.Size = new System.Drawing.Size(260, 121);
            this.box_Vorerkrankungen.TabIndex = 53;
            // 
            // txt_Plz
            // 
            this.txt_Plz.Location = new System.Drawing.Point(317, 103);
            this.txt_Plz.Name = "txt_Plz";
            this.txt_Plz.Size = new System.Drawing.Size(100, 20);
            this.txt_Plz.TabIndex = 55;
            // 
            // lblPLZ
            // 
            this.lblPLZ.AutoSize = true;
            this.lblPLZ.Location = new System.Drawing.Point(227, 103);
            this.lblPLZ.Name = "lblPLZ";
            this.lblPLZ.Size = new System.Drawing.Size(21, 13);
            this.lblPLZ.TabIndex = 54;
            this.lblPLZ.Text = "Plz";
            // 
            // txt_HausNr
            // 
            this.txt_HausNr.Location = new System.Drawing.Point(423, 80);
            this.txt_HausNr.Name = "txt_HausNr";
            this.txt_HausNr.Size = new System.Drawing.Size(31, 20);
            this.txt_HausNr.TabIndex = 56;
            // 
            // NeuerPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 333);
            this.Controls.Add(this.txt_HausNr);
            this.Controls.Add(this.txt_Plz);
            this.Controls.Add(this.lblPLZ);
            this.Controls.Add(this.box_Vorerkrankungen);
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
            this.Name = "NeuerPatient";
            this.Text = "NeuerPatient";
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
        private System.Windows.Forms.ListBox box_Vorerkrankungen;
        private System.Windows.Forms.TextBox txt_Plz;
        private System.Windows.Forms.Label lblPLZ;
        private System.Windows.Forms.TextBox txt_HausNr;
    }
}