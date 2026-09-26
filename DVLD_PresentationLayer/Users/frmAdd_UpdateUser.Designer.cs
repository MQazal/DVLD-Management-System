namespace DVLD_PresentationLayer
{
    partial class frmAdd_UpdateUser
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
            this.ctrlAdd_UpdateUser = new DVLD_PresentationLayer.ctrlAdd_UpdateUser();
            this.SuspendLayout();
            // 
            // ctrlAdd_UpdateUser
            // 
            this.ctrlAdd_UpdateUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlAdd_UpdateUser.Location = new System.Drawing.Point(0, 0);
            this.ctrlAdd_UpdateUser.Name = "ctrlAdd_UpdateUser";
            this.ctrlAdd_UpdateUser.Size = new System.Drawing.Size(1457, 704);
            this.ctrlAdd_UpdateUser.TabIndex = 0;
            // 
            // frmAdd_UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1507, 702);
            this.Controls.Add(this.ctrlAdd_UpdateUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAdd_UpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Update User Info.";
            this.Load += new System.EventHandler(this.frmAdd_UpdateUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlAdd_UpdateUser ctrlAdd_UpdateUser;
    }
}