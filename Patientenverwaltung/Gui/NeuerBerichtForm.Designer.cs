namespace Patientenverwaltung.Gui
{
    partial class NeuerBerichtForm
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
            this.btn_BerhichtHinzufuegen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Kasse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Geb = new System.Windows.Forms.TextBox();
            this.txt_Vorname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nachname = new System.Windows.Forms.TextBox();
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Beschwerden = new System.Windows.Forms.RichTextBox();
            this.txt_Bemerkungen = new System.Windows.Forms.RichTextBox();
            this.txt_Diagnose = new System.Windows.Forms.RichTextBox();
            this.lbl_Vorerkrankungen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_BerhichtHinzufuegen
            // 
            this.btn_BerhichtHinzufuegen.Location = new System.Drawing.Point(12, 272);
            this.btn_BerhichtHinzufuegen.Name = "btn_BerhichtHinzufuegen";
            this.btn_BerhichtHinzufuegen.Size = new System.Drawing.Size(103, 23);
            this.btn_BerhichtHinzufuegen.TabIndex = 34;
            this.btn_BerhichtHinzufuegen.Text = "Bericht hinzufügen";
            this.btn_BerhichtHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_BerhichtHinzufuegen.Click += new System.EventHandler(this.btn_BerhichtHinzufuegen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Vorerkrankungen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Krankenkasse";
            // 
            // txt_Kasse
            // 
            this.txt_Kasse.Enabled = false;
            this.txt_Kasse.Location = new System.Drawing.Point(317, 47);
            this.txt_Kasse.Name = "txt_Kasse";
            this.txt_Kasse.Size = new System.Drawing.Size(100, 20);
            this.txt_Kasse.TabIndex = 29;
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
            // txt_Geb
            // 
            this.txt_Geb.Enabled = false;
            this.txt_Geb.Location = new System.Drawing.Point(102, 44);
            this.txt_Geb.Name = "txt_Geb";
            this.txt_Geb.Size = new System.Drawing.Size(100, 20);
            this.txt_Geb.TabIndex = 25;
            // 
            // txt_Vorname
            // 
            this.txt_Vorname.Enabled = false;
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
            this.txt_Nachname.Enabled = false;
            this.txt_Nachname.Location = new System.Drawing.Point(102, 9);
            this.txt_Nachname.Name = "txt_Nachname";
            this.txt_Nachname.Size = new System.Drawing.Size(100, 20);
            this.txt_Nachname.TabIndex = 21;
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(132, 272);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(103, 23);
            this.btn_Abbrechen.TabIndex = 35;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Bemerkungen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Beschwerden";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(540, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Diagnose";
            // 
            // txt_Beschwerden
            // 
            this.txt_Beschwerden.Location = new System.Drawing.Point(12, 101);
            this.txt_Beschwerden.Name = "txt_Beschwerden";
            this.txt_Beschwerden.Size = new System.Drawing.Size(223, 146);
            this.txt_Beschwerden.TabIndex = 39;
            this.txt_Beschwerden.Text = "";
            // 
            // txt_Bemerkungen
            // 
            this.txt_Bemerkungen.Location = new System.Drawing.Point(266, 101);
            this.txt_Bemerkungen.Name = "txt_Bemerkungen";
            this.txt_Bemerkungen.Size = new System.Drawing.Size(223, 146);
            this.txt_Bemerkungen.TabIndex = 40;
            this.txt_Bemerkungen.Text = "";
            // 
            // txt_Diagnose
            // 
            this.txt_Diagnose.Location = new System.Drawing.Point(520, 101);
            this.txt_Diagnose.Name = "txt_Diagnose";
            this.txt_Diagnose.Size = new System.Drawing.Size(223, 146);
            this.txt_Diagnose.TabIndex = 41;
            this.txt_Diagnose.Text = "";
            // 
            // lbl_Vorerkrankungen
            // 
            this.lbl_Vorerkrankungen.AutoSize = true;
            this.lbl_Vorerkrankungen.Location = new System.Drawing.Point(441, 43);
            this.lbl_Vorerkrankungen.Name = "lbl_Vorerkrankungen";
            this.lbl_Vorerkrankungen.Size = new System.Drawing.Size(0, 13);
            this.lbl_Vorerkrankungen.TabIndex = 42;
            // 
            // NeuerBericht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 312);
            this.Controls.Add(this.lbl_Vorerkrankungen);
            this.Controls.Add(this.txt_Diagnose);
            this.Controls.Add(this.txt_Bemerkungen);
            this.Controls.Add(this.txt_Beschwerden);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.btn_BerhichtHinzufuegen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Kasse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Geb);
            this.Controls.Add(this.txt_Vorname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nachname);
            this.Name = "NeuerBericht";
            this.Text = "NeuerBericht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BerhichtHinzufuegen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Kasse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Geb;
        private System.Windows.Forms.TextBox txt_Vorname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nachname;
        private System.Windows.Forms.Button btn_Abbrechen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txt_Beschwerden;
        private System.Windows.Forms.RichTextBox txt_Diagnose;
        private System.Windows.Forms.RichTextBox txt_Bemerkungen;
        private System.Windows.Forms.Label lbl_Vorerkrankungen;
    }
}