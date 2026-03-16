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
    public partial class InventoryManagerScreen : Form
    {
        private Manager currentmanager = new Manager();

        private static InventoryManagerScreen instance;

        public static InventoryManagerScreen Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InventoryManagerScreen();
                }
                return instance;
            }
        }

        public InventoryManagerScreen()
        {
            InitializeComponent();
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

        public void setUsername()
        {
            usernamelabel.Text = currentmanager.Username;
        }
        private void manageinvenBtn_Click(object sender, EventArgs e)
        {

            if (!panel3.Controls.Contains(manageinventory.Instance))
            {
                panel3.Controls.Add(manageinventory.Instance);
                manageinventory.Instance.Dock = DockStyle.Fill;
                manageinventory.Instance.BringToFront();
            }
            else
            {
                manageinventory.Instance.BringToFront();
            }
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            ManagerProfile.Instance.setInventoryManager();

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InventoryManagerScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
