namespace Patientenverwaltung.Gui
{
    partial class NeuerTerminForm
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
            this.btn_TerminHinzufuegen = new System.Windows.Forms.Button();
            this.txt_Uhrzeit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Datum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(158, 54);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(103, 23);
            this.btn_Abbrechen.TabIndex = 67;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // btn_TerminHinzufuegen
            // 
            this.btn_TerminHinzufuegen.Location = new System.Drawing.Point(12, 54);
            this.btn_TerminHinzufuegen.Name = "btn_TerminHinzufuegen";
            this.btn_TerminHinzufuegen.Size = new System.Drawing.Size(140, 23);
            this.btn_TerminHinzufuegen.TabIndex = 66;
            this.btn_TerminHinzufuegen.Text = "Termin hinzufügen";
            this.btn_TerminHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_TerminHinzufuegen.Click += new System.EventHandler(this.btn_TerminHinzufuegen_Click);
            // 
            // txt_Uhrzeit
            // 
            this.txt_Uhrzeit.Location = new System.Drawing.Point(208, 15);
            this.txt_Uhrzeit.Name = "txt_Uhrzeit";
            this.txt_Uhrzeit.Size = new System.Drawing.Size(100, 20);
            this.txt_Uhrzeit.TabIndex = 60;
            this.txt_Uhrzeit.Text = "hh:mm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Uhrzeit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Datum";
            // 
            // txt_Datum
            // 
            this.txt_Datum.Location = new System.Drawing.Point(56, 15);
            this.txt_Datum.Name = "txt_Datum";
            this.txt_Datum.Size = new System.Drawing.Size(100, 20);
            this.txt_Datum.TabIndex = 57;
            this.txt_Datum.Text = "TT.MM.JJJJ";
            // 
            // NeuerTerminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 89);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.btn_TerminHinzufuegen);
            this.Controls.Add(this.txt_Uhrzeit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Datum);
            this.Name = "NeuerTerminForm";
            this.Text = "NeuerTermin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Abbrechen;
        private System.Windows.Forms.Button btn_TerminHinzufuegen;
        private System.Windows.Forms.TextBox txt_NachnameArzt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Uhrzeit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Datum;
        private System.Windows.Forms.TextBox txt_Vorname;
        private System.Windows.Forms.Label label2;
    }
}