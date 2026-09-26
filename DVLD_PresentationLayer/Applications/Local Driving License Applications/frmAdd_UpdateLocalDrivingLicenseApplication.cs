using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmAdd_UpdateLocalDrivingLicenseApplication : Form
    {
        public frmAdd_UpdateLocalDrivingLicenseApplication(int ApplicationID)
        {
            InitializeComponent();
            ctrlAdd_UpdateLocalDrivingLicenseApplication.InitializeApplicationObject(ApplicationID);
        }
    }
}