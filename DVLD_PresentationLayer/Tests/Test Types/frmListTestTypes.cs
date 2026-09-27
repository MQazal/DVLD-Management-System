using DVLD_BusinessLogicLayer;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using DVLD_PresentationLayer.Global_Classes;

namespace DVLD_PresentationLayer
{
    public partial class frmListTestTypes : Form
    {
        public frmListTestTypes()
        {
            InitializeComponent();
        }

        private void _AddRowsToTable()
        {
            DataTable Table = clsTestType.GetTestsList();
            foreach (DataRow Row in Table.Rows)
            {
                dgvTestTypes.Rows.Add(Row["TestTypeID"], Row["TestTypeTitle"], Row["TestTypeDescription"], Row["TestTypeFees"]);
            }
        }

        private void frmTestTypes_Load(object sender, EventArgs e)
        {
            clsUtil.SetScreenHeaderData(pcbxWall, Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\TestType 512.png"));
            _AddRowsToTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvTestTypes);
            dgvTestTypes.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ClearTableRows()
        {
            dgvTestTypes.Rows.Clear();
        }

        private void _RefreshTestTypesRecords()
        {
            _ClearTableRows();
            _AddRowsToTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvTestTypes);
        }

        private void _OpenUpdateTestTypeForm(int TestTypeID)
        {
            new frmUpdateTestType(TestTypeID).ShowDialog();
        }

        private void editTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenUpdateTestTypeForm(Convert.ToInt32(dgvTestTypes.CurrentRow.Cells[0].Value));
            _RefreshTestTypesRecords();
        }
    }
}