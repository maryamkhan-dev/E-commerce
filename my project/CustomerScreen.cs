using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace my_project
{
    public partial class CustomerScreen : Form
    {
        private Customer currentcustomer = new Customer();


        private static CustomerScreen instance;

        public static CustomerScreen Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerScreen();
                }
                return instance;
            }
        }
        public CustomerScreen()
        {
            InitializeComponent();
            Shop1.Instance.makeshop();
        }
        public Customer CurrentCustomer
        {
            get
            {
                return currentcustomer;
            }
            set
            {
                currentcustomer = value;
            }
        }

        public void makecart()
        {
            managecart.Instance.makecart();
        }
        public void setUsername()
        {
            usernamelabel.Text = currentcustomer.Username;
            
        }
    
        private void CustomerScreen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void shopBtn_Click(object sender, EventArgs e)
        {
            if(!panel3.Controls.Contains(Shop1.Instance))
            {
                panel3.Controls.Add(Shop1.Instance);
                Shop1.Instance.Dock = DockStyle.Fill;
                Shop1.Instance.BringToFront();
            }
            else
            {
                Shop1.Instance.BringToFront();
            }
        }

        private void cardBtn_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(managecart.Instance))
            {
                panel3.Controls.Add(managecart.Instance);
                managecart.Instance.Dock = DockStyle.Fill;
                managecart.Instance.BringToFront();
            }
            else
            {
                managecart.Instance.BringToFront(); 
            }

        }

        private void checkoutBtn_Click(object sender, EventArgs e) //manageordersbtn
        {
            if (!panel3.Controls.Contains(customermanageorders.Instance))
            {
                panel3.Controls.Add(customermanageorders.Instance);
                customermanageorders.Instance.Dock = DockStyle.Fill;
                customermanageorders.Instance.BringToFront();
            }
            else
            {
                customermanageorders.Instance.BringToFront();
            }

        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(CustomerProfile.Instance))
            {
                panel3.Controls.Add(CustomerProfile.Instance);
                CustomerProfile.Instance.Dock = DockStyle.Fill;
                CustomerProfile.Instance.BringToFront();
            }
            else
            {
                CustomerProfile.Instance.BringToFront();
            }
        }

        private void shop1_Load(object sender, EventArgs e)
        {

        }

        private void cart1_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void shop11_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
