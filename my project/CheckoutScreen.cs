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
    public partial class CheckoutScreen : Form
    {
        private static CheckoutScreen instance;
        private static Coupon coupon= new Coupon();

        private List<itemincheckout> itemsInCheckout = new List<itemincheckout>();

        public static CheckoutScreen Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CheckoutScreen();
                }
                return instance;
            }
        }
        public CheckoutScreen()
        {
            InitializeComponent();
            coupon = null;
        }



        public void AddItemToCheckout(string title, string author, int quantity, double price, string isbn)
        {
            itemincheckout newItem = new itemincheckout();
            newItem.Title = title;
            newItem.Author = author;
            newItem.Quantity = quantity;
            newItem.Price = price*quantity;
            newItem.ISBN = isbn;    
            itemsInCheckout.Add(newItem);
            flowLayoutPanel2.Controls.Add(newItem);
        }

        public void SetCheckoutValues(double subtotal, string deliveryfee, double total, string customerName, string customerAddress, string customerPhoneNumber, string customerEmail, Coupon currentcoupon)
        {
            nameofcustomer.Text = customerName;
            addresslabel.Text = customerAddress;
            phnumber.Text = customerPhoneNumber;
            emaillabel.Text = customerEmail;
            deliveryfeeincheckout.Text = deliveryfee;
            subtotalitemsincheckout.Text = subtotal.ToString();
            
            if(currentcoupon != null) 
            {
                coupon = currentcoupon;
                coupondiscountlabel.Text = currentcoupon.Discount.ToString();
                label11.Text = (total - currentcoupon.Discount).ToString();

            }
            else
            {
                coupondiscountlabel.Text = "0";
                label11.Text = total.ToString();

            }

        }
        private void CheckoutScreen_Load(object sender, EventArgs e)
        {

        }

        private void nameofcustomer_Click(object sender, EventArgs e)
        {

        }

        private void addresslabel_Click(object sender, EventArgs e)
        {

        }

        private void phnumber_Click(object sender, EventArgs e)
        {

        }

        private void emaillabel_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkout_Click(object sender, EventArgs e)
        {
            OrderConfirmationScreen orderConfirmationScreen = new OrderConfirmationScreen();
           
            orderConfirmationScreen = DataBase.Instance.MakeNewOrderForCustomer(this.itemsInCheckout, coupon);

            
            foreach (var item in itemsInCheckout)
            {
                
                var cartItemToRemove = managecart.Instance.getCart().FirstOrDefault(c => c.ItemTitle == item.Title && c.ItemAuthor == item.Author && c.ItemISBN == item.ISBN);
                if (cartItemToRemove != null)
                {
                    managecart.Instance.getCart().Remove(cartItemToRemove);
                    managecart.Instance.removeItemFromCart(cartItemToRemove);
                    DataBase.Instance.RemoveItemFromCustomerCart(cartItemToRemove); 

                }
            }

            managecart.Instance.UpdateOrderSummary();
            this.itemsInCheckout.Clear();
            flowLayoutPanel2.Controls.Clear();

            this.Hide();
            orderConfirmationScreen.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
