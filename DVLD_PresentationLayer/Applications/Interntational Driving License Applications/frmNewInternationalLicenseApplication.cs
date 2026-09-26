using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using DVLD_PresentationLayer.Licenses.International_Licenses;
using DVLD_PresentationLayer.Licenses.Local_Driving_License;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications.Interntational_Driving_License_Applications
{
    public partial class frmNewInternationalLicenseApplication : Form
    {
        clsLicense _CurrentLocalLicense;

        clsInternationalLicense _InternationalLicense;

        public frmNewInternationalLicenseApplication()
        {
            InitializeComponent();
            ctrlLocalDrivingLicenseInfoWithFilter.LicenseIDBack += CtrlLocalDrivingLicenseInfoWithFilter_LicenseIDBack;
        }

        private void CtrlLocalDrivingLicenseInfoWithFilter_LicenseIDBack(int LicenseID)
        {
            lblLocalLicenseID.Text = LicenseID.ToString();
            _CurrentLocalLicense = clsLicense.FindLicenseByLicenseID(LicenseID);
        }

        private void _SetDefaultNewInternationalLicenseApplicationInfo()
        {
            lblApplicationDate.Text = clsFormat.SetDateFormat(DateTime.Today.Date, "d/MM/yyyy");
            lblIssueDate.Text = clsFormat.SetDateFormat(DateTime.Today.Date, "d/MM/yyyy");
            lblFees.Text = clsApplicationType.GetApplicationTypeFees((int)clsApplication.enApplicationType.NewInternationalLicense).ToString();
            lblExpirationDate.Text = clsFormat.SetDateFormat(DateTime.Today.Date.AddYears(1), "d/MM/yyyy");
            lblCreatedByUser.Text = clsGlobalUser.CurrentUser.Username;
        }

        private void frmNewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            clsUtil.LoadFieldsPictures(gbxApplicationInfo, Images);
            _SetDefaultNewInternationalLicenseApplicationInfo();
        }

        private void _FillIssuedLicenseDetails(clsApplication NewApp)
        {
            lblApplicationID.Text = NewApp.ApplicationID.ToString();
            lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblExpirationDate.Text = clsFormat.SetDateFormat(_InternationalLicense.ExpirationDate, "y/MM/dddd");
        }

        private void _IssueNewInternationalDrivingLicense()
        {
            clsApplication NewApp = new clsApplication();
            NewApp.ApplicationDate = DateTime.Today.Date;
            NewApp.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            NewApp.LastStatusDate = DateTime.Today.Date;
            NewApp.ApplicationTypeID = Convert.ToInt32(clsApplication.enApplicationType.NewInternationalLicense);
            NewApp.PaidFees = clsApplicationType.GetApplicationTypeFees((int)clsApplication.enApplicationType.NewInternationalLicense);
            NewApp.ApplicantPersonID = _CurrentLocalLicense.DriverInfo.PersonInfo.PersonID;
            NewApp.CreatedByUserID = clsGlobalUser.CurrentUser.UserID;

            if (NewApp.Save())
            {
                _InternationalLicense = new clsInternationalLicense();
                _InternationalLicense.ApplicationID = NewApp.ApplicationID;
                _InternationalLicense.DriverID = _CurrentLocalLicense.DriverInfo.DriverID;
                _InternationalLicense.IssuedUsingLocalLicenseID = _CurrentLocalLicense.LicenseID;
                _InternationalLicense.IssueDate = DateTime.Today.Date;
                _InternationalLicense.ExpirationDate = DateTime.Today.Date.AddYears(1);
                _InternationalLicense.IsActive = true;
                _InternationalLicense.CreatedByUserID = clsGlobalUser.CurrentUser.UserID;

                if (MessageBox.Show("Are you sure you want to issue the License?", "Perform Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (_InternationalLicense.Save())
                    {
                        MessageBox.Show(clsUtil.PrintFinishMessage(clsUtil.enMode.AddNew,
                            $"International License Issued Sucessfully with ID = {_InternationalLicense.InternationalLicenseID}"),
                            "Finish Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _FillIssuedLicenseDetails(NewApp);
                        lnklblShowLicenseInfo.Enabled = true;
                        btnIssue.Enabled = false;
                    }
                }
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            // 1- Has Active Current Local Driving License
            if (!clsLicense.IsLicenseExit(_CurrentLocalLicense.DriverInfo.PersonInfo.PersonID, _CurrentLocalLicense.LicenseClassID))
            {
                MessageBox.Show("Current Local License is not active!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2- Current License is not Expired
            if (_CurrentLocalLicense.IsLicenseExpired())
            {
                MessageBox.Show("Current Local License is Expired!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3- Has Active Current International Driving License
            if (clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(_CurrentLocalLicense.LicenseID) != -1)
            {
                MessageBox.Show("Person has already Active International Driving License!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _IssueNewInternationalDrivingLicense();
        }

        private void lnklblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmShowLicenseHistoryOfPerson(_CurrentLocalLicense.DriverInfo.PersonInfo.PersonID).ShowDialog();
        }

        private void lnklblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmShowInternationalDrivingLicenseInfo(_InternationalLicense.InternationalLicenseID).ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}