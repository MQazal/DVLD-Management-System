using System;
using DVLD_BusinessLogicLayer;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmScheduleTest : Form
    {
        public frmScheduleTest(int LocalDrivingLicenseApplicationID, int AppointmentID, clsTestType.enTestType TestTypeID, bool IsLocked)
        {
            InitializeComponent();
            ctrlScheduleTest.InitializeAppointmentState(LocalDrivingLicenseApplicationID, AppointmentID, TestTypeID, IsLocked);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}