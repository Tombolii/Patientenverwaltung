namespace Patientenverwaltung.Gui
{
    partial class Bericht
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
            this.btn_BerichtHinzufuegen = new System.Windows.Forms.Button();
            this.btn_Startseite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Seitenzahl
            // 
            this.lbl_Seitenzahl.AutoSize = true;
            this.lbl_Seitenzahl.Location = new System.Drawing.Point(1228, 508);
            this.lbl_Seitenzahl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Seitenzahl.Name = "lbl_Seitenzahl";
            this.lbl_Seitenzahl.Size = new System.Drawing.Size(69, 16);
            this.lbl_Seitenzahl.TabIndex = 26;
            this.lbl_Seitenzahl.Text = "Seitenzahl";
            // 
            // btn_Zurueck
            // 
            this.btn_Zurueck.Location = new System.Drawing.Point(1188, 503);
            this.btn_Zurueck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Zurueck.Name = "btn_Zurueck";
            this.btn_Zurueck.Size = new System.Drawing.Size(27, 25);
            this.btn_Zurueck.TabIndex = 25;
            this.btn_Zurueck.Text = "<";
            this.btn_Zurueck.UseVisualStyleBackColor = true;
            // 
            // btn_Weiter
            // 
            this.btn_Weiter.Location = new System.Drawing.Point(1321, 503);
            this.btn_Weiter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Weiter.Name = "btn_Weiter";
            this.btn_Weiter.Size = new System.Drawing.Size(27, 25);
            this.btn_Weiter.TabIndex = 24;
            this.btn_Weiter.Text = ">";
            this.btn_Weiter.UseVisualStyleBackColor = true;
            // 
            // txt_BerichtSuche
            // 
            this.txt_BerichtSuche.Location = new System.Drawing.Point(1200, 89);
            this.txt_BerichtSuche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_BerichtSuche.Name = "txt_BerichtSuche";
            this.txt_BerichtSuche.Size = new System.Drawing.Size(147, 22);
            this.txt_BerichtSuche.TabIndex = 22;
            // 
            // btn_BerichtSuchen
            // 
            this.btn_BerichtSuchen.Location = new System.Drawing.Point(1200, 53);
            this.btn_BerichtSuchen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_BerichtSuchen.Name = "btn_BerichtSuchen";
            this.btn_BerichtSuchen.Size = new System.Drawing.Size(148, 28);
            this.btn_BerichtSuchen.TabIndex = 21;
            this.btn_BerichtSuchen.Text = "Bericht suchen";
            this.btn_BerichtSuchen.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(912, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Bemerkungen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Beschwerden";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(709, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Diagnose";
            // 
            // tbl_Berichte
            // 
            this.tbl_Berichte.ColumnCount = 5;
            this.tbl_Berichte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Berichte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Berichte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Berichte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Berichte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Berichte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Berichte.Location = new System.Drawing.Point(15, 36);
            this.tbl_Berichte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbl_Berichte.Name = "tbl_Berichte";
            this.tbl_Berichte.RowCount = 20;
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbl_Berichte.Size = new System.Drawing.Size(1033, 492);
            this.tbl_Berichte.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Uhrzeit";
            // 
            // btn_BerichtHinzufuegen
            // 
            this.btn_BerichtHinzufuegen.Location = new System.Drawing.Point(1200, 121);
            this.btn_BerichtHinzufuegen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_BerichtHinzufuegen.Name = "btn_BerichtHinzufuegen";
            this.btn_BerichtHinzufuegen.Size = new System.Drawing.Size(148, 28);
            this.btn_BerichtHinzufuegen.TabIndex = 27;
            this.btn_BerichtHinzufuegen.Text = "Bericht hinzufügen";
            this.btn_BerichtHinzufuegen.UseVisualStyleBackColor = true;
            // 
            // btn_Startseite
            // 
            this.btn_Startseite.Location = new System.Drawing.Point(1163, 15);
            this.btn_Startseite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Startseite.Name = "btn_Startseite";
            this.btn_Startseite.Size = new System.Drawing.Size(185, 28);
            this.btn_Startseite.TabIndex = 28;
            this.btn_Startseite.Text = "Zurück zu Patienten";
            this.btn_Startseite.UseVisualStyleBackColor = true;
            // 
            // Bericht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 554);
            this.Controls.Add(this.btn_Startseite);
            this.Controls.Add(this.btn_BerichtHinzufuegen);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bericht";
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
        private System.Windows.Forms.Button btn_BerichtHinzufuegen;
        private System.Windows.Forms.Button btn_Startseite;
    }
}