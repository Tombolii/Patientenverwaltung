namespace Patientenverwaltung.Gui
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.lblArztId = new System.Windows.Forms.Label();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.txtArztId = new System.Windows.Forms.TextBox();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArztId
            // 
            this.lblArztId.AutoSize = true;
            this.lblArztId.Location = new System.Drawing.Point(30, 30);
            this.lblArztId.Name = "lblArztId";
            this.lblArztId.Size = new System.Drawing.Size(43, 16);
            this.lblArztId.TabIndex = 0;
            this.lblArztId.Text = "ArztId:";
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Location = new System.Drawing.Point(30, 60);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(65, 16);
            this.lblPasswort.TabIndex = 1;
            this.lblPasswort.Text = "Passwort:";
            // 
            // txtArztId
            // 
            this.txtArztId.Location = new System.Drawing.Point(120, 30);
            this.txtArztId.Name = "txtArztId";
            this.txtArztId.Size = new System.Drawing.Size(150, 22);
            this.txtArztId.TabIndex = 2;
            // 
            // txtPasswort
            // 
            this.txtPasswort.Location = new System.Drawing.Point(120, 60);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.PasswordChar = '*';
            this.txtPasswort.Size = new System.Drawing.Size(150, 22);
            this.txtPasswort.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(120, 90);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(98, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Anmelden";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(120, 119);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(98, 26);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "Admin-Login";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(276, 157);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.txtArztId);
            this.Controls.Add(this.lblPasswort);
            this.Controls.Add(this.lblArztId);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
    }
}