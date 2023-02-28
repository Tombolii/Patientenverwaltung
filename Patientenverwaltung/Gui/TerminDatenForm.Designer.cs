namespace Patientenverwaltung.Gui
{
    partial class TerminDatenForm
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
            this.btn_TerminBearbeiten = new System.Windows.Forms.Button();
            this.txt_Uhrzeit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Datum = new System.Windows.Forms.TextBox();
            this.txt_Vorname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nachname = new System.Windows.Forms.TextBox();
            this.btn_TerminLoeschen = new System.Windows.Forms.Button();
            this.btnBericht = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(484, 135);
            this.btn_Abbrechen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(92, 28);
            this.btn_Abbrechen.TabIndex = 83;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // btn_TerminBearbeiten
            // 
            this.btn_TerminBearbeiten.Location = new System.Drawing.Point(13, 135);
            this.btn_TerminBearbeiten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_TerminBearbeiten.Name = "btn_TerminBearbeiten";
            this.btn_TerminBearbeiten.Size = new System.Drawing.Size(134, 28);
            this.btn_TerminBearbeiten.TabIndex = 82;
            this.btn_TerminBearbeiten.Text = "Termin bearbeiten";
            this.btn_TerminBearbeiten.UseVisualStyleBackColor = true;
            this.btn_TerminBearbeiten.Click += new System.EventHandler(this.btn_TerminBearbeiten_Click);
            // 
            // txt_Uhrzeit
            // 
            this.txt_Uhrzeit.Location = new System.Drawing.Point(423, 54);
            this.txt_Uhrzeit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Uhrzeit.Name = "txt_Uhrzeit";
            this.txt_Uhrzeit.ReadOnly = true;
            this.txt_Uhrzeit.Size = new System.Drawing.Size(132, 22);
            this.txt_Uhrzeit.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 75;
            this.label3.Text = "Uhrzeit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "Datum";
            // 
            // txt_Datum
            // 
            this.txt_Datum.Location = new System.Drawing.Point(136, 54);
            this.txt_Datum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Datum.Name = "txt_Datum";
            this.txt_Datum.ReadOnly = true;
            this.txt_Datum.Size = new System.Drawing.Size(132, 22);
            this.txt_Datum.TabIndex = 73;
            // 
            // txt_Vorname
            // 
            this.txt_Vorname.Location = new System.Drawing.Point(423, 11);
            this.txt_Vorname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Vorname.Name = "txt_Vorname";
            this.txt_Vorname.ReadOnly = true;
            this.txt_Vorname.Size = new System.Drawing.Size(132, 22);
            this.txt_Vorname.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "Vorname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Nachname";
            // 
            // txt_Nachname
            // 
            this.txt_Nachname.Location = new System.Drawing.Point(136, 11);
            this.txt_Nachname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Nachname.Name = "txt_Nachname";
            this.txt_Nachname.ReadOnly = true;
            this.txt_Nachname.Size = new System.Drawing.Size(132, 22);
            this.txt_Nachname.TabIndex = 69;
            // 
            // btn_TerminLoeschen
            // 
            this.btn_TerminLoeschen.Location = new System.Drawing.Point(159, 135);
            this.btn_TerminLoeschen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_TerminLoeschen.Name = "btn_TerminLoeschen";
            this.btn_TerminLoeschen.Size = new System.Drawing.Size(139, 28);
            this.btn_TerminLoeschen.TabIndex = 84;
            this.btn_TerminLoeschen.Text = "Termin löschen";
            this.btn_TerminLoeschen.UseVisualStyleBackColor = true;
            this.btn_TerminLoeschen.Click += new System.EventHandler(this.btn_TerminLoeschen_Click);
            // 
            // btnBericht
            // 
            this.btnBericht.Location = new System.Drawing.Point(306, 135);
            this.btnBericht.Margin = new System.Windows.Forms.Padding(4);
            this.btnBericht.Name = "btnBericht";
            this.btnBericht.Size = new System.Drawing.Size(170, 28);
            this.btnBericht.TabIndex = 85;
            this.btnBericht.Text = "Bericht";
            this.btnBericht.UseVisualStyleBackColor = true;
            this.btnBericht.Click += new System.EventHandler(this.btnBericht_Click);
            // 
            // TerminDatenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 190);
            this.Controls.Add(this.btnBericht);
            this.Controls.Add(this.btn_TerminLoeschen);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.btn_TerminBearbeiten);
            this.Controls.Add(this.txt_Uhrzeit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Datum);
            this.Controls.Add(this.txt_Vorname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nachname);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TerminDatenForm";
            this.Text = "TerminDaten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Abbrechen;
        private System.Windows.Forms.Button btn_TerminBearbeiten;
        private System.Windows.Forms.TextBox txt_Uhrzeit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Datum;
        private System.Windows.Forms.TextBox txt_Vorname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nachname;
        private System.Windows.Forms.Button btn_TerminLoeschen;
        private System.Windows.Forms.Button btnBericht;
    }
}