using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Licenses.Local_Driving_License.Controls
{
    public partial class ctrlLocalDrivingLicenseInfoWithFilter : UserControl
    {
        //public delegate void SendLicenseID(int LicenseID);

        //public event SendLicenseID LicenseIDBack;

        public event Action<int> SelectLicense;

        protected virtual void OnLicenseSelecting(int LicenseID)
        {
            Action<int> Handler = SelectLicense;
            if (Handler != null)
            {
                Handler(LicenseID);
            }
        }

        public ctrlLocalDrivingLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbxLicenseID.Text))
            {
                ctrlLocalDrivingLicenseInfo.ShowLicenseData(Convert.ToInt32(txbxLicenseID.Text));
            }
        }

        private void txbxLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && !string.IsNullOrEmpty(txbxLicenseID.Text))
            {
                e.Handled = true;
                ctrlLocalDrivingLicenseInfo.ShowLicenseData(Convert.ToInt32(txbxLicenseID.Text));
                //LicenseIDBack?.Invoke(Convert.ToInt32(txbxLicenseID.Text));
                OnLicenseSelecting(Convert.ToInt32(txbxLicenseID.Text));
                this.Focus();
            }
        }

        public void ShowLicenseDate(int LicenseID)
        {
            ctrlLocalDrivingLicenseInfo.ShowLicenseData(LicenseID);
            txbxLicenseID.Text = LicenseID.ToString();
            gbxFilter.Enabled = false;
        }
    }
}