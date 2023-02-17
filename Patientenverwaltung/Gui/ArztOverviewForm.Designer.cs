namespace Patientenverwaltung.Gui
{
    partial class ArztOverviewForm
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cal_Arzt = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.tblTermine = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_TerminHinzufuegen = new System.Windows.Forms.Button();
            this.btn_PatientenAnsehen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(18, 14);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(148, 20);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Hallo Manuel Neuer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ihr Terminkalender";
            // 
            // cal_Arzt
            // 
            this.cal_Arzt.Location = new System.Drawing.Point(24, 121);
            this.cal_Arzt.Margin = new System.Windows.Forms.Padding(14);
            this.cal_Arzt.Name = "cal_Arzt";
            this.cal_Arzt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Termine:";
            // 
            // tblTermine
            // 
            this.tblTermine.ColumnCount = 5;
            this.tblTermine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.3454F));
            this.tblTermine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.53545F));
            this.tblTermine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.02112F));
            this.tblTermine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.24434F));
            this.tblTermine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.70287F));
            this.tblTermine.Location = new System.Drawing.Point(374, 121);
            this.tblTermine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblTermine.Name = "tblTermine";
            this.tblTermine.RowCount = 15;
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTermine.Size = new System.Drawing.Size(663, 339);
            this.tblTermine.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Uhrzeit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nachname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(739, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vorname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(909, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Beschwerden";
            // 
            // btn_TerminHinzufuegen
            // 
            this.btn_TerminHinzufuegen.Location = new System.Drawing.Point(874, 469);
            this.btn_TerminHinzufuegen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_TerminHinzufuegen.Name = "btn_TerminHinzufuegen";
            this.btn_TerminHinzufuegen.Size = new System.Drawing.Size(162, 35);
            this.btn_TerminHinzufuegen.TabIndex = 12;
            this.btn_TerminHinzufuegen.Text = "Termin hinzufügen";
            this.btn_TerminHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_TerminHinzufuegen.Click += new System.EventHandler(this.btn_TerminHinzufuegen_Click);
            // 
            // btn_PatientenAnsehen
            // 
            this.btn_PatientenAnsehen.Location = new System.Drawing.Point(32, 469);
            this.btn_PatientenAnsehen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_PatientenAnsehen.Name = "btn_PatientenAnsehen";
            this.btn_PatientenAnsehen.Size = new System.Drawing.Size(162, 35);
            this.btn_PatientenAnsehen.TabIndex = 13;
            this.btn_PatientenAnsehen.Text = "Patienten ansehen";
            this.btn_PatientenAnsehen.UseVisualStyleBackColor = true;
            this.btn_PatientenAnsehen.Click += new System.EventHandler(this.btn_PatientenAnsehen_Click);
            // 
            // Programmstart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 528);
            this.Controls.Add(this.btn_PatientenAnsehen);
            this.Controls.Add(this.btn_TerminHinzufuegen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tblTermine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cal_Arzt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Name);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Programmstart";
            this.Text = "Ärzteseite";
            this.Load += new System.EventHandler(this.Programmstart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar cal_Arzt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tblTermine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_TerminHinzufuegen;
        private System.Windows.Forms.Button btn_PatientenAnsehen;
    }
}