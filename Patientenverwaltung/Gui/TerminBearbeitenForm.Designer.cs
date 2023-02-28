namespace Patientenverwaltung.Gui
{
    partial class TerminBearbeitenForm
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
            this.btn_AenderungUebernehmen = new System.Windows.Forms.Button();
            this.txt_Uhrzeit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Datum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(221, 69);
            this.btn_Abbrechen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(137, 28);
            this.btn_Abbrechen.TabIndex = 116;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // btn_AenderungUebernehmen
            // 
            this.btn_AenderungUebernehmen.Location = new System.Drawing.Point(16, 69);
            this.btn_AenderungUebernehmen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AenderungUebernehmen.Name = "btn_AenderungUebernehmen";
            this.btn_AenderungUebernehmen.Size = new System.Drawing.Size(187, 28);
            this.btn_AenderungUebernehmen.TabIndex = 115;
            this.btn_AenderungUebernehmen.Text = "Änderung übernehmen";
            this.btn_AenderungUebernehmen.UseVisualStyleBackColor = true;
            this.btn_AenderungUebernehmen.Click += new System.EventHandler(this.btn_AenderungUebernehmen_Click);
            // 
            // txt_Uhrzeit
            // 
            this.txt_Uhrzeit.Location = new System.Drawing.Point(284, 17);
            this.txt_Uhrzeit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Uhrzeit.Name = "txt_Uhrzeit";
            this.txt_Uhrzeit.Size = new System.Drawing.Size(132, 22);
            this.txt_Uhrzeit.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 108;
            this.label3.Text = "Uhrzeit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 107;
            this.label4.Text = "Datum";
            // 
            // txt_Datum
            // 
            this.txt_Datum.Location = new System.Drawing.Point(68, 17);
            this.txt_Datum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Datum.Name = "txt_Datum";
            this.txt_Datum.Size = new System.Drawing.Size(132, 22);
            this.txt_Datum.TabIndex = 106;
            // 
            // TerminBearbeitenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 129);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.btn_AenderungUebernehmen);
            this.Controls.Add(this.txt_Uhrzeit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Datum);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TerminBearbeitenForm";
            this.Text = "TerminBearbeiten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Abbrechen;
        private System.Windows.Forms.Button btn_AenderungUebernehmen;
        private System.Windows.Forms.TextBox txt_Uhrzeit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Datum;
    }
}