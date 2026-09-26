using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmShowUser : Form
    {
        public frmShowUser(int UserID)
        {
            InitializeComponent();
            ctrlUserInformation.ShowUserData(UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}