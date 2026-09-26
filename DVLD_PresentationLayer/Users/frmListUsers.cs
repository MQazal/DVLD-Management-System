using System;
using System.Windows.Forms;
using DVLD_BusinessLogicLayer;
using System.Drawing;
using System.Data;
using DVLD_PresentationLayer.Global_Classes;

namespace DVLD_PresentationLayer
{
    public partial class frmListUsers : Form
    {
        DataTable _UsersTable = new DataTable();

        public frmListUsers()
        {
            InitializeComponent();
        }

        private void _AddColumnsToTable()
        {
            _UsersTable.Columns.Add("User ID", typeof(int));
            _UsersTable.Columns.Add("Person ID", typeof(int));
            _UsersTable.Columns.Add("Full Name", typeof(string));
            _UsersTable.Columns.Add("Username", typeof(string));
            _UsersTable.Columns.Add("Is Active", typeof(bool));
        }

        private void _AddRowsToTable()
        {
            foreach (DataRow Row in clsUser.GetUsersList().Rows)
            {
                _UsersTable.Rows.Add(Row["UserID"], Row["PersonID"], clsPerson.FindPerson(Convert.ToInt32(Row["PersonID"])).FullName,
                    Row["Username"], Row["IsActive"]);
            }
        }

        private void _InitializeUsersDataTable()
        {
            _AddColumnsToTable();
            _AddRowsToTable();
            dgvUsers.DataSource = _UsersTable;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            clsUtil.SetScreenHeaderData(pcbxImage, Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Users 2 400.png"));
            _InitializeUsersDataTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvUsers);
            clsUtil.SetDefaultStateOfFilter(cmbxFilter, tbxFilter);
            clsUtil.SetDefaultStateOfFilter(cmbxIsActiveBox);
            dgvUsers.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmAdd_UpdateUser(-1).ShowDialog();
            _RefreshUsersRecords();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAdd_UpdateUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value)).ShowDialog();
            _RefreshUsersRecords();
        }

        private void _DeleteUser()
        {
            if (MessageBox.Show($"Are you sure you want to delete user [{dgvUsers.CurrentRow.Cells[0].Value.ToString()}]?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clsUser.DeleteUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value), Convert.ToInt32(dgvUsers.CurrentRow.Cells[1].Value));
                MessageBox.Show("Person is deleted sucessfully", "Finish Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void _ClearTableRows()
        {
            _UsersTable.Rows.Clear();
        }

        private void _RefreshUsersRecords()
        {
            _ClearTableRows();
            _AddRowsToTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvUsers);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeleteUser();
            _RefreshUsersRecords();
        }

        private void showDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmShowUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value)).ShowDialog();
            _RefreshUsersRecords();
        }

        enum _enFilterField
        {
            enNone,
            enUserID,
            enPersonID,
            enFullName,
            enUsername,
            enIsActive
        }

        _enFilterField _FilterType;

        private _enFilterField _GetFilterFiled(int SelectedIndex)
        {
            switch (SelectedIndex)
            {
                case 0:
                    return _enFilterField.enNone;
                case 1:
                    return _enFilterField.enUserID;
                case 2:
                    return _enFilterField.enPersonID;
                case 3:
                    return _enFilterField.enFullName;
                case 4:
                    return _enFilterField.enUsername;
            }
            return _enFilterField.enIsActive;
        }

        private void tbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_FilterType == _enFilterField.enNone)
                return;

            if (_FilterType == _enFilterField.enUserID || _FilterType == _enFilterField.enPersonID)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            else if (_FilterType == _enFilterField.enUsername)
                e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            else
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void _UpdateFilterState()
        {
            if (_FilterType == _enFilterField.enNone)
            {
                clsUtil.SetDefaultStateOfFilter(cmbxFilter, tbxFilter);
                clsUtil.SetDefaultStateOfFilter(cmbxIsActiveBox);
            }

            else if (_FilterType == _enFilterField.enIsActive)
                clsUtil.SetVisibilityMode(cmbxIsActiveBox, true, tbxFilter, false);

            else
                clsUtil.SetVisibilityMode(cmbxIsActiveBox, false, tbxFilter, true);
        }

        private int _GetFilterRowsCount(DataView View, string ColumnName)
        {
            if (string.IsNullOrEmpty(tbxFilter.Text))
                return 0;

            if (ColumnName == "[Person ID]" || ColumnName == "[User ID]")
                View.RowFilter = $"{ColumnName} = {Convert.ToInt32(tbxFilter.Text)}";

            else
                View.RowFilter = $"{ColumnName} LIKE '{tbxFilter.Text}%'";

            return View.Count;
        }

        private void _FilterRows(DataView View, string ColumnName)
        {
            if (_GetFilterRowsCount(View, ColumnName) == 0)
            {
                View.RowFilter = "";
                clsUtil.SetRecordsNumber(lblRecordsNumber, dgvUsers);
            }
            else
                clsUtil.SetRecordsNumber(lblRecordsNumber, View);
        }

        private void _SetFilterView()
        {
            switch (_FilterType)
            {
                case _enFilterField.enUserID:
                    _FilterRows(_UsersTable.DefaultView, "[User ID]");
                    break;

                case _enFilterField.enPersonID:
                    _FilterRows(_UsersTable.DefaultView, "[Person ID]");
                    break;

                case _enFilterField.enFullName:
                    _FilterRows(_UsersTable.DefaultView, "[Full Name]");
                    break;

                case _enFilterField.enUsername:
                    _FilterRows(_UsersTable.DefaultView, "[Username]");
                    break;
            }
        }

        private void tbxFilter_TextChanged(object sender, EventArgs e)
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
                    clsUtil.SetRecordsNumber(lblRecordsNumber, dgvUsers);
                    break;

                case _enIsActiveFilter.Yes:
                    View.RowFilter = $"[Is Active] = 'true'";
                    clsUtil.SetRecordsNumber(lblRecordsNumber, View);
                    break;

                case _enIsActiveFilter.No:
                    View.RowFilter = $"[Is Active] = 'false'";
                    clsUtil.SetRecordsNumber(lblRecordsNumber, View);
                    break;
            }
        }

        private void _SelectFilter()
        {
            cmbxIsActiveBox.SelectedIndex = 0;
            tbxFilter.Text = "";
            _FilterType = _GetFilterFiled(cmbxFilter.SelectedIndex);
            _UpdateFilterState();
        }

        private void cmbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectFilter();
        }

        private void cmbxIsActiveBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterByActiveFlag(_UsersTable.DefaultView, _GetActiveFlag(cmbxIsActiveBox.SelectedIndex));
        }
    }
}