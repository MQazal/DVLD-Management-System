using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class ctrlAdd_UpdateLocalDrivingLicenseApplication : UserControl
    {
        enum _enMode { AddNew, Update }
        _enMode _Mode;
        
        clsApplication _Application;

        clsLocalDrivingLicenseApplication _LocalApplication;

        private _enMode SelectMode(int ApplicationID)
        {
            return ApplicationID == -1 ? _enMode.AddNew : _enMode.Update;
        }

        private void _LoadApplicationData()
        {
            lblTitle.Text = "Update Application";
            lblApplicationID.Text = _Application.ApplicationID.ToString();
            lblDate.Text = clsFormat.SetDateFormat(_Application.ApplicationDate, "d/M/yyyy");
            cmbxClasses.SelectedItem = _LocalApplication.LicenseClassInfo.ClassName;
            lblFees.Text = _Application.PaidFees.ToString();
            lblUsername.Text = _Application.CreatedByUserInfo.Username;
        }

        private void _ConfigureFormStateInUpdateMode(int ApplicationID)
        {
            _Mode = _enMode.Update;
            _Application = clsApplication.FindApplication(ApplicationID);
            ctrlFindPerson.LoadPersonDataById(_Application.PersonInfo.PersonID);
            _LocalApplication = clsLocalDrivingLicenseApplication.FindLocalDrvingLicenseAppByApplicationID(_Application.ApplicationID);
            _LoadApplicationData();
        }

        private void _ConfigureFormStateInAddMode()
        {
            _Mode = _enMode.AddNew;
            _Application = new clsApplication();
            _LocalApplication = new clsLocalDrivingLicenseApplication();
            cmbxClasses.SelectedIndex = 2;
        }

        private void _LoadLicenseClasses()
        {
            foreach (DataRow Row in clsLicenseClass.GetClassesList().Rows)
            {
                cmbxClasses.Items.Add(Row["ClassName"]);
            }
        }

        public void InitializeApplicationObject(int ApplicationID)
        {
            _LoadLicenseClasses();
            _Mode = SelectMode(ApplicationID);
            if (_Mode == _enMode.Update)
                _ConfigureFormStateInUpdateMode(ApplicationID);
            else
                _ConfigureFormStateInAddMode();
        }

        public ctrlAdd_UpdateLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void ctrlLocalLicenseApplication_Load(object sender, EventArgs e)
        {
            clsUtil.LoadFieldsPictures(Application_InfoTap, Images);
        }

        private bool _IsUserExit()
        {
            clsPerson Person = clsPerson.FindPerson(ctrlFindPerson.PersonID);
            if (Person != null)
                return clsUser.IsUserExistByPersonID(Person.PersonID);
            else
                return false;
        }

        private void _SelectApplicationInfoTab()
        {
            if (_Mode == _enMode.Update)
            {
                Add_UpdateTaps.SelectedIndex = 1;
                return;
            }

            if (ctrlFindPerson.PersonID == -1)
            {
                MessageBox.Show("You must search about person firstly", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Add_UpdateTaps.SelectedIndex = 0;
            }
            
            else if (_IsUserExit())
            {
                MessageBox.Show("Selected person already has a user, choose another one!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Add_UpdateTaps.SelectedIndex = 0;
            }

            else
            {
                lblUsername.Text = clsGlobalUser.CurrentUser.Username;
                Add_UpdateTaps.SelectedIndex = 1;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _SelectApplicationInfoTab();
        }

        private void _SetInputDataToApplicationInfo()
        {
            // Add new Application
            _Application.ApplicationDate = DateTime.Today.Date;
            _Application.ApplicationStatus = clsApplication.enApplicationStatus.New;
            _Application.LastStatusDate = DateTime.Today.Date;
            _Application.ApplicationTypeID = Convert.ToInt32(clsApplication.enApplicationType.NewLocalLicense);
            _Application.PaidFees = clsApplicationType.GetApplicationTypeFees(_Application.ApplicationTypeID);
            _Application.ApplicantPersonID = ctrlFindPerson.PersonID;
            _Application.CreatedByUserID = clsGlobalUser.CurrentUser.UserID;
        }

        private void _SetLocalApplicationInfo()
        {
            // Add new Local Driving License Application
            _LocalApplication.ApplicationID = _Application.ApplicationID;
            _LocalApplication.LicenseClassID = cmbxClasses.SelectedIndex + 1;
        }

        private void _ConvertFormToUpdateMode()
        {
            _Mode = _enMode.Update;
            lblTitle.Text = "Update Application";
            lblApplicationID.Text = _Application.ApplicationID.ToString();
            lblDate.Text = clsFormat.SetDateFormat(_Application.ApplicationDate, "d/M/yyyy");
            lblFees.Text = _Application.PaidFees.ToString();
        }

        private void _AddNewApplication()
        {
            if (clsApplication.DoesPersonHaveActiveApplication(ctrlFindPerson.PersonID, clsApplication.enApplicationType.NewLocalLicense, Convert.ToInt32(cmbxClasses.SelectedIndex + 1)))
            {
                MessageBox.Show($"⚠️ An active application already exists for the following license class:\n\n" +
                                $"🚗 License Class: {cmbxClasses.SelectedItem}\n\n" +
                                $"Please complete or cancel the existing application before creating a new one.",
                                "⚠️ Application Already Exists",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _SetInputDataToApplicationInfo();

            if (_Application.Save())
            {
                _SetLocalApplicationInfo();
                if (_LocalApplication.Save())
                    MessageBox.Show(clsUtil.PrintFinishMessage((byte)_Mode, "New Application is Added Sucessfully!", "Application is Updated Successfully"), "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operation is Failed", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                _ConvertFormToUpdateMode();
        }

        private void _UpdateApplication()
        {
            _LocalApplication.LicenseClassID = cmbxClasses.SelectedIndex + 1;
            if (_LocalApplication.Save())
                MessageBox.Show(clsUtil.PrintFinishMessage((byte)_Mode, "New Application is Added Sucessfully!", "Application is Updated Successfully"), "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Operation is failed", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _SaveApplicationRecord()
        {
            if (clsLicense.IsLicenseExit(ctrlFindPerson.PersonID, cmbxClasses.SelectedIndex + 1))
            {
                MessageBox.Show("Person Already has Active License from this Class\nChoose different Driving License Class!", "Finish Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Mode == _enMode.AddNew)
            {
                _AddNewApplication();
                return;
            }
            _UpdateApplication();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveApplicationRecord();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Add_UpdateTaps.SelectedIndex = 0;
        }

        private void Add_UpdateTaps_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (Add_UpdateTaps.SelectedIndex == 1)
                _SelectApplicationInfoTab();
        }
    }
}