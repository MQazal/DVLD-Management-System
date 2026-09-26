namespace DVLD_PresentationLayer
{
    partial class frmListLicenseClasses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListLicenseClasses));
            this.dgvLicenseClasses = new System.Windows.Forms.DataGridView();
            this.col_ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ClassDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MinAllowedAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DefaultValidLen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ClassFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenseClassesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordsNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pcbxWall = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenseClasses)).BeginInit();
            this.LicenseClassesMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxWall)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLicenseClasses
            // 
            this.dgvLicenseClasses.AllowUserToAddRows = false;
            this.dgvLicenseClasses.AllowUserToDeleteRows = false;
            this.dgvLicenseClasses.AllowUserToOrderColumns = true;
            this.dgvLicenseClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLicenseClasses.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvLicenseClasses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLicenseClasses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLicenseClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLicenseClasses.ColumnHeadersHeight = 29;
            this.dgvLicenseClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ClassID,
            this.col_ClassName,
            this.col_ClassDescription,
            this.col_MinAllowedAge,
            this.col_DefaultValidLen,
            this.col_ClassFees});
            this.dgvLicenseClasses.ContextMenuStrip = this.LicenseClassesMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLicenseClasses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLicenseClasses.Location = new System.Drawing.Point(0, 327);
            this.dgvLicenseClasses.MultiSelect = false;
            this.dgvLicenseClasses.Name = "dgvLicenseClasses";
            this.dgvLicenseClasses.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLicenseClasses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLicenseClasses.RowHeadersWidth = 60;
            this.dgvLicenseClasses.RowTemplate.Height = 24;
            this.dgvLicenseClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLicenseClasses.Size = new System.Drawing.Size(1470, 243);
            this.dgvLicenseClasses.TabIndex = 14;
            // 
            // col_ClassID
            // 
            this.col_ClassID.FillWeight = 60F;
            this.col_ClassID.HeaderText = "Class ID";
            this.col_ClassID.MinimumWidth = 6;
            this.col_ClassID.Name = "col_ClassID";
            this.col_ClassID.ReadOnly = true;
            // 
            // col_ClassName
            // 
            this.col_ClassName.FillWeight = 180F;
            this.col_ClassName.HeaderText = "Class Name";
            this.col_ClassName.MinimumWidth = 6;
            this.col_ClassName.Name = "col_ClassName";
            this.col_ClassName.ReadOnly = true;
            // 
            // col_ClassDescription
            // 
            this.col_ClassDescription.FillWeight = 400F;
            this.col_ClassDescription.HeaderText = "Class Description";
            this.col_ClassDescription.MinimumWidth = 6;
            this.col_ClassDescription.Name = "col_ClassDescription";
            this.col_ClassDescription.ReadOnly = true;
            // 
            // col_MinAllowedAge
            // 
            this.col_MinAllowedAge.FillWeight = 130F;
            this.col_MinAllowedAge.HeaderText = "Minimum Allowed Age";
            this.col_MinAllowedAge.MinimumWidth = 6;
            this.col_MinAllowedAge.Name = "col_MinAllowedAge";
            this.col_MinAllowedAge.ReadOnly = true;
            // 
            // col_DefaultValidLen
            // 
            this.col_DefaultValidLen.FillWeight = 120F;
            this.col_DefaultValidLen.HeaderText = "Default Valid Length";
            this.col_DefaultValidLen.MinimumWidth = 6;
            this.col_DefaultValidLen.Name = "col_DefaultValidLen";
            this.col_DefaultValidLen.ReadOnly = true;
            // 
            // col_ClassFees
            // 
            this.col_ClassFees.FillWeight = 80F;
            this.col_ClassFees.HeaderText = "Class Fees";
            this.col_ClassFees.MinimumWidth = 6;
            this.col_ClassFees.Name = "col_ClassFees";
            this.col_ClassFees.ReadOnly = true;
            // 
            // LicenseClassesMenu
            // 
            this.LicenseClassesMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.LicenseClassesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editClassToolStripMenuItem});
            this.LicenseClassesMenu.Name = "contextMenuStrip1";
            this.LicenseClassesMenu.Size = new System.Drawing.Size(158, 42);
            // 
            // editClassToolStripMenuItem
            // 
            this.editClassToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editClassToolStripMenuItem.Image")));
            this.editClassToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editClassToolStripMenuItem.Name = "editClassToolStripMenuItem";
            this.editClassToolStripMenuItem.Size = new System.Drawing.Size(157, 38);
            this.editClassToolStripMenuItem.Text = "Edit Class";
            this.editClassToolStripMenuItem.Click += new System.EventHandler(this.editClassToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DecoType Naskh", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(583, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 48);
            this.label1.TabIndex = 13;
            this.label1.Text = "Show License Classes";
            // 
            // lblRecordsNumber
            // 
            this.lblRecordsNumber.AutoSize = true;
            this.lblRecordsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsNumber.Location = new System.Drawing.Point(230, 600);
            this.lblRecordsNumber.Name = "lblRecordsNumber";
            this.lblRecordsNumber.Size = new System.Drawing.Size(39, 29);
            this.lblRecordsNumber.TabIndex = 16;
            this.lblRecordsNumber.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "# Records No:";
            // 
            // pcbxWall
            // 
            this.pcbxWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbxWall.Location = new System.Drawing.Point(616, 12);
            this.pcbxWall.Name = "pcbxWall";
            this.pcbxWall.Size = new System.Drawing.Size(256, 221);
            this.pcbxWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxWall.TabIndex = 12;
            this.pcbxWall.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1285, 589);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 50);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmListLicenseClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 651);
            this.Controls.Add(this.dgvLicenseClasses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbxWall);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsNumber);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListLicenseClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show License Classes";
            this.Load += new System.EventHandler(this.frmShowLicenseClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenseClasses)).EndInit();
            this.LicenseClassesMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxWall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLicenseClasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbxWall;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ClassDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MinAllowedAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DefaultValidLen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ClassFees;
        private System.Windows.Forms.ContextMenuStrip LicenseClassesMenu;
        private System.Windows.Forms.ToolStripMenuItem editClassToolStripMenuItem;
    }
}