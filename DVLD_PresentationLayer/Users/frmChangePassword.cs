using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using DVLD_PresentationLayer.Global_Classes;
using DVLD_BusinessLogicLayer;

namespace DVLD_PresentationLayer
{
    public partial class frmChangePassword : Form
    {
        clsUser _CurrentUser;

        frmMain _CurrentMain;

        public frmChangePassword(int UserID, frmMain Main)
        {
            InitializeComponent();
            ctrlUserInformation.ShowUserData(UserID);
            _CurrentUser = clsUser.FindUserByUserID(UserID);
            _CurrentMain = Main;
        }

        private void _LoadFiledsPictures()
        {
            string Path = @"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Password 32.png";
            pcbxPass1.Image = Image.FromFile(Path);
            pcbxPass2.Image = Image.FromFile(Path);
            pcbxPass3.Image = Image.FromFile(Path);
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _LoadFiledsPictures();
        }

        private bool _ArePasswordsEqual(string Password1, string Password2)
        {
            return Password1 == Password2;
        }

        private bool _IsTextBoxEmpty(TextBox Box)
        {
            return string.IsNullOrEmpty(Box.Text);
        }

        private void txbxCurrentPassword_Leave(object sender, EventArgs e)
        {
            if (!_ArePasswordsEqual(txbxCurrentPassword.Text, _CurrentUser.Password))
            {
                Error.SetError(txbxCurrentPassword, "Current Password is not similar to your password!");
                return;
            }

            if (_IsTextBoxEmpty(txbxCurrentPassword))
            {
                Error.SetError(txbxCurrentPassword, "Current Password is not typed!");
                return;
            }

            Error.Clear();
        }

        private void txbxNewPassword_Leave(object sender, EventArgs e)
        {
            if (_IsTextBoxEmpty(txbxNewPassword))
            {
                Error.SetError(txbxNewPassword, "New Password is not typed!");
                return;
            }
            Error.Clear();
        }

        private void txbxConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (!_ArePasswordsEqual(txbxNewPassword.Text, txbxConfirmPassword.Text))
            {
                Error.SetError(txbxConfirmPassword, "Confirm Password is not similar to New Password!");
                return;
            }

            if (_IsTextBoxEmpty(txbxConfirmPassword))
            {
                Error.SetError(txbxConfirmPassword, "Confirm Password is not typed!");
                return;
            }

            Error.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _IsChangeProcessValid()
        {
            foreach (TextBox Box in this.Controls.OfType<TextBox>())
            {
                if (!string.IsNullOrEmpty(Error.GetError(Box)))
                    return false;
            }
            return true;
        }

        private void _ChangePassword()
        {
            if (_IsChangeProcessValid())
            {
                _CurrentUser.ChangePassword(_CurrentUser.UserID, txbxNewPassword.Text);
                MessageBox.Show(clsUtil.PrintFinishMessage(clsUtil.enMode.Update, "", $"Password is Changed from {txbxCurrentPassword.Text} to {_CurrentUser.Password} Successfully."), "Finsih Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                _CurrentMain._SignOut();
            }
            else
                MessageBox.Show($"Faild to Change\nYou Have Error(s)!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _ChangePassword();
        }
    }
}