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

namespace my_project
{
    public partial class OrderConfirmationScreen : Form
    {
        private List<itemincheckout> itemsInCheckout = new List<itemincheckout>();

        private string orderid;
        public void setList(List<itemincheckout> checkoutlist)
        {
            foreach (var item in checkoutlist)
            {
                flowLayoutPanel1.Controls.Add(item);
            }
        }
        public OrderConfirmationScreen()
        {
            InitializeComponent();
        }

       
        public string OrderID
        {
            get { return orderidlabelinconfirmation.Text; }
            set {  orderidlabelinconfirmation.Text = value;}
        }

        public string OrderDateTime
        {
            get { return OrderDateTimeLabelinconfirmation.Text; }
            set { OrderDateTimeLabelinconfirmation.Text = value; }
        }

        public string OrderStatus
        {
            get { return statsulabel.Text; }
            set { statsulabel.Text = value;}
        }

        public string OrderSubTotal
        {
            get { return subtotalitemsinconfirm.Text; }
            set { subtotalitemsinconfirm.Text = value; }
        }

        public string OrderDeliveryFee
        {
            get { return deliveryfeeinconfirm.Text; }
            set {  deliveryfeeinconfirm.Text = value;}
        }

        public string CouponDiscount
        {
            get { return couponinconfirm.Text; }
            set { couponinconfirm.Text = value; }
        }

        public string CustomerPhoneNumber
        {
            get { return phonenumberlabelinconfir.Text; }
            set { phonenumberlabelinconfir.Text = value; }  
        }
        
        public string CustomerAddress
        {
            get { return addresslabelinconfirmation.Text; }
            set {  addresslabelinconfirmation.Text = value; }
        }

        public string OrderTotalPrice
        {
            get { return totalprice.Text; }
            set { totalprice.Text = value; }
        }

        public string OrderCoupon
        {
            get { return couponinconfirm.Text; }
            set { couponinconfirm.Text = value; }    
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void continueshopping_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerScreen.Instance.Show();
        }
    }
}
