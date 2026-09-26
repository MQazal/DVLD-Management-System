using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using DVLD_PresentationLayer.Licenses.Local_Driving_License;
using DVLD_PresentationLayer.People;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications.Local_License_Applications
{
    public partial class ctrlLocalDrivingLicenseApplicationInfomration : UserControl
    {
        private clsLocalDrivingLicenseApplication _CurrentApplication;

        public ctrlLocalDrivingLicenseApplicationInfomration()
        {
            InitializeComponent();
        }

        private void _LoadLocalDrivingLicenseApplicationData()
        {
            lbl_ApplicationID.Text = _CurrentApplication.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseName.Text = _CurrentApplication.LicenseClassInfo.ClassName;
            lblPassedTests.Text = $"{_CurrentApplication.TotalPassedTests().ToString()}/3";
        }

        private void _LoadBasicApplicationData()
        {
            lbl_PersonID.Text = _CurrentApplication.ApplicantPersonID.ToString();
            lblStatus.Text = _CurrentApplication.StatusText;
            lblFees.Text = _CurrentApplication.PaidFees.ToString();
            lblType.Text = _CurrentApplication.ApplicationTypeInfo.ApplicationTitle;
            lbl_PersonName.Text = _CurrentApplication.ApplicantFullName;
            lbl_IssuedDate.Text = clsFormat.SetDateFormat(_CurrentApplication.ApplicationDate, "d/M/yyyy");
            lbl_StatusDate.Text = clsFormat.SetDateFormat(_CurrentApplication.LastStatusDate, "d/M/yyyy");
            lblUsername.Text = _CurrentApplication.CreatedByUserInfo.Username;
        }

        private void _SetLicenseInfoLinkState()
        {
            if (_CurrentApplication == null)
                return;

            if (clsLicense.IsLicenseExit(_CurrentApplication.ApplicationID))
                lnklbl_LicenseInfo.Enabled = true;
            else
                lnklbl_LicenseInfo.Enabled = false;
        }

        private void ctrlLocalDrivingLicenseApplicationInfomration_Load(object sender, EventArgs e)
        {
           clsUtil.LoadFieldsPictures(gbbxLicense, LicenseImages);
           clsUtil.LoadFieldsPictures(gbbxApplication, ApplicationImages);
            _SetLicenseInfoLinkState();
        }

        private void lnklbl_ShowPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmShowPerson(_CurrentApplication.PersonInfo.PersonID).ShowDialog();
        }

        public void ShowApplicationData(int LocalDrivingLicenseApplicationID)
        {
            _CurrentApplication = clsLocalDrivingLicenseApplication.FindLocalDrvingLicenseAppByLocalAppID(LocalDrivingLicenseApplicationID);
            _LoadLocalDrivingLicenseApplicationData();
            _LoadBasicApplicationData();
        }

        private void _OpenShowLocalLicenseInfo()
        {
            new frmShowLocalDrivingLicenseInfo(clsLicense.FindLicenseByApplicationID(_CurrentApplication.ApplicationID).LicenseID).ShowDialog();
        }

        private void lnklbl_LicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _OpenShowLocalLicenseInfo();
        }
    }
}