namespace Patientenverwaltung.Gui
{
    partial class AdminForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Passwort = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Titel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Fachgebiet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Geburtstag = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TelNr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Nachname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Vorname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_PLZ = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Ort = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_HausNr = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Straße = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Passwort";
            // 
            // txt_Passwort
            // 
            this.txt_Passwort.Location = new System.Drawing.Point(490, 44);
            this.txt_Passwort.Name = "txt_Passwort";
            this.txt_Passwort.Size = new System.Drawing.Size(100, 20);
            this.txt_Passwort.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 158);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Hinzufügen";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(102, 158);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Abbrechen";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Titel";
            // 
            // txt_Titel
            // 
            this.txt_Titel.Location = new System.Drawing.Point(490, 18);
            this.txt_Titel.Name = "txt_Titel";
            this.txt_Titel.Size = new System.Drawing.Size(100, 20);
            this.txt_Titel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fachgebiet ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_Fachgebiet
            // 
            this.txt_Fachgebiet.Location = new System.Drawing.Point(490, 69);
            this.txt_Fachgebiet.Name = "txt_Fachgebiet";
            this.txt_Fachgebiet.Size = new System.Drawing.Size(100, 20);
            this.txt_Fachgebiet.TabIndex = 8;
            this.txt_Fachgebiet.TextChanged += new System.EventHandler(this.txt_Fachgebiet_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Geburtstag";
            // 
            // txt_Geburtstag
            // 
            this.txt_Geburtstag.Location = new System.Drawing.Point(92, 124);
            this.txt_Geburtstag.Name = "txt_Geburtstag";
            this.txt_Geburtstag.Size = new System.Drawing.Size(100, 20);
            this.txt_Geburtstag.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Telefonnummer";
            // 
            // txt_TelNr
            // 
            this.txt_TelNr.Location = new System.Drawing.Point(92, 95);
            this.txt_TelNr.Name = "txt_TelNr";
            this.txt_TelNr.Size = new System.Drawing.Size(100, 20);
            this.txt_TelNr.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "E-Mail";
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(92, 70);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(100, 20);
            this.txt_Mail.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nachname";
            // 
            // txt_Nachname
            // 
            this.txt_Nachname.Location = new System.Drawing.Point(92, 44);
            this.txt_Nachname.Name = "txt_Nachname";
            this.txt_Nachname.Size = new System.Drawing.Size(100, 20);
            this.txt_Nachname.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Vorname";
            // 
            // txt_Vorname
            // 
            this.txt_Vorname.Location = new System.Drawing.Point(92, 18);
            this.txt_Vorname.Name = "txt_Vorname";
            this.txt_Vorname.Size = new System.Drawing.Size(100, 20);
            this.txt_Vorname.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "PLZ";
            // 
            // txt_PLZ
            // 
            this.txt_PLZ.Location = new System.Drawing.Point(294, 95);
            this.txt_PLZ.Name = "txt_PLZ";
            this.txt_PLZ.Size = new System.Drawing.Size(100, 20);
            this.txt_PLZ.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(214, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Ort";
            // 
            // txt_Ort
            // 
            this.txt_Ort.Location = new System.Drawing.Point(294, 70);
            this.txt_Ort.Name = "txt_Ort";
            this.txt_Ort.Size = new System.Drawing.Size(100, 20);
            this.txt_Ort.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(214, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Hausnummer";
            // 
            // txt_HausNr
            // 
            this.txt_HausNr.Location = new System.Drawing.Point(294, 44);
            this.txt_HausNr.Name = "txt_HausNr";
            this.txt_HausNr.Size = new System.Drawing.Size(100, 20);
            this.txt_HausNr.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(214, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Straße";
            // 
            // txt_Straße
            // 
            this.txt_Straße.Location = new System.Drawing.Point(294, 18);
            this.txt_Straße.Name = "txt_Straße";
            this.txt_Straße.Size = new System.Drawing.Size(100, 20);
            this.txt_Straße.TabIndex = 30;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 193);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_PLZ);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_Ort);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_HausNr);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_Straße);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Geburtstag);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_TelNr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Mail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Nachname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Vorname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Fachgebiet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Titel);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Passwort);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Passwort;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Titel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Fachgebiet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Geburtstag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TelNr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Nachname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Vorname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_PLZ;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Ort;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_HausNr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Straße;
    }
}