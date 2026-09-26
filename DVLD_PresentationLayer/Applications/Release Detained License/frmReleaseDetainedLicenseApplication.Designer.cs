namespace DVLD_PresentationLayer.Applications.Release_Detained_License
{
    partial class frmReleaseDetainedLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReleaseDetainedLicenseApplication));
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lnklblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lnklblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxReleaseInfo = new System.Windows.Forms.GroupBox();
            this.pcbxAppID = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pcbxTotalFees = new System.Windows.Forms.PictureBox();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pcbxAppFees = new System.Windows.Forms.PictureBox();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.pcbxLicesneID = new System.Windows.Forms.PictureBox();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.pcbxDetainDate = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pcbxDetainID = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pcbxUsername = new System.Windows.Forms.PictureBox();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbxFineFees = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrlLocalDrivingLicenseInfoWithFilter = new DVLD_PresentationLayer.Licenses.Local_Driving_License.Controls.ctrlLocalDrivingLicenseInfoWithFilter();
            this.gbxReleaseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAppID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxTotalFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAppFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLicesneID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxDetainDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxDetainID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFineFees)).BeginInit();
            this.SuspendLayout();
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "Number 32.png");
            this.Images.Images.SetKeyName(1, "Calendar 32.png");
            this.Images.Images.SetKeyName(2, "money 32.png");
            this.Images.Images.SetKeyName(3, "Number 32.png");
            this.Images.Images.SetKeyName(4, "Number 32.png");
            this.Images.Images.SetKeyName(5, "money 32.png");
            this.Images.Images.SetKeyName(6, "money 32.png");
            this.Images.Images.SetKeyName(7, "User 32 -2.png");
            // 
            // btnRelease
            // 
            this.btnRelease.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRelease.Enabled = false;
            this.btnRelease.FlatAppearance.BorderSize = 2;
            this.btnRelease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelease.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelease.Image = ((System.Drawing.Image)(resources.GetObject("btnRelease.Image")));
            this.btnRelease.Location = new System.Drawing.Point(1043, 114);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(172, 50);
            this.btnRelease.TabIndex = 206;
            this.btnRelease.Text = "Release";
            this.btnRelease.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRelease.UseVisualStyleBackColor = false;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1253, 114);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 50);
            this.btnClose.TabIndex = 205;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lnklblShowLicenseInfo
            // 
            this.lnklblShowLicenseInfo.AutoSize = true;
            this.lnklblShowLicenseInfo.Enabled = false;
            this.lnklblShowLicenseInfo.Location = new System.Drawing.Point(1095, 30);
            this.lnklblShowLicenseInfo.Name = "lnklblShowLicenseInfo";
            this.lnklblShowLicenseInfo.Size = new System.Drawing.Size(172, 25);
            this.lnklblShowLicenseInfo.TabIndex = 184;
            this.lnklblShowLicenseInfo.TabStop = true;
            this.lnklblShowLicenseInfo.Text = "Show License Info";
            this.lnklblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblShowLicenseInfo_LinkClicked);
            // 
            // lnklblShowLicenseHistory
            // 
            this.lnklblShowLicenseHistory.AutoSize = true;
            this.lnklblShowLicenseHistory.Enabled = false;
            this.lnklblShowLicenseHistory.Location = new System.Drawing.Point(1095, 75);
            this.lnklblShowLicenseHistory.Name = "lnklblShowLicenseHistory";
            this.lnklblShowLicenseHistory.Size = new System.Drawing.Size(210, 25);
            this.lnklblShowLicenseHistory.TabIndex = 183;
            this.lnklblShowLicenseHistory.TabStop = true;
            this.lnklblShowLicenseHistory.Text = "Show Licenses History";
            this.lnklblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblShowLicenseHistory_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(25, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(371, 32);
            this.lblTitle.TabIndex = 195;
            this.lblTitle.Text = "Release Detained License";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxReleaseInfo
            // 
            this.gbxReleaseInfo.Controls.Add(this.pcbxAppID);
            this.gbxReleaseInfo.Controls.Add(this.label1);
            this.gbxReleaseInfo.Controls.Add(this.lblApplicationID);
            this.gbxReleaseInfo.Controls.Add(this.lblTotalFees);
            this.gbxReleaseInfo.Controls.Add(this.label7);
            this.gbxReleaseInfo.Controls.Add(this.pcbxTotalFees);
            this.gbxReleaseInfo.Controls.Add(this.lblApplicationFees);
            this.gbxReleaseInfo.Controls.Add(this.label8);
            this.gbxReleaseInfo.Controls.Add(this.pcbxAppFees);
            this.gbxReleaseInfo.Controls.Add(this.lblFineFees);
            this.gbxReleaseInfo.Controls.Add(this.btnRelease);
            this.gbxReleaseInfo.Controls.Add(this.pcbxLicesneID);
            this.gbxReleaseInfo.Controls.Add(this.btnClose);
            this.gbxReleaseInfo.Controls.Add(this.lblLicenseID);
            this.gbxReleaseInfo.Controls.Add(this.lnklblShowLicenseInfo);
            this.gbxReleaseInfo.Controls.Add(this.label10);
            this.gbxReleaseInfo.Controls.Add(this.lnklblShowLicenseHistory);
            this.gbxReleaseInfo.Controls.Add(this.lblDetainDate);
            this.gbxReleaseInfo.Controls.Add(this.pcbxDetainDate);
            this.gbxReleaseInfo.Controls.Add(this.label6);
            this.gbxReleaseInfo.Controls.Add(this.pcbxDetainID);
            this.gbxReleaseInfo.Controls.Add(this.label5);
            this.gbxReleaseInfo.Controls.Add(this.pcbxUsername);
            this.gbxReleaseInfo.Controls.Add(this.lblDetainID);
            this.gbxReleaseInfo.Controls.Add(this.label2);
            this.gbxReleaseInfo.Controls.Add(this.pcbxFineFees);
            this.gbxReleaseInfo.Controls.Add(this.lblUsername);
            this.gbxReleaseInfo.Controls.Add(this.label4);
            this.gbxReleaseInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxReleaseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxReleaseInfo.Location = new System.Drawing.Point(0, 520);
            this.gbxReleaseInfo.Name = "gbxReleaseInfo";
            this.gbxReleaseInfo.Size = new System.Drawing.Size(1413, 185);
            this.gbxReleaseInfo.TabIndex = 197;
            this.gbxReleaseInfo.TabStop = false;
            this.gbxReleaseInfo.Text = "Release Detained License Info";
            // 
            // pcbxAppID
            // 
            this.pcbxAppID.Location = new System.Drawing.Point(570, 93);
            this.pcbxAppID.Name = "pcbxAppID";
            this.pcbxAppID.Size = new System.Drawing.Size(31, 26);
            this.pcbxAppID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxAppID.TabIndex = 231;
            this.pcbxAppID.TabStop = false;
            this.pcbxAppID.Tag = "4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 229;
            this.label1.Text = "Application ID:";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(621, 94);
            this.lblApplicationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(62, 25);
            this.lblApplicationID.TabIndex = 230;
            this.lblApplicationID.Text = "[???]";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.Location = new System.Drawing.Point(886, 52);
            this.lblTotalFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(62, 25);
            this.lblTotalFees.TabIndex = 228;
            this.lblTotalFees.Text = "[$$$]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(704, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 226;
            this.label7.Text = "Total Fees:";
            // 
            // pcbxTotalFees
            // 
            this.pcbxTotalFees.Location = new System.Drawing.Point(833, 50);
            this.pcbxTotalFees.Name = "pcbxTotalFees";
            this.pcbxTotalFees.Size = new System.Drawing.Size(31, 26);
            this.pcbxTotalFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxTotalFees.TabIndex = 227;
            this.pcbxTotalFees.TabStop = false;
            this.pcbxTotalFees.Tag = "6";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(621, 134);
            this.lblApplicationFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(62, 25);
            this.lblApplicationFees.TabIndex = 225;
            this.lblApplicationFees.Text = "[$$$]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(383, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 25);
            this.label8.TabIndex = 223;
            this.label8.Text = "Application Fees:";
            // 
            // pcbxAppFees
            // 
            this.pcbxAppFees.Location = new System.Drawing.Point(570, 133);
            this.pcbxAppFees.Name = "pcbxAppFees";
            this.pcbxAppFees.Size = new System.Drawing.Size(31, 26);
            this.pcbxAppFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxAppFees.TabIndex = 224;
            this.pcbxAppFees.TabStop = false;
            this.pcbxAppFees.Tag = "5";
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFees.Location = new System.Drawing.Point(218, 134);
            this.lblFineFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(62, 25);
            this.lblFineFees.TabIndex = 222;
            this.lblFineFees.Text = "[$$$]";
            // 
            // pcbxLicesneID
            // 
            this.pcbxLicesneID.Location = new System.Drawing.Point(570, 51);
            this.pcbxLicesneID.Name = "pcbxLicesneID";
            this.pcbxLicesneID.Size = new System.Drawing.Size(31, 26);
            this.pcbxLicesneID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxLicesneID.TabIndex = 221;
            this.pcbxLicesneID.TabStop = false;
            this.pcbxLicesneID.Tag = "3";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(621, 51);
            this.lblLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(62, 25);
            this.lblLicenseID.TabIndex = 220;
            this.lblLicenseID.Text = "[???]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(383, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 25);
            this.label10.TabIndex = 219;
            this.label10.Text = "License ID:";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.Location = new System.Drawing.Point(218, 94);
            this.lblDetainDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(136, 25);
            this.lblDetainDate.TabIndex = 218;
            this.lblDetainDate.Text = "[??/??/????]";
            // 
            // pcbxDetainDate
            // 
            this.pcbxDetainDate.Location = new System.Drawing.Point(165, 93);
            this.pcbxDetainDate.Name = "pcbxDetainDate";
            this.pcbxDetainDate.Size = new System.Drawing.Size(31, 26);
            this.pcbxDetainDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxDetainDate.TabIndex = 217;
            this.pcbxDetainDate.TabStop = false;
            this.pcbxDetainDate.Tag = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 216;
            this.label6.Text = "Detain Date:";
            // 
            // pcbxDetainID
            // 
            this.pcbxDetainID.Location = new System.Drawing.Point(165, 51);
            this.pcbxDetainID.Name = "pcbxDetainID";
            this.pcbxDetainID.Size = new System.Drawing.Size(31, 26);
            this.pcbxDetainID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxDetainID.TabIndex = 215;
            this.pcbxDetainID.TabStop = false;
            this.pcbxDetainID.Tag = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 208;
            this.label5.Text = "Detain ID:";
            // 
            // pcbxUsername
            // 
            this.pcbxUsername.Location = new System.Drawing.Point(833, 93);
            this.pcbxUsername.Name = "pcbxUsername";
            this.pcbxUsername.Size = new System.Drawing.Size(31, 26);
            this.pcbxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxUsername.TabIndex = 214;
            this.pcbxUsername.TabStop = false;
            this.pcbxUsername.Tag = "7";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.Location = new System.Drawing.Point(218, 52);
            this.lblDetainID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(62, 25);
            this.lblDetainID.TabIndex = 209;
            this.lblDetainID.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(704, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 213;
            this.label2.Text = "Created By:";
            // 
            // pcbxFineFees
            // 
            this.pcbxFineFees.Location = new System.Drawing.Point(165, 133);
            this.pcbxFineFees.Name = "pcbxFineFees";
            this.pcbxFineFees.Size = new System.Drawing.Size(31, 26);
            this.pcbxFineFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxFineFees.TabIndex = 211;
            this.pcbxFineFees.TabStop = false;
            this.pcbxFineFees.Tag = "2";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(886, 94);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 25);
            this.lblUsername.TabIndex = 212;
            this.lblUsername.Text = "[????]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 210;
            this.label4.Text = "Fine Fees:";
            // 
            // ctrlLocalDrivingLicenseInfoWithFilter
            // 
            this.ctrlLocalDrivingLicenseInfoWithFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlLocalDrivingLicenseInfoWithFilter.Location = new System.Drawing.Point(0, 0);
            this.ctrlLocalDrivingLicenseInfoWithFilter.Name = "ctrlLocalDrivingLicenseInfoWithFilter";
            this.ctrlLocalDrivingLicenseInfoWithFilter.Size = new System.Drawing.Size(1413, 547);
            this.ctrlLocalDrivingLicenseInfoWithFilter.TabIndex = 196;
            // 
            // frmReleaseDetainedLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 705);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbxReleaseInfo);
            this.Controls.Add(this.ctrlLocalDrivingLicenseInfoWithFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReleaseDetainedLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Release Detained License Application";
            this.Load += new System.EventHandler(this.frmReleaseDetainedLicenseApplication_Load);
            this.gbxReleaseInfo.ResumeLayout(false);
            this.gbxReleaseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAppID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxTotalFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAppFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLicesneID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxDetainDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxDetainID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFineFees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lnklblShowLicenseInfo;
        private System.Windows.Forms.LinkLabel lnklblShowLicenseHistory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbxReleaseInfo;
        private Licenses.Local_Driving_License.Controls.ctrlLocalDrivingLicenseInfoWithFilter ctrlLocalDrivingLicenseInfoWithFilter;
        private System.Windows.Forms.PictureBox pcbxLicesneID;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.PictureBox pcbxDetainDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pcbxDetainID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pcbxUsername;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbxFineFees;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pcbxTotalFees;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pcbxAppFees;
        private System.Windows.Forms.PictureBox pcbxAppID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblApplicationID;
    }
}