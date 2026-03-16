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
    public partial class ViewOrderForm : Form
    {
        List<eachorderbook> book = new List<eachorderbook>();   

        public ViewOrderForm()
        {
            InitializeComponent();

        }

        public List<eachorderbook> BookInOrder
        {
            get { return book; }
            set
            {
                book = value;
            }
        }

        public void DisplayOrderedBooks()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (eachorderbook bookControl in book)
            {
                flowLayoutPanel1.Controls.Add(bookControl);
            }
        }

        public string OrderID
        {
            get { return orderidlabel.Text; }
            set { orderidlabel.Text = value; }
        }

        public string OrderStatus
        {
            get { return orderstatuslabel.Text; }
            set { orderstatuslabel.Text = value; }
        }

        public string OrderTotal
        {
            get { return label4.Text; }
            set { label4.Text = value; }
        }

        public string OrderDate
        {
            get { return datelabel.Text; }
            set { datelabel.Text = value; }
        }

        public string UserName
        {
            get { return usernamelabel.Text; }
            set { usernamelabel.Text = value; }
        }

        public string CouponCode
        {
            get { return couponlabel.Text; }
            set { couponlabel.Text = value; }
        }

        public string DeliveryFee
        {
            get { return feelabel.Text; }
            set {  feelabel.Text = value; } 
        }
        //public string FirstName
        //{
        //    get { return fnamelabel.Text; }
        //    set { fnamelabel.Text = value; }
        //}

        //public string LastName
        //{
        //    get { return lnamelabel.Text; }
        //    set { lnamelabel.Text = value; }
        //}

        public string Address
        {
            get { return addresslabel.Text; }
            set { addresslabel.Text = value; }
        }

        //public string PhoneNumber
        //{
        //    get { return phnumberlabel.Text; }
        //    set { phnumberlabel.Text = value; }
        //}

        //public string Email
        //{
        //    get { return emailabel.Text; }
        //    set { emailabel.Text = value; }
        //}

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void orderidlabel_Click(object sender, EventArgs e)
        {

        }

        private void orderstatuslabel_Click(object sender, EventArgs e)
        {

        }

        private void datelabel_Click(object sender, EventArgs e)
        {

        }

        private void usernamelabel_Click(object sender, EventArgs e)
        {

        }

        private void fnamelabel_Click(object sender, EventArgs e)
        {

        }

        private void lnamelabel_Click(object sender, EventArgs e)
        {

        }

        private void addresslabel_Click(object sender, EventArgs e)
        {

        }

        private void phnumberlabel_Click(object sender, EventArgs e)
        {

        }

        private void emailabel_Click(object sender, EventArgs e)
        {

        }

        private void feelabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
