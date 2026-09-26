using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmScheduledTest : Form
    {
        public frmScheduledTest(int TestAppointment, int LocalDrivingLicenseApplication)
        {
            InitializeComponent();
            ctrlSecheduledTest.InitializeTestState(TestAppointment, LocalDrivingLicenseApplication);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}