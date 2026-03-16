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
    public partial class ManagerUpdateProfile : Form
    {
        public ManagerUpdateProfile()
        {
            InitializeComponent();
        }

        private void updateProfileBtn_Click(object sender, EventArgs e)
        {
            DataBase.Instance.UpdateManagerProfile(usernamelabel.Text.ToString(), fnamelabel.Text.ToString(), lnamelabel.Text.ToString(), emaillabel.Text.ToString(), passwrodlabel.Text.ToString(), dateLabel.Text.ToString(),
                                                     phnumberlabel.Text.ToString(), typebox.Text.ToString());
            this.Close();
        }

        public void setTextBoxes(string username, string password, string fname, string laname, string email, string phnum, string date, string type)
        {
            usernamelabel.Text = username;
            passwrodlabel.Text = password;
            fnamelabel.Text = fname;
            lnamelabel.Text = laname;
            emaillabel.Text = email;
            phnumberlabel.Text = phnum;
            dateLabel.Text = date;
            typebox.Text = type;

        }

    }
}
