using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class ctrlAdd_UpdateUser : UserControl
    {
        clsUser _User;

        enum _enMode { AddNew, Update }
        _enMode _Mode;

        private void _ShowUserData()
        {
            lblTitle.Text = "Update User";
            lbl_ID.Text = _User.UserID.ToString();
            tbxUsername.Text = _User.Username;
            tbxPassword.Text = _User.Password;
            tbxConfirmPassword.Text = _User.Password;
            chbxActive.Checked = _User.IsActive;
        }
        
        public ctrlAdd_UpdateUser()
        {
            InitializeComponent();
        }

        private _enMode _SelectMode(int UserID)
        {
            return UserID == -1 ? _enMode.AddNew : _enMode.Update;
        }

        public void InitializeUserObject(int UserID)
        {
            _Mode = _SelectMode(UserID);
            if (_Mode == _enMode.Update)
            {
                _User = clsUser.FindUserByUserID(UserID);
                ctrlFindPerson.LoadPersonDataById(_User.PersonInfo.PersonID);
                _ShowUserData();
            }
            else
                _User = new clsUser();
        }

        private void _NavigateToUserTab()
        {
            if (_Mode == _enMode.Update)
                Add_UpdateTaps.SelectedIndex = 1;

            else
            {
                _User.PersonInfo = clsPerson.FindPerson(ctrlFindPerson.PersonID);

                if (clsUser.IsUserExistByPersonID(_User.PersonInfo.PersonID))
                {
                    MessageBox.Show("Selected person already has a user, choose another one!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Add_UpdateTaps.SelectedIndex = 0;
                    ctrlFindPerson.gbxFilter.Enabled = true;
                }

                else if (_User.PersonInfo == null)
                {
                    MessageBox.Show("You must search about valid person firstly!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Add_UpdateTaps.SelectedIndex = 0;
                }

                else
                {
                    Add_UpdateTaps.SelectedIndex = 1;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _NavigateToUserTab();
        }

        private void _LoadFieldsPictures()
        {
            pbxID.Image = ImagesList.Images[0];
            pbxUsername.Image = ImagesList.Images[1];
            pbxPassword.Image = ImagesList.Images[2];
            pbxConfirmPassword.Image = ImagesList.Images[3];
        }

        private void ctrlAdd_UpdateUser_Load(object sender, EventArgs e)
        {
            _LoadFieldsPictures();
        }

        private bool _IsTextBoxEmpty(TextBox Current)
        {
            return string.IsNullOrEmpty(Current.Text);
        }

        private bool _IsPasswordSimilarToConfirmation()
        {
            for (byte i = 0; i < tbxConfirmPassword.Text.Length; i++)
            {
                if (tbxPassword.Text[i] != tbxConfirmPassword.Text[i])
                    return false;
            }
            return true;
        }

        private void _ValidateInputField(TextBox CurrentInputField, string ErrorMessage)
        {
            if (_IsTextBoxEmpty(CurrentInputField))
                Error.SetError(CurrentInputField, ErrorMessage);

            else if (!_IsPasswordSimilarToConfirmation())
                Error.SetError(CurrentInputField, ErrorMessage);

            else
                Error.SetError(CurrentInputField, "");
        }

        private void tbxUsername_Leave(object sender, EventArgs e)
        {
            _ValidateInputField((TextBox)sender, "Username is Empty");
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            _ValidateInputField((TextBox)sender, "Passowrd is Empty!");
        }

        private void tbxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            _ValidateInputField((TextBox)sender, "Confirmation not equal written password!");
        }

        private void tbxConfirmPassword_Leave(object sender, EventArgs e)
        {
            _ValidateInputField((TextBox)sender, "Password confirmation is Empty!");
        }

        private bool _SelectIsActiveBit()
        {
            return chbxActive.Checked;
        }

        private void _SetInputDataToObject()
        {
            _User.Username = tbxUsername.Text;
            _User.Password = tbxPassword.Text;
            _User.PersonID = _User.PersonInfo.PersonID;
            _User.IsActive = _SelectIsActiveBit();
        }

        private void _ConvertFormToUpdateMode()
        {
            _Mode = _enMode.Update;
            lblTitle.Text = "Update User";
            lbl_ID.Text = _User.UserID.ToString();
        }

        private bool _AreInputFieldsValid()
        {
            foreach (TextBox Box in Login_InfoTap.Controls.OfType<TextBox>())
                if (!string.IsNullOrEmpty(Error.GetError(Box)))
                {
                    return false;
                }
            return true;
        }

        private void _SaveUserRecord()
        {
            if (!_AreInputFieldsValid())
            {
                MessageBox.Show("You have error(s) in input data!", "Fialed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _SetInputDataToObject();

            if (_User.Save())
                MessageBox.Show(clsUtil.PrintFinishMessage((byte)_Mode, "New User is Added Sucessfully!", "User is Updated Sucessfully!"), "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Operation is Failed", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (_Mode == _enMode.AddNew)
                _ConvertFormToUpdateMode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveUserRecord();
        }

        private void Add_UpdateTaps_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (Add_UpdateTaps.SelectedIndex == 1)
                _NavigateToUserTab();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            tbxPassword.PasswordChar = '\0';
        }

        private void btnShowConfimPass_Click(object sender, EventArgs e)
        {
            tbxConfirmPassword.PasswordChar = '\0';
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Add_UpdateTaps.SelectedIndex = 0;
        }
    }
}