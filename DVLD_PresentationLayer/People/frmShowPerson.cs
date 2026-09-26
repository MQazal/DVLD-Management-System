using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmShowPerson : Form
    {
        public frmShowPerson(int PersonID)
        {
            InitializeComponent();
            ctrlPersonInformation.ShowPersonData(PersonID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}