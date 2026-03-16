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
    public partial class eachiteminorderhistory : UserControl
    {
        public eachiteminorderhistory()
        {
            InitializeComponent();
        }

      
        public string ItemTitle
        {
            get { return titleincheckout.Text; }
            set { titleincheckout.Text = value; }
        }

        public string ItemQuantity
        {
            get { return quantityincheckout.Text;}
            set { quantityincheckout.Text = value;} 
        }

        public string ItemPrice
        {
            get { return priceincheckout.Text;}
            set { priceincheckout.Text = value;}
        }

        public string ItemStatus
        {
            get { return orderstatus.Text; }
            set { orderstatus.Text = value;}    
        }

        private string isbn;
        public string ItemISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        private string orderid;
        public string OrderID
        {
            get { return orderid; }
            set { orderid = value; }
        }
        public void setReturnButton()
        {
            if (ItemStatus == "Returned" || ItemStatus == "Pending")
            {
                returnbutton.Enabled = false;
                returnbutton.BackColor = Color.Gray;

            }
            else
            {
                returnbutton.Enabled=true;
                returnbutton.BackColor = Color.FromArgb(20, 83, 105);
            }
        }

        private void titleincheckout_Click(object sender, EventArgs e)
        {

        }

        private void quantityincheckout_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        $"Are you sure you want to return the following item?\n\n" +
        $"Title: {ItemTitle}\n" +
        $"Quantity: {ItemQuantity}\n" +
        $"Price: {ItemPrice}\n" +
        $"Status: {ItemStatus}\n\n" +
        "Click 'Yes' to confirm return.",
        "Confirm Return",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                ItemStatus = "Returned";

                setReturnButton();
                DataBase.Instance.ReturnOrderItem(ItemISBN, Convert.ToInt32(orderid));

                MessageBox.Show("Your Request has been Processed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void eachiteminorderhistory_Load(object sender, EventArgs e)
        {

        }
    }
}
