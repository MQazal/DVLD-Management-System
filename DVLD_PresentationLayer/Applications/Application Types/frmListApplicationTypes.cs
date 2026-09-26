using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmListApplicationTypes : Form
    {
        DataTable _ApplicationTypesTable = new DataTable();

        public frmListApplicationTypes()
        {
            InitializeComponent();
        }

        private void _AddColumnsToTable()
        {
            DataColumn Col = new DataColumn();

            Col.ColumnName = "Application ID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.AutoIncrementSeed = 1;
            Col.AutoIncrementStep = 1;
            Col.ReadOnly = true;
            Col.Unique = true;
            _ApplicationTypesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Application Title";
            Col.DataType = typeof(string);
            _ApplicationTypesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Application Fees";
            Col.DataType = typeof(decimal);
            _ApplicationTypesTable.Columns.Add(Col);
        }

        private void _AddRowsToTable()
        {
            foreach (DataRow Row in clsApplicationType.GetApplicationTypesList().Rows)
            {
                _ApplicationTypesTable.Rows.Add(Row["ApplicationTypeID"], Row["ApplicationTitle"], Row["ApplicationFees"]);
            }
        }

        private void _InitializeApplicationTypesDataTable()
        {
            _AddColumnsToTable();
            _AddRowsToTable();
            dgvApplicationTypes.DataSource = _ApplicationTypesTable;
        }

        private void frmApplicationTypes_Load(object sender, EventArgs e)
        {
            clsUtil.SetScreenHeaderData(pcbxWall, Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Application Types 512.png"));
            _InitializeApplicationTypesDataTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvApplicationTypes);
            dgvApplicationTypes.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ClearTableRows()
        {
            _ApplicationTypesTable.Rows.Clear();
        }

        private void _RefreshApplicationTypesRecords()
        {
            _ClearTableRows();
            _AddRowsToTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvApplicationTypes);
        }

        private void _OpenUpdateApplicationTypeForm(int ApplicationTypeID)
        {
            new frmUpdateApplicationType(ApplicationTypeID).ShowDialog();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenUpdateApplicationTypeForm(Convert.ToInt32(dgvApplicationTypes.CurrentRow.Cells[0].Value));
            _RefreshApplicationTypesRecords();
        }
    }
}