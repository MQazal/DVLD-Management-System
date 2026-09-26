namespace DVLD_PresentationLayer.Licenses.Local_Driving_License
{
    partial class frmShowLocalDrivingLicenseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowLocalDrivingLicenseInfo));
            this.btnClose = new System.Windows.Forms.Button();
            this.pcbxIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pcbxTitleImage = new System.Windows.Forms.PictureBox();
            this.ctrlLocalDrivingLicenseInfo = new DVLD_PresentationLayer.Licenses.Local_Driving_License.Controls.ctrlLocalDrivingLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxTitleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1219, 524);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 50);
            this.btnClose.TabIndex = 180;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pcbxIcon
            // 
            this.pcbxIcon.Location = new System.Drawing.Point(556, 22);
            this.pcbxIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcbxIcon.Name = "pcbxIcon";
            this.pcbxIcon.Size = new System.Drawing.Size(41, 37);
            this.pcbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxIcon.TabIndex = 194;
            this.pcbxIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(362, 153);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(546, 39);
            this.lblTitle.TabIndex = 193;
            this.lblTitle.Text = "Driver Local License Info";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbxTitleImage
            // 
            this.pcbxTitleImage.InitialImage = null;
            this.pcbxTitleImage.Location = new System.Drawing.Point(556, 22);
            this.pcbxTitleImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcbxTitleImage.Name = "pcbxTitleImage";
            this.pcbxTitleImage.Size = new System.Drawing.Size(167, 126);
            this.pcbxTitleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxTitleImage.TabIndex = 192;
            this.pcbxTitleImage.TabStop = false;
            // 
            // ctrlLocalDrivingLicenseInfo
            // 
            this.ctrlLocalDrivingLicenseInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlLocalDrivingLicenseInfo.Location = new System.Drawing.Point(0, 195);
            this.ctrlLocalDrivingLicenseInfo.Name = "ctrlLocalDrivingLicenseInfo";
            this.ctrlLocalDrivingLicenseInfo.Size = new System.Drawing.Size(1425, 391);
            this.ctrlLocalDrivingLicenseInfo.TabIndex = 181;
            // 
            // frmShowLocalDrivingLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 586);
            this.Controls.Add(this.pcbxIcon);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pcbxTitleImage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlLocalDrivingLicenseInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowLocalDrivingLicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving License Info";
            this.Load += new System.EventHandler(this.frmShowLocalDrivingLicenseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxTitleImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private Controls.ctrlLocalDrivingLicenseInfo ctrlLocalDrivingLicenseInfo;
        private System.Windows.Forms.PictureBox pcbxIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pcbxTitleImage;
    }
}