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
    public partial class ManagerProfile : UserControl
    {
        private static ManagerProfile instance;

        public static ManagerProfile Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManagerProfile();
                }
                return instance;
            }
        }
        public ManagerProfile()
        {
            InitializeComponent();

        }

        public void setInventoryManager()
        {

            usernamelabel.Text = InventoryManagerScreen.Instance.CurrentManager.Username;

            passwordlabel.Text = InventoryManagerScreen.Instance.CurrentManager.Password;

            fnamelabel.Text = InventoryManagerScreen.Instance.CurrentManager.FirstName;
            lnamelabel.Text = InventoryManagerScreen.Instance.CurrentManager.LastName;
            email.Text = InventoryManagerScreen.Instance.CurrentManager.Email;


            phnumberlabel.Text = InventoryManagerScreen.Instance.CurrentManager.PhoneNumber;
            joiningdate.Text = InventoryManagerScreen.Instance.CurrentManager.JoiningDate;
            managertype.Text = InventoryManagerScreen.Instance.CurrentManager.Type;
        }

        public void setStoreManager()
        {
            usernamelabel.Text = StoreManagerScreen.Instance.CurrentManager.Username;
            passwordlabel.Text = StoreManagerScreen.Instance.CurrentManager.Password;
            fnamelabel.Text = StoreManagerScreen.Instance.CurrentManager.FirstName;
            lnamelabel.Text = StoreManagerScreen.Instance.CurrentManager.LastName;
            email.Text = StoreManagerScreen.Instance.CurrentManager.Email;
            phnumberlabel.Text = StoreManagerScreen.Instance.CurrentManager.PhoneNumber;
            joiningdate.Text = StoreManagerScreen.Instance.CurrentManager.JoiningDate;
            managertype.Text = StoreManagerScreen.Instance.CurrentManager.Type;
        }

        private void usernamelabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordlabel_Click(object sender, EventArgs e)
        {

        }

        private void fnamelabel_Click(object sender, EventArgs e)
        {

        }

        private void lnamelabel_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void phnumberlabel_Click(object sender, EventArgs e)
        {

        }

        private void joiningdate_Click(object sender, EventArgs e)
        {

        }

        private void managertype_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            ManagerUpdateProfile manupdateform = new ManagerUpdateProfile();

            manupdateform.setTextBoxes(usernamelabel.Text, passwordlabel.Text, fnamelabel.Text, lnamelabel.Text, email.Text, phnumberlabel.Text, joiningdate.Text, managertype.Text );
            manupdateform.ShowDialog();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete your profile?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
              //  DataBase.Instance.DeleteProfile(usernamelabel.Text, passwordlabel.Text);
                MessageBox.Show("Your profile has been deleted.", "Profile Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
