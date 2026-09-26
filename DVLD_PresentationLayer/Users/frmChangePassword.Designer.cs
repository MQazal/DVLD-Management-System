namespace DVLD_PresentationLayer
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.txbxCurrentPassword = new System.Windows.Forms.TextBox();
            this.pcbxPass1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbxNewPassword = new System.Windows.Forms.TextBox();
            this.pcbxPass2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.pcbxPass3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlUserInformation = new DVLD_PresentationLayer.ctrlUserInformation();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxPass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxPass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxPass3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // txbxCurrentPassword
            // 
            this.txbxCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxCurrentPassword.Location = new System.Drawing.Point(278, 486);
            this.txbxCurrentPassword.MaxLength = 20;
            this.txbxCurrentPassword.Name = "txbxCurrentPassword";
            this.txbxCurrentPassword.PasswordChar = '*';
            this.txbxCurrentPassword.Size = new System.Drawing.Size(231, 28);
            this.txbxCurrentPassword.TabIndex = 10;
            this.txbxCurrentPassword.Leave += new System.EventHandler(this.txbxCurrentPassword_Leave);
            // 
            // pcbxPass1
            // 
            this.pcbxPass1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbxPass1.Location = new System.Drawing.Point(204, 489);
            this.pcbxPass1.Name = "pcbxPass1";
            this.pcbxPass1.Size = new System.Drawing.Size(39, 28);
            this.pcbxPass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxPass1.TabIndex = 9;
            this.pcbxPass1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Current Password:";
            // 
            // txbxNewPassword
            // 
            this.txbxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxNewPassword.Location = new System.Drawing.Point(753, 489);
            this.txbxNewPassword.MaxLength = 20;
            this.txbxNewPassword.Name = "txbxNewPassword";
            this.txbxNewPassword.PasswordChar = '*';
            this.txbxNewPassword.Size = new System.Drawing.Size(231, 28);
            this.txbxNewPassword.TabIndex = 13;
            this.txbxNewPassword.Leave += new System.EventHandler(this.txbxNewPassword_Leave);
            // 
            // pcbxPass2
            // 
            this.pcbxPass2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbxPass2.Location = new System.Drawing.Point(688, 489);
            this.pcbxPass2.Name = "pcbxPass2";
            this.pcbxPass2.Size = new System.Drawing.Size(39, 28);
            this.pcbxPass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxPass2.TabIndex = 12;
            this.pcbxPass2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "New Password:";
            // 
            // txbxConfirmPassword
            // 
            this.txbxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxConfirmPassword.Location = new System.Drawing.Point(278, 534);
            this.txbxConfirmPassword.MaxLength = 20;
            this.txbxConfirmPassword.Name = "txbxConfirmPassword";
            this.txbxConfirmPassword.PasswordChar = '*';
            this.txbxConfirmPassword.Size = new System.Drawing.Size(231, 28);
            this.txbxConfirmPassword.TabIndex = 16;
            this.txbxConfirmPassword.Leave += new System.EventHandler(this.txbxConfirmPassword_Leave);
            // 
            // pcbxPass3
            // 
            this.pcbxPass3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbxPass3.Location = new System.Drawing.Point(204, 534);
            this.pcbxPass3.Name = "pcbxPass3";
            this.pcbxPass3.Size = new System.Drawing.Size(39, 28);
            this.pcbxPass3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxPass3.TabIndex = 15;
            this.pcbxPass3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Confirm Password:";
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(800, 540);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 50);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(962, 539);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 51);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlUserInformation
            // 
            this.ctrlUserInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlUserInformation.Location = new System.Drawing.Point(0, 0);
            this.ctrlUserInformation.Name = "ctrlUserInformation";
            this.ctrlUserInformation.Size = new System.Drawing.Size(1152, 472);
            this.ctrlUserInformation.TabIndex = 19;
            // 
            // frmChangePassword
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1152, 600);
            this.Controls.Add(this.ctrlUserInformation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbxConfirmPassword);
            this.Controls.Add(this.pcbxPass3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbxNewPassword);
            this.Controls.Add(this.pcbxPass2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbxCurrentPassword);
            this.Controls.Add(this.pcbxPass1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxPass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxPass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxPass3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbxCurrentPassword;
        private System.Windows.Forms.PictureBox pcbxPass1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbxNewPassword;
        private System.Windows.Forms.PictureBox pcbxPass2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxConfirmPassword;
        private System.Windows.Forms.PictureBox pcbxPass3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private ctrlUserInformation ctrlUserInformation;
    }
}