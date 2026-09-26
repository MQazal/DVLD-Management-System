namespace DVLD_PresentationLayer
{
    partial class frmListTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListTestTypes));
            this.lblRecordsNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTestTypes = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestTypesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pcbxWall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).BeginInit();
            this.TestTypesMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxWall)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecordsNumber
            // 
            this.lblRecordsNumber.AutoSize = true;
            this.lblRecordsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsNumber.Location = new System.Drawing.Point(187, 584);
            this.lblRecordsNumber.Name = "lblRecordsNumber";
            this.lblRecordsNumber.Size = new System.Drawing.Size(39, 29);
            this.lblRecordsNumber.TabIndex = 16;
            this.lblRecordsNumber.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 588);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "# Records No:";
            // 
            // dgvTestTypes
            // 
            this.dgvTestTypes.AllowUserToAddRows = false;
            this.dgvTestTypes.AllowUserToDeleteRows = false;
            this.dgvTestTypes.AllowUserToOrderColumns = true;
            this.dgvTestTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestTypes.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvTestTypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTestTypes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTestTypes.ColumnHeadersHeight = 29;
            this.dgvTestTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_Title,
            this.col_Description,
            this.col_Fees});
            this.dgvTestTypes.ContextMenuStrip = this.TestTypesMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTestTypes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTestTypes.Location = new System.Drawing.Point(1, 310);
            this.dgvTestTypes.MultiSelect = false;
            this.dgvTestTypes.Name = "dgvTestTypes";
            this.dgvTestTypes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTestTypes.RowHeadersWidth = 60;
            this.dgvTestTypes.RowTemplate.Height = 24;
            this.dgvTestTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestTypes.Size = new System.Drawing.Size(1463, 243);
            this.dgvTestTypes.TabIndex = 14;
            // 
            // col_ID
            // 
            this.col_ID.FillWeight = 30F;
            this.col_ID.HeaderText = "Test ID";
            this.col_ID.MaxInputLength = 2;
            this.col_ID.MinimumWidth = 6;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_Title
            // 
            this.col_Title.FillWeight = 70F;
            this.col_Title.HeaderText = "Test Title";
            this.col_Title.MinimumWidth = 6;
            this.col_Title.Name = "col_Title";
            this.col_Title.ReadOnly = true;
            // 
            // col_Description
            // 
            this.col_Description.FillWeight = 300F;
            this.col_Description.HeaderText = "Test Description";
            this.col_Description.MinimumWidth = 6;
            this.col_Description.Name = "col_Description";
            this.col_Description.ReadOnly = true;
            // 
            // col_Fees
            // 
            this.col_Fees.FillWeight = 30F;
            this.col_Fees.HeaderText = "Test Fees";
            this.col_Fees.MinimumWidth = 6;
            this.col_Fees.Name = "col_Fees";
            this.col_Fees.ReadOnly = true;
            // 
            // TestTypesMenu
            // 
            this.TestTypesMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TestTypesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTestToolStripMenuItem});
            this.TestTypesMenu.Name = "TestsMenu";
            this.TestTypesMenu.Size = new System.Drawing.Size(218, 74);
            // 
            // editTestToolStripMenuItem
            // 
            this.editTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editTestToolStripMenuItem.Image")));
            this.editTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editTestToolStripMenuItem.Name = "editTestToolStripMenuItem";
            this.editTestToolStripMenuItem.Size = new System.Drawing.Size(217, 70);
            this.editTestToolStripMenuItem.Text = "Edit Test Type";
            this.editTestToolStripMenuItem.Click += new System.EventHandler(this.editTestToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DecoType Naskh", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(540, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 48);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manage Tests Types";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1242, 574);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 50);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pcbxWall
            // 
            this.pcbxWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbxWall.Location = new System.Drawing.Point(562, 12);
            this.pcbxWall.Name = "pcbxWall";
            this.pcbxWall.Size = new System.Drawing.Size(256, 221);
            this.pcbxWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxWall.TabIndex = 12;
            this.pcbxWall.TabStop = false;
            // 
            // frmListTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 636);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTestTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbxWall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListTestTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Test Types";
            this.Load += new System.EventHandler(this.frmTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).EndInit();
            this.TestTypesMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxWall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTestTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbxWall;
        private System.Windows.Forms.ContextMenuStrip TestTypesMenu;
        private System.Windows.Forms.ToolStripMenuItem editTestToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Fees;
    }
}