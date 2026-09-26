using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.People
{
    public partial class ctrlPersonInformation : UserControl
    {
        clsPerson _CurrentPerson;

        public ctrlPersonInformation()
        {
            InitializeComponent();
        }

        private void _LoadPersonData()
        {
            lbl_ID.Text = _CurrentPerson.PersonID.ToString();
            lblFullName.Text = _CurrentPerson.FullName;
            lblNationalNo.Text = _CurrentPerson.NationalNumber;
            lblGender.Text = clsUtil.GetBitString(_CurrentPerson.Gender, "Female", "Male");
            lblDateOfBirth.Text = clsFormat.SetDateFormat(_CurrentPerson.DateOfBirth, "d/M/yyyy");
            lblPhone.Text = _CurrentPerson.Phone;
            lblEmail.Text = _CurrentPerson.Email;
            lblAddress.Text = _CurrentPerson.Address;
            lblCountry.Text = _CurrentPerson.CountryInfo.CountryName;
            clsUtil.SetPersonImageFromPath(_CurrentPerson.ImagePath, pcbxPersonImage);
        }

        public void ShowPersonData(int PersonID)
        {
            _CurrentPerson = clsPerson.FindPerson(PersonID);
            _LoadPersonData();
        }

        private void ctrlPersonInformation_Load(object sender, EventArgs e)
        {
            clsUtil.LoadFieldsPictures(gbxPerson, Images);
        }

        private void _OpenUpdatePersonForm(int PersonID)
        {
            new frmAdd_UpdatePerson(PersonID).ShowDialog();
        }

        private void _RefreshPersonData()
        {
            _CurrentPerson = clsPerson.FindPerson(_CurrentPerson.PersonID);
            _LoadPersonData();
        }

        private void lblEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_CurrentPerson != null)
            {
                _OpenUpdatePersonForm(_CurrentPerson.PersonID);
                _RefreshPersonData();
            }
        }
    }
}