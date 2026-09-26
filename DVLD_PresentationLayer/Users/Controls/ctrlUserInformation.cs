using System;
using DVLD_BusinessLogicLayer;
using System.Windows.Forms;
using DVLD_PresentationLayer.Global_Classes;

namespace DVLD_PresentationLayer
{
    public partial class ctrlUserInformation : UserControl
    {
        clsUser _CurrentUser;

        public ctrlUserInformation()
        {
            InitializeComponent();
        }

        private void _LoadUserData()
        {
            lbl_ID.Text = _CurrentUser.UserID.ToString();
            lblUsername.Text = _CurrentUser.Username;
            lblActive.Text = clsUtil.GetBitString(Convert.ToByte(_CurrentUser.IsActive), "Yes", "No");
        }

        public void ShowUserData(int UserID)
        {
            _CurrentUser = clsUser.FindUserByUserID(UserID);
            PersonInformation.ShowPersonData(_CurrentUser.PersonInfo.PersonID);
            _LoadUserData();
        }

        private void _OpenUpdateUserForm(int UserID)
        {
            new frmAdd_UpdateUser(UserID).ShowDialog();
        }

        private void _RefreshUserData()
        {
            _CurrentUser = clsUser.FindUserByUserID(_CurrentUser.UserID);
            _LoadUserData();
        }

        private void lblEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_CurrentUser != null)
            {
                _OpenUpdateUserForm(_CurrentUser.UserID);
                _RefreshUserData();
            }
        }
    }
}