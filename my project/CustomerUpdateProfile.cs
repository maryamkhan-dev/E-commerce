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
    public partial class CustomerUpdateProfile : Form
    {
        public CustomerUpdateProfile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerUpdateProfile_Load(object sender, EventArgs e)
        {

        }

        public void setTextBoxes(string username, string password, string fname, string laname, string email, string phnum, string address, string city, string state)
        {
            usernamelabel.Text = username;
            passwrodlabel.Text = password;  
            fnamelabel.Text = fname;
            lnamelabel.Text = laname;   
            emaillabel.Text = email;    
            phnumberlabel.Text = phnum; 
            addresslabel.Text = address;    
            citylabel.Text = city;  
            statebox.Text = state;  
        }

        private void updateProfileBtn_Click(object sender, EventArgs e)
        {
            DataBase.Instance.UpdateCustomerProfile(usernamelabel.Text.ToString(), passwrodlabel.Text.ToString(), fnamelabel.Text.ToString(), lnamelabel.Text.ToString(), emaillabel.Text.ToString(), phnumberlabel.Text.ToString(), addresslabel.Text.ToString(),
                                                     citylabel.Text.ToString(), statebox.Text.ToString());
            this.Close();
        }
    }
}
