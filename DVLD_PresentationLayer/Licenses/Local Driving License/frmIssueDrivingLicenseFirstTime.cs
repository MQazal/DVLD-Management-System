using System;
using System.Windows.Forms;
using System.Drawing;
using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;

namespace DVLD_PresentationLayer.Licenses.Local_Driving_License
{
    public partial class frmIssueDrivingLicenseFirstTime : Form
    {
        clsLocalDrivingLicenseApplication _LocalApp;

        public frmIssueDrivingLicenseFirstTime(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            ctrlLocalDrivingLicenseApplicationInfomration.ShowApplicationData(LocalDrivingLicenseApplicationID);
            _LocalApp = clsLocalDrivingLicenseApplication.FindLocalDrvingLicenseAppByLocalAppID(LocalDrivingLicenseApplicationID);
        }

        private void frmIssueDrivingLicenseFirstTime_Load(object sender, EventArgs e)
        {
            pcbxNotes.Image = Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Notes 32.png");
        }

        private void _IssueNewDrivingLicense()
        {
            if (_LocalApp.IssueDrivingLicenseForFirstTime(txbxNotes.Text, clsGlobalUser.CurrentUser.UserID))
            {
               MessageBox.Show(clsUtil.PrintFinishMessage(clsUtil.enMode.AddNew, $"New License Issued Sucessfully with License ID = {clsLicense.FindLicenseByApplicationID(_LocalApp.ApplicationID).LicenseID}"), "Finish Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
               btnIssueLicense.Enabled = false;
            }
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            _IssueNewDrivingLicense();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}