using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Licenses.Local_Driving_License.Controls
{
    public partial class ctrlDriverLicenses : UserControl
    {
        DataTable _LocalLicensesTable = new DataTable();

        DataTable _InternationalLicensesTable = new DataTable();

        private int _DriverID = default(int);

        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }

        public void SetDriverID(int DriverID)
        {
            _DriverID = DriverID;
        }

        private void _AddColumnsToLocalLicensesTable()
        {
            DataColumn Col = new DataColumn();

            Col.ColumnName = "License ID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.AutoIncrementSeed = 1;
            Col.AutoIncrementStep = 1;
            Col.ReadOnly = true;
            Col.Unique = true;
            _LocalLicensesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Application ID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.AutoIncrementSeed = 1;
            Col.AutoIncrementStep = 1;
            Col.ReadOnly = true;
            Col.Unique = true;
            _LocalLicensesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Class Name";
            Col.DataType = typeof(string);
            _LocalLicensesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Issue Date";
            Col.DataType = typeof(string);
            _LocalLicensesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Expiration Date";
            Col.DataType = typeof(string);
            _LocalLicensesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Is Active";
            Col.DataType = typeof(bool);
            _LocalLicensesTable.Columns.Add(Col);
        }

        private void _AddRowsToLocalLicensesTable()
        {
            foreach (DataRow Row in clsLicense.GetLicensesList(_DriverID).Rows)
            {
                _LocalLicensesTable.Rows.Add(Row["LicenseID"], Row["ApplicationID"],
                    clsLicenseClass.FindLicenseClass(Convert.ToInt32(Row["LicenseClassID"])).ClassName,
                    clsFormat.SetDateFormat(Convert.ToDateTime(Row["IssueDate"]), "d/MM/yyyy"),
                    clsFormat.SetDateFormat(Convert.ToDateTime(Row["ExpirationDate"]), "d/MM/yyyy"), Row["IsActive"]);
            }
        }

        private void _CreateLocalLicensesTable()
        {
            _AddColumnsToLocalLicensesTable();
            _AddRowsToLocalLicensesTable();
            dgvLocalDrivingLicenses.DataSource = _LocalLicensesTable;
        }

        public void InitializeLocalLicenses()
        {
            _CreateLocalLicensesTable();
            clsUtil.SetRecordsNumber(lblLocalLicensesNumber, dgvLocalDrivingLicenses);
        }

        private void _AddColumnsToInternationalLicensesTable()
        {
            DataColumn Col = new DataColumn();

            Col.ColumnName = "International License ID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.AutoIncrementSeed = 1;
            Col.AutoIncrementStep = 1;
            Col.ReadOnly = true;
            Col.Unique = true;
            _InternationalLicensesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Application ID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.AutoIncrementSeed = 1;
            Col.AutoIncrementStep = 1;
            Col.ReadOnly = true;
            Col.Unique = true;
            _InternationalLicensesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Local License ID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.AutoIncrementSeed = 1;
            Col.AutoIncrementStep = 1;
            Col.ReadOnly = true;
            Col.Unique = true;
            _InternationalLicensesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Issue Date";
            Col.DataType = typeof(string);
            _InternationalLicensesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Expiration Date";
            Col.DataType = typeof(string);
            _InternationalLicensesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Is Active";
            Col.DataType = typeof(bool);
            _InternationalLicensesTable.Columns.Add(Col);
        }

        private void _AddRowsToInternationalLicensesTable()
        {
            foreach (DataRow Row in clsInternationalLicense.GetInternationalLicensesList(_DriverID).Rows)
            {
                _InternationalLicensesTable.Rows.Add(Row["InternationalLicenseID"], Row["ApplicationID"],
                    Row["IssuedUsingLocalLicenseID"],
                    clsFormat.SetDateFormat(Convert.ToDateTime(Row["IssueDate"]), "d/MM/yyyy"),
                    clsFormat.SetDateFormat(Convert.ToDateTime(Row["ExpirationDate"]), "d/MM/yyyy"), Row["IsActive"]);
            }
        }

        private void _CreateInternationalLicensesTable()
        {
            _AddColumnsToInternationalLicensesTable();
            _AddRowsToInternationalLicensesTable();
            dgvInternationalDrivingLicenses.DataSource = _InternationalLicensesTable;
        }

        public void InitializeInternationalLicenses()
        {
            _CreateInternationalLicensesTable();
            clsUtil.SetRecordsNumber(lblInternationalLicensesNumber, dgvInternationalDrivingLicenses);
        }
    }
}