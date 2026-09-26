namespace DVLD_PresentationLayer.Applications.Interntational_Driving_License_Applications
{
    partial class frmListInternationalLicesnseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListInternationalLicesnseApplications));
            this.pcbxImage2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbxImage1 = new System.Windows.Forms.PictureBox();
            this.txbxFilter = new System.Windows.Forms.TextBox();
            this.cmbxFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInternationalApplications = new System.Windows.Forms.DataGridView();
            this.ApplicationsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecordsNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxIsActiveBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalApplications)).BeginInit();
            this.ApplicationsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbxImage2
            // 
            this.pcbxImage2.Location = new System.Drawing.Point(802, 113);
            this.pcbxImage2.Name = "pcbxImage2";
            this.pcbxImage2.Size = new System.Drawing.Size(51, 45);
            this.pcbxImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxImage2.TabIndex = 31;
            this.pcbxImage2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DecoType Naskh", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(375, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 48);
            this.label1.TabIndex = 30;
            this.label1.Text = "International Driving License Applications";
            // 
            // pcbxImage1
            // 
            this.pcbxImage1.Location = new System.Drawing.Point(521, 12);
            this.pcbxImage1.Name = "pcbxImage1";
            this.pcbxImage1.Size = new System.Drawing.Size(264, 226);
            this.pcbxImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxImage1.TabIndex = 29;
            this.pcbxImage1.TabStop = false;
            // 
            // txbxFilter
            // 
            this.txbxFilter.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxFilter.Location = new System.Drawing.Point(408, 317);
            this.txbxFilter.Name = "txbxFilter";
            this.txbxFilter.Size = new System.Drawing.Size(274, 29);
            this.txbxFilter.TabIndex = 34;
            this.txbxFilter.TextChanged += new System.EventHandler(this.txbxFilter_TextChanged);
            this.txbxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbxFilter_KeyPress);
            // 
            // cmbxFilter
            // 
            this.cmbxFilter.BackColor = System.Drawing.Color.LightGray;
            this.cmbxFilter.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxFilter.FormattingEnabled = true;
            this.cmbxFilter.Items.AddRange(new object[] {
            "None",
            "International License ID",
            "Application ID",
            "Driver ID",
            "Local License ID",
            "Is Active"});
            this.cmbxFilter.Location = new System.Drawing.Point(114, 316);
            this.cmbxFilter.MaxDropDownItems = 12;
            this.cmbxFilter.Name = "cmbxFilter";
            this.cmbxFilter.Size = new System.Drawing.Size(288, 31);
            this.cmbxFilter.TabIndex = 33;
            this.cmbxFilter.SelectedIndexChanged += new System.EventHandler(this.cmbxFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Filter By:";
            // 
            // dgvInternationalApplications
            // 
            this.dgvInternationalApplications.AllowUserToAddRows = false;
            this.dgvInternationalApplications.AllowUserToDeleteRows = false;
            this.dgvInternationalApplications.AllowUserToOrderColumns = true;
            this.dgvInternationalApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInternationalApplications.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvInternationalApplications.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInternationalApplications.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInternationalApplications.ColumnHeadersHeight = 30;
            this.dgvInternationalApplications.ContextMenuStrip = this.ApplicationsMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternationalApplications.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInternationalApplications.Location = new System.Drawing.Point(183, 361);
            this.dgvInternationalApplications.MultiSelect = false;
            this.dgvInternationalApplications.Name = "dgvInternationalApplications";
            this.dgvInternationalApplications.ReadOnly = true;
            this.dgvInternationalApplications.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalApplications.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInternationalApplications.RowHeadersWidth = 60;
            this.dgvInternationalApplications.RowTemplate.Height = 24;
            this.dgvInternationalApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternationalApplications.Size = new System.Drawing.Size(1062, 248);
            this.dgvInternationalApplications.TabIndex = 35;
            // 
            // ApplicationsMenu
            // 
            this.ApplicationsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ApplicationsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.ApplicationsMenu.Name = "ApplicationsMenu";
            this.ApplicationsMenu.Size = new System.Drawing.Size(281, 118);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonDetailsToolStripMenuItem.Image")));
            this.showPersonDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseDetailsToolStripMenuItem.Image")));
            this.showLicenseDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image")));
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MintCream;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(1254, 259);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 88);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1194, 615);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 50);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecordsNumber
            // 
            this.lblRecordsNumber.AutoSize = true;
            this.lblRecordsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsNumber.Location = new System.Drawing.Point(178, 624);
            this.lblRecordsNumber.Name = "lblRecordsNumber";
            this.lblRecordsNumber.Size = new System.Drawing.Size(39, 29);
            this.lblRecordsNumber.TabIndex = 38;
            this.lblRecordsNumber.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 628);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "# Records No:";
            // 
            // cmbxIsActiveBox
            // 
            this.cmbxIsActiveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxIsActiveBox.FormattingEnabled = true;
            this.cmbxIsActiveBox.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmbxIsActiveBox.Location = new System.Drawing.Point(408, 318);
            this.cmbxIsActiveBox.Name = "cmbxIsActiveBox";
            this.cmbxIsActiveBox.Size = new System.Drawing.Size(192, 28);
            this.cmbxIsActiveBox.TabIndex = 41;
            this.cmbxIsActiveBox.SelectedIndexChanged += new System.EventHandler(this.cmbxIsActiveBox_SelectedIndexChanged);
            // 
            // frmListInternationalLicesnseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 671);
            this.Controls.Add(this.cmbxIsActiveBox);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvInternationalApplications);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbxFilter);
            this.Controls.Add(this.cmbxFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcbxImage2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbxImage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListInternationalLicesnseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International Licesnse Applications";
            this.Load += new System.EventHandler(this.frmListInternationalLicesnseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalApplications)).EndInit();
            this.ApplicationsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbxImage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbxImage1;
        private System.Windows.Forms.TextBox txbxFilter;
        private System.Windows.Forms.ComboBox cmbxFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInternationalApplications;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip ApplicationsMenu;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbxIsActiveBox;
    }
}