using DVLD_PresentationLayer.Global_Classes;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Licenses.Local_Driving_License
{
    public partial class frmShowLocalDrivingLicenseInfo : Form
    {
        public frmShowLocalDrivingLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            ctrlLocalDrivingLicenseInfo.ShowLicenseData(LicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowLocalDrivingLicenseInfo_Load(object sender, EventArgs e)
        {
            clsUtil.SetPersonImageFromPath(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\LicenseView 400.png", pcbxTitleImage);
            clsUtil.SetPersonImageFromPath(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Local 32.png", pcbxIcon);
        }
    }
}