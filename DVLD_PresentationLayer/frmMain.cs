using System;
using System.Windows.Forms;
using System.Drawing;
using DVLD_PresentationLayer.Drivers;
using DVLD_PresentationLayer.Applications.Interntational_Driving_License_Applications;
using DVLD_PresentationLayer.Applications.Renew_Local_License;
using DVLD_PresentationLayer.Applications.Replace_Lost_Or_Damaged_License;
using DVLD_PresentationLayer.Licenses.Detain_License;
using DVLD_PresentationLayer.Applications.Release_Detained_License;
using DVLD_PresentationLayer.Applications.Local_Driving_License_Applications;

namespace DVLD_PresentationLayer
{
    public partial class frmMain : Form
    {
        static frmLogin _LoginScreen;

        public frmMain(frmLogin login = null)
        {
            InitializeComponent();
            _LoginScreen = login;
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            new frmListPeople().ShowDialog();
        }

        private void _SetBackgroundImage()
        {
            this.BackgroundImage = Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Screen'sWall.png");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _SetBackgroundImage();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new frmListUsers().ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmChangePassword(clsGlobalUser.CurrentUser.UserID, this).ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmShowUser(clsGlobalUser.CurrentUser.UserID).ShowDialog();
        }

        public void _SignOut()
        {
            clsGlobalUser.CurrentUser = null;
            _LoginScreen.Show();
            this.Close();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SignOut();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmListApplicationTypes().ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmListTestTypes().ShowDialog();
        }

        private void licenseClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmListLicenseClasses().ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAdd_UpdateLocalDrivingLicenseApplication(-1).ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmListLocalDrivingLicenseApplications().ShowDialog();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            new frmListDrivers().ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmNewInternationalLicenseApplication().ShowDialog();   
        }

        private void internationalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmListInternationalLicesnseApplications().ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmRenewLocalDrivingLicenseApplication().ShowDialog();
        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmReplaceLostOrDamagedLicenseApplication().ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDetainLicense().ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmReleaseDetainedLicenseApplication().ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmListDetainedLicenses().ShowDialog();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmReleaseDetainedLicenseApplication().ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmListLocalDrivingLicenseApplications().ShowDialog();
        }
    }
}