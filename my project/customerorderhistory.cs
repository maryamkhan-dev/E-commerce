using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace my_project
{
    public partial class customerorderhistory : UserControl
    {
        private List<eachiteminorderhistory> orderitems = new List<eachiteminorderhistory>();

        public customerorderhistory()
        {
            InitializeComponent(); 

        }

       

        public void AddItem()
        {
            int y = 5; 
            foreach (var item in OrderItems)
            {
                Panel newpanel = new Panel();
                newpanel.Width = 1190;
                newpanel.Height = 55;
                newpanel.Location = new Point(10, y);
                newpanel.Visible = true;
                newpanel.Controls.Add(item); 
                panel2.Controls.Add(newpanel);
                panel2.Height += 50; 
                y += 55;
                item.setReturnButton();
            }
        }

        public List<eachiteminorderhistory> OrderItems
        {
            get { return orderitems; }
            set { orderitems = value; }
        }
        public string OrderCouponAmount
        {
            get { return couponlabel.Text; }
            set { couponlabel.Text = value; }
        }

     


        public string OrderID
        {
            get { return orderidlabelinhistory.Text; }
            set { orderidlabelinhistory.Text = value; }
        }

        public string OrderDate
        {
            get { return orderdateinhistory.Text; }
            set { orderdateinhistory.Text = value; }
        }

        public string OrderStatus
        {
            get { return status.Text; }
            set {  status.Text = value; }
        }

        public string DeliveryFee
        {
            get { return deliveryfee.Text; }
            set { deliveryfee.Text = value;}
        }

        public string TotalPrice
        {
            get { return totalpricelabel.Text; }
            set {  totalpricelabel.Text = value;}
        }
        


        private void customerorderhistory_Load(object sender, EventArgs e)
        {

        }

        private void orderidlabelinhistory_Click(object sender, EventArgs e)
        {
            //getter setter
        }

        private void orderdateinhistory_Click(object sender, EventArgs e)
        {
            //gettersetter
        }

        private void orderstatus_Click(object sender, EventArgs e)
        {

        }

        private void priceincheckout_Click(object sender, EventArgs e)
        {

        }

        private void quantityincheckout_Click(object sender, EventArgs e)
        {

        }

        private void titleincheckout_Click(object sender, EventArgs e)
        {

        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deliveryfee_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void subtotoallabel_Click(object sender, EventArgs e)
        {

        }
    }
}
