namespace Patientenverwaltung.Gui
{
    partial class BerichtBearbeitenForm
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
            this.boxDiagnose = new System.Windows.Forms.ComboBox();
            this.txt_Bemerkungen = new System.Windows.Forms.RichTextBox();
            this.txt_Beschwerden = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.btn_AenderungUebernehmen = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_Vorerkrankungen = new System.Windows.Forms.Label();
            this.txtUhrzeit = new System.Windows.Forms.TextBox();
            this.lblUhrzeit = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boxDiagnose
            // 
            this.boxDiagnose.Location = new System.Drawing.Point(693, 123);
            this.boxDiagnose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxDiagnose.Name = "boxDiagnose";
            this.boxDiagnose.Size = new System.Drawing.Size(296, 24);
            this.boxDiagnose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxDiagnose.TabIndex = 62;
            // 
            // txt_Bemerkungen
            // 
            this.txt_Bemerkungen.Location = new System.Drawing.Point(355, 123);
            this.txt_Bemerkungen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Bemerkungen.Name = "txt_Bemerkungen";
            this.txt_Bemerkungen.Size = new System.Drawing.Size(296, 179);
            this.txt_Bemerkungen.TabIndex = 61;
            this.txt_Bemerkungen.Text = "";
            // 
            // txt_Beschwerden
            // 
            this.txt_Beschwerden.Location = new System.Drawing.Point(16, 123);
            this.txt_Beschwerden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Beschwerden.Name = "txt_Beschwerden";
            this.txt_Beschwerden.Size = new System.Drawing.Size(296, 179);
            this.txt_Beschwerden.TabIndex = 60;
            this.txt_Beschwerden.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 59;
            this.label8.Text = "Bemerkungen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 103);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 58;
            this.label9.Text = "Beschwerden";
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(196, 336);
            this.btn_Abbrechen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(137, 28);
            this.btn_Abbrechen.TabIndex = 57;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // btn_AenderungUebernehmen
            // 
            this.btn_AenderungUebernehmen.Location = new System.Drawing.Point(16, 336);
            this.btn_AenderungUebernehmen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AenderungUebernehmen.Name = "btn_AenderungUebernehmen";
            this.btn_AenderungUebernehmen.Size = new System.Drawing.Size(172, 28);
            this.btn_AenderungUebernehmen.TabIndex = 56;
            this.btn_AenderungUebernehmen.Text = "Änderung übernehmen";
            this.btn_AenderungUebernehmen.UseVisualStyleBackColor = true;
            this.btn_AenderungUebernehmen.Click += new System.EventHandler(this.btn_AenderungUebernehmen_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(711, 103);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 83;
            this.label10.Text = "Diagnose";
            // 
            // lbl_Vorerkrankungen
            // 
            this.lbl_Vorerkrankungen.AutoSize = true;
            this.lbl_Vorerkrankungen.Location = new System.Drawing.Point(588, 53);
            this.lbl_Vorerkrankungen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Vorerkrankungen.Name = "lbl_Vorerkrankungen";
            this.lbl_Vorerkrankungen.Size = new System.Drawing.Size(0, 16);
            this.lbl_Vorerkrankungen.TabIndex = 84;
            // 
            // txtUhrzeit
            // 
            this.txtUhrzeit.Enabled = false;
            this.txtUhrzeit.Location = new System.Drawing.Point(385, 21);
            this.txtUhrzeit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtUhrzeit.Name = "txtUhrzeit";
            this.txtUhrzeit.Size = new System.Drawing.Size(196, 22);
            this.txtUhrzeit.TabIndex = 88;
            // 
            // lblUhrzeit
            // 
            this.lblUhrzeit.AutoSize = true;
            this.lblUhrzeit.Location = new System.Drawing.Point(321, 25);
            this.lblUhrzeit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUhrzeit.Name = "lblUhrzeit";
            this.lblUhrzeit.Size = new System.Drawing.Size(48, 16);
            this.lblUhrzeit.TabIndex = 87;
            this.lblUhrzeit.Text = "Uhrzeit";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(20, 25);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(46, 16);
            this.lblDatum.TabIndex = 86;
            this.lblDatum.Text = "Datum";
            // 
            // txtDatum
            // 
            this.txtDatum.Enabled = false;
            this.txtDatum.Location = new System.Drawing.Point(99, 21);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(196, 22);
            this.txtDatum.TabIndex = 85;
            // 
            // BerichtBearbeitenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 377);
            this.Controls.Add(this.txtUhrzeit);
            this.Controls.Add(this.lblUhrzeit);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.lbl_Vorerkrankungen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.boxDiagnose);
            this.Controls.Add(this.txt_Bemerkungen);
            this.Controls.Add(this.txt_Beschwerden);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.btn_AenderungUebernehmen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BerichtBearbeitenForm";
            this.Text = "BerichtBearbeiten";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox boxDiagnose;
    private System.Windows.Forms.RichTextBox txt_Bemerkungen;
    private System.Windows.Forms.RichTextBox txt_Beschwerden;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Button btn_Abbrechen;
    private System.Windows.Forms.Button btn_AenderungUebernehmen;
    private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_Vorerkrankungen;
        private System.Windows.Forms.TextBox txtUhrzeit;
        private System.Windows.Forms.Label lblUhrzeit;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtDatum;
    }
}