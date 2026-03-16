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
    public partial class StoreManagerScreen : Form
    {
        private Manager currentmanager = new Manager();

        private static StoreManagerScreen instance;

        public static StoreManagerScreen Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StoreManagerScreen();
                }
                return instance;
            }
        }
        public StoreManagerScreen()
        {
            InitializeComponent();
        }
        public void setUsername()
        {
            usernamelabel.Text = currentmanager.Username;
        }
        public Manager CurrentManager
        {
            get
            {
                return currentmanager;
            }
            set
            {
                currentmanager = value;
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void manageorderBtn_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(manageorders.Instance))
            {
                panel3.Controls.Add(manageorders.Instance);
                manageorders.Instance.Dock = DockStyle.Fill;
                manageorders.Instance.BringToFront();
            }
            else
            {
                manageorders.Instance.BringToFront();
            }
        }

        private void manageprofilesBtn_Click(object sender, EventArgs e) //managediscounts
        {
            if (!panel3.Controls.Contains(managediscounts.Instance))
            {
                panel3.Controls.Add(managediscounts.Instance);
                managediscounts.Instance.Dock = DockStyle.Fill;
                managediscounts.Instance.BringToFront();
            }
            else
            {
                managediscounts.Instance.BringToFront();
            }
        }

        private void profileBtn_Click(object sender, EventArgs e)// manageprofile
        {
            ManagerProfile.Instance.setStoreManager();
            if (!panel3.Controls.Contains(ManagerProfile.Instance))
            {
                panel3.Controls.Add(ManagerProfile.Instance);
                ManagerProfile.Instance.Dock = DockStyle.Fill;
                ManagerProfile.Instance.BringToFront();
            }
            else
            {
                ManagerProfile.Instance.BringToFront();
            }
        }

        private void managecoupons_Click(object sender, EventArgs e)
        {

            if (!panel3.Controls.Contains(managecoupon.Instance))
            {
                panel3.Controls.Add(managecoupon.Instance);
                managecoupon.Instance.Dock = DockStyle.Fill;
                managecoupon.Instance.BringToFront();
            }
            else
            {
                managecoupon.Instance.BringToFront();
            }
        }

        private void StoreManagerScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
