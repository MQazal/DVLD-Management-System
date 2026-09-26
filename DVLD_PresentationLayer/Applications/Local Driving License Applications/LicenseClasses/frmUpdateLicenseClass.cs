using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications.Local_Driving_License_Applications.LicenseClasses
{
    public partial class frmUpdateLicenseClass : Form
    {
        clsLicenseClass _CurrentLicenseClass;

        public frmUpdateLicenseClass(int LicenseClassID)
        {
            InitializeComponent();
            _LoadLicenseClassInfo(LicenseClassID);
        }

        private void _LoadLicenseClassInfo(int LicenseClassID)
        {
            _CurrentLicenseClass = clsLicenseClass.FindLicenseClass(LicenseClassID);
            lbl_ID.Text = _CurrentLicenseClass.LicenseClassID.ToString();
            txbxName.Text = _CurrentLicenseClass.ClassName;
            txbxDescription.Text = _CurrentLicenseClass.ClassDescription;
            txbxAllowedAge.Text = _CurrentLicenseClass.MinimumAllowedAge.ToString();
            txbxValidityLength.Text = _CurrentLicenseClass.DefaultValidityLength.ToString();
            txbxFees.Text = _CurrentLicenseClass.Fees.ToString();
        }

        private void frmUpdateLicenseClass_Load(object sender, EventArgs e)
        {
            clsUtil.LoadFieldsPictures(this, Images);
            this.ActiveControl = null;
        }

        private void _SetInputDataToObject()
        {
            _CurrentLicenseClass.ClassName = txbxName.Text;
            _CurrentLicenseClass.ClassDescription = txbxDescription.Text;
            _CurrentLicenseClass.MinimumAllowedAge = Convert.ToByte(txbxAllowedAge.Text);
            _CurrentLicenseClass.DefaultValidityLength = Convert.ToByte(txbxValidityLength.Text);
            _CurrentLicenseClass.Fees = Convert.ToDecimal(txbxFees.Text);
        }

        private void _UpdateLicenseClass()
        {
            _SetInputDataToObject();
            if (_CurrentLicenseClass.UpdateLicenseClass())
                MessageBox.Show(clsUtil.PrintFinishMessage(clsUtil.enMode.Update, "", "License Class Updated Sucessfully."), "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Update is failed!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _UpdateLicenseClass();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}