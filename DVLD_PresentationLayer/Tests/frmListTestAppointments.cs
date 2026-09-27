using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmListTestAppointments : Form
    {
        int _LocalDrivingLicenseApplicationID = default(int);

        clsTestType.enTestType _TestTypeID;

        DataTable _TestAppointmentsTable = new DataTable();

        public frmListTestAppointments(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            InitializeComponent();
            ctrlLocalDrivingLicenseApplicationInfomration.ShowApplicationData(LocalDrivingLicenseApplicationID);
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestTypeID = TestTypeID;
        }

        private void _ConfigureHeaderByTestType()
        {
            switch (_TestTypeID)
            {
                case clsTestType.enTestType.VisionTest:
                    {
                        clsUtil.SetScreenHeaderData(pcbxTitleImage, Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Vision 512.png")
                            , lblTitle, "Vision Test Appointments");
                        break;
                    }

                case clsTestType.enTestType.WrittenTest:
                    {
                        clsUtil.SetScreenHeaderData(pcbxTitleImage, Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Written Test 512.png")
                            , lblTitle, "Written Test Appointments");
                        break;
                    }

                case clsTestType.enTestType.StreetTest:
                    {
                        clsUtil.SetScreenHeaderData(pcbxTitleImage, Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\driving-test 512.png")
                            , lblTitle, "Street Test Appointments");
                        break;
                    }
            }
        }

        private void _AddColumnsToTable()
        {
            DataColumn Col = new DataColumn();

            Col.ColumnName = "Appointment ID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.AutoIncrementSeed = 1;
            Col.AutoIncrementStep = 1;
            Col.ReadOnly = true;
            Col.Unique = true;
            _TestAppointmentsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Appointment Date";
            Col.DataType = typeof(string);
            _TestAppointmentsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Paid Fees";
            Col.DataType = typeof(decimal);
            _TestAppointmentsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Is Locked";
            Col.DataType = typeof(bool);
            _TestAppointmentsTable.Columns.Add(Col);
        }

        private void _AddRowsToTable()
        {
            DataTable Table = clsTestAppointment.GetTestAppointmentsList(_LocalDrivingLicenseApplicationID, clsTestType.GetTestTitle(_TestTypeID));
            foreach (DataRow Row in Table.Rows)
            {
                _TestAppointmentsTable.Rows.Add(Row["AppointmentID"],
                    clsFormat.SetDateFormat(Convert.ToDateTime(Row["AppointmentDate"]), "d/M/yyyy"), Row["PaidFees"],
                    Row["IsLocked"]);
            }
        }

        private void _InitializeAppointmentsDataTable()
        {
            _AddColumnsToTable();
            _AddRowsToTable();
            dgvTestAppointments.DataSource = _TestAppointmentsTable;
        }

        private void frmListTestAppointments_Load(object sender, EventArgs e)
        {
            _ConfigureHeaderByTestType();
            _InitializeAppointmentsDataTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvTestAppointments);
            dgvTestAppointments.ClearSelection();
        }

        private void _OpenAddUpdateTestAppointmentForm(int LocalDrivingLicenseApplicationID, int AppointmentID, clsTestType.enTestType TestTypeID, bool IsLocked)
        {
            new frmScheduleTest(LocalDrivingLicenseApplicationID, AppointmentID, TestTypeID, IsLocked).ShowDialog();
        }

        private void _AddNewTestAppointment()
        {
            // Active Booked Test Appointment
            if (clsTestAppointment.GetLastTestAppointment(_LocalDrivingLicenseApplicationID, _TestTypeID) != null)
            {
                MessageBox.Show("Person Already have an active appointment for this test.\nYou cannot add new appointment.", "Faild Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pass Test Type
            if (clsLocalDrivingLicenseApplication.IsPersonPassTestType(_LocalDrivingLicenseApplicationID, _TestTypeID))
            {
                MessageBox.Show("The person already passed this test before, you can only\nretake failed test.", "Faild Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _OpenAddUpdateTestAppointmentForm(_LocalDrivingLicenseApplicationID, -1, _TestTypeID, false);
        }

        private void _ClearTableRows()
        {
            _TestAppointmentsTable.Rows.Clear();
        }

        private void _RefreshTestAppointmentsRecords()
        {
            _ClearTableRows();
            _AddRowsToTable();
            clsUtil.SetRecordsNumber(lblRecordsNumber, dgvTestAppointments);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _AddNewTestAppointment();
            _RefreshTestAppointmentsRecords();
        }

        private void _UpdateTestAppointment()
        {
            clsTestAppointment Appointment = clsTestAppointment.Find(Convert.ToInt32(dgvTestAppointments.CurrentRow.Cells[0].Value));
            _OpenAddUpdateTestAppointmentForm(Appointment.LocalDrivingLicenseApplicationID, Appointment.AppointmentID, Appointment.TestTypeID, Appointment.IsLocked);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _UpdateTestAppointment();
            _RefreshTestAppointmentsRecords();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _OpenTakeTestForm()
        {
            clsTestAppointment Appointment = clsTestAppointment.Find(Convert.ToInt32(dgvTestAppointments.CurrentRow.Cells[0].Value));
            new frmScheduledTest(Appointment.AppointmentID, Appointment.LocalDrivingLicenseApplicationID).ShowDialog();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenTakeTestForm();
            _RefreshTestAppointmentsRecords();
        }
    }
}