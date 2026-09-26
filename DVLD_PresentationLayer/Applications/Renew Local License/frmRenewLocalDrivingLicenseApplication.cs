using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using DVLD_PresentationLayer.Licenses.Local_Driving_License;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications.Renew_Local_License
{
    public partial class frmRenewLocalDrivingLicenseApplication : Form
    {
        clsLicense _OldLocalLicense;

        clsLicense _NewLocalLicense;

        public frmRenewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            ctrlLocalDrivingLicenseInfoWithFilter.LicenseIDBack += CtrlLocalDrivingLicenseInfoWithFilter_LicenseIDBack;
        }

        private void _LoadOldLicenseData(int LicenseID)
        {
            _OldLocalLicense = clsLicense.FindLicenseByLicenseID(LicenseID);
            lblOldLicenseID.Text = _OldLocalLicense.LicenseID.ToString();
            lblLicenseFees.Text = _OldLocalLicense.PaidFees.ToString();
            lblExpirationDate.Text = clsFormat.SetDateFormat(DateTime.Today.Date.AddYears(_OldLocalLicense.LicenseClassInfo.DefaultValidityLength), "d/MM/yyyy");
            decimal TotalFees = Convert.ToDecimal(lblApplicationFees.Text) + _OldLocalLicense.PaidFees;
            lblTotalFees.Text = TotalFees.ToString();
            lnklblShowLicenseHistory.Enabled = true;
        }

        private void CtrlLocalDrivingLicenseInfoWithFilter_LicenseIDBack(int LicenseID)
        {
            _LoadOldLicenseData(LicenseID);
            btnRenew.Enabled = true;
        }

        private void _SetDefaultRenewDrivingLicenseApplicationInfo()
        {
            lblApplicationDate.Text = clsFormat.SetDateFormat(DateTime.Today.Date, "d/MM/yyyy");
            lblIssueDate.Text = clsFormat.SetDateFormat(DateTime.Today.Date, "d/MM/yyyy");
            lblApplicationFees.Text = clsApplicationType.GetApplicationTypeFees((int)clsApplication.enApplicationType.RenewDrivingLicense).ToString();
            lblCreatedByUser.Text = clsGlobalUser.CurrentUser.Username;
        }

        private void frmRenewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            clsUtil.LoadFieldsPictures(gbxApplicationInfo, Images);
            _SetDefaultRenewDrivingLicenseApplicationInfo();
            btnRenew.Enabled = false;
        }

        private void lnklblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmShowLicenseHistoryOfPerson(_OldLocalLicense.DriverInfo.PersonInfo.PersonID).ShowDialog();
        }

        private void Renew()
        {
            _NewLocalLicense = _OldLocalLicense.RenewLicense(txbxNotes.Text, clsGlobalUser.CurrentUser.UserID);
            lblApplicationID.Text = _NewLocalLicense.ApplicationID.ToString();
            lblRenewedLicenseID.Text = _NewLocalLicense.LicenseID.ToString();
            lnklblShowLicenseInfo.Enabled = true;
            btnRenew.Enabled = false;
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (!_OldLocalLicense.IsLicenseExpired())
            {
                MessageBox.Show($"Selected License is not expired," +
                    $"it will expire on {clsFormat.SetDateFormat(_OldLocalLicense.ExpirationDate, "d/MM/yyyy")}",
                    "Fialed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to Renew the License?", "Perform Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Renew();
                MessageBox.Show($"Licesne Renewed Successfully with ID = {_NewLocalLicense.LicenseID}", "Finish Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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