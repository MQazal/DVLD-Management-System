using System;
using DVLD_BusinessLogicLayer;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using DVLD_PresentationLayer.Licenses.Local_Driving_License;
using DVLD_PresentationLayer.Global_Classes;

namespace DVLD_PresentationLayer.Drivers
{
    public partial class frmListDrivers : Form
    {
        DataTable _DriversTable = new DataTable();

        public frmListDrivers()
        {
            InitializeComponent();
        }

        private void _AddColumnsToTable()
        {
            _DriversTable.Columns.Add("Driver ID", typeof(int));
            _DriversTable.Columns.Add("Person ID", typeof(int));
            _DriversTable.Columns.Add("National Number", typeof(string));
            _DriversTable.Columns.Add("Full Name", typeof(string));
            _DriversTable.Columns.Add("Created Date", typeof(string));
            _DriversTable.Columns.Add("Active Licenses", typeof(byte));
        }

        private void _AddRowsToTable()
        {
            DataTable Table = clsDriver.GetDriversList();
            foreach (DataRow Row in Table.Rows)
            {
                _DriversTable.Rows.Add(Row["DriverID"], Row["PersonID"], Row["NationalNumber"], Row["FullName"],
                    clsFormat.SetDateFormat(Convert.ToDateTime(Row["CreatedDate"]), "d/MM/yyyy"),
                    Row["NumberOfActiveLicenses"]);
            }
        }

        private void _InitializeDriversDataTable()
        {
            _AddColumnsToTable();
            _AddRowsToTable();
            dgvDrivers.DataSource = _DriversTable;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        enum _enFilterField
        {
            enNone,
            enDriverID,
            enPersonID,
            enNationalNumber,
            enFullName,
            enActiveLicenses
        }

        _enFilterField _FilterType;

        private _enFilterField _GetFilterField(int SelectedIndex)
        {
            switch (SelectedIndex)
            {
                case 0:
                    return _enFilterField.enNone;
                case 1:
                    return _enFilterField.enDriverID;
                case 2:
                    return _enFilterField.enPersonID;
                case 3:
                    return _enFilterField.enNationalNumber;
                case 4:
                    return _enFilterField.enFullName;
            }
            return _enFilterField.enActiveLicenses;
        }

        private void _UpdateFilterState()
        {
            if (_FilterType == _enFilterField.enNone)
                clsUtil.SetDefaultStateOfFilter(cmbxFilter, txbxFilter);
            else
                txbxFilter.Visible = true;
        }

        private int _GetFilterRowsCount(DataView View, string ColumnName)
        {
            if (string.IsNullOrEmpty(txbxFilter.Text))
                return 0;

            if (ColumnName == "[Driver ID]" || ColumnName == "[Person ID]" || ColumnName == "[Active Licenses]")
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
                clsUtil.SetRecordsNumber(lblRecordsNumber, dgvDrivers);
            }
            else
                clsUtil.SetRecordsNumber(lblRecordsNumber, View);
        }

        private void _SetFilterView()
        {
            switch (_FilterType)
            {
                case _enFilterField.enDriverID:
                    _FilterRows(_DriversTable.DefaultView, "[Driver ID]");
                    break;

                case _enFilterField.enPersonID:
                    _FilterRows(_DriversTable.DefaultView, "[Person ID]");
                    break;

                case _enFilterField.enNationalNumber:
                    _FilterRows(_DriversTable.DefaultView, "[National Number]");
                    break;

                case _enFilterField.enFullName:
                    _FilterRows(_DriversTable.DefaultView, "[Full Name]");
                    break;

                case _enFilterField.enActiveLicenses:
                    _FilterRows(_DriversTable.DefaultView, "[Active Licenses]");
                    break;
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmShowPerson(Convert.ToInt32(dgvDrivers.CurrentRow.Cells[1].Value)).ShowDialog();
        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            clsUtil.SetScreenHeaderData(pcbxImage, Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Driver Main.png"));
            _InitializeDriversDataTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvDrivers);
            clsUtil.SetDefaultStateOfFilter(cmbxFilter, txbxFilter);
            dgvDrivers.ClearSelection();
        }

        private void _SelectFitler()
        {
            txbxFilter.Text = "";
            _FilterType = _GetFilterField(cmbxFilter.SelectedIndex);
            _UpdateFilterState();
        }

        private void cmbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectFitler();
        }

        private void txbxFilter_TextChanged(object sender, EventArgs e)
        {
            _SetFilterView();
        }

        private void txbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_FilterType == _enFilterField.enNone)
                return;

            if (_FilterType == _enFilterField.enDriverID || _FilterType == _enFilterField.enPersonID
                || _FilterType == _enFilterField.enActiveLicenses)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            else if (_FilterType == _enFilterField.enNationalNumber)
                e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            else
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmShowLicenseHistoryOfPerson(Convert.ToInt32(dgvDrivers.CurrentRow.Cells[1].Value)).ShowDialog();
        }
    }
}