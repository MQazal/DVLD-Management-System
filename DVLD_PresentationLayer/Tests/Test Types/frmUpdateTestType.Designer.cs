namespace DVLD_PresentationLayer
{
    partial class frmUpdateTestType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateTestType));
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.pcbxID = new System.Windows.Forms.PictureBox();
            this.txbxDescription = new System.Windows.Forms.TextBox();
            this.pcbxDescription = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txbxFees = new System.Windows.Forms.TextBox();
            this.txbxTitle = new System.Windows.Forms.TextBox();
            this.pcbxFees = new System.Windows.Forms.PictureBox();
            this.pcbxTitle = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DecoType Naskh", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 48);
            this.label1.TabIndex = 18;
            this.label1.Text = "Update Test Type";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(388, 474);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 50);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(198, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 50);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "Number 32.png");
            this.Images.Images.SetKeyName(1, "TitleTag.png");
            this.Images.Images.SetKeyName(2, "description.png");
            this.Images.Images.SetKeyName(3, "money 32.png");
            // 
            // pcbxID
            // 
            this.pcbxID.Location = new System.Drawing.Point(198, 89);
            this.pcbxID.Name = "pcbxID";
            this.pcbxID.Size = new System.Drawing.Size(31, 30);
            this.pcbxID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxID.TabIndex = 55;
            this.pcbxID.TabStop = false;
            this.pcbxID.Tag = "0";
            // 
            // txbxDescription
            // 
            this.txbxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxDescription.Location = new System.Drawing.Point(256, 237);
            this.txbxDescription.MaxLength = 3;
            this.txbxDescription.Multiline = true;
            this.txbxDescription.Name = "txbxDescription";
            this.txbxDescription.Size = new System.Drawing.Size(403, 145);
            this.txbxDescription.TabIndex = 45;
            // 
            // pcbxDescription
            // 
            this.pcbxDescription.Location = new System.Drawing.Point(198, 237);
            this.pcbxDescription.Name = "pcbxDescription";
            this.pcbxDescription.Size = new System.Drawing.Size(31, 30);
            this.pcbxDescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxDescription.TabIndex = 54;
            this.pcbxDescription.TabStop = false;
            this.pcbxDescription.Tag = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "Description:";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(251, 89);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(48, 25);
            this.lbl_ID.TabIndex = 52;
            this.lbl_ID.Text = "???";
            // 
            // txbxFees
            // 
            this.txbxFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxFees.Location = new System.Drawing.Point(256, 407);
            this.txbxFees.MaxLength = 3;
            this.txbxFees.Name = "txbxFees";
            this.txbxFees.Size = new System.Drawing.Size(160, 30);
            this.txbxFees.TabIndex = 46;
            this.txbxFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbxTitle
            // 
            this.txbxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxTitle.Location = new System.Drawing.Point(256, 153);
            this.txbxTitle.MaxLength = 60;
            this.txbxTitle.Name = "txbxTitle";
            this.txbxTitle.Size = new System.Drawing.Size(403, 30);
            this.txbxTitle.TabIndex = 44;
            // 
            // pcbxFees
            // 
            this.pcbxFees.Location = new System.Drawing.Point(198, 407);
            this.pcbxFees.Name = "pcbxFees";
            this.pcbxFees.Size = new System.Drawing.Size(31, 30);
            this.pcbxFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxFees.TabIndex = 51;
            this.pcbxFees.TabStop = false;
            this.pcbxFees.Tag = "3";
            // 
            // pcbxTitle
            // 
            this.pcbxTitle.Location = new System.Drawing.Point(198, 153);
            this.pcbxTitle.Name = "pcbxTitle";
            this.pcbxTitle.Size = new System.Drawing.Size(31, 30);
            this.pcbxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxTitle.TabIndex = 50;
            this.pcbxTitle.TabStop = false;
            this.pcbxTitle.Tag = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Booking Fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "ID:";
            // 
            // frmUpdateTestType
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(676, 536);
            this.Controls.Add(this.pcbxID);
            this.Controls.Add(this.txbxDescription);
            this.Controls.Add(this.pcbxDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txbxFees);
            this.Controls.Add(this.txbxTitle);
            this.Controls.Add(this.pcbxFees);
            this.Controls.Add(this.pcbxTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUpdateTestType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Test Type";
            this.Load += new System.EventHandler(this.frmUpdateTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.PictureBox pcbxID;
        private System.Windows.Forms.TextBox txbxDescription;
        private System.Windows.Forms.PictureBox pcbxDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txbxFees;
        private System.Windows.Forms.TextBox txbxTitle;
        private System.Windows.Forms.PictureBox pcbxFees;
        private System.Windows.Forms.PictureBox pcbxTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}