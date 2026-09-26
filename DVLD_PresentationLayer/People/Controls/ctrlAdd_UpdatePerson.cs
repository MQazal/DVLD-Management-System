using DVLD_BusinessLogicLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using DVLD_PresentationLayer.Global_Classes;

namespace DVLD_PresentationLayer
{
    public partial class ctrlAdd_UpdatePerson : UserControl
    {
        private enum _enMode { AddNew, Update }
        _enMode _Mode;

        clsPerson _Person;

        public int NewID = default(int);

        private _enMode _SelectMode(int PersonID)
        {
            return PersonID == -1 ? _enMode.AddNew : _enMode.Update;
        }

        private void _SelectGenderFromDB(byte BitValue)
        {
            if (BitValue == 0)
                rdbtnMale.Checked = true;
            else
                rdbtnFemale.Checked = true;
        }

        private void _LoadPersonData()
        {
            lblTitle.Text = "Update Person";
            lbl_ID.Text = _Person.PersonID.ToString();
            tbxFName.Text = _Person.FirstName;
            tbxSName.Text = _Person.SecondName;
            tbxTName.Text = _Person.ThirdName;
            tbxLName.Text = _Person.LastName;
            tbxNationalNo.Text = _Person.NationalNumber;
            _SelectGenderFromDB(_Person.Gender);
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            tbxPhone.Text = _Person.Phone;
            tbxEmail.Text = _Person.Email;
            tbxAddress.Text = _Person.Address;
            _LoadImage(_Person.ImagePath);
        }

        public void InitializePersonObject(int PersonID)
        {
            _Mode = _SelectMode(PersonID);
            if (_Mode == _enMode.Update)
            {
                _Person = clsPerson.FindPerson(PersonID);
                _LoadPersonData();
            }
            else
                _Person = new clsPerson();
            _SetCountry();
        }

        public ctrlAdd_UpdatePerson()
        {
            InitializeComponent();
        }

        private void _LoadCountriesList()
        {
            foreach(DataRow Row in clsCountry.GetCountriesList().Rows)
            {
                cbxCountry.Items.Add(Row["CountryName"].ToString());
            }
        }

        private void _SetCountry()
        {
            _LoadCountriesList();
            if (_Person.PersonID == default(int))
                cbxCountry.SelectedItem = "Saudi Arabia";
            else
                cbxCountry.SelectedIndex = _Person.CountryInfo.CountryID - 1;
        }

        private void _SetImageFromFile(string ImagePath)
        {
            pbxImage.Image = Image.FromFile(ImagePath);
            pbxImage.Tag = ImagePath;
            lblUserImage.Visible = false;
            lblDefaultImage.Visible = false;
            lblRemoveImage.Visible = true;
        }

        private void _LoadImage(string ImagePath)
        {
            if (!string.IsNullOrEmpty(ImagePath))
                _SetImageFromFile(ImagePath);
            else
                lblRemoveImage.Visible = false;
        }

        private void _SetDefaultImage()
        {
            if (rdbtnMale.Checked)
                _SetImageFromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Male 512.png");

            else if (rdbtnFemale.Checked)
                _SetImageFromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\Female 512.png");

            else
                pbxImage.Image = null;
        }

        private void lblDefaultImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _SetDefaultImage();
        }

        private void _SetDateToMinimumAgeDate()
        {
            dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
        }

        private void ctrlAddPerson_Load(object sender, EventArgs e)
        {
            _SetDateToMinimumAgeDate();
        }

        private bool _IsTextBoxEmpty(TextBox Current)
        {
            return string.IsNullOrEmpty(Current.Text);
        }

        private void _ValidateInputField(TextBox CurrentInputField, string ErrorMessage)
        {
            if (_IsTextBoxEmpty(CurrentInputField) && CurrentInputField != tbxNationalNo)
                error.SetError(CurrentInputField, ErrorMessage);
            else
                error.Clear();
        }

        private void tbxFName_Leave(object sender, EventArgs e)
        {
            _ValidateInputField((TextBox)sender, "First Name is Empty!");
        }

        private void tbxSName_Leave(object sender, EventArgs e)
        {
            _ValidateInputField((TextBox)sender, "Second Name is Empty!");
        }

        private void tbxTName_Leave(object sender, EventArgs e)
        {
            _ValidateInputField((TextBox)sender, "Third Name is Empty!");
        }

        private void tbxLName_Leave(object sender, EventArgs e)
        {
            _ValidateInputField((TextBox)sender, "Last Name is Empty!");
        }

        private void tbxNationalNo_Leave(object sender, EventArgs e)
        {
            if (_IsTextBoxEmpty(tbxNationalNo))
            {
                error.SetError(tbxNationalNo, "National Number is Empty!");
            }

            else if (clsPerson.IsPersonExist(tbxNationalNo.Text))
            {
                error.SetError(tbxNationalNo, "National number is used for another person!");
            }

            else
            {
                error.Clear();
            }
        }

        private void tbxPhone_Leave(object sender, EventArgs e)
        {
            _ValidateInputField((TextBox)sender, "Phone Number is Empty!");
        }

        private bool _CheckGmailFormat(byte StartFormatIndex)
        {
            char[] GmailChars = { 'g', 'm', 'a', 'i', 'l', '.', 'c', 'o', 'm' };
            byte arrIndex = 0;
            bool IsValidFormat = default(bool);

            for (byte i = StartFormatIndex; i < tbxEmail.Text.Length; i++)
            {
                if (GmailChars[arrIndex] == tbxEmail.Text[i])
                    arrIndex++;

                if (arrIndex == GmailChars.Length)
                    IsValidFormat = true;
            }

            return IsValidFormat;
        }

        private bool _IsEmailValid()
        {
            for(byte i = 0; i < tbxEmail.Text.Length; i++)
            {
                if (tbxEmail.Text[i] == '@')
                {
                    return _CheckGmailFormat(i += 1);
                }
            }
            return false;
        }

        private void tbxEmail_Leave(object sender, EventArgs e)
        {
            if (!_IsTextBoxEmpty((TextBox)sender))
            {
                if (!_IsEmailValid())
                    error.SetError(tbxEmail, "Incorrect Email Format!");
                else
                    error.Clear();
            }
        }

        private void tbxAddress_Leave(object sender, EventArgs e)
        {
            _ValidateInputField((TextBox)sender, "Address is Empty!");
        }

        private DialogResult _GetDialogResult()
        {
            OFImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            OFImage.FilterIndex = 1;
            OFImage.RestoreDirectory = true;
            return OFImage.ShowDialog();
        }

        private void lblUserImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_GetDialogResult() == DialogResult.OK)
                _SetImageFromFile(OFImage.FileName);
        }

        private void _RemoveCurrentUserImage()
        {
            pbxImage.Image.Dispose();
            pbxImage.Image = null;
            pbxImage.Tag = "";
            lblUserImage.Visible = true;
            lblDefaultImage.Visible = true;
            lblRemoveImage.Visible = false;
        }

        private void lblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _RemoveCurrentUserImage();
        }

        private byte _SelectGenderBySelection()
        {
            if (rdbtnMale.Checked)
                return 0;
            else
                return 1;
        }

        private string _GenerateNewPath()
        {
            string Directory = @"C:\DVLD-People-Images\";
            string ImageName = $"{Guid.NewGuid()}.jpg";
            return Directory + ImageName;
        }

        private void _CopySelectedImageToFolder(string GUIDPath)
        {
            File.Copy(pbxImage.Tag.ToString(), GUIDPath);
        }

        private void _RemoveOldUserImageFromFile(string OldPath)
        {
            File.Delete(OldPath);
        }

        private void _AssignImagePath()
        {
            if (pbxImage.Tag == null)
                _Person.ImagePath = "";

            else if (_Mode == _enMode.AddNew)
            {
                _Person.ImagePath = _GenerateNewPath();
                _CopySelectedImageToFolder(_Person.ImagePath);
            }

            else if (_Person.ImagePath != pbxImage.Tag.ToString()) // update mode + path is changed
            {
                _RemoveOldUserImageFromFile(_Person.ImagePath);
                _Person.ImagePath = _GenerateNewPath();
                _CopySelectedImageToFolder(_Person.ImagePath);
            }

            // last case: update mode + path is not changed: Image's path stay same to be return to database's entity
        }

        private void _SetInputDataToObject()
        {
            _Person.FirstName = tbxFName.Text;
            _Person.SecondName = tbxSName.Text;
            _Person.ThirdName = tbxTName.Text;
            _Person.LastName = tbxLName.Text;
            _Person.NationalNumber = tbxNationalNo.Text;
            _Person.Gender = _SelectGenderBySelection();
            _Person.DateOfBirth = Convert.ToDateTime(clsFormat.SetDateFormat(dtpDateOfBirth.Value, "yyyy/MM/dd"));
            _Person.Phone = tbxPhone.Text;
            _Person.Email = tbxEmail.Text;
            _Person.CountryID = cbxCountry.SelectedIndex + 1;
            _Person.Address = tbxAddress.Text;
            _AssignImagePath();
        }

        private void _ConvertFormToUpdateMode()
        {
            _Mode = _enMode.Update;
            lblTitle.Text = "Update Person";
            lbl_ID.Text = _Person.PersonID.ToString();
        }

        private void _SavePersonRecord()
        {
            _SetInputDataToObject();

            if (_Person.Save())
                MessageBox.Show(clsUtil.PrintFinishMessage((byte)_Mode, "New Person is Added Sucessfully!", "Person is Updated Sucessfully!"), "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Operation is Failed", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (_Mode == _enMode.AddNew)
            {
                NewID = _Person.PersonID;
                _ConvertFormToUpdateMode();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SavePersonRecord();
        }

        // note: if e.Handled == true then the key is blocked

        private void tbxLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbxNationalNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}