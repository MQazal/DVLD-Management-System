using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using DVLD_PresentationLayer.Licenses.Local_Driving_License;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications.Replace_Lost_Or_Damaged_License
{
    public partial class frmReplaceLostOrDamagedLicenseApplication : Form
    {
        clsLicense _OldLocalLicense;

        clsLicense _NewLocalLicense;

        public frmReplaceLostOrDamagedLicenseApplication()
        {
            InitializeComponent();
            ctrlLocalDrivingLicenseInfoWithFilter.LicenseIDBack += CtrlLocalDrivingLicenseInfoWithFilter_LicenseIDBack;
        }

        private void _LoadOldLicenseData(int LicenseID)
        {
            _OldLocalLicense = clsLicense.FindLicenseByLicenseID(LicenseID);
            lblOldLicenseID.Text = _OldLocalLicense.LicenseID.ToString();
            lblExpirationDate.Text = clsFormat.SetDateFormat(_OldLocalLicense.ExpirationDate, "d/MM/yyyy");
            lnklblShowLicenseHistory.Enabled = true;
        }

        private void CtrlLocalDrivingLicenseInfoWithFilter_LicenseIDBack(int LicenseID)
        {
            _LoadOldLicenseData(LicenseID);
            btnReplacament.Enabled = true;
        }

        private void _SetDefaultRenewDrivingLicenseApplicationInfo()
        {
            lblApplicationDate.Text = clsFormat.SetDateFormat(DateTime.Today.Date, "d/MM/yyyy");
            lblIssueDate.Text = clsFormat.SetDateFormat(DateTime.Today.Date, "d/MM/yyyy");
            lblCreatedByUser.Text = clsGlobalUser.CurrentUser.Username;
        }

        private void frmReplaceLostOrDamagedLicenseApplication_Load(object sender, EventArgs e)
        {
            clsUtil.LoadFieldsPictures(gbxApplicationInfo, Images);
            _SetDefaultRenewDrivingLicenseApplicationInfo();
            btnReplacament.Enabled = false;
            rbtnDamagedLicense.Checked = true;
        }

        private void rbtnLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDamagedLicense.Checked)
                lblApplicationFees.Text = clsApplicationType.GetApplicationTypeFees((int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense).ToString();
            else
                lblApplicationFees.Text = clsApplicationType.GetApplicationTypeFees((int)clsApplication.enApplicationType.ReplaceLostDrivingLicense).ToString();
        }

        private void lnklblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmShowLicenseHistoryOfPerson(_OldLocalLicense.DriverInfo.PersonInfo.PersonID).ShowDialog();
        }

        private clsLicense.enIssueReason _GetReplaceIssue()
        {
            if (rbtnDamagedLicense.Checked)
                return clsLicense.enIssueReason.DamagedReplacement;
            else
                return clsLicense.enIssueReason.LostReplacement;
        }

        private void _ReplaceLicense()
        {
            _NewLocalLicense = _OldLocalLicense.ReplaceLicense(_GetReplaceIssue(), txbxNotes.Text, clsGlobalUser.CurrentUser.UserID);
            lblApplicationID.Text = _NewLocalLicense.ApplicationID.ToString();
            lblReplacedLicenseID.Text = _NewLocalLicense.LicenseID.ToString();
            lnklblShowLicenseInfo.Enabled = true;
            btnReplacament.Enabled = false;
        }

        private void btnReplacament_Click(object sender, EventArgs e)
        {
            if (_OldLocalLicense.IsLicenseExpired())
            {
                MessageBox.Show($"Selected License is not Active!", "Fialed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to Replace the License?", "Perform Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _ReplaceLicense();
                MessageBox.Show($"Licesne Replaced Successfully with ID = {_NewLocalLicense.LicenseID}", "Finish Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnklblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmShowLocalDrivingLicenseInfo(_NewLocalLicense.LicenseID).ShowDialog();
        }
    }
}