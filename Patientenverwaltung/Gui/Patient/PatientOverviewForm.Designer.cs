namespace Patientenverwaltung.Gui
{
    partial class PatientOverviewForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_PatientSuchen = new System.Windows.Forms.Button();
            this.txtSucheNachname = new System.Windows.Forms.TextBox();
            this.btn_PatientHinzufuegen = new System.Windows.Forms.Button();
            this.btn_Weiter = new System.Windows.Forms.Button();
            this.btn_Zurueck = new System.Windows.Forms.Button();
            this.lbl_Seitenanzahl = new System.Windows.Forms.Label();
            this.btn_Startseite = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_PatientAnzeigen = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.tblPatientInformationen = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geburtstag";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Krankenkasse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ort";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Adresse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(813, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 7;
            // 
            // btn_PatientSuchen
            // 
            this.btn_PatientSuchen.Location = new System.Drawing.Point(883, 93);
            this.btn_PatientSuchen.Name = "btn_PatientSuchen";
            this.btn_PatientSuchen.Size = new System.Drawing.Size(111, 23);
            this.btn_PatientSuchen.TabIndex = 8;
            this.btn_PatientSuchen.Text = "Patient suchen";
            this.btn_PatientSuchen.UseVisualStyleBackColor = true;
            this.btn_PatientSuchen.Click += new System.EventHandler(this.btn_PatientSuchen_Click);
            // 
            // txtSucheNachname
            // 
            this.txtSucheNachname.Location = new System.Drawing.Point(883, 67);
            this.txtSucheNachname.Name = "txtSucheNachname";
            this.txtSucheNachname.Size = new System.Drawing.Size(111, 20);
            this.txtSucheNachname.TabIndex = 9;
            // 
            // btn_PatientHinzufuegen
            // 
            this.btn_PatientHinzufuegen.Location = new System.Drawing.Point(883, 190);
            this.btn_PatientHinzufuegen.Name = "btn_PatientHinzufuegen";
            this.btn_PatientHinzufuegen.Size = new System.Drawing.Size(111, 23);
            this.btn_PatientHinzufuegen.TabIndex = 10;
            this.btn_PatientHinzufuegen.Text = "Patient hinzufügen";
            this.btn_PatientHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_PatientHinzufuegen.Click += new System.EventHandler(this.btn_PatientHinzufuegen_Click);
            // 
            // btn_Weiter
            // 
            this.btn_Weiter.Location = new System.Drawing.Point(974, 228);
            this.btn_Weiter.Name = "btn_Weiter";
            this.btn_Weiter.Size = new System.Drawing.Size(20, 20);
            this.btn_Weiter.TabIndex = 11;
            this.btn_Weiter.Text = ">";
            this.btn_Weiter.UseVisualStyleBackColor = true;
            this.btn_Weiter.Click += new System.EventHandler(this.btn_Weiter_Click);
            // 
            // btn_Zurueck
            // 
            this.btn_Zurueck.Enabled = false;
            this.btn_Zurueck.Location = new System.Drawing.Point(884, 228);
            this.btn_Zurueck.Name = "btn_Zurueck";
            this.btn_Zurueck.Size = new System.Drawing.Size(20, 20);
            this.btn_Zurueck.TabIndex = 12;
            this.btn_Zurueck.Text = "<";
            this.btn_Zurueck.UseVisualStyleBackColor = true;
            this.btn_Zurueck.Click += new System.EventHandler(this.btn_Zurueck_Click);
            // 
            // lbl_Seitenanzahl
            // 
            this.lbl_Seitenanzahl.AutoSize = true;
            this.lbl_Seitenanzahl.Location = new System.Drawing.Point(908, 232);
            this.lbl_Seitenanzahl.Name = "lbl_Seitenanzahl";
            this.lbl_Seitenanzahl.Size = new System.Drawing.Size(31, 13);
            this.lbl_Seitenanzahl.TabIndex = 13;
            this.lbl_Seitenanzahl.Text = "Seite";
            // 
            // btn_Startseite
            // 
            this.btn_Startseite.Location = new System.Drawing.Point(866, 10);
            this.btn_Startseite.Name = "btn_Startseite";
            this.btn_Startseite.Size = new System.Drawing.Size(139, 23);
            this.btn_Startseite.TabIndex = 14;
            this.btn_Startseite.Text = "Zurück zur Startseite";
            this.btn_Startseite.UseVisualStyleBackColor = true;
            this.btn_Startseite.Click += new System.EventHandler(this.btn_Startseite_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(880, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nachname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(881, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "(Bitte Patient auswählen)";
            // 
            // btn_PatientAnzeigen
            // 
            this.btn_PatientAnzeigen.Enabled = false;
            this.btn_PatientAnzeigen.Location = new System.Drawing.Point(883, 148);
            this.btn_PatientAnzeigen.Name = "btn_PatientAnzeigen";
            this.btn_PatientAnzeigen.Size = new System.Drawing.Size(111, 23);
            this.btn_PatientAnzeigen.TabIndex = 18;
            this.btn_PatientAnzeigen.Text = "Patient anzeigen";
            this.btn_PatientAnzeigen.UseVisualStyleBackColor = true;
            this.btn_PatientAnzeigen.Click += new System.EventHandler(this.btn_PatientAnzeigen_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(945, 232);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(13, 13);
            this.lblPage.TabIndex = 19;
            this.lblPage.Text = "1";
            // 
            // tblPatientInformationen
            // 
            this.tblPatientInformationen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPatientInformationen.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tblPatientInformationen.ColumnCount = 7;
            this.tblPatientInformationen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.42331F));
            this.tblPatientInformationen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.26282F));
            this.tblPatientInformationen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.6282F));
            this.tblPatientInformationen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.22436F));
            this.tblPatientInformationen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.84848F));
            this.tblPatientInformationen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.75758F));
            this.tblPatientInformationen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tblPatientInformationen.Location = new System.Drawing.Point(42, 31);
            this.tblPatientInformationen.Name = "tblPatientInformationen";
            this.tblPatientInformationen.RowCount = 9;
            this.tblPatientInformationen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.12003F));
            this.tblPatientInformationen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42857F));
            this.tblPatientInformationen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPatientInformationen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.10999F));
            this.tblPatientInformationen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.10999F));
            this.tblPatientInformationen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.10999F));
            this.tblPatientInformationen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.10999F));
            this.tblPatientInformationen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.10999F));
            this.tblPatientInformationen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.10999F));
            this.tblPatientInformationen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPatientInformationen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPatientInformationen.Size = new System.Drawing.Size(800, 213);
            this.tblPatientInformationen.TabIndex = 20;
            this.tblPatientInformationen.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tblPatientInformationen_CellPaint);
            // 
            // PatientOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1016, 262);
            this.Controls.Add(this.tblPatientInformationen);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btn_PatientAnzeigen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Startseite);
            this.Controls.Add(this.lbl_Seitenanzahl);
            this.Controls.Add(this.btn_Zurueck);
            this.Controls.Add(this.btn_Weiter);
            this.Controls.Add(this.btn_PatientHinzufuegen);
            this.Controls.Add(this.txtSucheNachname);
            this.Controls.Add(this.btn_PatientSuchen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PatientOverviewForm";
            this.Text = "Patienten Übersicht";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatientOverviewForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_PatientSuchen;
        private System.Windows.Forms.TextBox txtSucheNachname;
        private System.Windows.Forms.Button btn_PatientHinzufuegen;
        private System.Windows.Forms.Button btn_Weiter;
        private System.Windows.Forms.Button btn_Zurueck;
        private System.Windows.Forms.Label lbl_Seitenanzahl;
        private System.Windows.Forms.Button btn_Startseite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_PatientAnzeigen;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.TableLayoutPanel tblPatientInformationen;
    }
}