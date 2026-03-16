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
    public partial class ChooseUser : Form
    {
        private string user;

        public string UserType
        {
            get { return user; }
            set { user = value; }
        }

        public ChooseUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void loginBtn_Click(object sender, EventArgs e) //store manager
        {
            user = "Store Manager";
            this.Hide();
            Login lform = new Login(user);
            lform.ShowDialog();
        }

        private void ChooseUser_Load(object sender, EventArgs e)
        {
          

        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            user = "Inventory Manager";
            
           
            Login lform = new Login(user);

            this.Hide();
            lform.ShowDialog();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            user = "Customer";
            this.Hide();
            Login lform = new Login(user);
            lform.ShowDialog();
        }

    }
}
