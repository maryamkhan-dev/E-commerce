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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
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
                return;
            }
            string username = usernamelabel.Text.Trim();  
            string fname = fnamelabel.Text.Trim();   
            string lname = lnamelabel.Text.Trim();
            string email = emaillabel.Text.Trim();  
            string password = passwordlabel.Text.Trim();        
            string address = addresslabel.Text.Trim();  
            string phonenumber = phonenumberlabel.Text.Trim();  
            string city = citylabel.Text.Trim();
            string state = statebox.Text.Trim();


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(phonenumber) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(state))
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


            DataBase.Instance.AddNewCustomer(username, fname, lname, email, password, address, phonenumber, city, state);
            MessageBox.Show("User registered successfully.");


            CustomerScreen customerscreen = new CustomerScreen();
            Customer customeron = DataBase.Instance.GetCustomer(username);
            CustomerScreen.Instance.CurrentCustomer = customeron;
            DataBase.Instance.MakeCartForNewCustomer(username);

            CustomerScreen.Instance.setUsername();

            this.Close();
            customerscreen.ShowDialog();

        }

        private void statebox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void usernamelabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void addresslabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void citylabel_TextChanged(object sender, EventArgs e)
        {

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
