using System;
using DVLD_BusinessLogicLayer;
using System.Windows.Forms;
using DVLD_PresentationLayer.Global_Classes;

namespace DVLD_PresentationLayer.Licenses.International_Licenses.Controls
{
    public partial class ctrlInternationalDriverLicenseInfo : UserControl
    {
        clsInternationalLicense _CurrentInternationalLicense;

        public ctrlInternationalDriverLicenseInfo()
        {
            InitializeComponent();
        }

        private void _LoadLicenseInfo()
        {
            lblFullName.Text = _CurrentInternationalLicense.DriverInfo.PersonInfo.FullName;
            lblNationalNo.Text = _CurrentInternationalLicense.DriverInfo.PersonInfo.NationalNumber;
            lblGender.Text = clsUtil.GetBitString(_CurrentInternationalLicense.DriverInfo.PersonInfo.Gender, "Female", "Male");
            lblDateOfBirth.Text = clsFormat.SetDateFormat(_CurrentInternationalLicense.DriverInfo.PersonInfo.DateOfBirth, "d/MM/yyyy");
            lblLocalLicenseID.Text = _CurrentInternationalLicense.LocalLicenseInfo.LicenseID.ToString();
            lblDriverID.Text = _CurrentInternationalLicense.DriverInfo.DriverID.ToString();
            lblApplicationID.Text = _CurrentInternationalLicense.ApplicationInfo.ApplicationID.ToString();
            lblInternationalLicenseID.Text = _CurrentInternationalLicense.InternationalLicenseID.ToString();
            lblIssueDate.Text = clsFormat.SetDateFormat(_CurrentInternationalLicense.IssueDate, "d/MM/yyyy");
            lblExpirationDate.Text = clsFormat.SetDateFormat(_CurrentInternationalLicense.ExpirationDate, "d/MM/yyyy");
            lblIsActive.Text = clsUtil.GetBitString(Convert.ToByte(_CurrentInternationalLicense.IsActive), "Yes", "No");
            clsUtil.SetPersonImageFromPath(_CurrentInternationalLicense.DriverInfo.PersonInfo.ImagePath, pcbxPersonImage);
        }

        public void ShowLicenseData(int InternationalLicenseID)
        {
            _CurrentInternationalLicense = clsInternationalLicense.FindInternationalLicenseByInternationalLicenseID(InternationalLicenseID);
            _LoadLicenseInfo();
        }

        private void ctrlInternationalDriverLicenseInfo_Load(object sender, EventArgs e)
        {
            clsUtil.LoadFieldsPictures(gbxInternationalLicenseInfo, Images);
        }
    }
}