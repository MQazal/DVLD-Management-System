using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmListPeople : Form
    {
        DataTable _PeopleTable = new DataTable();

        public frmListPeople()
        {
            InitializeComponent();
        }

        private void _AddColumnsToTable()
        {
            DataColumn Col = new DataColumn();

            Col.ColumnName = "Person ID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.AutoIncrementSeed = 1;
            Col.AutoIncrementStep = 1;
            Col.ReadOnly = true;
            Col.Unique = true;
            _PeopleTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "National No.";
            Col.DataType = typeof(string);
            _PeopleTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "First Name";
            Col.DataType = typeof(string);
            _PeopleTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Second Name";
            Col.DataType = typeof(string);
            _PeopleTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Third Name";
            Col.DataType = typeof(string);
            _PeopleTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Last Name";
            Col.DataType = typeof(string);
            _PeopleTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Gender";
            Col.DataType = typeof(string);
            _PeopleTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Date Of Birth";
            Col.DataType = typeof(string);
            _PeopleTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Country";
            Col.DataType = typeof(string);
            _PeopleTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Phone";
            Col.DataType = typeof(string);
            _PeopleTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Email";
            Col.DataType = typeof(string);
            _PeopleTable.Columns.Add(Col);
        }

        private void _AddRowsToTable()
        {
            DataTable Table = clsPerson.GetPeopleList();
            foreach (DataRow Row in Table.Rows)
            {
                _PeopleTable.Rows.Add(Row["PersonID"], Row["NationalNumber"], Row["FirstName"],
                    Row["SecondName"], Row["ThirdName"], Row["LastName"],
                    Row["Gender"], clsFormat.SetDateFormat(Convert.ToDateTime(Row["DateOfBirth"]), "d/M/yyyy"),
                    Row["CountryName"], Row["Phone"], Row["Email"]);
            }
        }

        private void _InitializePeopleDataTable()
        {
            _AddColumnsToTable();
            _AddRowsToTable();
            dgvPeople.DataSource = _PeopleTable;
        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            clsUtil.SetScreenHeaderData(pcbxTitleImage, Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\People400.PNG"));
            _InitializePeopleDataTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvPeople);
            clsUtil.SetDefaultStateOfFilter(cmbxFilter, tbxFilter);
            dgvPeople.ClearSelection();
        }

        private void _ClearTableRows()
        {
            _PeopleTable.Rows.Clear();
        }

        private void _RefreshPeopleRecords()
        {
            _ClearTableRows();
            _AddRowsToTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvPeople);
        }

        private void _OpenAdd_UpdateForm(int PersonID)
        {
            new frmAdd_UpdatePerson(PersonID).ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _OpenAdd_UpdateForm(-1);
            _RefreshPeopleRecords();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenAdd_UpdateForm(Convert.ToInt32(dgvPeople.CurrentRow.Cells[0].Value));
            _RefreshPeopleRecords();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _DeletePerson()
        {
            if (MessageBox.Show($"Are you sure you want to delete person [{dgvPeople.CurrentRow.Cells[0].Value.ToString()}]?", "Confirm Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clsPerson.DeletePerson(Convert.ToInt32(dgvPeople.CurrentRow.Cells[0].Value));
                MessageBox.Show("Person is deleted sucessfully", "Finish Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeletePerson();
            _RefreshPeopleRecords();
        }

        private void _OpenShowPersonInformationForm(int PersonID)
        {
            new frmShowPerson(PersonID).ShowDialog();
        }

        private void showDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenShowPersonInformationForm(Convert.ToInt32(dgvPeople.CurrentRow.Cells[0].Value));
        }

        enum _enFilterField
        {
            enNone,
            enPersonID,
            enNationalNumber,
            enFirstName,
            enSecondName,
            enThirdName,
            enLastName,
            enGender,
            enDateOfBirth,
            enCountry,
            enPhone,
            enEmail
        }

        _enFilterField _FilterType;

        private _enFilterField _GetFilterField(int SelectedIndex)
        {
            switch (SelectedIndex)
            {
                case 0:
                    return _enFilterField.enNone;
                case 1:
                    return _enFilterField.enPersonID;
                case 2:
                    return _enFilterField.enNationalNumber;
                case 3:
                    return _enFilterField.enFirstName;
                case 4:
                    return _enFilterField.enSecondName;
                case 5:
                    return _enFilterField.enThirdName;
                case 6:
                    return _enFilterField.enLastName;
                case 7:
                    return _enFilterField.enGender;
                case 8:
                    return _enFilterField.enDateOfBirth;
                case 9:
                    return _enFilterField.enCountry;
                case 10:
                    return _enFilterField.enPhone;
            }
            return _enFilterField.enEmail;
        }

        private void tbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_FilterType == _enFilterField.enNone)
                return;

            if (_FilterType == _enFilterField.enPersonID || _FilterType == _enFilterField.enPhone
                || _FilterType == _enFilterField.enDateOfBirth)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            else if (_FilterType == _enFilterField.enNationalNumber)
                e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            else
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void _UpdateFilterState()
        {
            if (_FilterType == _enFilterField.enNone)
                clsUtil.SetDefaultStateOfFilter(cmbxFilter, tbxFilter);
            else
                tbxFilter.Visible = true;
        }

        private int _GetFilterRowsCount(DataView View, string ColumnName)
        {
            if (string.IsNullOrEmpty(tbxFilter.Text))
                return 0;

            if (ColumnName == "[Person ID]")
                View.RowFilter = $"[Person ID] = {Convert.ToInt32(tbxFilter.Text)}";

            else
                View.RowFilter = $"{ColumnName} LIKE '{tbxFilter.Text}%'";

            return View.Count;
        }

        private void _FilterRows(DataView View, string ColumnName)
        {
            if (_GetFilterRowsCount(View, ColumnName) == 0)
            {
                View.RowFilter = "";
                clsUtil.SetRecordsNumber(lblRecordsNumber, dgvPeople);
            }
            else
                clsUtil.SetRecordsNumber(lblRecordsNumber, View);
        }

        private void _SetFilterView()
        {
            switch (_FilterType)
            {
                case _enFilterField.enPersonID:
                    _FilterRows(_PeopleTable.DefaultView, "[Person ID]");
                    break;

                case _enFilterField.enNationalNumber:
                    _FilterRows(_PeopleTable.DefaultView, "[National No.]");
                    break;

                case _enFilterField.enFirstName:
                    _FilterRows(_PeopleTable.DefaultView, "[First Name]");
                    break;

                case _enFilterField.enSecondName:
                    _FilterRows(_PeopleTable.DefaultView, "[Second Name]");
                    break;

                case _enFilterField.enThirdName:
                    _FilterRows(_PeopleTable.DefaultView, "[Third Name]");
                    break;

                case _enFilterField.enLastName:
                    _FilterRows(_PeopleTable.DefaultView, "[Last Name]");
                    break;

                case _enFilterField.enGender:
                    _FilterRows(_PeopleTable.DefaultView, "[Gender]");
                    break;

                case _enFilterField.enDateOfBirth:
                    _FilterRows(_PeopleTable.DefaultView, "[Date Of Birth]");
                    break;

                case _enFilterField.enCountry:
                    _FilterRows(_PeopleTable.DefaultView, "[Country]");
                    break;

                case _enFilterField.enPhone:
                    _FilterRows(_PeopleTable.DefaultView, "[Phone]");
                    break;

                default:
                    _FilterRows(_PeopleTable.DefaultView, "[Email]");
                    break;
            }
        }

        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            _SetFilterView();
        }

        private void _SelectFilter()
        {
            tbxFilter.Text = "";
            _FilterType = _GetFilterField(cmbxFilter.SelectedIndex);
            _UpdateFilterState();
        }

        private void cmbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectFilter();
        }

        private void _ShowFindPersonForm()
        {
            new frmFindPerson().ShowDialog();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _ShowFindPersonForm();
            _RefreshPeopleRecords();
        }
    }
}