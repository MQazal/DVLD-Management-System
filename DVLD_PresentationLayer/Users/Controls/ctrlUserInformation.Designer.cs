namespace DVLD_PresentationLayer
{
    partial class ctrlUserInformation
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
            this.gbxLoginInfo = new System.Windows.Forms.GroupBox();
            this.lblEdit = new System.Windows.Forms.LinkLabel();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonInformation = new DVLD_PresentationLayer.People.ctrlPersonInformation();
            this.gbxLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLoginInfo
            // 
            this.gbxLoginInfo.Controls.Add(this.lblEdit);
            this.gbxLoginInfo.Controls.Add(this.lblActive);
            this.gbxLoginInfo.Controls.Add(this.lblUsername);
            this.gbxLoginInfo.Controls.Add(this.lbl_ID);
            this.gbxLoginInfo.Controls.Add(this.label4);
            this.gbxLoginInfo.Controls.Add(this.label2);
            this.gbxLoginInfo.Controls.Add(this.label1);
            this.gbxLoginInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxLoginInfo.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLoginInfo.Location = new System.Drawing.Point(0, 370);
            this.gbxLoginInfo.Name = "gbxLoginInfo";
            this.gbxLoginInfo.Size = new System.Drawing.Size(1155, 102);
            this.gbxLoginInfo.TabIndex = 1;
            this.gbxLoginInfo.TabStop = false;
            this.gbxLoginInfo.Text = "Login Information";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.Location = new System.Drawing.Point(917, 39);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(163, 24);
            this.lblEdit.TabIndex = 23;
            this.lblEdit.TabStop = true;
            this.lblEdit.Text = "Edit User Detials";
            this.lblEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEdit_LinkClicked);
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(766, 45);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(68, 21);
            this.lblActive.TabIndex = 6;
            this.lblActive.Text = "[????]";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(452, 45);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(68, 21);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "[????]";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(191, 45);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(22, 21);
            this.lbl_ID.TabIndex = 2;
            this.lbl_ID.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Is Active:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID:";
            // 
            // PersonInformation
            // 
            this.PersonInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.PersonInformation.Location = new System.Drawing.Point(0, 0);
            this.PersonInformation.Name = "PersonInformation";
            this.PersonInformation.Size = new System.Drawing.Size(1155, 355);
            this.PersonInformation.TabIndex = 2;
            // 
            // ctrlUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PersonInformation);
            this.Controls.Add(this.gbxLoginInfo);
            this.Name = "ctrlUserInformation";
            this.Size = new System.Drawing.Size(1155, 472);
            this.gbxLoginInfo.ResumeLayout(false);
            this.gbxLoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLoginInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.LinkLabel lblEdit;
        private People.ctrlPersonInformation PersonInformation;
    }
}
