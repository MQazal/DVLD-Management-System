namespace DVLD_PresentationLayer
{
    partial class ctrlAdd_UpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlAdd_UpdateUser));
            this.Add_UpdateTaps = new System.Windows.Forms.TabControl();
            this.Person_InfoTap = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlFindPerson = new DVLD_PresentationLayer.ctrlFindPerson();
            this.Login_InfoTap = new System.Windows.Forms.TabPage();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnShowConfimPass = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chbxActive = new System.Windows.Forms.CheckBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.pbxID = new System.Windows.Forms.PictureBox();
            this.pbxConfirmPassword = new System.Windows.Forms.PictureBox();
            this.pbxPassword = new System.Windows.Forms.PictureBox();
            this.pbxUsername = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ImagesList = new System.Windows.Forms.ImageList(this.components);
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.Add_UpdateTaps.SuspendLayout();
            this.Person_InfoTap.SuspendLayout();
            this.Login_InfoTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_UpdateTaps
            // 
            this.Add_UpdateTaps.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.Add_UpdateTaps.Controls.Add(this.Person_InfoTap);
            this.Add_UpdateTaps.Controls.Add(this.Login_InfoTap);
            this.Add_UpdateTaps.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Add_UpdateTaps.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_UpdateTaps.Location = new System.Drawing.Point(0, 54);
            this.Add_UpdateTaps.Name = "Add_UpdateTaps";
            this.Add_UpdateTaps.SelectedIndex = 0;
            this.Add_UpdateTaps.Size = new System.Drawing.Size(1457, 650);
            this.Add_UpdateTaps.TabIndex = 0;
            this.Add_UpdateTaps.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.Add_UpdateTaps_Selecting);
            // 
            // Person_InfoTap
            // 
            this.Person_InfoTap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Person_InfoTap.Controls.Add(this.btnNext);
            this.Person_InfoTap.Controls.Add(this.ctrlFindPerson);
            this.Person_InfoTap.Location = new System.Drawing.Point(4, 31);
            this.Person_InfoTap.Name = "Person_InfoTap";
            this.Person_InfoTap.Padding = new System.Windows.Forms.Padding(3);
            this.Person_InfoTap.Size = new System.Drawing.Size(1449, 615);
            this.Person_InfoTap.TabIndex = 0;
            this.Person_InfoTap.Text = "Person Info";
            this.Person_InfoTap.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(1292, 546);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(135, 50);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlFindPerson
            // 
            this.ctrlFindPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlFindPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlFindPerson.Location = new System.Drawing.Point(3, 3);
            this.ctrlFindPerson.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlFindPerson.Name = "ctrlFindPerson";
            this.ctrlFindPerson.Size = new System.Drawing.Size(1441, 607);
            this.ctrlFindPerson.TabIndex = 17;
            // 
            // Login_InfoTap
            // 
            this.Login_InfoTap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Login_InfoTap.Controls.Add(this.btnPrevious);
            this.Login_InfoTap.Controls.Add(this.btnShowConfimPass);
            this.Login_InfoTap.Controls.Add(this.btnShowPassword);
            this.Login_InfoTap.Controls.Add(this.btnSave);
            this.Login_InfoTap.Controls.Add(this.chbxActive);
            this.Login_InfoTap.Controls.Add(this.lbl_ID);
            this.Login_InfoTap.Controls.Add(this.label5);
            this.Login_InfoTap.Controls.Add(this.label4);
            this.Login_InfoTap.Controls.Add(this.label3);
            this.Login_InfoTap.Controls.Add(this.label2);
            this.Login_InfoTap.Controls.Add(this.tbxConfirmPassword);
            this.Login_InfoTap.Controls.Add(this.tbxPassword);
            this.Login_InfoTap.Controls.Add(this.tbxUsername);
            this.Login_InfoTap.Controls.Add(this.pbxID);
            this.Login_InfoTap.Controls.Add(this.pbxConfirmPassword);
            this.Login_InfoTap.Controls.Add(this.pbxPassword);
            this.Login_InfoTap.Controls.Add(this.pbxUsername);
            this.Login_InfoTap.Location = new System.Drawing.Point(4, 31);
            this.Login_InfoTap.Name = "Login_InfoTap";
            this.Login_InfoTap.Padding = new System.Windows.Forms.Padding(3);
            this.Login_InfoTap.Size = new System.Drawing.Size(1449, 615);
            this.Login_InfoTap.TabIndex = 1;
            this.Login_InfoTap.Text = "Login Info";
            this.Login_InfoTap.UseVisualStyleBackColor = true;
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
            // btnShowConfimPass
            // 
            this.btnShowConfimPass.Image = ((System.Drawing.Image)(resources.GetObject("btnShowConfimPass.Image")));
            this.btnShowConfimPass.Location = new System.Drawing.Point(779, 269);
            this.btnShowConfimPass.Name = "btnShowConfimPass";
            this.btnShowConfimPass.Size = new System.Drawing.Size(46, 34);
            this.btnShowConfimPass.TabIndex = 49;
            this.btnShowConfimPass.UseVisualStyleBackColor = true;
            this.btnShowConfimPass.Click += new System.EventHandler(this.btnShowConfimPass_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPassword.Image")));
            this.btnShowPassword.Location = new System.Drawing.Point(779, 212);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(46, 34);
            this.btnShowPassword.TabIndex = 48;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
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
            // chbxActive
            // 
            this.chbxActive.AutoSize = true;
            this.chbxActive.Location = new System.Drawing.Point(435, 327);
            this.chbxActive.Name = "chbxActive";
            this.chbxActive.Size = new System.Drawing.Size(121, 23);
            this.chbxActive.TabIndex = 46;
            this.chbxActive.Text = "Is Active";
            this.chbxActive.UseVisualStyleBackColor = true;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(431, 102);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(69, 19);
            this.lbl_ID.TabIndex = 45;
            this.lbl_ID.Text = "[????]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Confirm Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "UserID:";
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxConfirmPassword.Location = new System.Drawing.Point(435, 269);
            this.tbxConfirmPassword.MaxLength = 20;
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.PasswordChar = '*';
            this.tbxConfirmPassword.Size = new System.Drawing.Size(328, 27);
            this.tbxConfirmPassword.TabIndex = 40;
            this.tbxConfirmPassword.TextChanged += new System.EventHandler(this.tbxConfirmPassword_TextChanged);
            this.tbxConfirmPassword.Leave += new System.EventHandler(this.tbxConfirmPassword_Leave);
            // 
            // tbxPassword
            // 
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPassword.Location = new System.Drawing.Point(435, 212);
            this.tbxPassword.MaxLength = 20;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(328, 27);
            this.tbxPassword.TabIndex = 39;
            this.tbxPassword.Leave += new System.EventHandler(this.tbxPassword_Leave);
            // 
            // tbxUsername
            // 
            this.tbxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUsername.Location = new System.Drawing.Point(435, 154);
            this.tbxUsername.MaxLength = 20;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(328, 27);
            this.tbxUsername.TabIndex = 38;
            this.tbxUsername.Leave += new System.EventHandler(this.tbxUsername_Leave);
            // 
            // pbxID
            // 
            this.pbxID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxID.Location = new System.Drawing.Point(372, 102);
            this.pbxID.Name = "pbxID";
            this.pbxID.Size = new System.Drawing.Size(30, 27);
            this.pbxID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxID.TabIndex = 37;
            this.pbxID.TabStop = false;
            this.pbxID.Tag = "1";
            // 
            // pbxConfirmPassword
            // 
            this.pbxConfirmPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxConfirmPassword.Location = new System.Drawing.Point(372, 269);
            this.pbxConfirmPassword.Name = "pbxConfirmPassword";
            this.pbxConfirmPassword.Size = new System.Drawing.Size(30, 27);
            this.pbxConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxConfirmPassword.TabIndex = 36;
            this.pbxConfirmPassword.TabStop = false;
            this.pbxConfirmPassword.Tag = "4";
            // 
            // pbxPassword
            // 
            this.pbxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxPassword.Location = new System.Drawing.Point(372, 212);
            this.pbxPassword.Name = "pbxPassword";
            this.pbxPassword.Size = new System.Drawing.Size(30, 27);
            this.pbxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPassword.TabIndex = 34;
            this.pbxPassword.TabStop = false;
            this.pbxPassword.Tag = "3";
            // 
            // pbxUsername
            // 
            this.pbxUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxUsername.Location = new System.Drawing.Point(372, 154);
            this.pbxUsername.Name = "pbxUsername";
            this.pbxUsername.Size = new System.Drawing.Size(30, 27);
            this.pbxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUsername.TabIndex = 31;
            this.pbxUsername.TabStop = false;
            this.pbxUsername.Tag = "2";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitle.Location = new System.Drawing.Point(607, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add New User";
            // 
            // ImagesList
            // 
            this.ImagesList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagesList.ImageStream")));
            this.ImagesList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImagesList.Images.SetKeyName(0, "Number 32.png");
            this.ImagesList.Images.SetKeyName(1, "Person 32.png");
            this.ImagesList.Images.SetKeyName(2, "Password 32.png");
            this.ImagesList.Images.SetKeyName(3, "Password 32.png");
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // ctrlAdd_UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.Add_UpdateTaps);
            this.Name = "ctrlAdd_UpdateUser";
            this.Size = new System.Drawing.Size(1457, 704);
            this.Load += new System.EventHandler(this.ctrlAdd_UpdateUser_Load);
            this.Add_UpdateTaps.ResumeLayout(false);
            this.Person_InfoTap.ResumeLayout(false);
            this.Login_InfoTap.ResumeLayout(false);
            this.Login_InfoTap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Add_UpdateTaps;
        private System.Windows.Forms.TabPage Person_InfoTap;
        private System.Windows.Forms.TabPage Login_InfoTap;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pbxConfirmPassword;
        private System.Windows.Forms.PictureBox pbxPassword;
        private System.Windows.Forms.PictureBox pbxUsername;
        private System.Windows.Forms.PictureBox pbxID;
        private System.Windows.Forms.ImageList ImagesList;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.CheckBox chbxActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnShowConfimPass;
        private System.Windows.Forms.Button btnPrevious;
        private ctrlFindPerson ctrlFindPerson;
    }
}
