using DVLD_PresentationLayer.Global_Classes;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Licenses.International_Licenses
{
    public partial class frmShowInternationalDrivingLicenseInfo : Form
    {
        public frmShowInternationalDrivingLicenseInfo(int InternationalLicenseID)
        {
            InitializeComponent();
            ctrlInternationalDriverLicenseInfo.ShowLicenseData(InternationalLicenseID);
        }

        private void frmShowInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            clsUtil.SetPersonImageFromPath(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\LicenseView 400.png", pcbxTitleImage);
            clsUtil.SetPersonImageFromPath(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\International 32.png", pcbxIcon);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}