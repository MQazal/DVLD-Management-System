namespace DVLD_PresentationLayer
{
    partial class ctrlAdd_UpdateLocalDrivingLicenseApplication
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlAdd_UpdateLocalDrivingLicenseApplication));
            this.lblTitle = new System.Windows.Forms.Label();
            this.Add_UpdateTaps = new System.Windows.Forms.TabControl();
            this.Person_InfoTap = new System.Windows.Forms.TabPage();
            this.ctrlFindPerson = new DVLD_PresentationLayer.ctrlFindPerson();
            this.Application_InfoTap = new System.Windows.Forms.TabPage();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.cmbxClasses = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.pcbxUser = new System.Windows.Forms.PictureBox();
            this.pcbxAppID = new System.Windows.Forms.PictureBox();
            this.pcbxFees = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbxClass = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pcbxDate = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.Add_UpdateTaps.SuspendLayout();
            this.Person_InfoTap.SuspendLayout();
            this.Application_InfoTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAppID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxDate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitle.Location = new System.Drawing.Point(392, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(534, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "New Local Driving License Application";
            // 
            // Add_UpdateTaps
            // 
            this.Add_UpdateTaps.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.Add_UpdateTaps.Controls.Add(this.Person_InfoTap);
            this.Add_UpdateTaps.Controls.Add(this.Application_InfoTap);
            this.Add_UpdateTaps.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_UpdateTaps.Location = new System.Drawing.Point(29, 58);
            this.Add_UpdateTaps.Name = "Add_UpdateTaps";
            this.Add_UpdateTaps.SelectedIndex = 0;
            this.Add_UpdateTaps.Size = new System.Drawing.Size(1197, 644);
            this.Add_UpdateTaps.TabIndex = 3;
            this.Add_UpdateTaps.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.Add_UpdateTaps_Selecting);
            // 
            // Person_InfoTap
            // 
            this.Person_InfoTap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Person_InfoTap.Controls.Add(this.ctrlFindPerson);
            this.Person_InfoTap.Location = new System.Drawing.Point(4, 31);
            this.Person_InfoTap.Name = "Person_InfoTap";
            this.Person_InfoTap.Padding = new System.Windows.Forms.Padding(3);
            this.Person_InfoTap.Size = new System.Drawing.Size(1189, 609);
            this.Person_InfoTap.TabIndex = 0;
            this.Person_InfoTap.Text = "Person Info";
            this.Person_InfoTap.UseVisualStyleBackColor = true;
            // 
            // ctrlFindPerson
            // 
            this.ctrlFindPerson.AutoScroll = true;
            this.ctrlFindPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlFindPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlFindPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFindPerson.Location = new System.Drawing.Point(3, 3);
            this.ctrlFindPerson.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlFindPerson.Name = "ctrlFindPerson";
            this.ctrlFindPerson.Size = new System.Drawing.Size(1181, 601);
            this.ctrlFindPerson.TabIndex = 2;
            // 
            // Application_InfoTap
            // 
            this.Application_InfoTap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Application_InfoTap.Controls.Add(this.lblUsername);
            this.Application_InfoTap.Controls.Add(this.lblFees);
            this.Application_InfoTap.Controls.Add(this.cmbxClasses);
            this.Application_InfoTap.Controls.Add(this.lblDate);
            this.Application_InfoTap.Controls.Add(this.lblApplicationID);
            this.Application_InfoTap.Controls.Add(this.pcbxUser);
            this.Application_InfoTap.Controls.Add(this.pcbxAppID);
            this.Application_InfoTap.Controls.Add(this.pcbxFees);
            this.Application_InfoTap.Controls.Add(this.label1);
            this.Application_InfoTap.Controls.Add(this.pcbxClass);
            this.Application_InfoTap.Controls.Add(this.btnPrevious);
            this.Application_InfoTap.Controls.Add(this.pcbxDate);
            this.Application_InfoTap.Controls.Add(this.btnSave);
            this.Application_InfoTap.Controls.Add(this.label5);
            this.Application_InfoTap.Controls.Add(this.label4);
            this.Application_InfoTap.Controls.Add(this.label3);
            this.Application_InfoTap.Controls.Add(this.label2);
            this.Application_InfoTap.Location = new System.Drawing.Point(4, 31);
            this.Application_InfoTap.Name = "Application_InfoTap";
            this.Application_InfoTap.Padding = new System.Windows.Forms.Padding(3);
            this.Application_InfoTap.Size = new System.Drawing.Size(1189, 609);
            this.Application_InfoTap.TabIndex = 1;
            this.Application_InfoTap.Text = "Application Info";
            this.Application_InfoTap.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(483, 378);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(59, 19);
            this.lblUsername.TabIndex = 57;
            this.lblUsername.Text = "[???]";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Location = new System.Drawing.Point(483, 309);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(59, 19);
            this.lblFees.TabIndex = 56;
            this.lblFees.Text = "[???]";
            // 
            // cmbxClasses
            // 
            this.cmbxClasses.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbxClasses.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxClasses.FormattingEnabled = true;
            this.cmbxClasses.Location = new System.Drawing.Point(489, 234);
            this.cmbxClasses.Name = "cmbxClasses";
            this.cmbxClasses.Size = new System.Drawing.Size(429, 29);
            this.cmbxClasses.TabIndex = 55;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(483, 167);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 19);
            this.lblDate.TabIndex = 54;
            this.lblDate.Text = "[???]";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Location = new System.Drawing.Point(483, 94);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(59, 19);
            this.lblApplicationID.TabIndex = 53;
            this.lblApplicationID.Text = "[???]";
            // 
            // pcbxUser
            // 
            this.pcbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbxUser.Location = new System.Drawing.Point(388, 378);
            this.pcbxUser.Name = "pcbxUser";
            this.pcbxUser.Size = new System.Drawing.Size(30, 27);
            this.pcbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxUser.TabIndex = 52;
            this.pcbxUser.TabStop = false;
            this.pcbxUser.Tag = "4";
            // 
            // pcbxAppID
            // 
            this.pcbxAppID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbxAppID.Location = new System.Drawing.Point(388, 94);
            this.pcbxAppID.Name = "pcbxAppID";
            this.pcbxAppID.Size = new System.Drawing.Size(30, 27);
            this.pcbxAppID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxAppID.TabIndex = 41;
            this.pcbxAppID.TabStop = false;
            this.pcbxAppID.Tag = "0";
            // 
            // pcbxFees
            // 
            this.pcbxFees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbxFees.Location = new System.Drawing.Point(388, 309);
            this.pcbxFees.Name = "pcbxFees";
            this.pcbxFees.Size = new System.Drawing.Size(30, 27);
            this.pcbxFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxFees.TabIndex = 40;
            this.pcbxFees.TabStop = false;
            this.pcbxFees.Tag = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Created By:";
            // 
            // pcbxClass
            // 
            this.pcbxClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbxClass.Location = new System.Drawing.Point(388, 237);
            this.pcbxClass.Name = "pcbxClass";
            this.pcbxClass.Size = new System.Drawing.Size(30, 27);
            this.pcbxClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxClass.TabIndex = 39;
            this.pcbxClass.TabStop = false;
            this.pcbxClass.Tag = "2";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrevious.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(795, 441);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(111, 50);
            this.btnPrevious.TabIndex = 50;
            this.btnPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // pcbxDate
            // 
            this.pcbxDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbxDate.Location = new System.Drawing.Point(388, 167);
            this.pcbxDate.Name = "pcbxDate";
            this.pcbxDate.Size = new System.Drawing.Size(30, 27);
            this.pcbxDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxDate.TabIndex = 38;
            this.pcbxDate.TabStop = false;
            this.pcbxDate.Tag = "1";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(950, 441);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 50);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Application Fees:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "License Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Application Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "D.L Application ID:";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(1242, 644);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(135, 50);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "Number 32.png");
            this.Images.Images.SetKeyName(1, "Calendar 32.png");
            this.Images.Images.SetKeyName(2, "LocalDriving License.png");
            this.Images.Images.SetKeyName(3, "money 32 - 2.png");
            this.Images.Images.SetKeyName(4, "User 32 -2.png");
            // 
            // ctrlAdd_UpdateLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.Add_UpdateTaps);
            this.Controls.Add(this.lblTitle);
            this.Name = "ctrlAdd_UpdateLocalDrivingLicenseApplication";
            this.Size = new System.Drawing.Size(1396, 717);
            this.Load += new System.EventHandler(this.ctrlLocalLicenseApplication_Load);
            this.Add_UpdateTaps.ResumeLayout(false);
            this.Person_InfoTap.ResumeLayout(false);
            this.Application_InfoTap.ResumeLayout(false);
            this.Application_InfoTap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAppID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl Add_UpdateTaps;
        private System.Windows.Forms.TabPage Person_InfoTap;
        private System.Windows.Forms.Button btnNext;
        private ctrlFindPerson ctrlFindPerson;
        private System.Windows.Forms.TabPage Application_InfoTap;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbxUser;
        private System.Windows.Forms.PictureBox pcbxAppID;
        private System.Windows.Forms.PictureBox pcbxFees;
        private System.Windows.Forms.PictureBox pcbxClass;
        private System.Windows.Forms.PictureBox pcbxDate;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.ComboBox cmbxClasses;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblFees;
    }
}
