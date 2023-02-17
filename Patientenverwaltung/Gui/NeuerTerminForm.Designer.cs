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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeuerTerminForm));
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.btn_TerminHinzufuegen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Uhrzeit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Datum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Beschwerden = new System.Windows.Forms.RichTextBox();
            this.txt_arztID = new System.Windows.Forms.TextBox();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(211, 357);
            this.btn_Abbrechen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(137, 28);
            this.btn_Abbrechen.TabIndex = 67;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // btn_TerminHinzufuegen
            // 
            this.btn_TerminHinzufuegen.Location = new System.Drawing.Point(16, 357);
            this.btn_TerminHinzufuegen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TerminHinzufuegen.Name = "btn_TerminHinzufuegen";
            this.btn_TerminHinzufuegen.Size = new System.Drawing.Size(187, 28);
            this.btn_TerminHinzufuegen.TabIndex = 66;
            this.btn_TerminHinzufuegen.Text = "Termin hinzufügen";
            this.btn_TerminHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_TerminHinzufuegen.Click += new System.EventHandler(this.btn_TerminHinzufuegen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 65;
            this.label7.Text = "Beschwerden";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 62;
            this.label6.Text = "Arzt ID";
            // 
            // txt_Uhrzeit
            // 
            this.txt_Uhrzeit.Location = new System.Drawing.Point(421, 58);
            this.txt_Uhrzeit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Uhrzeit.Name = "txt_Uhrzeit";
            this.txt_Uhrzeit.Size = new System.Drawing.Size(132, 22);
            this.txt_Uhrzeit.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Uhrzeit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 58;
            this.label4.Text = "Datum";
            // 
            // txt_Datum
            // 
            this.txt_Datum.Location = new System.Drawing.Point(136, 54);
            this.txt_Datum.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Datum.Name = "txt_Datum";
            this.txt_Datum.Size = new System.Drawing.Size(132, 22);
            this.txt_Datum.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Patienten ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(136, 11);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(132, 22);
            this.txt_ID.TabIndex = 53;
            // 
            // txt_Beschwerden
            // 
            this.txt_Beschwerden.Location = new System.Drawing.Point(16, 171);
            this.txt_Beschwerden.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Beschwerden.Name = "txt_Beschwerden";
            this.txt_Beschwerden.Size = new System.Drawing.Size(345, 157);
            this.txt_Beschwerden.TabIndex = 52;
            this.txt_Beschwerden.Text = "";
            // 
            // txt_arztID
            // 
            this.txt_arztID.Location = new System.Drawing.Point(421, 11);
            this.txt_arztID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_arztID.Name = "txt_arztID";
            this.txt_arztID.Size = new System.Drawing.Size(132, 22);
            this.txt_arztID.TabIndex = 68;
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchPatient.Image")));
            this.btnSearchPatient.Location = new System.Drawing.Point(101, 15);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(28, 18);
            this.btnSearchPatient.TabIndex = 69;
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // NeuerTerminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 416);
            this.Controls.Add(this.btnSearchPatient);
            this.Controls.Add(this.txt_arztID);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.btn_TerminHinzufuegen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Uhrzeit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Datum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_Beschwerden);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NeuerTerminForm";
            this.Text = "NeuerTermin";
            this.Load += new System.EventHandler(this.NeuerTermin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Abbrechen;
        private System.Windows.Forms.Button btn_TerminHinzufuegen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_NachnameArzt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Uhrzeit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Datum;
        private System.Windows.Forms.TextBox txt_Vorname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.RichTextBox txt_Beschwerden;
        private System.Windows.Forms.TextBox txt_arztID;
        private System.Windows.Forms.Button btnSearchPatient;
    }
}