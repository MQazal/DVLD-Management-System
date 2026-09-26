namespace DVLD_PresentationLayer.Licenses.Local_Driving_License.Controls
{
    partial class ctrlDriverLicenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxLicenses = new System.Windows.Forms.GroupBox();
            this.LicensesTabs = new System.Windows.Forms.TabControl();
            this.LocalLicenses_Tab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLocalLicensesNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLocalDrivingLicenses = new System.Windows.Forms.DataGridView();
            this.InternationalLicenses_Tab = new System.Windows.Forms.TabPage();
            this.dgvInternationalDrivingLicenses = new System.Windows.Forms.DataGridView();
            this.lblInternationalLicensesNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxLicenses.SuspendLayout();
            this.LicensesTabs.SuspendLayout();
            this.LocalLicenses_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenses)).BeginInit();
            this.InternationalLicenses_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalDrivingLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxLicenses
            // 
            this.gbxLicenses.Controls.Add(this.LicensesTabs);
            this.gbxLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLicenses.Location = new System.Drawing.Point(0, 0);
            this.gbxLicenses.Name = "gbxLicenses";
            this.gbxLicenses.Size = new System.Drawing.Size(1220, 392);
            this.gbxLicenses.TabIndex = 0;
            this.gbxLicenses.TabStop = false;
            this.gbxLicenses.Text = "Driver Licenses";
            // 
            // LicensesTabs
            // 
            this.LicensesTabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.LicensesTabs.Controls.Add(this.LocalLicenses_Tab);
            this.LicensesTabs.Controls.Add(this.InternationalLicenses_Tab);
            this.LicensesTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LicensesTabs.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicensesTabs.Location = new System.Drawing.Point(3, 26);
            this.LicensesTabs.Multiline = true;
            this.LicensesTabs.Name = "LicensesTabs";
            this.LicensesTabs.SelectedIndex = 0;
            this.LicensesTabs.Size = new System.Drawing.Size(1214, 363);
            this.LicensesTabs.TabIndex = 1;
            // 
            // LocalLicenses_Tab
            // 
            this.LocalLicenses_Tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocalLicenses_Tab.Controls.Add(this.label1);
            this.LocalLicenses_Tab.Controls.Add(this.lblLocalLicensesNumber);
            this.LocalLicenses_Tab.Controls.Add(this.label3);
            this.LocalLicenses_Tab.Controls.Add(this.dgvLocalDrivingLicenses);
            this.LocalLicenses_Tab.Location = new System.Drawing.Point(4, 37);
            this.LocalLicenses_Tab.Name = "LocalLicenses_Tab";
            this.LocalLicenses_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.LocalLicenses_Tab.Size = new System.Drawing.Size(1206, 322);
            this.LocalLicenses_Tab.TabIndex = 0;
            this.LocalLicenses_Tab.Text = "Local Driving Licenses";
            this.LocalLicenses_Tab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Local Licenses History:";
            // 
            // lblLocalLicensesNumber
            // 
            this.lblLocalLicensesNumber.AutoSize = true;
            this.lblLocalLicensesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicensesNumber.Location = new System.Drawing.Point(1152, 16);
            this.lblLocalLicensesNumber.Name = "lblLocalLicensesNumber";
            this.lblLocalLicensesNumber.Size = new System.Drawing.Size(39, 29);
            this.lblLocalLicensesNumber.TabIndex = 10;
            this.lblLocalLicensesNumber.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(997, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "# Records No:";
            // 
            // dgvLocalDrivingLicenses
            // 
            this.dgvLocalDrivingLicenses.AllowUserToAddRows = false;
            this.dgvLocalDrivingLicenses.AllowUserToDeleteRows = false;
            this.dgvLocalDrivingLicenses.AllowUserToOrderColumns = true;
            this.dgvLocalDrivingLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLocalDrivingLicenses.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvLocalDrivingLicenses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalDrivingLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocalDrivingLicenses.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocalDrivingLicenses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocalDrivingLicenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLocalDrivingLicenses.Location = new System.Drawing.Point(3, 63);
            this.dgvLocalDrivingLicenses.MultiSelect = false;
            this.dgvLocalDrivingLicenses.Name = "dgvLocalDrivingLicenses";
            this.dgvLocalDrivingLicenses.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalDrivingLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLocalDrivingLicenses.RowHeadersWidth = 60;
            this.dgvLocalDrivingLicenses.RowTemplate.Height = 24;
            this.dgvLocalDrivingLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalDrivingLicenses.Size = new System.Drawing.Size(1198, 254);
            this.dgvLocalDrivingLicenses.TabIndex = 5;
            // 
            // InternationalLicenses_Tab
            // 
            this.InternationalLicenses_Tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InternationalLicenses_Tab.Controls.Add(this.dgvInternationalDrivingLicenses);
            this.InternationalLicenses_Tab.Controls.Add(this.lblInternationalLicensesNumber);
            this.InternationalLicenses_Tab.Controls.Add(this.label5);
            this.InternationalLicenses_Tab.Controls.Add(this.label2);
            this.InternationalLicenses_Tab.Location = new System.Drawing.Point(4, 37);
            this.InternationalLicenses_Tab.Name = "InternationalLicenses_Tab";
            this.InternationalLicenses_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.InternationalLicenses_Tab.Size = new System.Drawing.Size(1206, 322);
            this.InternationalLicenses_Tab.TabIndex = 1;
            this.InternationalLicenses_Tab.Text = "International Driving Licenses";
            this.InternationalLicenses_Tab.UseVisualStyleBackColor = true;
            // 
            // dgvInternationalDrivingLicenses
            // 
            this.dgvInternationalDrivingLicenses.AllowUserToAddRows = false;
            this.dgvInternationalDrivingLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalDrivingLicenses.AllowUserToOrderColumns = true;
            this.dgvInternationalDrivingLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInternationalDrivingLicenses.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvInternationalDrivingLicenses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalDrivingLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInternationalDrivingLicenses.ColumnHeadersHeight = 29;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternationalDrivingLicenses.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInternationalDrivingLicenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInternationalDrivingLicenses.Location = new System.Drawing.Point(3, 61);
            this.dgvInternationalDrivingLicenses.MultiSelect = false;
            this.dgvInternationalDrivingLicenses.Name = "dgvInternationalDrivingLicenses";
            this.dgvInternationalDrivingLicenses.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalDrivingLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInternationalDrivingLicenses.RowHeadersWidth = 60;
            this.dgvInternationalDrivingLicenses.RowTemplate.Height = 24;
            this.dgvInternationalDrivingLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternationalDrivingLicenses.Size = new System.Drawing.Size(1198, 256);
            this.dgvInternationalDrivingLicenses.TabIndex = 15;
            // 
            // lblInternationalLicensesNumber
            // 
            this.lblInternationalLicensesNumber.AutoSize = true;
            this.lblInternationalLicensesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalLicensesNumber.Location = new System.Drawing.Point(1149, 15);
            this.lblInternationalLicensesNumber.Name = "lblInternationalLicensesNumber";
            this.lblInternationalLicensesNumber.Size = new System.Drawing.Size(39, 29);
            this.lblInternationalLicensesNumber.TabIndex = 14;
            this.lblInternationalLicensesNumber.Text = "??";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(994, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "# Records No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "International Licenses History:";
            // 
            // ctrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxLicenses);
            this.Name = "ctrlDriverLicenses";
            this.Size = new System.Drawing.Size(1220, 392);
            this.gbxLicenses.ResumeLayout(false);
            this.LicensesTabs.ResumeLayout(false);
            this.LocalLicenses_Tab.ResumeLayout(false);
            this.LocalLicenses_Tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenses)).EndInit();
            this.InternationalLicenses_Tab.ResumeLayout(false);
            this.InternationalLicenses_Tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalDrivingLicenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLicenses;
        private System.Windows.Forms.TabControl LicensesTabs;
        private System.Windows.Forms.TabPage LocalLicenses_Tab;
        private System.Windows.Forms.TabPage InternationalLicenses_Tab;
        private System.Windows.Forms.DataGridView dgvLocalDrivingLicenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLocalLicensesNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvInternationalDrivingLicenses;
        private System.Windows.Forms.Label lblInternationalLicensesNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}
