namespace DVLD_PresentationLayer.Licenses.Local_Driving_License
{
    partial class frmShowLicenseHistoryOfPerson
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
            this.pcbxTitleImage = new System.Windows.Forms.PictureBox();
            this.ctrlDriverLicenses = new DVLD_PresentationLayer.Licenses.Local_Driving_License.Controls.ctrlDriverLicenses();
            this.ctrlFindPerson = new DVLD_PresentationLayer.ctrlFindPerson();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxTitleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxTitleImage
            // 
            this.pcbxTitleImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbxTitleImage.Location = new System.Drawing.Point(1171, 12);
            this.pcbxTitleImage.Name = "pcbxTitleImage";
            this.pcbxTitleImage.Size = new System.Drawing.Size(193, 199);
            this.pcbxTitleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxTitleImage.TabIndex = 1;
            this.pcbxTitleImage.TabStop = false;
            // 
            // ctrlDriverLicenses
            // 
            this.ctrlDriverLicenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlDriverLicenses.Location = new System.Drawing.Point(0, 453);
            this.ctrlDriverLicenses.Name = "ctrlDriverLicenses";
            this.ctrlDriverLicenses.Size = new System.Drawing.Size(1220, 389);
            this.ctrlDriverLicenses.TabIndex = 2;
            // 
            // ctrlFindPerson
            // 
            this.ctrlFindPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlFindPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlFindPerson.Location = new System.Drawing.Point(0, 0);
            this.ctrlFindPerson.Name = "ctrlFindPerson";
            this.ctrlFindPerson.Size = new System.Drawing.Size(1376, 454);
            this.ctrlFindPerson.TabIndex = 0;
            // 
            // frmShowLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 835);
            this.Controls.Add(this.ctrlDriverLicenses);
            this.Controls.Add(this.pcbxTitleImage);
            this.Controls.Add(this.ctrlFindPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowLicenseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License History";
            this.Load += new System.EventHandler(this.frmShowLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxTitleImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlFindPerson ctrlFindPerson;
        private System.Windows.Forms.PictureBox pcbxTitleImage;
        private Controls.ctrlDriverLicenses ctrlDriverLicenses;
    }
}