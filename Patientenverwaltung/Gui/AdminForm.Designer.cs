namespace Patientenverwaltung.Gui
{
    partial class AdminForm
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
            this.txt_arztID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Passwort = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_titel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Fachgebiet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_arztID
            // 
            this.txt_arztID.Location = new System.Drawing.Point(71, 49);
            this.txt_arztID.Name = "txt_arztID";
            this.txt_arztID.Size = new System.Drawing.Size(100, 20);
            this.txt_arztID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arzt ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Passwort";
            // 
            // txt_Passwort
            // 
            this.txt_Passwort.Location = new System.Drawing.Point(270, 52);
            this.txt_Passwort.Name = "txt_Passwort";
            this.txt_Passwort.Size = new System.Drawing.Size(100, 20);
            this.txt_Passwort.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 116);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Hinzufügen";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(96, 116);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Abbrechen";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Titel";
            // 
            // txt_titel
            // 
            this.txt_titel.Location = new System.Drawing.Point(71, 22);
            this.txt_titel.Name = "txt_titel";
            this.txt_titel.Size = new System.Drawing.Size(100, 20);
            this.txt_titel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fachgebiet ID";
            // 
            // txt_Fachgebiet
            // 
            this.txt_Fachgebiet.Location = new System.Drawing.Point(270, 29);
            this.txt_Fachgebiet.Name = "txt_Fachgebiet";
            this.txt_Fachgebiet.Size = new System.Drawing.Size(100, 20);
            this.txt_Fachgebiet.TabIndex = 8;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 157);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Fachgebiet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_titel);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Passwort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_arztID);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_arztID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Passwort;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_titel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Fachgebiet;
    }
}