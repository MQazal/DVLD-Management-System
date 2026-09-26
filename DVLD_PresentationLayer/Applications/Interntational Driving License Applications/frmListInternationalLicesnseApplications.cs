using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using DVLD_PresentationLayer.Licenses.International_Licenses;
using DVLD_PresentationLayer.Licenses.Local_Driving_License;

namespace DVLD_PresentationLayer.Applications.Interntational_Driving_License_Applications
{
    public partial class frmListInternationalLicesnseApplications : Form
    {
        DataTable _InternationaLicenseApplicationsTable = new DataTable();

        public frmListInternationalLicesnseApplications()
        {
            InitializeComponent();
        }

        private void _AddColumnsToTable()
        {
            DataColumn Col = new DataColumn();

            Col.ColumnName = "International License ID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.AutoIncrementSeed = 1;
            Col.AutoIncrementStep = 1;
            Col.ReadOnly = true;
            Col.Unique = true;
            _InternationaLicenseApplicationsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Application ID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.AutoIncrementSeed = 1;
            Col.AutoIncrementStep = 1;
            Col.ReadOnly = true;
            Col.Unique = true;
            _InternationaLicenseApplicationsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Driver ID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.AutoIncrementSeed = 1;
            Col.AutoIncrementStep = 1;
            Col.ReadOnly = true;
            Col.Unique = true;
            _InternationaLicenseApplicationsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Local License ID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.AutoIncrementSeed = 1;
            Col.AutoIncrementStep = 1;
            Col.ReadOnly = true;
            Col.Unique = true;
            _InternationaLicenseApplicationsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Issue Date";
            Col.DataType = typeof(string);
            _InternationaLicenseApplicationsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Expiration Date";
            Col.DataType = typeof(string);
            _InternationaLicenseApplicationsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Is Active";
            Col.DataType = typeof(bool);
            _InternationaLicenseApplicationsTable.Columns.Add(Col);
        }

        private void _AddRowsToTable()
        {
            foreach (DataRow Row in clsInternationalLicense.GetInternationalLicensesList().Rows)
            {
                _InternationaLicenseApplicationsTable.Rows.Add(Row["InternationalLicenseID"], Row["ApplicationID"],
                    Row["DriverID"], Row["IssuedUsingLocalLicenseID"],
                    clsFormat.SetDateFormat(Convert.ToDateTime(Row["IssueDate"]), "d/MM/yyyy"),
                    clsFormat.SetDateFormat(Convert.ToDateTime(Row["ExpirationDate"]), "d/MM/yyyy"), Row["IsActive"]);
            }
        }

        private void _InitializeInternationalDrivingLicenseApplicationsDataTable()
        {
            _AddColumnsToTable();
            _AddRowsToTable();
            dgvInternationalApplications.DataSource = _InternationaLicenseApplicationsTable;
        }

        private void frmListInternationalLicesnseApplications_Load(object sender, EventArgs e)
        {
            clsUtil.SetScreenHeaderData(pcbxImage1, Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Applications.png"));
            clsUtil.SetScreenHeaderData(pcbxImage2, Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\International 32.png"));
            _InitializeInternationalDrivingLicenseApplicationsDataTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvInternationalApplications);
            clsUtil.SetDefaultStateOfFilter(cmbxFilter, txbxFilter);
            dgvInternationalApplications.ClearSelection();
        }

        private void _ClearTableRows()
        {
            _InternationaLicenseApplicationsTable.Rows.Clear();
        }

        private void _RefreshApplicationsRecords()
        {
            _ClearTableRows();
            _AddRowsToTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvInternationalApplications);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmNewInternationalLicenseApplication().ShowDialog();
            _RefreshApplicationsRecords();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmShowPerson(clsInternationalLicense.FindInternationalLicenseByInternationalLicenseID(Convert.ToInt32(dgvInternationalApplications.CurrentRow.Cells[0].Value)).DriverInfo.PersonInfo.PersonID).ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmShowInternationalDrivingLicenseInfo(Convert.ToInt32(dgvInternationalApplications.CurrentRow.Cells[0].Value)).ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmShowLicenseHistoryOfPerson(clsInternationalLicense.FindInternationalLicenseByInternationalLicenseID(Convert.ToInt32(dgvInternationalApplications.CurrentRow.Cells[0].Value)).DriverInfo.PersonInfo.PersonID).ShowDialog();
        }

        enum _enFilterField
        {
            enNone,
            enIntLicenseID,
            enAppID,
            enDriverID,
            enLocalLicenseID,
            enIsActive
        }

        _enFilterField _Filter;

        private _enFilterField _GetFilterType()
        {
            switch (cmbxFilter.SelectedIndex)
            {
                case 0:
                    return _enFilterField.enNone;

                case 1:
                    return _enFilterField.enIntLicenseID;

                case 2:
                    return _enFilterField.enAppID;

                case 3:
                    return _enFilterField.enDriverID;

                case 4:
                    return _enFilterField.enLocalLicenseID;
            }

            return _enFilterField.enIsActive;
        }

        private void _UpdateFilterState()
        {
            if (_Filter == _enFilterField.enNone)
            {
                clsUtil.SetDefaultStateOfFilter(cmbxFilter, txbxFilter);
                clsUtil.SetDefaultStateOfFilter(cmbxIsActiveBox);
            }

            else if (_Filter == _enFilterField.enIsActive)
                clsUtil.SetVisibilityMode(cmbxIsActiveBox, true, txbxFilter, false);

            else
                clsUtil.SetVisibilityMode(cmbxIsActiveBox, false, txbxFilter, true);
        }

        private void _SelectFilter()
        {
            cmbxIsActiveBox.SelectedIndex = 0;
            txbxFilter.Text = "";
            _Filter = _GetFilterType();
            _UpdateFilterState();
        }

        private void cmbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectFilter();
        }

        private void txbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_Filter == _enFilterField.enNone)
                return;

            if (_Filter == _enFilterField.enIntLicenseID || _Filter == _enFilterField.enAppID || _Filter == _enFilterField.enDriverID
                || _Filter == _enFilterField.enLocalLicenseID)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private int _GetFilterRowsCount(DataView View, string ColumnName)
        {
            if (string.IsNullOrEmpty(txbxFilter.Text))
                return 0;

            View.RowFilter = $"{ColumnName} = {Convert.ToInt32(txbxFilter.Text)}";

            return View.Count;
        }

        private void _FilterRows(DataView View, string ColumnName)
        {
            if (_GetFilterRowsCount(View, ColumnName) == 0)
            {
                View.RowFilter = "";
                clsUtil.SetRecordsNumber(lblRecordsNumber, dgvInternationalApplications);
            }
            else
                clsUtil.SetRecordsNumber(lblRecordsNumber, View);
        }

        private void _SetFilterView()
        {
            switch (_Filter)
            {
                case _enFilterField.enIntLicenseID:
                    _FilterRows(_InternationaLicenseApplicationsTable.DefaultView, "[International License ID]");
                    break;

                case _enFilterField.enAppID:
                    _FilterRows(_InternationaLicenseApplicationsTable.DefaultView, "[Application ID]");
                    break;

                case _enFilterField.enDriverID:
                    _FilterRows(_InternationaLicenseApplicationsTable.DefaultView, "[Driver ID]");
                    break;

                case _enFilterField.enLocalLicenseID:
                    _FilterRows(_InternationaLicenseApplicationsTable.DefaultView, "[Local License ID]");
                    break;
            }
        }

        private void txbxFilter_TextChanged(object sender, EventArgs e)
        {
            _SetFilterView();
        }

        enum _enIsActiveFilter
        {
            All,
            Yes,
            No
        }

        private _enIsActiveFilter _GetActiveFlag(int SelectedIndex)
        {
            switch (SelectedIndex)
            {
                case 0:
                    return _enIsActiveFilter.All;

                case 1:
                    return _enIsActiveFilter.Yes;
            }

            return _enIsActiveFilter.No;
        }

        private void _FilterByActiveFlag(DataView View, _enIsActiveFilter Flag)
        {
            switch (Flag)
            {
                case _enIsActiveFilter.All:
                    View.RowFilter = "";
                    clsUtil.SetRecordsNumber(lblRecordsNumber, dgvInternationalApplications);
                    break;

                case _enIsActiveFilter.Yes:
                    View.RowFilter = "[Is Active] = 'true'";
                    clsUtil.SetRecordsNumber(lblRecordsNumber, View);
                    break;

                case _enIsActiveFilter.No:
                    View.RowFilter = "[Is Active] = 'false'";
                    clsUtil.SetRecordsNumber(lblRecordsNumber, View);
                    break;
            }
        }

        private void cmbxIsActiveBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterByActiveFlag(_InternationaLicenseApplicationsTable.DefaultView, _GetActiveFlag(cmbxIsActiveBox.SelectedIndex));
        }
    }
}