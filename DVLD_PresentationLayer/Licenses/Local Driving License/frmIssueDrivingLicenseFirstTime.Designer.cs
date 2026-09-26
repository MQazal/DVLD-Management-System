namespace DVLD_PresentationLayer.Licenses.Local_Driving_License
{
    partial class frmIssueDrivingLicenseFirstTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueDrivingLicenseFirstTime));
            this.pcbxNotes = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxNotes = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssueLicense = new System.Windows.Forms.Button();
            this.ctrlLocalDrivingLicenseApplicationInfomration = new DVLD_PresentationLayer.Applications.Local_License_Applications.ctrlLocalDrivingLicenseApplicationInfomration();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxNotes
            // 
            this.pcbxNotes.Location = new System.Drawing.Point(95, 441);
            this.pcbxNotes.Name = "pcbxNotes";
            this.pcbxNotes.Size = new System.Drawing.Size(31, 26);
            this.pcbxNotes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxNotes.TabIndex = 178;
            this.pcbxNotes.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 442);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 177;
            this.label1.Text = "Notes:";
            // 
            // txbxNotes
            // 
            this.txbxNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxNotes.Location = new System.Drawing.Point(142, 441);
            this.txbxNotes.MaxLength = 500;
            this.txbxNotes.Multiline = true;
            this.txbxNotes.Name = "txbxNotes";
            this.txbxNotes.Size = new System.Drawing.Size(657, 127);
            this.txbxNotes.TabIndex = 176;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(465, 581);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 50);
            this.btnClose.TabIndex = 179;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIssueLicense.FlatAppearance.BorderSize = 2;
            this.btnIssueLicense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIssueLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueLicense.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnIssueLicense.Image")));
            this.btnIssueLicense.Location = new System.Drawing.Point(298, 581);
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.Size = new System.Drawing.Size(148, 50);
            this.btnIssueLicense.TabIndex = 180;
            this.btnIssueLicense.Text = "Issue";
            this.btnIssueLicense.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnIssueLicense.UseVisualStyleBackColor = false;
            this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
            // 
            // ctrlLocalDrivingLicenseApplicationInfomration
            // 
            this.ctrlLocalDrivingLicenseApplicationInfomration.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlLocalDrivingLicenseApplicationInfomration.Location = new System.Drawing.Point(0, 0);
            this.ctrlLocalDrivingLicenseApplicationInfomration.Name = "ctrlLocalDrivingLicenseApplicationInfomration";
            this.ctrlLocalDrivingLicenseApplicationInfomration.Size = new System.Drawing.Size(850, 411);
            this.ctrlLocalDrivingLicenseApplicationInfomration.TabIndex = 0;
            // 
            // frmIssueDrivingLicenseFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 643);
            this.Controls.Add(this.btnIssueLicense);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pcbxNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbxNotes);
            this.Controls.Add(this.ctrlLocalDrivingLicenseApplicationInfomration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIssueDrivingLicenseFirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Driving License First Time";
            this.Load += new System.EventHandler(this.frmIssueDrivingLicenseFirstTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.Local_License_Applications.ctrlLocalDrivingLicenseApplicationInfomration ctrlLocalDrivingLicenseApplicationInfomration;
        private System.Windows.Forms.PictureBox pcbxNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxNotes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssueLicense;
    }
}