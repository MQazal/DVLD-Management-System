using System;
using DVLD_BusinessLogicLayer;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Linq;

namespace DVLD_PresentationLayer
{
    public partial class frmLogin : Form
    {
        string _Path = @"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\LoginInfo.txt";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void _LoadPictures()
        {
            pcbxImage.Image = Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Authentication.jpg");
            pcbxUsername.Image = Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Person 32.png");
            pcbxPassword.Image = Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Password 32.png");
        }

        private void _LoadLoginInfo()
        {
            if (!string.IsNullOrEmpty(File.ReadAllText(_Path)))
            {
                txbxUsername.Text = File.ReadLines(_Path).ElementAt(0);
                txbxPassword.Text = File.ReadLines(_Path).ElementAt(1);
                chcbxRememberMe.Checked = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _LoadPictures();
            _LoadLoginInfo();
        }

        private bool _IsTextBoxEmpty(TextBox Current)
        {
            return string.IsNullOrEmpty(Current.Text);
        }

        private void _ValidateInputField(TextBox CurrentInputField, string ErrorMessage)
        {
            if (_IsTextBoxEmpty(CurrentInputField))
                Error.SetError(CurrentInputField, ErrorMessage);
            else
                Error.Clear();
        }

        private void txbxPassword_Leave(object sender, EventArgs e)
        {
            _ValidateInputField((TextBox)sender, "Text is empty!");
        }

        private void _InsertLoginInfoIntoFile()
        {
            if (chcbxRememberMe.Checked)
                File.WriteAllText(_Path, $"{txbxUsername.Text}\n{txbxPassword.Text}");
            else
                File.WriteAllText(_Path, "");
        }

        private void chcbxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            _InsertLoginInfoIntoFile();
        }

        private void _IntilizeUserObject()
        {
            clsGlobalUser.CurrentUser = clsUser.FindUserByUsernameAndPassword(txbxUsername.Text, txbxPassword.Text);
        }

        private bool _IsUserExit()
        {
            return clsGlobalUser.CurrentUser != null;
        }

        private bool _IsUserActive()
        {
            return clsGlobalUser.CurrentUser.IsUserActive();
        }

        private void _OpenMainScreen()
        {
            new frmMain(this).Show();
            this.Hide();
        }

        private void _PerformLogin()
        {
            _IntilizeUserObject();

            if (!_IsUserExit())
            {
                MessageBox.Show("Username/Password is not valid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_IsUserActive())
            {
                MessageBox.Show("User is not active in the system!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _OpenMainScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _InsertLoginInfoIntoFile();
            _PerformLogin();
        }

        private void _ShowPassword()
        {
            btnShowPassword.Tag = 2;
            btnShowPassword.Image = Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\show password.png");
            txbxPassword.PasswordChar = '\0';
        }

        private void _HidePassword()
        {
            btnShowPassword.Tag = 1;
            btnShowPassword.Image = Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\icons8-hide-password-35.png");
            txbxPassword.PasswordChar = '*';
        }

        private void _ConfigurePasswordVisibility()
        {
            if (Convert.ToByte(btnShowPassword.Tag) == 1)
                _ShowPassword();
            else
                _HidePassword();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            _ConfigurePasswordVisibility();
        }
    }
}