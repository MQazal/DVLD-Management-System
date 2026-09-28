namespace DVLD_PresentationLayer.Applications.Replace_Lost_Or_Damaged_License
{
    partial class frmReplaceLostOrDamagedLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplaceLostOrDamagedLicenseApplication));
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxReplacementFor = new System.Windows.Forms.GroupBox();
            this.rbtnLostLicense = new System.Windows.Forms.RadioButton();
            this.rbtnDamagedLicense = new System.Windows.Forms.RadioButton();
            this.gbxApplicationInfo = new System.Windows.Forms.GroupBox();
            this.btnReplacament = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lnklblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.pcbxNotes = new System.Windows.Forms.PictureBox();
            this.lnklblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txbxNotes = new System.Windows.Forms.TextBox();
            this.pcbxOldLicenseID = new System.Windows.Forms.PictureBox();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pcbxRenewedLicID = new System.Windows.Forms.PictureBox();
            this.lblReplacedLicenseID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.pcbxExpDate = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.pcbxIssueDate = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pcbxRenewLicAppID = new System.Windows.Forms.PictureBox();
            this.pcbxUsername = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbxAppFees = new System.Windows.Forms.PictureBox();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.pcbxAppDate = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.ctrlLocalDrivingLicenseInfoWithFilter = new DVLD_PresentationLayer.Licenses.Local_Driving_License.Controls.ctrlLocalDrivingLicenseInfoWithFilter();
            this.gbxReplacementFor.SuspendLayout();
            this.gbxApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxOldLicenseID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxRenewedLicID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxExpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxIssueDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxRenewLicAppID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAppFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAppDate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 38);
            this.lblTitle.TabIndex = 184;
            this.lblTitle.Text = "License Replacement";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxReplacementFor
            // 
            this.gbxReplacementFor.Controls.Add(this.rbtnLostLicense);
            this.gbxReplacementFor.Controls.Add(this.rbtnDamagedLicense);
            this.gbxReplacementFor.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxReplacementFor.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.gbxReplacementFor.Location = new System.Drawing.Point(920, 51);
            this.gbxReplacementFor.Name = "gbxReplacementFor";
            this.gbxReplacementFor.Size = new System.Drawing.Size(420, 65);
            this.gbxReplacementFor.TabIndex = 192;
            this.gbxReplacementFor.TabStop = false;
            this.gbxReplacementFor.Text = "Repalcement For:";
            // 
            // rbtnLostLicense
            // 
            this.rbtnLostLicense.AutoSize = true;
            this.rbtnLostLicense.Location = new System.Drawing.Point(250, 27);
            this.rbtnLostLicense.Name = "rbtnLostLicense";
            this.rbtnLostLicense.Size = new System.Drawing.Size(141, 29);
            this.rbtnLostLicense.TabIndex = 1;
            this.rbtnLostLicense.Text = "Lost License";
            this.rbtnLostLicense.UseVisualStyleBackColor = true;
            this.rbtnLostLicense.CheckedChanged += new System.EventHandler(this.rbtnLostLicense_CheckedChanged);
            // 
            // rbtnDamagedLicense
            // 
            this.rbtnDamagedLicense.AutoSize = true;
            this.rbtnDamagedLicense.Location = new System.Drawing.Point(19, 27);
            this.rbtnDamagedLicense.Name = "rbtnDamagedLicense";
            this.rbtnDamagedLicense.Size = new System.Drawing.Size(189, 29);
            this.rbtnDamagedLicense.TabIndex = 0;
            this.rbtnDamagedLicense.Text = "Damaged License";
            this.rbtnDamagedLicense.UseVisualStyleBackColor = true;
            this.rbtnDamagedLicense.CheckedChanged += new System.EventHandler(this.rbtnLostLicense_CheckedChanged);
            // 
            // gbxApplicationInfo
            // 
            this.gbxApplicationInfo.Controls.Add(this.btnReplacament);
            this.gbxApplicationInfo.Controls.Add(this.btnClose);
            this.gbxApplicationInfo.Controls.Add(this.lnklblShowLicenseInfo);
            this.gbxApplicationInfo.Controls.Add(this.pcbxNotes);
            this.gbxApplicationInfo.Controls.Add(this.lnklblShowLicenseHistory);
            this.gbxApplicationInfo.Controls.Add(this.label3);
            this.gbxApplicationInfo.Controls.Add(this.txbxNotes);
            this.gbxApplicationInfo.Controls.Add(this.pcbxOldLicenseID);
            this.gbxApplicationInfo.Controls.Add(this.lblOldLicenseID);
            this.gbxApplicationInfo.Controls.Add(this.label12);
            this.gbxApplicationInfo.Controls.Add(this.pcbxRenewedLicID);
            this.gbxApplicationInfo.Controls.Add(this.lblReplacedLicenseID);
            this.gbxApplicationInfo.Controls.Add(this.label10);
            this.gbxApplicationInfo.Controls.Add(this.lblExpirationDate);
            this.gbxApplicationInfo.Controls.Add(this.pcbxExpDate);
            this.gbxApplicationInfo.Controls.Add(this.label8);
            this.gbxApplicationInfo.Controls.Add(this.lblIssueDate);
            this.gbxApplicationInfo.Controls.Add(this.pcbxIssueDate);
            this.gbxApplicationInfo.Controls.Add(this.label6);
            this.gbxApplicationInfo.Controls.Add(this.pcbxRenewLicAppID);
            this.gbxApplicationInfo.Controls.Add(this.pcbxUsername);
            this.gbxApplicationInfo.Controls.Add(this.label1);
            this.gbxApplicationInfo.Controls.Add(this.lblCreatedByUser);
            this.gbxApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.gbxApplicationInfo.Controls.Add(this.label2);
            this.gbxApplicationInfo.Controls.Add(this.pcbxAppFees);
            this.gbxApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.gbxApplicationInfo.Controls.Add(this.pcbxAppDate);
            this.gbxApplicationInfo.Controls.Add(this.label5);
            this.gbxApplicationInfo.Controls.Add(this.lblApplicationID);
            this.gbxApplicationInfo.Controls.Add(this.label4);
            this.gbxApplicationInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxApplicationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxApplicationInfo.Location = new System.Drawing.Point(0, 555);
            this.gbxApplicationInfo.Name = "gbxApplicationInfo";
            this.gbxApplicationInfo.Size = new System.Drawing.Size(1406, 255);
            this.gbxApplicationInfo.TabIndex = 193;
            this.gbxApplicationInfo.TabStop = false;
            this.gbxApplicationInfo.Text = "Application Info for Replacement License";
            // 
            // btnReplacament
            // 
            this.btnReplacament.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReplacament.FlatAppearance.BorderSize = 2;
            this.btnReplacament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReplacament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplacament.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplacament.Image = ((System.Drawing.Image)(resources.GetObject("btnReplacament.Image")));
            this.btnReplacament.Location = new System.Drawing.Point(1087, 140);
            this.btnReplacament.Name = "btnReplacament";
            this.btnReplacament.Size = new System.Drawing.Size(292, 50);
            this.btnReplacament.TabIndex = 206;
            this.btnReplacament.Text = "Issue Replacament";
            this.btnReplacament.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReplacament.UseVisualStyleBackColor = false;
            this.btnReplacament.Click += new System.EventHandler(this.btnReplacament_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1087, 196);
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
            this.lnklblShowLicenseInfo.Location = new System.Drawing.Point(1114, 52);
            this.lnklblShowLicenseInfo.Name = "lnklblShowLicenseInfo";
            this.lnklblShowLicenseInfo.Size = new System.Drawing.Size(216, 25);
            this.lnklblShowLicenseInfo.TabIndex = 184;
            this.lnklblShowLicenseInfo.TabStop = true;
            this.lnklblShowLicenseInfo.Text = "Show New License Info";
            this.lnklblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblShowLicenseInfo_LinkClicked);
            // 
            // pcbxNotes
            // 
            this.pcbxNotes.Location = new System.Drawing.Point(300, 175);
            this.pcbxNotes.Name = "pcbxNotes";
            this.pcbxNotes.Size = new System.Drawing.Size(31, 26);
            this.pcbxNotes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxNotes.TabIndex = 204;
            this.pcbxNotes.TabStop = false;
            this.pcbxNotes.Tag = "10";
            // 
            // lnklblShowLicenseHistory
            // 
            this.lnklblShowLicenseHistory.AutoSize = true;
            this.lnklblShowLicenseHistory.Enabled = false;
            this.lnklblShowLicenseHistory.Location = new System.Drawing.Point(1114, 94);
            this.lnklblShowLicenseHistory.Name = "lnklblShowLicenseHistory";
            this.lnklblShowLicenseHistory.Size = new System.Drawing.Size(200, 25);
            this.lnklblShowLicenseHistory.TabIndex = 183;
            this.lnklblShowLicenseHistory.TabStop = true;
            this.lnklblShowLicenseHistory.Text = "Show License History";
            this.lnklblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblShowLicenseHistory_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 203;
            this.label3.Text = "Notes:";
            // 
            // txbxNotes
            // 
            this.txbxNotes.Location = new System.Drawing.Point(356, 176);
            this.txbxNotes.MaxLength = 500;
            this.txbxNotes.Multiline = true;
            this.txbxNotes.Name = "txbxNotes";
            this.txbxNotes.Size = new System.Drawing.Size(513, 64);
            this.txbxNotes.TabIndex = 202;
            // 
            // pcbxOldLicenseID
            // 
            this.pcbxOldLicenseID.Location = new System.Drawing.Point(874, 74);
            this.pcbxOldLicenseID.Name = "pcbxOldLicenseID";
            this.pcbxOldLicenseID.Size = new System.Drawing.Size(31, 26);
            this.pcbxOldLicenseID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxOldLicenseID.TabIndex = 195;
            this.pcbxOldLicenseID.TabStop = false;
            this.pcbxOldLicenseID.Tag = "6";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseID.Location = new System.Drawing.Point(934, 75);
            this.lblOldLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(62, 25);
            this.lblOldLicenseID.TabIndex = 194;
            this.lblOldLicenseID.Text = "[???]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(627, 74);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 25);
            this.label12.TabIndex = 193;
            this.label12.Text = "Old License ID:";
            // 
            // pcbxRenewedLicID
            // 
            this.pcbxRenewedLicID.Location = new System.Drawing.Point(874, 39);
            this.pcbxRenewedLicID.Name = "pcbxRenewedLicID";
            this.pcbxRenewedLicID.Size = new System.Drawing.Size(31, 26);
            this.pcbxRenewedLicID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxRenewedLicID.TabIndex = 192;
            this.pcbxRenewedLicID.TabStop = false;
            this.pcbxRenewedLicID.Tag = "5";
            // 
            // lblReplacedLicenseID
            // 
            this.lblReplacedLicenseID.AutoSize = true;
            this.lblReplacedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplacedLicenseID.Location = new System.Drawing.Point(934, 40);
            this.lblReplacedLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReplacedLicenseID.Name = "lblReplacedLicenseID";
            this.lblReplacedLicenseID.Size = new System.Drawing.Size(62, 25);
            this.lblReplacedLicenseID.TabIndex = 191;
            this.lblReplacedLicenseID.Text = "[???]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(627, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 25);
            this.label10.TabIndex = 190;
            this.label10.Text = "Replacaed License ID:";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(934, 108);
            this.lblExpirationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(136, 25);
            this.lblExpirationDate.TabIndex = 189;
            this.lblExpirationDate.Text = "[??/??/????]";
            // 
            // pcbxExpDate
            // 
            this.pcbxExpDate.Location = new System.Drawing.Point(874, 107);
            this.pcbxExpDate.Name = "pcbxExpDate";
            this.pcbxExpDate.Size = new System.Drawing.Size(31, 26);
            this.pcbxExpDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxExpDate.TabIndex = 188;
            this.pcbxExpDate.TabStop = false;
            this.pcbxExpDate.Tag = "7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(627, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 25);
            this.label8.TabIndex = 187;
            this.label8.Text = "Expiration Date:";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.Location = new System.Drawing.Point(351, 105);
            this.lblIssueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(136, 25);
            this.lblIssueDate.TabIndex = 186;
            this.lblIssueDate.Text = "[??/??/????]";
            // 
            // pcbxIssueDate
            // 
            this.pcbxIssueDate.Location = new System.Drawing.Point(300, 103);
            this.pcbxIssueDate.Name = "pcbxIssueDate";
            this.pcbxIssueDate.Size = new System.Drawing.Size(31, 26);
            this.pcbxIssueDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxIssueDate.TabIndex = 185;
            this.pcbxIssueDate.TabStop = false;
            this.pcbxIssueDate.Tag = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 184;
            this.label6.Text = "Issue Date:";
            // 
            // pcbxRenewLicAppID
            // 
            this.pcbxRenewLicAppID.Location = new System.Drawing.Point(300, 37);
            this.pcbxRenewLicAppID.Name = "pcbxRenewLicAppID";
            this.pcbxRenewLicAppID.Size = new System.Drawing.Size(31, 26);
            this.pcbxRenewLicAppID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxRenewLicAppID.TabIndex = 183;
            this.pcbxRenewLicAppID.TabStop = false;
            this.pcbxRenewLicAppID.Tag = "0";
            // 
            // pcbxUsername
            // 
            this.pcbxUsername.Location = new System.Drawing.Point(874, 142);
            this.pcbxUsername.Name = "pcbxUsername";
            this.pcbxUsername.Size = new System.Drawing.Size(31, 26);
            this.pcbxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxUsername.TabIndex = 182;
            this.pcbxUsername.TabStop = false;
            this.pcbxUsername.Tag = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(627, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 181;
            this.label1.Text = "Created By:";
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.Location = new System.Drawing.Point(934, 143);
            this.lblCreatedByUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(74, 25);
            this.lblCreatedByUser.TabIndex = 180;
            this.lblCreatedByUser.Text = "[????]";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(351, 140);
            this.lblApplicationFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(62, 25);
            this.lblApplicationFees.TabIndex = 179;
            this.lblApplicationFees.Text = "[$$$]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 177;
            this.label2.Text = "Application Fees:";
            // 
            // pcbxAppFees
            // 
            this.pcbxAppFees.Location = new System.Drawing.Point(300, 138);
            this.pcbxAppFees.Name = "pcbxAppFees";
            this.pcbxAppFees.Size = new System.Drawing.Size(31, 26);
            this.pcbxAppFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxAppFees.TabIndex = 178;
            this.pcbxAppFees.TabStop = false;
            this.pcbxAppFees.Tag = "3";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(351, 71);
            this.lblApplicationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(136, 25);
            this.lblApplicationDate.TabIndex = 176;
            this.lblApplicationDate.Text = "[??/??/????]";
            // 
            // pcbxAppDate
            // 
            this.pcbxAppDate.Location = new System.Drawing.Point(300, 70);
            this.pcbxAppDate.Name = "pcbxAppDate";
            this.pcbxAppDate.Size = new System.Drawing.Size(31, 26);
            this.pcbxAppDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxAppDate.TabIndex = 175;
            this.pcbxAppDate.TabStop = false;
            this.pcbxAppDate.Tag = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 174;
            this.label5.Text = "Application Date:";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(351, 38);
            this.lblApplicationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(62, 25);
            this.lblApplicationID.TabIndex = 173;
            this.lblApplicationID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 25);
            this.label4.TabIndex = 172;
            this.label4.Text = "Replace.Lic.Application ID:";
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "Number 32.png");
            this.Images.Images.SetKeyName(1, "Calendar 32.png");
            this.Images.Images.SetKeyName(2, "Calendar 32.png");
            this.Images.Images.SetKeyName(3, "money 32.png");
            this.Images.Images.SetKeyName(4, "money 32.png");
            this.Images.Images.SetKeyName(5, "Number 32.png");
            this.Images.Images.SetKeyName(6, "Number 32.png");
            this.Images.Images.SetKeyName(7, "Calendar 32.png");
            this.Images.Images.SetKeyName(8, "User 32 -2.png");
            this.Images.Images.SetKeyName(9, "money 32.png");
            this.Images.Images.SetKeyName(10, "Notes 32.png");
            // 
            // ctrlLocalDrivingLicenseInfoWithFilter
            // 
            this.ctrlLocalDrivingLicenseInfoWithFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlLocalDrivingLicenseInfoWithFilter.Location = new System.Drawing.Point(0, 0);
            this.ctrlLocalDrivingLicenseInfoWithFilter.Name = "ctrlLocalDrivingLicenseInfoWithFilter";
            this.ctrlLocalDrivingLicenseInfoWithFilter.Size = new System.Drawing.Size(1406, 549);
            this.ctrlLocalDrivingLicenseInfoWithFilter.TabIndex = 185;
            this.ctrlLocalDrivingLicenseInfoWithFilter.SelectLicense += new System.Action<int>(this.ctrlLocalDrivingLicenseInfoWithFilter_SelectLicense);
            // 
            // frmReplaceLostOrDamagedLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 810);
            this.Controls.Add(this.gbxApplicationInfo);
            this.Controls.Add(this.gbxReplacementFor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlLocalDrivingLicenseInfoWithFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReplaceLostOrDamagedLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replace Lost Or Damaged License Application";
            this.Load += new System.EventHandler(this.frmReplaceLostOrDamagedLicenseApplication_Load);
            this.gbxReplacementFor.ResumeLayout(false);
            this.gbxReplacementFor.PerformLayout();
            this.gbxApplicationInfo.ResumeLayout(false);
            this.gbxApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxOldLicenseID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxRenewedLicID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxExpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxIssueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxRenewLicAppID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAppFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAppDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Licenses.Local_Driving_License.Controls.ctrlLocalDrivingLicenseInfoWithFilter ctrlLocalDrivingLicenseInfoWithFilter;
        private System.Windows.Forms.GroupBox gbxReplacementFor;
        private System.Windows.Forms.RadioButton rbtnLostLicense;
        private System.Windows.Forms.RadioButton rbtnDamagedLicense;
        private System.Windows.Forms.GroupBox gbxApplicationInfo;
        private System.Windows.Forms.Button btnReplacament;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lnklblShowLicenseInfo;
        private System.Windows.Forms.PictureBox pcbxNotes;
        private System.Windows.Forms.LinkLabel lnklblShowLicenseHistory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbxNotes;
        private System.Windows.Forms.PictureBox pcbxOldLicenseID;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pcbxRenewedLicID;
        private System.Windows.Forms.Label lblReplacedLicenseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.PictureBox pcbxExpDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.PictureBox pcbxIssueDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pcbxRenewLicAppID;
        private System.Windows.Forms.PictureBox pcbxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbxAppFees;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.PictureBox pcbxAppDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList Images;
    }
}