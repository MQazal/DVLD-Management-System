using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmAdd_UpdatePerson : Form
    {
        public frmAdd_UpdatePerson(int PersonID)
        {
            InitializeComponent();
            ctrlAdd_UpdatePerson.InitializePersonObject(PersonID);
        }

        // Delegate's Sender

        public delegate void SendNewPerson(int NewPersonID);

        public event SendNewPerson NewPersonBack;

        private void _CloseForm()
        {
            this.Close();
            NewPersonBack?.Invoke(ctrlAdd_UpdatePerson.NewID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _CloseForm();
        }

        private void frmAdd_UpdatePerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            NewPersonBack?.Invoke(ctrlAdd_UpdatePerson.NewID);
        }
    }
}