namespace DVLD_PresentationLayer
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panLogin = new System.Windows.Forms.Panel();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chcbxRememberMe = new System.Windows.Forms.CheckBox();
            this.txbxPassword = new System.Windows.Forms.TextBox();
            this.txbxUsername = new System.Windows.Forms.TextBox();
            this.pcbxPassword = new System.Windows.Forms.PictureBox();
            this.pcbxUsername = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbxImage = new System.Windows.Forms.PictureBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // panLogin
            // 
            this.panLogin.Controls.Add(this.btnShowPassword);
            this.panLogin.Controls.Add(this.label4);
            this.panLogin.Controls.Add(this.btnLogin);
            this.panLogin.Controls.Add(this.chcbxRememberMe);
            this.panLogin.Controls.Add(this.txbxPassword);
            this.panLogin.Controls.Add(this.txbxUsername);
            this.panLogin.Controls.Add(this.pcbxPassword);
            this.panLogin.Controls.Add(this.pcbxUsername);
            this.panLogin.Controls.Add(this.label3);
            this.panLogin.Controls.Add(this.label2);
            this.panLogin.Controls.Add(this.label1);
            this.panLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panLogin.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panLogin.Location = new System.Drawing.Point(0, 0);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(1166, 538);
            this.panLogin.TabIndex = 0;
            this.panLogin.Tag = "1";
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPassword.Image")));
            this.btnShowPassword.Location = new System.Drawing.Point(1098, 337);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(56, 46);
            this.btnShowPassword.TabIndex = 2;
            this.btnShowPassword.Tag = "1";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(735, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 156);
            this.label4.TabIndex = 11;
            this.label4.Text = "WELCOME TO\r\nDRIVING VEHICLE\r\nLICENSE DEPARTMENT\r\n(DVLD) SYSTEM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Location = new System.Drawing.Point(876, 459);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 56);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chcbxRememberMe
            // 
            this.chcbxRememberMe.AutoSize = true;
            this.chcbxRememberMe.Location = new System.Drawing.Point(757, 407);
            this.chcbxRememberMe.Name = "chcbxRememberMe";
            this.chcbxRememberMe.Size = new System.Drawing.Size(172, 31);
            this.chcbxRememberMe.TabIndex = 9;
            this.chcbxRememberMe.Text = "Remember Me";
            this.chcbxRememberMe.UseVisualStyleBackColor = true;
            this.chcbxRememberMe.CheckedChanged += new System.EventHandler(this.chcbxRememberMe_CheckedChanged);
            // 
            // txbxPassword
            // 
            this.txbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxPassword.Location = new System.Drawing.Point(816, 337);
            this.txbxPassword.MaxLength = 8;
            this.txbxPassword.Name = "txbxPassword";
            this.txbxPassword.PasswordChar = '*';
            this.txbxPassword.Size = new System.Drawing.Size(276, 34);
            this.txbxPassword.TabIndex = 21;
            this.txbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbxPassword.Leave += new System.EventHandler(this.txbxPassword_Leave);
            // 
            // txbxUsername
            // 
            this.txbxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxUsername.Location = new System.Drawing.Point(816, 275);
            this.txbxUsername.MaxLength = 20;
            this.txbxUsername.Name = "txbxUsername";
            this.txbxUsername.Size = new System.Drawing.Size(276, 34);
            this.txbxUsername.TabIndex = 20;
            this.txbxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbxUsername.Leave += new System.EventHandler(this.txbxPassword_Leave);
            // 
            // pcbxPassword
            // 
            this.pcbxPassword.Location = new System.Drawing.Point(757, 337);
            this.pcbxPassword.Name = "pcbxPassword";
            this.pcbxPassword.Size = new System.Drawing.Size(33, 30);
            this.pcbxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxPassword.TabIndex = 6;
            this.pcbxPassword.TabStop = false;
            // 
            // pcbxUsername
            // 
            this.pcbxUsername.Location = new System.Drawing.Point(757, 281);
            this.pcbxUsername.Name = "pcbxUsername";
            this.pcbxUsername.Size = new System.Drawing.Size(33, 28);
            this.pcbxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxUsername.TabIndex = 5;
            this.pcbxUsername.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(843, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login to your Account";
            // 
            // pcbxImage
            // 
            this.pcbxImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbxImage.Location = new System.Drawing.Point(0, 0);
            this.pcbxImage.Name = "pcbxImage";
            this.pcbxImage.Size = new System.Drawing.Size(622, 538);
            this.pcbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxImage.TabIndex = 1;
            this.pcbxImage.TabStop = false;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 538);
            this.Controls.Add(this.pcbxImage);
            this.Controls.Add(this.panLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.PictureBox pcbxImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbxPassword;
        private System.Windows.Forms.PictureBox pcbxUsername;
        private System.Windows.Forms.TextBox txbxPassword;
        private System.Windows.Forms.TextBox txbxUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chcbxRememberMe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.Button btnShowPassword;
    }
}