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
    public partial class eachitemincart : UserControl
    {
        private int quantity;
        private double itemPrice;
        private double totalPrice;
        public bool isItemSelected { get; set; }
        public eachitemincart()
        {
            InitializeComponent();
            Quantity = 1;
        }

        public int Quantity
        {
            get => quantity;
            set
            {
                quantity = value;
                quantityincart.Text = quantity.ToString();
                UpdateTotalPrice(); 
                managecart.Instance.UpdateOrderSummary(); 
            }
        }

        public double ItemPrice
        {
            get => itemPrice;
            set
            {
                itemPrice = value;
                UpdateTotalPrice(); 
            }
        }

        public double TotalPrice
        {
            get => totalPrice;
            set
            {
                totalPrice = value;
                pricelabelincart.Text = totalPrice.ToString("0.00"); 
            }
        }

        private void eachitemincart_Load(object sender, EventArgs e)
        {

        }

        public string ItemTitle
        {
            get => titlelabelincart.Text;
            set => titlelabelincart.Text = value;
        }

        public string ItemAuthor
        {
            get => authorlabelincart.Text;
            set => authorlabelincart.Text = value;
        }

        public string ItemISBN
        {
            get => isbnlabelincart.Text;
            set => isbnlabelincart.Text = value;
        }

        private void quantityincart_Click(object sender, EventArgs e)
        {

        }

        private void removeoneBtn_Click(object sender, EventArgs e)
        {
            if (Quantity > 1) 
                Quantity--;

           DataBase.Instance.UpdateQuantityOfItem(this.ItemISBN, Quantity);

        }

        private void addoneBtn_Click(object sender, EventArgs e)
        {
            Quantity++;
            DataBase.Instance.UpdateQuantityOfItem(this.ItemISBN, Quantity);

        }

        private void UpdateTotalPrice()
        {
            TotalPrice = ItemPrice * Quantity;
        }

        private void isitemselected_CheckedChanged(object sender, EventArgs e)
        {
            isItemSelected = isitemselected.Checked;

            managecart.Instance.UpdateOrderSummary();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
