using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using DVLD_PresentationLayer.Licenses.Local_Driving_License;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Licenses.Detain_License
{
    public partial class frmDetainLicense : Form
    {
        clsLicense _CurrentLicense;

        public frmDetainLicense()
        {
            InitializeComponent();
            ctrlLocalDrivingLicenseInfoWithFilter.LicenseIDBack += CtrlLocalDrivingLicenseInfoWithFilter_LicenseIDBack;
        }

        private void _LoadLicenseData(int LicenseID)
        {
            _CurrentLicense = clsLicense.FindLicenseByLicenseID(LicenseID);
            lblLicenseID.Text = _CurrentLicense.LicenseID.ToString();
            lnklblShowLicenseHistory.Enabled = true;
        }

        private void CtrlLocalDrivingLicenseInfoWithFilter_LicenseIDBack(int LicenseID)
        {
            _LoadLicenseData(LicenseID);
            btnDetain.Enabled = true;
        }

        private void _SetDefaultDetainLicenseInfo()
        {
            lblDetainDate.Text = clsFormat.SetDateFormat(DateTime.Today.Date, "d/MM/yyyy");
            lblCreatedByUser.Text = clsGlobalUser.CurrentUser.Username;
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            clsUtil.LoadFieldsPictures(gbxDetainInfo, Images);
            _SetDefaultDetainLicenseInfo();
            btnDetain.Enabled = false;
        }

        private void lnklblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmShowLicenseHistoryOfPerson(_CurrentLicense.DriverInfo.PersonInfo.PersonID).ShowDialog();
        }

        private void _SetNewDetainedLicenseInfo()
        {
            _CurrentLicense.DetainedLicenseInfo = new clsDetainedLicense();
            _CurrentLicense.DetainedLicenseInfo.LicenseID = _CurrentLicense.LicenseID;
            _CurrentLicense.DetainedLicenseInfo.DetainDate = DateTime.Today.Date;
            _CurrentLicense.DetainedLicenseInfo.FineFees = Convert.ToDecimal(txbxFineFees.Text);
            _CurrentLicense.DetainedLicenseInfo.CreatedByUserID = clsGlobalUser.CurrentUser.UserID;
        }

        private void DetainLicense()
        {
            if (MessageBox.Show("Are you sure you want to detian this license?", "PerformMessage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _SetNewDetainedLicenseInfo();
                if (_CurrentLicense.DetainedLicenseInfo.Save())
                {
                    MessageBox.Show($"Licesne Detained Successfully with ID = {_CurrentLicense.DetainedLicenseInfo.DetainID}", "Finish Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDetainID.Text = _CurrentLicense.DetainedLicenseInfo.DetainID.ToString();
                    lnklblShowLicenseInfo.Enabled = true;
                }
            }
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (_CurrentLicense.IsDetained)
            {
                MessageBox.Show("Current License already is Detained, choose another one!", "Fialed Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            DetainLicense();
            btnDetain.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnklblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmShowLocalDrivingLicenseInfo(_CurrentLicense.LicenseID).ShowDialog();
        }
    }
}