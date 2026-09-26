namespace DVLD_PresentationLayer.Licenses.International_Licenses
{
    partial class frmShowInternationalDrivingLicenseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowInternationalDrivingLicenseInfo));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pcbxTitleImage = new System.Windows.Forms.PictureBox();
            this.pcbxIcon = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlInternationalDriverLicenseInfo = new DVLD_PresentationLayer.Licenses.International_Licenses.Controls.ctrlInternationalDriverLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxTitleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(257, 139);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(546, 39);
            this.lblTitle.TabIndex = 140;
            this.lblTitle.Text = "Driver International License Info";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbxTitleImage
            // 
            this.pcbxTitleImage.InitialImage = null;
            this.pcbxTitleImage.Location = new System.Drawing.Point(447, 8);
            this.pcbxTitleImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcbxTitleImage.Name = "pcbxTitleImage";
            this.pcbxTitleImage.Size = new System.Drawing.Size(167, 126);
            this.pcbxTitleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxTitleImage.TabIndex = 139;
            this.pcbxTitleImage.TabStop = false;
            // 
            // pcbxIcon
            // 
            this.pcbxIcon.Location = new System.Drawing.Point(447, 8);
            this.pcbxIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcbxIcon.Name = "pcbxIcon";
            this.pcbxIcon.Size = new System.Drawing.Size(40, 35);
            this.pcbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxIcon.TabIndex = 191;
            this.pcbxIcon.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(977, 439);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 50);
            this.btnClose.TabIndex = 192;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlInternationalDriverLicenseInfo
            // 
            this.ctrlInternationalDriverLicenseInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlInternationalDriverLicenseInfo.Location = new System.Drawing.Point(0, 181);
            this.ctrlInternationalDriverLicenseInfo.Name = "ctrlInternationalDriverLicenseInfo";
            this.ctrlInternationalDriverLicenseInfo.Size = new System.Drawing.Size(1144, 347);
            this.ctrlInternationalDriverLicenseInfo.TabIndex = 0;
            // 
            // frmShowInternationalDrivingLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 528);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pcbxIcon);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pcbxTitleImage);
            this.Controls.Add(this.ctrlInternationalDriverLicenseInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowInternationalDrivingLicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show International License Info";
            this.Load += new System.EventHandler(this.frmShowInternationalLicenseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxTitleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlInternationalDriverLicenseInfo ctrlInternationalDriverLicenseInfo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pcbxTitleImage;
        private System.Windows.Forms.PictureBox pcbxIcon;
        private System.Windows.Forms.Button btnClose;
    }
}