using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using DVLD_PresentationLayer.Licenses.Local_Driving_License;
using DVLD_PresentationLayer.Licenses.Detain_License;

namespace DVLD_PresentationLayer.Applications.Release_Detained_License
{
    public partial class frmListDetainedLicenses : Form
    {
        DataTable _DetainedLicensesTable = new DataTable();

        public frmListDetainedLicenses()
        {
            InitializeComponent();
        }

        private void _AddColumnsToTable()
        {
            DataColumn Col = new DataColumn();

            Col.ColumnName = "Detain ID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.AutoIncrementSeed = 1;
            Col.AutoIncrementStep = 1;
            Col.ReadOnly = true;
            Col.Unique = true;
            _DetainedLicensesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "License ID";
            Col.DataType = typeof(int);
            _DetainedLicensesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Datain Date";
            Col.DataType = typeof(string);
            _DetainedLicensesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Is Released";
            Col.DataType = typeof(bool);
            _DetainedLicensesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Fine Fees";
            Col.DataType = typeof(decimal);
            _DetainedLicensesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Release Date";
            Col.DataType = typeof(string);
            _DetainedLicensesTable.Columns.Add(Col);


            Col = new DataColumn();
            Col.ColumnName = "National No.";
            Col.DataType = typeof(string);
            _DetainedLicensesTable.Columns.Add(Col);


            Col = new DataColumn();
            Col.ColumnName = "Full Name";
            Col.DataType = typeof(string);
            _DetainedLicensesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Release Application ID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.AutoIncrementSeed = 1;
            Col.AutoIncrementStep = 1;
            Col.ReadOnly = true;
            Col.Unique = true;
            _DetainedLicensesTable.Columns.Add(Col);
        }

        private void _AddRowsToTable()
        {
            DataTable Table = clsDetainedLicense.GetDetainedLicensesList();
            foreach (DataRow Row in Table.Rows)
            {
                _DetainedLicensesTable.Rows.Add(Row["DetainID"], Row["LicenseID"],
                    clsFormat.SetDateFormat(Convert.ToDateTime(Row["DetainDate"]), "d/MM/yyyy"),
                    Row["IsReleased"], Row["FineFees"], Row["ReleaseDate"], Row["NationalNumber"],
                    Row["FullName"], Row["ReleaseApplicationID"]);
            }
        }

        private void _InitializeDetainedLicensesDataTable()
        {
            _AddColumnsToTable();
            _AddRowsToTable();
            dgvDetainedLicenses.DataSource = _DetainedLicensesTable;
        }

        private void frmListDetainedLicenses_Load(object sender, EventArgs e)
        {
            clsUtil.SetScreenHeaderData(pcbxTitleImage, Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Detain 512.png"));
            _InitializeDetainedLicensesDataTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvDetainedLicenses);
            clsUtil.SetDefaultStateOfFilter(cmbxFilter, txbxFilter);
            clsUtil.SetDefaultStateOfFilter(cmbxIsReleased);
            dgvDetainedLicenses.ClearSelection();
        }

        private void PesonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmShowPerson(clsLicense.FindLicenseByLicenseID
                (Convert.ToInt32(dgvDetainedLicenses.CurrentRow.Cells[1].Value)).DriverInfo.PersonInfo.PersonID).ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmShowLocalDrivingLicenseInfo(Convert.ToInt32(dgvDetainedLicenses.CurrentRow.Cells[1].Value)).ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmShowLicenseHistoryOfPerson(clsLicense.FindLicenseByLicenseID
                (Convert.ToInt32(dgvDetainedLicenses.CurrentRow.Cells[1].Value)).DriverInfo.PersonInfo.PersonID).ShowDialog();
        }

        private void _ClearTableRows()
        {
            _DetainedLicensesTable.Rows.Clear();
        }

        private void _RefreshDetainedLicensesRecords()
        {
            _ClearTableRows();
            _AddRowsToTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvDetainedLicenses);
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmReleaseDetainedLicenseApplication(Convert.ToInt32(dgvDetainedLicenses.CurrentRow.Cells[1].Value)).ShowDialog();
            _RefreshDetainedLicensesRecords();
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            new frmDetainLicense().ShowDialog();
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            new frmReleaseDetainedLicenseApplication().ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        enum _enFilterField
        {
            enNone,
            enDetainID,
            enIsReleased,
            enNationalNo,
            enFullName,
            enReleaseApplicationID
        }

        _enFilterField _FilterType;

        private _enFilterField _GetFilterFiled(int SelectedIndex)
        {
            switch (SelectedIndex)
            {
                case 0:
                    return _enFilterField.enNone;

                case 1:
                    return _enFilterField.enDetainID;

                case 2:
                    return _enFilterField.enIsReleased;

                case 3:
                    return _enFilterField.enNationalNo;

                case 4:
                    return _enFilterField.enFullName;
            }

            return _enFilterField.enReleaseApplicationID;
        }

        private void _UpdateFilterState()
        {
            if (_FilterType == _enFilterField.enNone)
            {
                clsUtil.SetDefaultStateOfFilter(cmbxFilter, txbxFilter);
                clsUtil.SetDefaultStateOfFilter(cmbxIsReleased);
            }
            else if (_FilterType == _enFilterField.enIsReleased)
                clsUtil.SetVisibilityMode(cmbxIsReleased, true, txbxFilter, false);
            else
                clsUtil.SetVisibilityMode(cmbxIsReleased, false, txbxFilter, true);
        }

        private int _GetFilterRowsCount(DataView View, string ColumnName)
        {
            if (string.IsNullOrEmpty(txbxFilter.Text))
                return 0;

            if (ColumnName == "[Detain ID]" || ColumnName == "[Release Application ID]")
                View.RowFilter = $"{ColumnName} = {Convert.ToInt32(txbxFilter.Text)}";

            else
                View.RowFilter = $"{ColumnName} LIKE '{txbxFilter.Text}%'";

            return View.Count;
        }

        private void _FilterRows(DataView View, string ColumnName)
        {
            if (_GetFilterRowsCount(View, ColumnName) == 0)
            {
                View.RowFilter = "";
                clsUtil.SetRecordsNumber(lblRecordsNumber, dgvDetainedLicenses);
            }
            else
                clsUtil.SetRecordsNumber(lblRecordsNumber, View);
        }

        private void _SetFilterView()
        {
            switch (_FilterType)
            {
                case _enFilterField.enDetainID:
                    _FilterRows(_DetainedLicensesTable.DefaultView, "[Detain ID]");
                    break;

                case _enFilterField.enNationalNo:
                    _FilterRows(_DetainedLicensesTable.DefaultView, "[National No.]");
                    break;

                case _enFilterField.enFullName:
                    _FilterRows(_DetainedLicensesTable.DefaultView, "[Full Name]");
                    break;

                case _enFilterField.enReleaseApplicationID:
                    _FilterRows(_DetainedLicensesTable.DefaultView, "[Release Application ID]");
                    break;
            }
        }

        enum _enIsReleasedFilter
        {
            All,
            Yes,
            No
        }

        private _enIsReleasedFilter _GetReleasedFlag(int SelectedIndex)
        {
            switch (SelectedIndex)
            {
                case 0:
                    return _enIsReleasedFilter.All;

                case 1:
                    return _enIsReleasedFilter.Yes;
            }

            return _enIsReleasedFilter.No;
        }

        private void _FilterByReleasedFlag(DataView View, _enIsReleasedFilter Flag)
        {
            switch (Flag)
            {
                case _enIsReleasedFilter.All:
                    View.RowFilter = "";
                    clsUtil.SetRecordsNumber(lblRecordsNumber, dgvDetainedLicenses);
                    break;

                case _enIsReleasedFilter.Yes:
                    View.RowFilter = "[Is Released] = 'true'";
                    clsUtil.SetRecordsNumber(lblRecordsNumber, View);
                    break;

                case _enIsReleasedFilter.No:
                    View.RowFilter = "[Is Released] = 'false'";
                    clsUtil.SetRecordsNumber(lblRecordsNumber, View);
                    break;
            }
        }

        private void _SelectFilter()
        {
            cmbxIsReleased.SelectedIndex = 0;
            txbxFilter.Text = "";
            _FilterType = _GetFilterFiled(cmbxFilter.SelectedIndex);
            _UpdateFilterState();
        }

        private void txbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_FilterType == _enFilterField.enNone)
                return;

            if (_FilterType == _enFilterField.enDetainID || _FilterType == _enFilterField.enReleaseApplicationID)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            else if (_FilterType == _enFilterField.enNationalNo)
                e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            else
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectFilter();
        }

        private void cmbxIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterByReleasedFlag(_DetainedLicensesTable.DefaultView, _GetReleasedFlag(cmbxIsReleased.SelectedIndex));
        }

        private void txbxFilter_TextChanged(object sender, EventArgs e)
        {
            _SetFilterView();
        }
    }
}