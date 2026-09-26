namespace DVLD_PresentationLayer.Licenses.Local_Driving_License.Controls
{
    partial class ctrlLocalDrivingLicenseInfoWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlLocalDrivingLicenseInfoWithFilter));
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txbxLicenseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlLocalDrivingLicenseInfo = new DVLD_PresentationLayer.Licenses.Local_Driving_License.Controls.ctrlLocalDrivingLicenseInfo();
            this.gbxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.btnFind);
            this.gbxFilter.Controls.Add(this.txbxLicenseID);
            this.gbxFilter.Controls.Add(this.label1);
            this.gbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFilter.Location = new System.Drawing.Point(434, 40);
            this.gbxFilter.Margin = new System.Windows.Forms.Padding(4);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Padding = new System.Windows.Forms.Padding(4);
            this.gbxFilter.Size = new System.Drawing.Size(462, 78);
            this.gbxFilter.TabIndex = 18;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filter";
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(376, 24);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(59, 46);
            this.btnFind.TabIndex = 18;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txbxLicenseID
            // 
            this.txbxLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxLicenseID.Location = new System.Drawing.Point(170, 33);
            this.txbxLicenseID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txbxLicenseID.Name = "txbxLicenseID";
            this.txbxLicenseID.Size = new System.Drawing.Size(161, 30);
            this.txbxLicenseID.TabIndex = 17;
            this.txbxLicenseID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbxLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbxLicenseID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "License ID:";
            // 
            // ctrlLocalDrivingLicenseInfo
            // 
            this.ctrlLocalDrivingLicenseInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlLocalDrivingLicenseInfo.Location = new System.Drawing.Point(0, 125);
            this.ctrlLocalDrivingLicenseInfo.Name = "ctrlLocalDrivingLicenseInfo";
            this.ctrlLocalDrivingLicenseInfo.Size = new System.Drawing.Size(1415, 424);
            this.ctrlLocalDrivingLicenseInfo.TabIndex = 0;
            // 
            // ctrlLocalDrivingLicenseInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxFilter);
            this.Controls.Add(this.ctrlLocalDrivingLicenseInfo);
            this.Name = "ctrlLocalDrivingLicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(1415, 549);
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlLocalDrivingLicenseInfo ctrlLocalDrivingLicenseInfo;
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txbxLicenseID;
        private System.Windows.Forms.Label label1;
    }
}
