using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Applications.Local_License_Applications;
using DVLD_PresentationLayer.Global_Classes;
using DVLD_PresentationLayer.Licenses.Local_Driving_License;
using DVLD_PresentationLayer.Tests;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications.Local_Driving_License_Applications
{
    public partial class frmListLocalDrivingLicenseApplications : Form
    {
        DataTable _LocalDrivingLicenseApplicationsTable = new DataTable();

        enum _enMenuCase { ApplicationIsCancled, NotPass, PassWihtoutLicense, PassWithLicense }

        public frmListLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void _AddColumnsToTable()
        {
            DataColumn Col = new DataColumn();

            Col.ColumnName = "L.D.L.AppID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.AutoIncrementSeed = 1;
            Col.AutoIncrementStep = 1;
            Col.ReadOnly = true;
            Col.Unique = true;
            _LocalDrivingLicenseApplicationsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Driving Class";
            Col.DataType = typeof(string);
            _LocalDrivingLicenseApplicationsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "National No.";
            Col.DataType = typeof(string);
            _LocalDrivingLicenseApplicationsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Full Name";
            Col.DataType = typeof(string);
            _LocalDrivingLicenseApplicationsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Application Date";
            Col.DataType = typeof(string);
            _LocalDrivingLicenseApplicationsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Passed Tests Number";
            Col.DataType = typeof(byte);
            _LocalDrivingLicenseApplicationsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Status";
            Col.DataType = typeof(string);
            _LocalDrivingLicenseApplicationsTable.Columns.Add(Col);
        }

        private void _AddRowsToTable()
        {
            DataTable Table = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationsList();
            foreach (DataRow Row in Table.Rows)
            {
                _LocalDrivingLicenseApplicationsTable.Rows.Add(Row["LocalDrivingLicenseApplicationID"], Row["ClassName"],
                    Row["NationalNumber"], Row["FullName"],
                    clsFormat.SetDateFormat(Convert.ToDateTime(Row["ApplicationDate"]), "d/MM/yyyy"),
                    Row["NumberOfPassedTests"], Row["Status"]);
            }
        }

        private void _InitializeLocalDrivingLicenseApplicationsDataTable()
        {
            _AddColumnsToTable();
            _AddRowsToTable();
            dgvLocalApplications.DataSource = _LocalDrivingLicenseApplicationsTable;
        }

        private void _SetMenuDefaultEnabledState()
        {
            editApplicationToolStripMenuItem.Enabled = true;
            deleteApplicationToolStripMenuItem.Enabled = true;
            cancelApplicationToolStripMenuItem.Enabled = true;
            sechduleTestsToolStripMenuItem.Enabled = true;
            issueDrivingLisenceFirstTimeToolStripMenuItem.Enabled = true;
            showLicenseToolStripMenuItem.Enabled = true;
            showPersonLicenseHistoryToolStripMenuItem.Enabled = true;
        }

        private void _HandleNotPassedTestsCase(int L_D_L_AppID, _enMenuCase Case)
        {
            if (Case == _enMenuCase.ApplicationIsCancled)
            {
                editApplicationToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = false;
                sechduleTestsToolStripMenuItem.Enabled = false;
            }

            else
            {
                editApplicationToolStripMenuItem.Enabled = true;
                deleteApplicationToolStripMenuItem.Enabled = true;
                cancelApplicationToolStripMenuItem.Enabled = true;
                sechduleTestsToolStripMenuItem.Enabled = true;
                _HandleTestBookingItemsState(L_D_L_AppID);
            }

            // Shared Items:
            issueDrivingLisenceFirstTimeToolStripMenuItem.Enabled = false;
            showLicenseToolStripMenuItem.Enabled = false;
            showPersonLicenseHistoryToolStripMenuItem.Enabled = false;
        }

        private void _HandlePassedTestsCase(int L_D_L_AppID, _enMenuCase Case)
        {
            if (Case == _enMenuCase.PassWihtoutLicense)
            {
                issueDrivingLisenceFirstTimeToolStripMenuItem.Enabled = true;
                showLicenseToolStripMenuItem.Enabled = false;
                showPersonLicenseHistoryToolStripMenuItem.Enabled = false;
            }

            else
            {
                issueDrivingLisenceFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = true;
                showPersonLicenseHistoryToolStripMenuItem.Enabled = true;
            }

            // Shared Items:
            editApplicationToolStripMenuItem.Enabled = false;
            deleteApplicationToolStripMenuItem.Enabled = false;
            cancelApplicationToolStripMenuItem.Enabled = false;
            sechduleTestsToolStripMenuItem.Enabled = false;
        }

        private void _SetMenuCustomEnabledState(int L_D_L_AppID)
        {
            _enMenuCase Case = _GetCurrentMenuCase(L_D_L_AppID);

            if (Case == _enMenuCase.ApplicationIsCancled || Case == _enMenuCase.NotPass)
                _HandleNotPassedTestsCase(L_D_L_AppID, Case);
            else
                _HandlePassedTestsCase(L_D_L_AppID, Case);
        }

        private void _EnableTestsBookingItems(bool EnableState)
        {
            sechduleVisionTestToolStripMenuItem.Enabled = EnableState;
            sechduleWrittenTestToolStripMenuItem.Enabled = EnableState;
            sechduleStreetTestToolStripMenuItem.Enabled = EnableState;
        }

        private void _SetTestsBookingItemsBasedOnPassedTests(int L_D_L_AppID)
        {
            if (!clsLocalDrivingLicenseApplication.IsPersonPassTestType(L_D_L_AppID, clsTestType.enTestType.VisionTest))
            {
                sechduleWrittenTestToolStripMenuItem.Enabled = false;
                sechduleStreetTestToolStripMenuItem.Enabled = false;
            }

            else if (!clsLocalDrivingLicenseApplication.IsPersonPassTestType(L_D_L_AppID, clsTestType.enTestType.WrittenTest))
            {
                sechduleVisionTestToolStripMenuItem.Enabled = false;
                sechduleStreetTestToolStripMenuItem.Enabled = false;
            }

            else if (!clsLocalDrivingLicenseApplication.IsPersonPassTestType(L_D_L_AppID, clsTestType.enTestType.StreetTest))
            {
                sechduleVisionTestToolStripMenuItem.Enabled = false;
                sechduleWrittenTestToolStripMenuItem.Enabled = false;
            }

            // Person passed all Tests
            else
            {
                _EnableTestsBookingItems(false);
            }
        }

        private void _HandleTestBookingItemsState(int L_D_L_AppID)
        {
            _EnableTestsBookingItems(true);
            _SetTestsBookingItemsBasedOnPassedTests(L_D_L_AppID);
        }

        private void frmListLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            clsUtil.SetScreenHeaderData(pcbxImage1, Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Applications.png"));
            clsUtil.SetScreenHeaderData(pcbxImage2, Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Local 32.png"));
            _InitializeLocalDrivingLicenseApplicationsDataTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvLocalApplications);
            clsUtil.SetDefaultStateOfFilter(cmbxFilter, txbxFilter);
            dgvLocalApplications.ClearSelection();
        }

        private void _ClearTableRows()
        {
            _LocalDrivingLicenseApplicationsTable.Rows.Clear();
        }

        private void _RefreshApplicationsRecords()
        {
            _ClearTableRows();
            _AddRowsToTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvLocalApplications);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmAdd_UpdateLocalDrivingLicenseApplication(-1).ShowDialog();
            _RefreshApplicationsRecords();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showApplicationDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmShowLocalDrivingLicenseApplication(Convert.ToInt32(dgvLocalApplications.CurrentRow.Cells[0].Value)).ShowDialog();
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAdd_UpdateLocalDrivingLicenseApplication(clsLocalDrivingLicenseApplication.FindLocalDrvingLicenseAppByLocalAppID
                (Convert.ToInt32(dgvLocalApplications.CurrentRow.Cells[0].Value)).ApplicationID).ShowDialog();
            _RefreshApplicationsRecords();
        }

        private void _DeleteApplication()
        {
            if (MessageBox.Show($"Are you sure you want to delete Application [{dgvLocalApplications.CurrentRow.Cells[0].Value}]?", "Confirm Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int ApplicationID = clsLocalDrivingLicenseApplication.FindLocalDrvingLicenseAppByLocalAppID(Convert.ToInt32(dgvLocalApplications.CurrentRow.Cells[0].Value)).ApplicationID;
                if (clsLocalDrivingLicenseApplication.DeleteLocalDrivingLicenseApplication(ApplicationID))
                    MessageBox.Show("Application is deleted sucessfully", "Finish Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to delete application", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeleteApplication();
            _RefreshApplicationsRecords();
        }

        private void _CancelApplication()
        {
            clsApplication App = clsApplication.FindApplication(clsLocalDrivingLicenseApplication.FindLocalDrvingLicenseAppByLocalAppID(Convert.ToInt32(dgvLocalApplications.CurrentRow.Cells[0].Value)).ApplicationID);
            if (MessageBox.Show($"Are you sure you want to cancel application?", "Confirm Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (App.Cancel())
                {
                    MessageBox.Show($"Application of Number [{Convert.ToInt32(dgvLocalApplications.CurrentRow.Cells[0].Value)}] is Canceled Successfully!", "Finish Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CancelApplication();
            _RefreshApplicationsRecords();
        }

        private void sechduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmListTestAppointments(Convert.ToInt32(dgvLocalApplications.CurrentRow.Cells[0].Value),
                clsTestType.enTestType.VisionTest).ShowDialog();
        }

        private void sechduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmListTestAppointments(Convert.ToInt32(dgvLocalApplications.CurrentRow.Cells[0].Value),
                clsTestType.enTestType.WrittenTest).ShowDialog();
        }

        private void sechduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmListTestAppointments(Convert.ToInt32(dgvLocalApplications.CurrentRow.Cells[0].Value),
                clsTestType.enTestType.StreetTest).ShowDialog();
        }

        private void issueDrivingLisenceFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmIssueDrivingLicenseFirstTime(Convert.ToInt32(dgvLocalApplications.CurrentRow.Cells[0].Value));
            _RefreshApplicationsRecords();
        }

        private void _OpenShowLicenseForm(int LocalDrivingLicenseApplicationID)
        {
            new frmShowLocalDrivingLicenseInfo(clsLicense.FindLicenseByApplicationID(clsLocalDrivingLicenseApplication.FindLocalDrvingLicenseAppByLocalAppID(LocalDrivingLicenseApplicationID).ApplicationID).LicenseID).ShowDialog();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenShowLicenseForm(Convert.ToInt32(dgvLocalApplications.CurrentRow.Cells[0].Value));
        }

        private void _OpenLicensesHistoryForm(int LocalAppID)
        {
            new frmShowLicenseHistoryOfPerson(clsLocalDrivingLicenseApplication.FindLocalDrvingLicenseAppByLocalAppID(LocalAppID).PersonInfo.PersonID).ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenLicensesHistoryForm(Convert.ToInt32(dgvLocalApplications.CurrentRow.Cells[0].Value));
        }

        enum _enFilterField
        {
            enNone,
            enAppID,
            enNationalNumber,
            enFullName,
            enStatus
        }

        _enFilterField _Filter;

        private _enFilterField _GetFilterType()
        {
            switch (cmbxFilter.SelectedIndex)
            {
                case 0:
                    return _enFilterField.enNone;
                case 1:
                    return _enFilterField.enAppID;
                case 2:
                    return _enFilterField.enNationalNumber;
                case 3:
                    return _enFilterField.enFullName;
            }
            return _enFilterField.enStatus;
        }

        private void _UpdateFilterState()
        {
            if (_Filter == _enFilterField.enNone)
                clsUtil.SetDefaultStateOfFilter(cmbxFilter, txbxFilter);
            else
                txbxFilter.Visible = true;
        }

        private void _SelectFilter()
        {
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

            if (_Filter == _enFilterField.enAppID)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            else if (_Filter == _enFilterField.enNationalNumber)
                e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            else if (_Filter == _enFilterField.enStatus)
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);

            else
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private int _GetFilterRowsCount(DataView View, string ColumnName)
        {
            if (string.IsNullOrEmpty(txbxFilter.Text))
                return 0;

            else if (ColumnName == "[L.D.L.AppID]")
                View.RowFilter = $"[L.D.L.AppID] = {Convert.ToInt32(txbxFilter.Text)}";

            else
                View.RowFilter = $"{ColumnName} LIKE '{txbxFilter.Text}%'";

            return View.Count;
        }

        private void _FilterRows(DataView View, string ColumnName)
        {
            if (_GetFilterRowsCount(View, ColumnName) == 0)
            {
                View.RowFilter = "";
                clsUtil.SetRecordsNumber(lblRecordsNumber, dgvLocalApplications);
            }
            else
                clsUtil.SetRecordsNumber(lblRecordsNumber, View);
        }

        private void _SetFilterView()
        {
            switch (_Filter)
            {
                case _enFilterField.enAppID:
                    _FilterRows(_LocalDrivingLicenseApplicationsTable.DefaultView, "[L.D.L.AppID]");
                    break;

                case _enFilterField.enNationalNumber:
                    _FilterRows(_LocalDrivingLicenseApplicationsTable.DefaultView, "[National No.]");
                    break;

                case _enFilterField.enFullName:
                    _FilterRows(_LocalDrivingLicenseApplicationsTable.DefaultView, "[Full Name]");
                    break;

                case _enFilterField.enStatus:
                    _FilterRows(_LocalDrivingLicenseApplicationsTable.DefaultView, "[Status]");
                    break;
            }
        }

        private void txbxFilter_TextChanged(object sender, EventArgs e)
        {
            _SetFilterView();
        }

        private _enMenuCase _GetCurrentMenuCase(int L_D_L_AppID)
        {
            clsLocalDrivingLicenseApplication Application = clsLocalDrivingLicenseApplication.FindLocalDrvingLicenseAppByLocalAppID(L_D_L_AppID);

            if (Application.ApplicationStatus == clsApplication.enApplicationStatus.Cancelled)
                return _enMenuCase.ApplicationIsCancled;

            else if (Application.ApplicationStatus == clsApplication.enApplicationStatus.Completed)
                return _enMenuCase.PassWithLicense;

            else if (Application.TotalPassedTests() == 3)
                return _enMenuCase.PassWihtoutLicense;

            else
                return _enMenuCase.NotPass;
        }

        private void dgvLocalApplications_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.Button == MouseButtons.Right)
            {
                dgvLocalApplications.ClearSelection();
                dgvLocalApplications.Rows[e.RowIndex].Selected = true;
                dgvLocalApplications.CurrentCell = dgvLocalApplications.Rows[e.RowIndex].Cells[e.ColumnIndex >= 0 ? e.ColumnIndex : 0];

                _SetMenuDefaultEnabledState();
                _SetMenuCustomEnabledState(Convert.ToInt32(dgvLocalApplications.CurrentRow.Cells[0].Value));
            }
        }
    }
}