using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications.Local_License_Applications
{
    public partial class frmShowLocalDrivingLicenseApplication : Form
    {
        public frmShowLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            ctrlLocalDrivingLicenseApplicationInfomration.ShowApplicationData(LocalDrivingLicenseApplicationID);
        }
    }
}