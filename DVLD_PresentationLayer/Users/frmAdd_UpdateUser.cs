using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmAdd_UpdateUser : Form
    {
        public frmAdd_UpdateUser(int UserID)
        {
            InitializeComponent();
            ctrlAdd_UpdateUser.InitializeUserObject(UserID);
        }

        private void frmAdd_UpdateUser_Load(object sender, EventArgs e)
        {
            ctrlAdd_UpdateUser.Size = this.ClientSize;
        }
    }
}