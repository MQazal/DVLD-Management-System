namespace DVLD_PresentationLayer
{
    partial class ctrlFindPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlFindPerson));
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbxSerachValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxFilter = new System.Windows.Forms.ComboBox();
            this.PersonInformation = new DVLD_PresentationLayer.People.ctrlPersonInformation();
            this.gbxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.btnAdd);
            this.gbxFilter.Controls.Add(this.btnSearch);
            this.gbxFilter.Controls.Add(this.txbxSerachValue);
            this.gbxFilter.Controls.Add(this.label1);
            this.gbxFilter.Controls.Add(this.cmbxFilter);
            this.gbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFilter.Location = new System.Drawing.Point(138, 20);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(713, 83);
            this.gbxFilter.TabIndex = 0;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filter";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(633, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 45);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(560, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 45);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbxSerachValue
            // 
            this.txbxSerachValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxSerachValue.Location = new System.Drawing.Point(367, 41);
            this.txbxSerachValue.Name = "txbxSerachValue";
            this.txbxSerachValue.Size = new System.Drawing.Size(146, 29);
            this.txbxSerachValue.TabIndex = 11;
            this.txbxSerachValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By:";
            // 
            // cmbxFilter
            // 
            this.cmbxFilter.BackColor = System.Drawing.Color.LightGray;
            this.cmbxFilter.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxFilter.FormattingEnabled = true;
            this.cmbxFilter.Items.AddRange(new object[] {
            "Person ID",
            "National Number"});
            this.cmbxFilter.Location = new System.Drawing.Point(127, 43);
            this.cmbxFilter.MaxDropDownItems = 12;
            this.cmbxFilter.Name = "cmbxFilter";
            this.cmbxFilter.Size = new System.Drawing.Size(203, 31);
            this.cmbxFilter.TabIndex = 10;
            this.cmbxFilter.SelectedIndexChanged += new System.EventHandler(this.cmbxFilter_SelectedIndexChanged);
            // 
            // PersonInformation
            // 
            this.PersonInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PersonInformation.Location = new System.Drawing.Point(0, 109);
            this.PersonInformation.Name = "PersonInformation";
            this.PersonInformation.Size = new System.Drawing.Size(1171, 355);
            this.PersonInformation.TabIndex = 1;
            // 
            // ctrlFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PersonInformation);
            this.Controls.Add(this.gbxFilter);
            this.Name = "ctrlFindPerson";
            this.Size = new System.Drawing.Size(1171, 464);
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxSerachValue;
        private System.Windows.Forms.ComboBox cmbxFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.GroupBox gbxFilter;
        private People.ctrlPersonInformation PersonInformation;
    }
}
