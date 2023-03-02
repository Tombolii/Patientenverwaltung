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
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Beschwerden = new System.Windows.Forms.RichTextBox();
            this.txt_Bemerkungen = new System.Windows.Forms.RichTextBox();
            this.lbl_Vorerkrankungen = new System.Windows.Forms.Label();
            this.boxDiagnose = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_BerhichtHinzufuegen
            // 
            this.btn_BerhichtHinzufuegen.Location = new System.Drawing.Point(13, 226);
            this.btn_BerhichtHinzufuegen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BerhichtHinzufuegen.Name = "btn_BerhichtHinzufuegen";
            this.btn_BerhichtHinzufuegen.Size = new System.Drawing.Size(137, 28);
            this.btn_BerhichtHinzufuegen.TabIndex = 34;
            this.btn_BerhichtHinzufuegen.Text = "Bericht hinzufügen";
            this.btn_BerhichtHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_BerhichtHinzufuegen.Click += new System.EventHandler(this.btn_BerhichtHinzufuegen_Click);
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(158, 226);
            this.btn_Abbrechen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(137, 28);
            this.btn_Abbrechen.TabIndex = 35;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Bemerkungen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "Beschwerden";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(657, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "Diagnose";
            // 
            // txt_Beschwerden
            // 
            this.txt_Beschwerden.Location = new System.Drawing.Point(13, 29);
            this.txt_Beschwerden.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Beschwerden.Name = "txt_Beschwerden";
            this.txt_Beschwerden.Size = new System.Drawing.Size(296, 179);
            this.txt_Beschwerden.TabIndex = 39;
            this.txt_Beschwerden.Text = "";
            // 
            // txt_Bemerkungen
            // 
            this.txt_Bemerkungen.Location = new System.Drawing.Point(338, 29);
            this.txt_Bemerkungen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Bemerkungen.Name = "txt_Bemerkungen";
            this.txt_Bemerkungen.Size = new System.Drawing.Size(296, 179);
            this.txt_Bemerkungen.TabIndex = 40;
            this.txt_Bemerkungen.Text = "";
            // 
            // lbl_Vorerkrankungen
            // 
            this.lbl_Vorerkrankungen.AutoSize = true;
            this.lbl_Vorerkrankungen.Location = new System.Drawing.Point(588, 53);
            this.lbl_Vorerkrankungen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Vorerkrankungen.Name = "lbl_Vorerkrankungen";
            this.lbl_Vorerkrankungen.Size = new System.Drawing.Size(0, 16);
            this.lbl_Vorerkrankungen.TabIndex = 42;
            // 
            // boxDiagnose
            // 
            this.boxDiagnose.Location = new System.Drawing.Point(660, 29);
            this.boxDiagnose.Margin = new System.Windows.Forms.Padding(4);
            this.boxDiagnose.Name = "boxDiagnose";
            this.boxDiagnose.Size = new System.Drawing.Size(296, 24);
            this.boxDiagnose.TabIndex = 63;
            this.boxDiagnose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // NeuerBerichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 292);
            this.Controls.Add(this.boxDiagnose);
            this.Controls.Add(this.lbl_Vorerkrankungen);
            this.Controls.Add(this.txt_Bemerkungen);
            this.Controls.Add(this.txt_Beschwerden);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.btn_BerhichtHinzufuegen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NeuerBerichtForm";
            this.Text = "Neuen Bericht anlegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BerhichtHinzufuegen;
        private System.Windows.Forms.Button btn_Abbrechen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txt_Beschwerden;
        private System.Windows.Forms.RichTextBox txt_Bemerkungen;
        private System.Windows.Forms.Label lbl_Vorerkrankungen;
        private System.Windows.Forms.ComboBox boxDiagnose;
    }
}