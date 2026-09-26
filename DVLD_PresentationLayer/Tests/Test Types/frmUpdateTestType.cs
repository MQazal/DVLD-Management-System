using DVLD_BusinessLogicLayer;
using DVLD_PresentationLayer.Global_Classes;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmUpdateTestType : Form
    {
        clsTestType _CurrentTestType;

        public frmUpdateTestType(int TestTypeID)
        {
            InitializeComponent();
            _LoadTestTypeInfo(TestTypeID);
        }

        private void _LoadTestTypeInfo(int TestTypeID)
        {
            _CurrentTestType = clsTestType.FindTest(TestTypeID);
            lbl_ID.Text = _CurrentTestType.TestID.ToString();
            txbxTitle.Text = _CurrentTestType.TestTitle;
            txbxDescription.Text = _CurrentTestType.TestDescription;
            txbxFees.Text = _CurrentTestType.TestFees.ToString();
        }

        private void frmUpdateTest_Load(object sender, EventArgs e)
        {
            clsUtil.LoadFieldsPictures(this, Images);
            this.ActiveControl = null;
        }

        private void _SetInputDataToObject()
        {
            _CurrentTestType.TestTitle = txbxTitle.Text;
            _CurrentTestType.TestDescription = txbxDescription.Text;
            _CurrentTestType.TestFees = Convert.ToDecimal(txbxFees.Text);
        }

        private void _UpdateTestType()
        {
            _SetInputDataToObject();
            if (_CurrentTestType.UpdateTest())
                MessageBox.Show(clsUtil.PrintFinishMessage(clsUtil.enMode.Update, "", "Test Type Updated Sucessfully."), "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Update is failed!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _UpdateTestType();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}