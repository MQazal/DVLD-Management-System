using DVLD_BusinessLogicLayer;
using System;
using System.Windows.Forms;

// Boolean Flag Form -> Is person Exit or no?

namespace DVLD_PresentationLayer
{
    public partial class ctrlFindPerson : UserControl
    {
        public int PersonID = -1;

        enum _enSearchFilter { enPersonID, enNationalNumber }
        _enSearchFilter _Filter;

        public ctrlFindPerson()
        {
            InitializeComponent();
        }

        private void _CloseSearch()
        {
            if (_Filter == _enSearchFilter.enPersonID)
            {
                txbxSerachValue.Text = PersonID.ToString();
                cmbxFilter.SelectedIndex = 0;
            }
            else
            {
                txbxSerachValue.Text = txbxSerachValue.Text;
                cmbxFilter.SelectedIndex = 1;
            }

            gbxFilter.Enabled = false;
        }

        private bool _IsSearchTextHasLetters()
        {
            foreach (char Letter in txbxSerachValue.Text)
            {
                if (char.IsLetter(Letter))
                    return true;
            }
            return false;
        }

        private bool _IsPersonExit()
        {
            if (cmbxFilter.SelectedIndex == 0)
            {
                if (_IsSearchTextHasLetters())
                {
                    return false;
                }
                _Filter = _enSearchFilter.enPersonID;
                return clsPerson.IsPersonExist(Convert.ToInt32(txbxSerachValue.Text));
            }
            else
            {
                _Filter = _enSearchFilter.enNationalNumber;
                return clsPerson.IsPersonExist(txbxSerachValue.Text);
            }
        }

        public void LoadPersonDataById(int PersonID)
        {
           PersonInformation.ShowPersonData(PersonID);
            this.PersonID = PersonID;
            _CloseSearch();
        }

        public void LoadPersonData(bool IsPersonExit)
        {
            if (IsPersonExit)
            {
                if (_Filter == _enSearchFilter.enPersonID)
                {
                    PersonID = Convert.ToInt32(txbxSerachValue.Text);
                    PersonInformation.ShowPersonData(PersonID);
                }
                else
                {
                    PersonID = clsPerson.FindPerson(txbxSerachValue.Text).PersonID;
                    PersonInformation.ShowPersonData(PersonID);
                }
                _CloseSearch();
            }
            else
                MessageBox.Show("Person is not found! try again", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool _IsSearchValid()
        {
            if (cmbxFilter.SelectedItem == null)
            {
                MessageBox.Show("No filter type was selected!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(txbxSerachValue.Text))
            {
                MessageBox.Show("Search box is empty!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void _Search()
        {
            if (!_IsSearchValid())
            {
                return;
            }
            LoadPersonData(_IsPersonExit());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Search();
        }

        // Delegate's Receiver

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd_UpdatePerson Add = new frmAdd_UpdatePerson(-1);
            Add.NewPersonBack += Add_NewPersonBack;
            Add.ShowDialog();
        }

        private void Add_NewPersonBack(int NewPersonID)
        {
            PersonInformation.ShowPersonData(NewPersonID);
            PersonID = NewPersonID;
            _CloseSearch();
        }

        private void cmbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbxSerachValue.Focus();
        }
    }
}