namespace Patientenverwaltung.Gui
{
    partial class BerichtOverviewForm
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
            this.lbl_Seitenzahl = new System.Windows.Forms.Label();
            this.btn_Zurueck = new System.Windows.Forms.Button();
            this.btn_Weiter = new System.Windows.Forms.Button();
            this.txt_BerichtSuche = new System.Windows.Forms.TextBox();
            this.btn_BerichtSuchen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbl_Berichte = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ToPatientenDaten = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Seitenzahl
            // 
            this.lbl_Seitenzahl.AutoSize = true;
            this.lbl_Seitenzahl.Location = new System.Drawing.Point(926, 201);
            this.lbl_Seitenzahl.Name = "lbl_Seitenzahl";
            this.lbl_Seitenzahl.Size = new System.Drawing.Size(31, 13);
            this.lbl_Seitenzahl.TabIndex = 26;
            this.lbl_Seitenzahl.Text = "Seite";
            // 
            // btn_Zurueck
            // 
            this.btn_Zurueck.Location = new System.Drawing.Point(900, 197);
            this.btn_Zurueck.Name = "btn_Zurueck";
            this.btn_Zurueck.Size = new System.Drawing.Size(20, 20);
            this.btn_Zurueck.TabIndex = 25;
            this.btn_Zurueck.Text = "<";
            this.btn_Zurueck.UseVisualStyleBackColor = true;
            this.btn_Zurueck.Click += new System.EventHandler(this.btn_Zurueck_Click);
            // 
            // btn_Weiter
            // 
            this.btn_Weiter.Location = new System.Drawing.Point(991, 197);
            this.btn_Weiter.Name = "btn_Weiter";
            this.btn_Weiter.Size = new System.Drawing.Size(20, 20);
            this.btn_Weiter.TabIndex = 24;
            this.btn_Weiter.Text = ">";
            this.btn_Weiter.UseVisualStyleBackColor = true;
            this.btn_Weiter.Click += new System.EventHandler(this.btn_Weiter_Click);
            // 
            // txt_BerichtSuche
            // 
            this.txt_BerichtSuche.Location = new System.Drawing.Point(900, 83);
            this.txt_BerichtSuche.Name = "txt_BerichtSuche";
            this.txt_BerichtSuche.Size = new System.Drawing.Size(111, 20);
            this.txt_BerichtSuche.TabIndex = 22;
            // 
            // btn_BerichtSuchen
            // 
            this.btn_BerichtSuchen.Location = new System.Drawing.Point(900, 109);
            this.btn_BerichtSuchen.Name = "btn_BerichtSuchen";
            this.btn_BerichtSuchen.Size = new System.Drawing.Size(111, 23);
            this.btn_BerichtSuchen.TabIndex = 21;
            this.btn_BerichtSuchen.Text = "Bericht suchen";
            this.btn_BerichtSuchen.UseVisualStyleBackColor = true;
            this.btn_BerichtSuchen.Click += new System.EventHandler(this.btn_BerichtSuchen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Bemerkungen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Beschwerden";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Diagnose";
            // 
            // tbl_Berichte
            // 
            this.tbl_Berichte.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tbl_Berichte.ColumnCount = 5;
            this.tbl_Berichte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Berichte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Berichte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Berichte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Berichte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Berichte.Location = new System.Drawing.Point(11, 29);
            this.tbl_Berichte.Name = "tbl_Berichte";
            this.tbl_Berichte.RowCount = 10;
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Berichte.Size = new System.Drawing.Size(775, 185);
            this.tbl_Berichte.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Uhrzeit";
            // 
            // btn_ToPatientenDaten
            // 
            this.btn_ToPatientenDaten.Location = new System.Drawing.Point(900, 12);
            this.btn_ToPatientenDaten.Name = "btn_ToPatientenDaten";
            this.btn_ToPatientenDaten.Size = new System.Drawing.Size(111, 23);
            this.btn_ToPatientenDaten.TabIndex = 28;
            this.btn_ToPatientenDaten.Text = "Zurück zu Patient";
            this.btn_ToPatientenDaten.UseVisualStyleBackColor = true;
            this.btn_ToPatientenDaten.Click += new System.EventHandler(this.btn_ToPatientenDaten_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(897, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Datum";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(963, 201);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(13, 13);
            this.lblPage.TabIndex = 30;
            this.lblPage.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(963, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "1";
            // 
            // BerichtOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 233);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_ToPatientenDaten);
            this.Controls.Add(this.lbl_Seitenzahl);
            this.Controls.Add(this.btn_Zurueck);
            this.Controls.Add(this.btn_Weiter);
            this.Controls.Add(this.txt_BerichtSuche);
            this.Controls.Add(this.btn_BerichtSuchen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbl_Berichte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BerichtOverviewForm";
            this.Text = "Bericht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Seitenzahl;
        private System.Windows.Forms.Button btn_Zurueck;
        private System.Windows.Forms.Button btn_Weiter;
        private System.Windows.Forms.TextBox txt_BerichtSuche;
        private System.Windows.Forms.Button btn_BerichtSuchen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tbl_Berichte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ToPatientenDaten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label label8;
    }
}