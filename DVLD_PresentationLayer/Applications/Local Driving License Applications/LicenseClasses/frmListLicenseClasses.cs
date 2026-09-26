using System;
using DVLD_BusinessLogicLayer;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using DVLD_PresentationLayer.Applications.Local_Driving_License_Applications.LicenseClasses;
using DVLD_PresentationLayer.Global_Classes;

namespace DVLD_PresentationLayer
{
    public partial class frmListLicenseClasses : Form
    {
        public frmListLicenseClasses()
        {
            InitializeComponent();
        }

        private void _AddRowsToTable()
        {
            foreach (DataRow Row in clsLicenseClass.GetClassesList().Rows)
            {
                dgvLicenseClasses.Rows.Add(Row["ClassID"], Row["ClassName"], Row["ClassDescription"],
                    Row["MinimumAllowedAge"], Row["DefalutValidityLength"], Row["ClassFees"]);
            }
        }

        private void frmShowLicenseClasses_Load(object sender, EventArgs e)
        {
            clsUtil.SetScreenHeaderData(pcbxWall, Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\LicenWall.png"));
            _AddRowsToTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvLicenseClasses);
            dgvLicenseClasses.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ClearTableRows()
        {
            dgvLicenseClasses.Rows.Clear();
        }

        private void _RefreshLicenseClassesRecords()
        {
            _ClearTableRows();
            _AddRowsToTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvLicenseClasses);
        }

        private void _OpenUpdateLicenseClassForm(int LicenseClassID)
        {
            new frmUpdateLicenseClass(LicenseClassID).ShowDialog();
        }

        private void editClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenUpdateLicenseClassForm(Convert.ToInt32(dgvLicenseClasses.CurrentRow.Cells[0].Value));
            _RefreshLicenseClassesRecords();
        }
    }
}