namespace DVLD_PresentationLayer.Applications.Local_License_Applications
{
    partial class frmShowLocalDrivingLicenseApplication
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
            this.ctrlLocalDrivingLicenseApplicationInfomration = new DVLD_PresentationLayer.Applications.Local_License_Applications.ctrlLocalDrivingLicenseApplicationInfomration();
            this.SuspendLayout();
            // 
            // ctrlLocalDrivingLicenseApplicationInfomration
            // 
            this.ctrlLocalDrivingLicenseApplicationInfomration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlLocalDrivingLicenseApplicationInfomration.Location = new System.Drawing.Point(0, 0);
            this.ctrlLocalDrivingLicenseApplicationInfomration.Name = "ctrlLocalDrivingLicenseApplicationInfomration";
            this.ctrlLocalDrivingLicenseApplicationInfomration.Size = new System.Drawing.Size(857, 419);
            this.ctrlLocalDrivingLicenseApplicationInfomration.TabIndex = 0;
            // 
            // frmShowLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 419);
            this.Controls.Add(this.ctrlLocalDrivingLicenseApplicationInfomration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving License Application";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlLocalDrivingLicenseApplicationInfomration ctrlLocalDrivingLicenseApplicationInfomration;
    }
}