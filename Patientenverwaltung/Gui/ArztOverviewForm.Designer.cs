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
            this.tblTermine = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_PatientenAnsehen = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.lbl_Seitenanzahl = new System.Windows.Forms.Label();
            this.btn_Zurueck = new System.Windows.Forms.Button();
            this.btn_Weiter = new System.Windows.Forms.Button();
            this.checkAlleTermine = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(16, 11);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(126, 16);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Hallo Manuel Neuer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ihr Terminkalender";
            // 
            // cal_Arzt
            // 
            this.cal_Arzt.Location = new System.Drawing.Point(21, 97);
            this.cal_Arzt.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.cal_Arzt.Name = "cal_Arzt";
            this.cal_Arzt.TabIndex = 2;
            // 
            // tblTermine
            // 
            this.tblTermine.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tblTermine.ColumnCount = 4;
            this.tblTermine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.2069F));
            this.tblTermine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.82759F));
            this.tblTermine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.51724F));
            this.tblTermine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.13793F));
            this.tblTermine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tblTermine.Location = new System.Drawing.Point(332, 97);
            this.tblTermine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblTermine.Name = "tblTermine";
            this.tblTermine.RowCount = 10;
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblTermine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblTermine.Size = new System.Drawing.Size(391, 271);
            this.tblTermine.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Uhrzeit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nachname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vorname";
            // 
            // btn_PatientenAnsehen
            // 
            this.btn_PatientenAnsehen.Location = new System.Drawing.Point(28, 375);
            this.btn_PatientenAnsehen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_PatientenAnsehen.Name = "btn_PatientenAnsehen";
            this.btn_PatientenAnsehen.Size = new System.Drawing.Size(144, 28);
            this.btn_PatientenAnsehen.TabIndex = 13;
            this.btn_PatientenAnsehen.Text = "Patienten ansehen";
            this.btn_PatientenAnsehen.UseVisualStyleBackColor = true;
            this.btn_PatientenAnsehen.Click += new System.EventHandler(this.btn_PatientenAnsehen_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(647, 382);
            this.lblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(14, 16);
            this.lblPage.TabIndex = 23;
            this.lblPage.Text = "1";
            // 
            // lbl_Seitenanzahl
            // 
            this.lbl_Seitenanzahl.AutoSize = true;
            this.lbl_Seitenanzahl.Location = new System.Drawing.Point(597, 382);
            this.lbl_Seitenanzahl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Seitenanzahl.Name = "lbl_Seitenanzahl";
            this.lbl_Seitenanzahl.Size = new System.Drawing.Size(38, 16);
            this.lbl_Seitenanzahl.TabIndex = 22;
            this.lbl_Seitenanzahl.Text = "Seite";
            // 
            // btn_Zurueck
            // 
            this.btn_Zurueck.Enabled = false;
            this.btn_Zurueck.Location = new System.Drawing.Point(565, 377);
            this.btn_Zurueck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Zurueck.Name = "btn_Zurueck";
            this.btn_Zurueck.Size = new System.Drawing.Size(27, 25);
            this.btn_Zurueck.TabIndex = 21;
            this.btn_Zurueck.Text = "<";
            this.btn_Zurueck.UseVisualStyleBackColor = true;
            this.btn_Zurueck.Click += new System.EventHandler(this.btn_Zurueck_Click);
            // 
            // btn_Weiter
            // 
            this.btn_Weiter.Location = new System.Drawing.Point(685, 377);
            this.btn_Weiter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Weiter.Name = "btn_Weiter";
            this.btn_Weiter.Size = new System.Drawing.Size(27, 25);
            this.btn_Weiter.TabIndex = 20;
            this.btn_Weiter.Text = ">";
            this.btn_Weiter.UseVisualStyleBackColor = true;
            this.btn_Weiter.Click += new System.EventHandler(this.btn_Weiter_Click);
            // 
            // checkAlleTermine
            // 
            this.checkAlleTermine.AutoSize = true;
            this.checkAlleTermine.Checked = true;
            this.checkAlleTermine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAlleTermine.Location = new System.Drawing.Point(21, 63);
            this.checkAlleTermine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkAlleTermine.Name = "checkAlleTermine";
            this.checkAlleTermine.Size = new System.Drawing.Size(163, 20);
            this.checkAlleTermine.TabIndex = 24;
            this.checkAlleTermine.Text = "Alle Termine anzeigen";
            this.checkAlleTermine.UseVisualStyleBackColor = true;
            this.checkAlleTermine.CheckedChanged += new System.EventHandler(this.checkAlleTermine_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 315);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "(Doppelklick auf Termin \r\nfür weitere Optionen)\r\n";
            // 
            // ArztOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 422);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkAlleTermine);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.lbl_Seitenanzahl);
            this.Controls.Add(this.btn_Zurueck);
            this.Controls.Add(this.btn_Weiter);
            this.Controls.Add(this.btn_PatientenAnsehen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tblTermine);
            this.Controls.Add(this.cal_Arzt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Name);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ArztOverviewForm";
            this.Text = "Startseite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArztOverviewForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar cal_Arzt;
        private System.Windows.Forms.TableLayoutPanel tblTermine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_PatientenAnsehen;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lbl_Seitenanzahl;
        private System.Windows.Forms.Button btn_Zurueck;
        private System.Windows.Forms.Button btn_Weiter;
        private System.Windows.Forms.CheckBox checkAlleTermine;
        private System.Windows.Forms.Label label2;
    }
}