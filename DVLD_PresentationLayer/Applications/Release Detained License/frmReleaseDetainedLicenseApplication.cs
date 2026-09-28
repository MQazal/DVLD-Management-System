using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using DVLD_PresentationLayer.Licenses.Local_Driving_License;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications.Release_Detained_License
{
    public partial class frmReleaseDetainedLicenseApplication : Form
    {
        clsLicense _CurrentDetainedLicense;

        private void _InitializeLicenseIDState(int LicenseID)
        {
            if (LicenseID != -1)
            {
                ctrlLocalDrivingLicenseInfoWithFilter.ShowLicenseDate(LicenseID);
                _CurrentDetainedLicense = clsLicense.FindLicenseByLicenseID(LicenseID);
                _LoadDetainedLicenseData();
                btnRelease.Enabled = true;
            }
        }

        public frmReleaseDetainedLicenseApplication(int LicenseID = -1)
        {
            InitializeComponent();
            _InitializeLicenseIDState(LicenseID);
            //ctrlLocalDrivingLicenseInfoWithFilter.LicenseIDBack += CtrlLocalDrivingLicenseInfoWithFilter_LicenseIDBack;
        }

        private void _LoadDetainedLicenseData()
        {
            lblDetainID.Text = _CurrentDetainedLicense.DetainedLicenseInfo.DetainID.ToString();
            lblDetainDate.Text = clsFormat.SetDateFormat(_CurrentDetainedLicense.DetainedLicenseInfo.DetainDate, "d/MM/yyyy");
            lblFineFees.Text = _CurrentDetainedLicense.DetainedLicenseInfo.FineFees.ToString();
            lblLicenseID.Text = _CurrentDetainedLicense.LicenseID.ToString();
            lblApplicationFees.Text = clsApplicationType.GetApplicationTypeFees((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicense).ToString();
            lblTotalFees.Text = (_CurrentDetainedLicense.DetainedLicenseInfo.FineFees +
                clsApplicationType.GetApplicationTypeFees((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicense)).ToString();
            lblUsername.Text = clsGlobalUser.CurrentUser.Username;
            lnklblShowLicenseHistory.Enabled = true;
        }

        //private void CtrlLocalDrivingLicenseInfoWithFilter_LicenseIDBack(int LicenseID)
        //{
        //    _CurrentDetainedLicense = clsLicense.FindLicenseByLicenseID(LicenseID);
        //    _LoadDetainedLicenseData();
        //    btnRelease.Enabled = true;
        //}

        private void lnklblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmShowLicenseHistoryOfPerson(_CurrentDetainedLicense.DriverInfo.PersonInfo.PersonID).ShowDialog();
        }

        private void lnklblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmShowLocalDrivingLicenseInfo(_CurrentDetainedLicense.LicenseID).ShowDialog();
        }

        private void frmReleaseDetainedLicenseApplication_Load(object sender, EventArgs e)
        {
            clsUtil.LoadFieldsPictures(gbxReleaseInfo, Images);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReleaseDetainedLicense()
        {
            if (MessageBox.Show("Are you sure you want to release this detained license?", "PerformMessage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_CurrentDetainedLicense.ReleaseDetainedLicense(clsGlobalUser.CurrentUser.UserID))
                {
                    MessageBox.Show($"Detained License Released Successfully", "Finish Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblApplicationID.Text = _CurrentDetainedLicense.DetainedLicenseInfo.ReleaseApplicationID.ToString();
                    lnklblShowLicenseInfo.Enabled = true;
                }
            }
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (!_CurrentDetainedLicense.IsDetained)
            {
                MessageBox.Show("Selected License is not Detained, choose another one!", "Fialed Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            ReleaseDetainedLicense();
            btnRelease.Enabled = false;
        }

        private void ctrlLocalDrivingLicenseInfoWithFilter_SelectLicense(int obj)
        {
            _CurrentDetainedLicense = clsLicense.FindLicenseByLicenseID(obj);
            _LoadDetainedLicenseData();
            btnRelease.Enabled = true;
        }
    }
}