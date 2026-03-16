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
    public partial class managecart : UserControl
    {
        private static managecart instance;

        Coupon currentcoupon = null;
        private List<eachitemincart> cartItems = new List<eachitemincart>();

        private double subtotal;
        private double total;
        private double discountAmount = 0;

        public List<eachitemincart> getCart()
        {
            return cartItems;
        }


        public static managecart Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new managecart();
                }
                return instance;
            }
        }
        public managecart()
        {
            InitializeComponent();
            removebtn.Enabled = false;  
            checkoutBtn.Enabled = false;    
            removebtn.BackColor = Color.Gray;
            checkoutBtn.BackColor = Color.Gray;
            if(cartItems.Count > 0)
            { clearcart.Enabled = true;clearcart.BackColor = Color.FromArgb(20, 83, 105);
               
            }
            else
            {clearcart.Enabled = false; clearcart.BackColor = Color.Gray;

            }
        }

        private void managecart_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void addtocartBtn_Click(object sender, EventArgs e) //clearcartbtn
        {
            
            cartItems.Clear();
            flowLayoutPanel1.Controls.Clear();
            DataBase.Instance.ClearCart();
            UpdateOrderSummary();
        }


        public void makecart()
        {
            cartItems = DataBase.Instance.getCustomerItemsinCart(CustomerScreen.Instance.CurrentCustomer.Username);

            foreach (eachitemincart item in cartItems)
            {
                flowLayoutPanel1.Controls.Add(item);
            }
        }
        public void AddItemInCart(string title, string isbn, string author, double price)
        {
            eachitemincart existingItem = cartItems.Find(item => item.ItemISBN == isbn);

            if (existingItem != null)
            {
                existingItem.Quantity++;
                DataBase.Instance.UpdateQuantityOfItem(existingItem.ItemISBN, existingItem.Quantity);
            }
            else
            {
                eachitemincart newCartItem = new eachitemincart();
                newCartItem.ItemTitle = title;
                newCartItem.ItemAuthor = author;
                newCartItem.ItemPrice = price;
                newCartItem.ItemISBN = isbn;
                cartItems.Add(newCartItem);
                DataBase.Instance.AddItemInCustomerCart(newCartItem.ItemISBN);

                flowLayoutPanel1.Controls.Add(newCartItem);
            }
            

            UpdateOrderSummary();
        }
       

        public void UpdateOrderSummary()
        {
            if (cartItems.Count == 0)
            {
                clearcart.Enabled = false;
                clearcart.BackColor = Color.Gray;
            }
            else
            {
                clearcart.Enabled= true;
                clearcart.BackColor = Color.FromArgb(20, 83, 105);
            }

            var selectedItems = cartItems.Where(item => item.isItemSelected).ToList();
            subtotal = selectedItems.Sum(item => item.ItemPrice * item.Quantity);
            subtotalitems.Text = subtotal.ToString("0.00");
            deliveryfee.Text = "50.00";
            total = subtotal + 50; 
            totalpricelabeltext.Text = total.ToString("0.00");

            if (selectedItems.Count == 0)
            {
                subtotalitems.Text = "";
                deliveryfee.Text = "";
                totalpricelabeltext.Text = "";
                removebtn.Enabled = false;
                removebtn.BackColor = Color.Gray;
                checkoutBtn.Enabled = false;    
                checkoutBtn.BackColor = Color.Gray; 
            }
            else
            {
                removebtn.Enabled = true;
                removebtn.BackColor = Color.FromArgb(20, 83, 105);
                checkoutBtn.Enabled= true;
                checkoutBtn.BackColor = Color.FromArgb(20, 83, 105);
            }

        }
        private void subtotalitems_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deliveryfee_Click(object sender, EventArgs e)
        {

        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            var selectedItems = cartItems.Where(item => item.isItemSelected).ToList();

            foreach (var item in selectedItems)
            {
                cartItems.Remove(item);
                DataBase.Instance.RemoveItemFromCustomerCart(item);
                flowLayoutPanel1.Controls.Remove(item);
            }

            UpdateOrderSummary();
        }

        public void removeItemFromCart(eachitemincart item)
        {
            flowLayoutPanel1.Controls.Remove(item);

        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
         //   bool iscouponapplied = false;
            CheckoutScreen checkoutform = new CheckoutScreen();

            var selectedItems = cartItems.Where(item => item.isItemSelected).ToList();

            foreach (var item in selectedItems)
            {
                checkoutform.AddItemToCheckout(item.ItemTitle, item.ItemAuthor, item.Quantity, item.ItemPrice, item.ItemISBN);
            }

            subtotal = selectedItems.Sum(item => item.ItemPrice * item.Quantity);
            subtotalitems.Text = subtotal.ToString("0.00");
            deliveryfee.Text = "50.00";
            total = subtotal + 50;

           
            totalpricelabeltext.Text = total.ToString();

            string customerName = CustomerScreen.Instance.CurrentCustomer.FirstName + " " + CustomerScreen.Instance.CurrentCustomer.LastName;
            string customerAddress = CustomerScreen.Instance.CurrentCustomer.Address + ", " + CustomerScreen.Instance.CurrentCustomer.City + ", " + CustomerScreen.Instance.CurrentCustomer.State + ", ";
            string customerPhoneNumber = CustomerScreen.Instance.CurrentCustomer.PhoneNumber;
            string customerEmail = CustomerScreen.Instance.CurrentCustomer.Email;

            checkoutform.SetCheckoutValues(subtotal, deliveryfee.Text, Convert.ToDouble(totalpricelabeltext.Text), customerName, customerAddress, customerPhoneNumber, customerEmail, currentcoupon);
            CustomerScreen.Instance.Hide();
            checkoutform.Show();
        }

        public List<eachitemincart> GetSelectedItems()
        {
            return cartItems.FindAll(item => item.isItemSelected);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string couponCode = coupontextbox.Text.Trim();

            currentcoupon = new Coupon();

            if (!string.IsNullOrEmpty(couponCode))
            {
                currentcoupon = DataBase.Instance.validateCoupon(couponCode);
                if (currentcoupon != null)
                {
                    if (currentcoupon.Discount > 0)
                    {
                        discountAmount = currentcoupon.Discount;
                        total -= discountAmount;
                        coupondiscount.Visible = true;
                        coupondiscount.Text = currentcoupon.Discount.ToString();
                        couponapplied.Visible = true;
                        button1.BackColor = Color.Gray;
                        button1.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid coupon code. No discount applied.", "Invalid Coupon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            totalpricelabeltext.Text = total.ToString();
            
        }

        private void coupontextbox_TextChanged(object sender, EventArgs e)
        {
            var selectedItems = cartItems.Where(item => item.isItemSelected).ToList();

            if (string.IsNullOrEmpty(coupontextbox.Text))
            {
                couponapplied.Visible = false;
                coupondiscount.Visible= false;
                total = subtotal + 50;
                totalpricelabeltext.Text= total.ToString(); 
                button1.Enabled = true;
                button1.BackColor = Color.FromArgb(20, 83, 105);
                currentcoupon = null;
            }
        }
    }
}
