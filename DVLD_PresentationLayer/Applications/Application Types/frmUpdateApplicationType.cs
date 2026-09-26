using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmUpdateApplicationType : Form
    {
        clsApplicationType _CurrentApplicationType;

        public frmUpdateApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            _LoadApplicationTypeInfo(ApplicationTypeID);
        }

        private void _LoadApplicationTypeInfo(int ApplicationTypeID)
        {
            _CurrentApplicationType = clsApplicationType.FindApplicationType(ApplicationTypeID);
            lbl_ID.Text = _CurrentApplicationType.ApplicationTypeID.ToString();
            txbxTitle.Text = _CurrentApplicationType.ApplicationTitle;
            txbxFees.Text = _CurrentApplicationType.ApplicationFees.ToString();
        }

        private void frmUpdateApplication_Load(object sender, EventArgs e)
        {
            clsUtil.LoadFieldsPictures(this, Images);
            this.ActiveControl = null;
        }

        private void _SetInputDataToObject()
        {
            _CurrentApplicationType.ApplicationTitle = txbxTitle.Text;
            _CurrentApplicationType.ApplicationFees = Convert.ToDecimal(txbxFees.Text);
        }

        private void _UpdateApplicationType()
        {
            _SetInputDataToObject();
            if (_CurrentApplicationType.UpdateApplicationType())
                MessageBox.Show(clsUtil.PrintFinishMessage(clsUtil.enMode.Update, "Application Type Updated Sucessfully!"), "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Update is failed!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _UpdateApplicationType();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}