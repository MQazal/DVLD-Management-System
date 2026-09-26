using System;
using System.Windows.Forms;
using System.Drawing;
using DVLD_BusinessLogicLayer;

namespace DVLD_PresentationLayer.Licenses.Local_Driving_License
{
    public partial class frmShowLicenseHistoryOfPerson : Form
    {
        public frmShowLicenseHistoryOfPerson(int PersonID)
        {
            InitializeComponent();
            ctrlFindPerson.LoadPersonDataById(PersonID);
            ctrlDriverLicenses.SetDriverID(clsDriver.FindDriverByPersonID(PersonID).DriverID);
        }

        private void frmShowLicenseHistory_Load(object sender, EventArgs e)
        {
            pcbxTitleImage.Image = Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\PersonLicenseHistory 512.png");
            ctrlDriverLicenses.InitializeLocalLicenses();
            ctrlDriverLicenses.InitializeInternationalLicenses();
        }
    }
}