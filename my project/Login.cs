using my_project.my_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_project
{
    public partial class Login : Form
    {
        private string user;
        public Login(string u)
        {
            InitializeComponent();
            user = u;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = login_username.Text.Trim();
            string password = login_password.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username is required. Please enter a username.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password is required. Please enter a password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DataBase.Instance.CheckUser(username, password, user))
            {
                MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;

                if (user == "Customer")
                {
                    CustomerScreen customerscreen = new CustomerScreen();
                    Customer customeron = DataBase.Instance.GetCustomer(username);
                    CustomerScreen.Instance.CurrentCustomer = customeron;   
                    CustomerScreen.Instance.setUsername();
                    CustomerScreen.Instance.makecart();
                    this.Close(); 
                    customerscreen.ShowDialog();
                }
                else if (user == "Store Manager")
                {
                    StoreManagerScreen storemanager = new StoreManagerScreen();
                    Manager mangeron = DataBase.Instance.GetManager(username);
                    StoreManagerScreen.Instance.CurrentManager = mangeron;
                    StoreManagerScreen.Instance.setUsername();

                    this.Close();
                    storemanager.ShowDialog();

                }
                else if (user == "Inventory Manager")
                {
                    InventoryManagerScreen inventorymanager = new InventoryManagerScreen();
                    Manager manageron = DataBase.Instance.GetManager(username);
                    InventoryManagerScreen.Instance.CurrentManager = manageron;
                    InventoryManagerScreen.Instance.setUsername();
                    this.Close();
                    inventorymanager.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passworderror_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            if (user =="Customer")
            {
                Register registerform = new Register();
                this.Hide();
                registerform.ShowDialog();
            }
            else if (user == "Store Manager" || user =="Inventory Manager")
            {
                ManagerRegisterForm managerregisterform = new ManagerRegisterForm(user);    
                this.Hide();
                managerregisterform.ShowDialog();   
            }
           
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showPass.Checked)
            {
                login_password.PasswordChar = '\0'; 
            }
            else
            {
                login_password.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            ChooseUser userform = new ChooseUser();
            userform.ShowDialog();
        }
    }
}
