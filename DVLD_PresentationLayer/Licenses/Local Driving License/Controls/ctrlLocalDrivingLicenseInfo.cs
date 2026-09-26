using System;
using DVLD_BusinessLogicLayer;
using System.Windows.Forms;
using DVLD_PresentationLayer.Global_Classes;

namespace DVLD_PresentationLayer.Licenses.Local_Driving_License.Controls
{
    public partial class ctrlLocalDrivingLicenseInfo : UserControl
    {
        clsLicense _CurrentLicense;

        public ctrlLocalDrivingLicenseInfo()
        {
            InitializeComponent();
        }

        private void _LoadLicenseInfo()
        {
            lbl_ID.Text = _CurrentLicense.LicenseID.ToString();
            lblClass.Text = _CurrentLicense.LicenseClassInfo.ClassName;
            lblFullName.Text = _CurrentLicense.ApplicationInfo.PersonInfo.FullName;
            lblNationalNo.Text = _CurrentLicense.ApplicationInfo.PersonInfo.NationalNumber;
            lblGender.Text = lblGender.Text = clsUtil.GetBitString(_CurrentLicense.ApplicationInfo.PersonInfo.Gender, "Female", "Male");
            lblDateOfBirth.Text = clsFormat.SetDateFormat(_CurrentLicense.ApplicationInfo.PersonInfo.DateOfBirth, "d/MM/yyyy");
            lblIssueDate.Text = clsFormat.SetDateFormat(_CurrentLicense.IssueDate, "d/MM/yyyy");
            lblExpirationDate.Text = clsFormat.SetDateFormat(_CurrentLicense.ExpirationDate, "d/MM/yyyy");
            lblIssueReason.Text = _CurrentLicense.IssueReasonText;
            lblIsActive.Text = clsUtil.GetBitString(Convert.ToByte(_CurrentLicense.IsActive), "Yes", "No");
            lblIsDetained.Text = clsUtil.GetBitString(Convert.ToByte(_CurrentLicense.IsDetained), "Yes", "No");
            lblNotes.Text = _CurrentLicense.Notes;
            clsUtil.SetPersonImageFromPath(_CurrentLicense.ApplicationInfo.PersonInfo.ImagePath, pcbxPersonImage);
        }

        public void ShowLicenseData(int LicenseID)
        {
            _CurrentLicense = clsLicense.FindLicenseByLicenseID(LicenseID);
            _LoadLicenseInfo();
        }

        private void ctrlLocalDrivingLicenseInfo_Load(object sender, EventArgs e)
        {
            clsUtil.LoadFieldsPictures(gbxLicenseInfo, Images);
        }
    }
}