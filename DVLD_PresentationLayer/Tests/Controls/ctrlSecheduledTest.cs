using System;
using DVLD_BusinessLogicLayer;
using System.Windows.Forms;
using DVLD_PresentationLayer.Global_Classes;
using System.Drawing;
using DVLD_PresentationLayer.People;

namespace DVLD_PresentationLayer.Tests.Controls
{
    public partial class ctrlSecheduledTest : UserControl
    {
        enum _enMode { AddNew, Update }
        _enMode _Mode;

        clsLocalDrivingLicenseApplication _LocalApp;
        clsTestAppointment _Appointment;
        clsTest _Test;

        private _enMode _SelectMode()
        {
            return _Test == null ? _enMode.AddNew : _enMode.Update;
        }

        private void _LoadApplicationInfo(int LocalDrivingLicenseApplicationID)
        {
            _LocalApp = clsLocalDrivingLicenseApplication.FindLocalDrvingLicenseAppByLocalAppID(LocalDrivingLicenseApplicationID);
            lblLocalDrivingLicenseAppID.Text = _LocalApp.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = _LocalApp.LicenseClassInfo.ClassName; // inhertaince
            lblFullName.Text = _LocalApp.ApplicantFullName; // inhertaince
        }

        private void _LoadAppointmentInfo(int TestAppointmentID)
        {
            _Appointment = clsTestAppointment.Find(TestAppointmentID);
            lblTrial.Text = _LocalApp.TotalTrialsPerTest((clsTestType.enTestType)_Appointment.TestTypeID).ToString();
            lblDate.Text = clsFormat.SetDateFormat(_Appointment.AppointmentDate, "d/MM/yyyy");
            lblFees.Text = _Appointment.PaidFees.ToString();
        }

        private void _SetTestResult()
        {
            if (_Test.TestResult)
                rbtnPass.Checked = true;
            else
                rbtnFail.Checked = true;
        }

        private void _LoadTestInfo()
        {
            lblTestID.Text = _Test.TestID.ToString();
            _SetTestResult();
            txbxNotes.Text = _Test.Notes;
        }

        private void _DisableTestResultSelection()
        {
            rbtnPass.Enabled = false;
            rbtnFail.Enabled = false;
        }

        private void _SetTestTypeImage()
        {
            if ((clsTestType.enTestType)_Appointment.TestTypeID == clsTestType.enTestType.VisionTest)
                pcbxTestTypeImage.Image = Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Vision 512.png");

            else if ((clsTestType.enTestType)_Appointment.TestTypeID == clsTestType.enTestType.WrittenTest)
                pcbxTestTypeImage.Image = Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Written Test 512.png");

            else
                pcbxTestTypeImage.Image = Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\driving-test 512.png");
        }

        public void InitializeTestState(int TestAppointmentID, int LocalDrivingLicenseApplicationID)
        {
            _LoadApplicationInfo(LocalDrivingLicenseApplicationID);

            _LoadAppointmentInfo(TestAppointmentID);

            _SetTestTypeImage();

            _Test = clsTest.FindTestByTestAppointment(TestAppointmentID);

            _Mode = _SelectMode();

            if (_Mode == _enMode.Update)
            {
                _LoadTestInfo();
                _DisableTestResultSelection();
            }

            else
            {
                _Test = new clsTest();
                lblTestID.Text = "Not Taken Yet";
            }
        }

        public ctrlSecheduledTest()
        {
            InitializeComponent();
        }

        private void _LoadFieldsPictures()
        {
            clsUtil.LoadFieldsPictures(gbxTestType, Images);
        }

        private void ctrlSecheduledTest_Load(object sender, EventArgs e)
        {
            _LoadFieldsPictures();
        }

        private void rbtnFail_CheckedChanged(object sender, EventArgs e)
        {
            if ((RadioButton)sender == rbtnPass)
                _Test.TestResult = true;
            else
                _Test.TestResult = false;
        }

        private bool _GetTestResult()
        {
            if (rbtnPass.Checked)
                return true;
            else
                return false;
        }

        private void _AddNewTest()
        {
            _Test.AppointmentID = _Appointment.AppointmentID;
            _Test.TestResult = _GetTestResult();
            _Test.Notes = txbxNotes.Text;
            _Test.CreatedByUserID = clsGlobalUser.CurrentUser.UserID;
        }

        private void _ConvertFormToUpdateMode()
        {
            _Mode = _enMode.Update;
            lblTestID.Text = _Test.TestID.ToString();
            _DisableTestResultSelection();
        }

        private void _UpdateTest()
        {
            _Test.Notes = txbxNotes.Text;
        }

        private void _SaveTestRecord()
        {
            if (_Mode == _enMode.AddNew)
            {
                _AddNewTest();
                if (MessageBox.Show("Are you sure you want to save?\nAfter that you cannot change\nthe Pass/Fail results after you save!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (_Test.Save())
                    {
                        MessageBox.Show(clsUtil.PrintFinishMessage((byte)_enMode.AddNew, "New Test is Added Successfully!"), "Finish Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _ConvertFormToUpdateMode();
                    }
                }
            }

            else
            {
                _UpdateTest();
                if (_Test.Save())
                {
                    MessageBox.Show(clsUtil.PrintFinishMessage((byte)_enMode.Update, "", "Test is Updated Succesfully!"), "Finish Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveTestRecord();
            btnSave.Enabled = false;
        }
    }
}