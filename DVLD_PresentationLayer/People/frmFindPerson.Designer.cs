namespace DVLD_PresentationLayer
{
    partial class frmFindPerson
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
            this.ctrlFindPerson = new DVLD_PresentationLayer.ctrlFindPerson();
            this.SuspendLayout();
            // 
            // ctrlFindPerson
            // 
            this.ctrlFindPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlFindPerson.Location = new System.Drawing.Point(0, 0);
            this.ctrlFindPerson.Name = "ctrlFindPerson";
            this.ctrlFindPerson.Size = new System.Drawing.Size(1153, 457);
            this.ctrlFindPerson.TabIndex = 0;
            // 
            // frmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 457);
            this.Controls.Add(this.ctrlFindPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFindPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Person";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlFindPerson ctrlFindPerson;
    }
}