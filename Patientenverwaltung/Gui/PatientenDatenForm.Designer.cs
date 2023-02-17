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
            this.txt_Vorerkrankung = new System.Windows.Forms.RichTextBox();
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
            this.SuspendLayout();
            // 
            // txt_Vorerkrankung
            // 
            this.txt_Vorerkrankung.Enabled = false;
            this.txt_Vorerkrankung.Location = new System.Drawing.Point(15, 215);
            this.txt_Vorerkrankung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Vorerkrankung.Name = "txt_Vorerkrankung";
            this.txt_Vorerkrankung.Size = new System.Drawing.Size(343, 175);
            this.txt_Vorerkrankung.TabIndex = 0;
            this.txt_Vorerkrankung.Text = "";
            // 
            // txt_Nachname
            // 
            this.txt_Nachname.Location = new System.Drawing.Point(150, 15);
            this.txt_Nachname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nachname.Name = "txt_Nachname";
            this.txt_Nachname.Size = new System.Drawing.Size(148, 26);
            this.txt_Nachname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nachname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vorname";
            // 
            // txt_Vorname
            // 
            this.txt_Vorname.Location = new System.Drawing.Point(472, 15);
            this.txt_Vorname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Vorname.Name = "txt_Vorname";
            this.txt_Vorname.Size = new System.Drawing.Size(148, 26);
            this.txt_Vorname.TabIndex = 4;
            // 
            // btn_Berichte
            // 
            this.btn_Berichte.Location = new System.Drawing.Point(192, 403);
            this.btn_Berichte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Berichte.Name = "btn_Berichte";
            this.btn_Berichte.Size = new System.Drawing.Size(164, 35);
            this.btn_Berichte.TabIndex = 5;
            this.btn_Berichte.Text = "Berichte ansehen";
            this.btn_Berichte.UseVisualStyleBackColor = true;
            this.btn_Berichte.Click += new System.EventHandler(this.btn_Berichte_Click);
            // 
            // txt_Ort
            // 
            this.txt_Ort.Enabled = false;
            this.txt_Ort.Location = new System.Drawing.Point(472, 69);
            this.txt_Ort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Ort.Name = "txt_Ort";
            this.txt_Ort.Size = new System.Drawing.Size(148, 26);
            this.txt_Ort.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Geburtsdatum";
            // 
            // txt_Geburtstag
            // 
            this.txt_Geburtstag.Enabled = false;
            this.txt_Geburtstag.Location = new System.Drawing.Point(150, 69);
            this.txt_Geburtstag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Geburtstag.Name = "txt_Geburtstag";
            this.txt_Geburtstag.Size = new System.Drawing.Size(148, 26);
            this.txt_Geburtstag.TabIndex = 6;
            // 
            // txt_Adresse
            // 
            this.txt_Adresse.Enabled = false;
            this.txt_Adresse.Location = new System.Drawing.Point(472, 123);
            this.txt_Adresse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Adresse.Name = "txt_Adresse";
            this.txt_Adresse.Size = new System.Drawing.Size(148, 26);
            this.txt_Adresse.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Krankenkasse";
            // 
            // txt_Kasse
            // 
            this.txt_Kasse.Enabled = false;
            this.txt_Kasse.Location = new System.Drawing.Point(150, 123);
            this.txt_Kasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Kasse.Name = "txt_Kasse";
            this.txt_Kasse.Size = new System.Drawing.Size(148, 26);
            this.txt_Kasse.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Vorerkrankungen";
            // 
            // btn_PatientBearbeiten
            // 
            this.btn_PatientBearbeiten.Location = new System.Drawing.Point(20, 403);
            this.btn_PatientBearbeiten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_PatientBearbeiten.Name = "btn_PatientBearbeiten";
            this.btn_PatientBearbeiten.Size = new System.Drawing.Size(164, 35);
            this.btn_PatientBearbeiten.TabIndex = 15;
            this.btn_PatientBearbeiten.Text = "Patient Bearbeiten";
            this.btn_PatientBearbeiten.UseVisualStyleBackColor = true;
            this.btn_PatientBearbeiten.Click += new System.EventHandler(this.btn_PatientBearbeiten_Click);
            // 
            // btn_Zurueck
            // 
            this.btn_Zurueck.Location = new System.Drawing.Point(364, 403);
            this.btn_Zurueck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Zurueck.Name = "btn_Zurueck";
            this.btn_Zurueck.Size = new System.Drawing.Size(154, 35);
            this.btn_Zurueck.TabIndex = 36;
            this.btn_Zurueck.Text = "Zurück";
            this.btn_Zurueck.UseVisualStyleBackColor = true;
            this.btn_Zurueck.Click += new System.EventHandler(this.btn_Zurueck_Click);
            // 
            // PatientenDaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 448);
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
            this.Controls.Add(this.txt_Vorerkrankung);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PatientenDaten";
            this.Text = "Patientendaten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_Vorerkrankung;
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
    }
}

