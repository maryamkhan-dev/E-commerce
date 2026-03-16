using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_project.my_project
{
    public partial class ManagerRegisterForm : Form
    {
        private string managertype;
        public ManagerRegisterForm(string u)
        {
            InitializeComponent();
            managertype = u;

        }

        private void ManagerRegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            string phnum = phonenumberlabel.Text;
            StringBuilder digitString = new StringBuilder();

            foreach (char c in phnum)
            {
                if (char.IsDigit(c))
                {
                    digitString.Append(c);
                }
            }

            string phnumlenght = digitString.ToString();
            if (phnumlenght.Length != 11)
            {
                MessageBox.Show("Incorrect Phone Number", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (passwordlabel.Text.Length != 9)
            {
                MessageBox.Show("Password must be 9 characters long.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string username = usernamelabel.Text.Trim();
            string fname = fnamelabel.Text.Trim();
            string lname = lnamelabel.Text.Trim();
            string email = emaillabel.Text.Trim();
            string password = passwordlabel.Text.Trim();
            string phonenumber = phonenumberlabel.Text.Trim();
            DateTime joiningdate = dateTimePicker1.Value;
            string managertype = typebox.Text.Trim();   

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || joiningdate == DateTime.MinValue ||
                string.IsNullOrEmpty(phonenumber) || string.IsNullOrEmpty(managertype))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            if (!email.Contains("@") || !email.EndsWith(".com"))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            if (DataBase.Instance.UserNameExists(username))
            {
                MessageBox.Show("Username already exists. Please choose another one.");
                return;
            }


            DataBase.Instance.AddNewManager(username, fname, lname, email, password, phonenumber, joiningdate, managertype);
            MessageBox.Show("User registered successfully.");


            if (managertype == "Store Manager")
            {
                StoreManagerScreen storemanager = new StoreManagerScreen();
               
                Manager smanager = DataBase.Instance.GetManager(username);
                StoreManagerScreen.Instance.CurrentManager = smanager;
                StoreManagerScreen.Instance.setUsername();


                this.Close();
                storemanager.ShowDialog();

            }
            else 
            {
                InventoryManagerScreen inventorymanager = new InventoryManagerScreen();
                Manager manageron = DataBase.Instance.GetManager(username);
                InventoryManagerScreen.Instance.CurrentManager = manageron;
                InventoryManagerScreen.Instance.setUsername();

                this.Close();
                inventorymanager.ShowDialog();
            }
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showPass.Checked)
            {
                passwordlabel.PasswordChar = '\0'; 
            }
            else
            {
                passwordlabel.PasswordChar = '*';
            }
        }

        private void passwordlabel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void phonenumberlabel_TextChanged(object sender, EventArgs e)
        {
            string text = phonenumberlabel.Text;
            StringBuilder digitString = new StringBuilder();

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    digitString.Append(c);
                }
            }

            phonenumberlabel.Text = digitString.ToString();
            phonenumberlabel.SelectionStart = phonenumberlabel.TextLength;
        }
    }
}
