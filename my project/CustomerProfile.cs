using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_project
{
    public partial class CustomerProfile : UserControl
    {
        private static CustomerProfile instance;

        public static CustomerProfile Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerProfile();
                }
                return instance;
            }
        }
        public CustomerProfile()
        {
            InitializeComponent();
            usernamelabel.Text = CustomerScreen.Instance.CurrentCustomer.Username;
            passwordlabel.Text = CustomerScreen.Instance.CurrentCustomer.Password;
            fnamelabel.Text = CustomerScreen.Instance.CurrentCustomer.FirstName;
            lnamelabel.Text = CustomerScreen.Instance.CurrentCustomer.LastName;
            email.Text = CustomerScreen.Instance.CurrentCustomer.Email;
            phnumberlabel.Text = CustomerScreen.Instance.CurrentCustomer.PhoneNumber;
            addresslabel.Text = CustomerScreen.Instance.CurrentCustomer.Address;
            cityl.Text = CustomerScreen.Instance.CurrentCustomer.City;
            statel.Text = CustomerScreen.Instance.CurrentCustomer.State;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            CustomerUpdateProfile cusupdateform = new CustomerUpdateProfile();
            cusupdateform.setTextBoxes(usernamelabel.Text, passwordlabel.Text, fnamelabel.Text, lnamelabel.Text, email.Text, phnumberlabel.Text, addresslabel.Text, cityl.Text, statel.Text);
            cusupdateform.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete your profile?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                DataBase.Instance.DeleteProfile(usernamelabel.Text, passwordlabel.Text);
                MessageBox.Show("Your profile has been deleted.", "Profile Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
