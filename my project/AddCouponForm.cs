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
    public partial class AddCouponForm : Form
    {
        public AddCouponForm()
        {
            InitializeComponent();
        }

        private void discountlabel_TextChanged(object sender, EventArgs e)
        {
            string text = discountlabel.Text;
            StringBuilder digitString = new StringBuilder();
            bool foundDecimalPoint = false;

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    digitString.Append(c);
                }
                else if (c == '.' && !foundDecimalPoint)
                {
                    digitString.Append(c);
                    foundDecimalPoint = true;
                }
            }

            discountlabel.Text = digitString.ToString();
            discountlabel.SelectionStart = discountlabel.TextLength;
        }

        public string CouponCode
        {
            get { return couponbox.Text; }
            set {  couponbox.Text = value; }    
        }

        public string DiscountAmount
        {
            get { return discountlabel.Text; }
            set {  discountlabel.Text = value; }
        }
        private void couponbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
