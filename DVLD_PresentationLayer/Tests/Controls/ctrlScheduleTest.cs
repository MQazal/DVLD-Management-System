using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests.Controls
{
    public partial class ctrlScheduleTest : UserControl
    {
        enum _enMode { AddNew = 0, Update = 1 };
        _enMode _Mode;

        enum _enBookingMode { FirstTimeSchedule = 0, RetakeTestSchedule = 1 };
        _enBookingMode _BookingMode;

        clsApplication _NewApp;

        clsLocalDrivingLicenseApplication _LocalApp;

        clsTestAppointment _Appointment;

        clsTestType.enTestType _TestTypeID;

        public ctrlScheduleTest()
        {
            InitializeComponent();
        }

        private void _SetFieldsPictuers()
        {
            clsUtil.LoadFieldsPictures(gbxTestInfo, Images);
            clsUtil.LoadFieldsPictures(gbxRetakeTestInfo, Images);
        }

        private void ctrlScheduleTest_Load(object sender, EventArgs e)
        {
            _SetFieldsPictuers();
        }

        private void _HandleTestTypeMode(clsTestType.enTestType TestTypeID)
        {
            _TestTypeID = TestTypeID;

            switch (_TestTypeID)
            {
                case clsTestType.enTestType.VisionTest:
                    {
                        gbxTestInfo.Text = "Vision Test";
                        pcbxTestTypeImage.Image = Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Vision 512.png");
                        break;
                    }

                case clsTestType.enTestType.WrittenTest:
                    {
                        gbxTestInfo.Text = "Written Test";
                        pcbxTestTypeImage.Image = Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Written Test 512.png");
                        break;
                    }

                case clsTestType.enTestType.StreetTest:
                    {
                        gbxTestInfo.Text = "Street Test";
                        pcbxTestTypeImage.Image = Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\driving-test 512.png");
                        break;
                    }
            }
            lblTitle.Text = $"Schedule {gbxTestInfo.Text}";
        }

        private _enMode _SelectMode(int AppointmentID)
        {
            return AppointmentID == -1 ? _enMode.AddNew : _enMode.Update;
        }

        private void _LoadLocalDrivingLicenseApplicationData(int LocalDrivingLicenseApplicationID)
        {
            _LocalApp = clsLocalDrivingLicenseApplication.FindLocalDrvingLicenseAppByLocalAppID(LocalDrivingLicenseApplicationID);
            lblLocalDrivingLicenseAppID.Text = _LocalApp.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = _LocalApp.LicenseClassInfo.ClassName;
            lblFullName.Text = _LocalApp.PersonInfo.FullName;
            lblTrial.Text = _LocalApp.TotalTrialsPerTest(_TestTypeID).ToString();
            lblTestFees.Text = clsTestType.FindTest((int)_TestTypeID).TestFees.ToString();
        }

        private void _LoadAppointmentData()
        {
            dtpTestDate.Value = _Appointment.AppointmentDate;
        }

        private void _HandleAddUpdateMode(int AppointmentID)
        {
            _Mode = _SelectMode(AppointmentID);

            if (_Mode == _enMode.Update)
            {
                lblTitle.Text = "Schedule Test";
                _Appointment = clsTestAppointment.Find(AppointmentID);
                _LoadAppointmentData();
            }

            else
            {
                _Appointment = new clsTestAppointment();
                dtpTestDate.Value = DateTime.Today;
            }
        }

        private decimal _GetTotalRetakeTestFees(decimal retakeTestFees, decimal testFees)
        {
            return retakeTestFees + testFees;
        }

        private void _HandleBookingMode()
        {
            if (_LocalApp.DoesAttendTestType(_TestTypeID) && _Appointment.RetakeTestApplicationID != -1)
                _BookingMode = _enBookingMode.RetakeTestSchedule;
            else
                _BookingMode = _enBookingMode.FirstTimeSchedule;
        }

        private void _DisableRetakeTestBoxInfo()
        {
            gbxRetakeTestInfo.Enabled = false;
            lblRetakeAppFees.Text = "0";
            lblTotalFees.Text = lblTestFees.Text;
            lblRetakeTestAppID.Text = "N/A";
        }

        private void _AddNewRetakeTestApplication()
        {
            _NewApp = new clsApplication();
            _NewApp.ApplicantPersonID = _LocalApp.ApplicantPersonID;
            _NewApp.ApplicationDate = DateTime.Today.Date;
            _NewApp.ApplicationTypeID = Convert.ToInt32(clsApplication.enApplicationType.RetakeTest);
            _NewApp.ApplicationStatus = clsApplication.enApplicationStatus.New;
            _NewApp.LastStatusDate = _NewApp.ApplicationDate;
            _NewApp.PaidFees = clsApplicationType.GetApplicationTypeFees(Convert.ToInt32(clsApplication.enApplicationType.RetakeTest));
            _NewApp.CreatedByUserID = clsGlobalUser.CurrentUser.UserID;
            _NewApp.Save();
        }

        private void _InitializeNewRetakeTestApplication()
        {
            if (_Mode == _enMode.AddNew)
                _AddNewRetakeTestApplication();
            else
                _NewApp = clsApplication.FindApplication(_Appointment.RetakeTestApplicationID);
        }

        private void _LoadNewRetakeTestApplicationInfo()
        {
            _InitializeNewRetakeTestApplication();
            lblRetakeAppFees.Text = _NewApp.PaidFees.ToString();
            lblTotalFees.Text = _GetTotalRetakeTestFees(_NewApp.PaidFees, Convert.ToDecimal(lblTestFees.Text)).ToString();
            lblRetakeTestAppID.Text = _NewApp.ApplicationID.ToString();
        }

        private void _EnableRetakeTestBoxInfo()
        {
            lblTitle.Text = "Schedule Retake Test";
            _LoadNewRetakeTestApplicationInfo();
        }

        private void _HandleRetakeTestInfo()
        {
            if (_BookingMode == _enBookingMode.FirstTimeSchedule)
                _DisableRetakeTestBoxInfo();
            else
                _EnableRetakeTestBoxInfo();
        }

        private void _SetPassTestMessage()
        {
            if (!_Appointment.HasPassedTestForAppointment())
                lblRetakeTestPossibility.Text = "Person already sat for the test, appointment locked.";
            else
                lblRetakeTestPossibility.Text = "Person already pass for the test, appointment locked.";
        }

        private void _SetFormInLockedState()
        {
            lblTitle.Visible = false;
            _SetPassTestMessage();
            dtpTestDate.Enabled = false;
            btnSave.Enabled = false;
            if (_BookingMode == _enBookingMode.FirstTimeSchedule)
            {
                _DisableRetakeTestBoxInfo();
            }
        }

        private void _HandleTestCompletionState(bool IsLocked)
        {
            if (IsLocked)
            {
                _SetFormInLockedState();
                return;
            }
            lblRetakeTestPossibility.Visible = false;
        }

        public void InitializeAppointmentState(int LocalDrivingLicenseApplicationID, int AppointmentID, clsTestType.enTestType TestTypeID, bool IsLocked)
        {
            _HandleTestTypeMode(TestTypeID);

            _LoadLocalDrivingLicenseApplicationData(LocalDrivingLicenseApplicationID);

            _HandleAddUpdateMode(AppointmentID);

            _HandleBookingMode();

            _HandleRetakeTestInfo();

            _HandleTestCompletionState(IsLocked);
        }

        private void _SetNewAppointmentInfoToObject()
        {
            _Appointment.TestTypeID = _TestTypeID;
            _Appointment.LocalDrivingLicenseApplicationID = _LocalApp.LocalDrivingLicenseApplicationID;
            _Appointment.AppointmentDate = dtpTestDate.Value;
            _Appointment.PaidFees = Convert.ToDecimal(lblTestFees.Text);
            _Appointment.CreatedByUserID = clsGlobalUser.CurrentUser.UserID;
            _Appointment.IsLocked = false;

            if (_BookingMode == _enBookingMode.FirstTimeSchedule)
                _Appointment.RetakeTestApplicationID = -1;
            else
                _Appointment.RetakeTestApplicationID = _NewApp.ApplicationID;
        }

        private void _BookNewTest()
        {
            _SetNewAppointmentInfoToObject();
            if (_Appointment.Save())
            {
                MessageBox.Show(clsUtil.PrintFinishMessage((byte)_enMode.AddNew, "New Test Appointment is added sucessfully."), "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = _enMode.Update;
            }
        }

        private void _UpdateTest()
        {
            _Appointment.AppointmentDate = dtpTestDate.Value;
            if (_Appointment.Save())
                MessageBox.Show(clsUtil.PrintFinishMessage((byte)_enMode.Update, "", "Test Appointment is Updated Sucessfully"), "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Mode == _enMode.AddNew)
            {
                _BookNewTest();
                btnSave.Enabled = false;
            }
            else
                _UpdateTest();
        }
    }
}