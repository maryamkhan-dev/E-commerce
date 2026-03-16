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
    public partial class UpdateBookForm : Form
    {
        public string BookISBN
        {
            get { return isbnlabel.Text; }
            set { isbnlabel.Text = value; }
        }

        public string BookTitle
        {
            get { return titlelable.Text; }
            set { titlelable.Text = value; }
        }

        public string BookAuthor
        {
            get { return authorlabel.Text; }
            set { authorlabel.Text = value; }
        }

        public string BookPublisher
        {
            get { return publisherlabel.Text; }
            set { publisherlabel.Text = value; }
        }

        public string BookPublishYear
        {
            get { return publishyearlabel.Text; }
            set { publishyearlabel.Text = value; }
        }

        public double BookPrice
        {
            get { return double.Parse(pricelabel.Text); }
            set { pricelabel.Text = value.ToString(); }
        }

        public int BookQuantity
        {
            get { return int.Parse(quantitylabel.Text); }
            set { quantitylabel.Text = value.ToString(); }
        }
        public UpdateBookForm()
        {
            InitializeComponent();
        }

        private void isbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateBookBtn_Click(object sender, EventArgs e)
        {
        }

        private void UpdateBookForm_Load(object sender, EventArgs e)
        {

        }



        private void updateBookBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void titlelable_TextChanged(object sender, EventArgs e)
        {

        }

        private void authorlabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void publisherlabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void publishyearlabel_TextChanged_1(object sender, EventArgs e)
        {

            string text = publishyearlabel.Text;
            StringBuilder digitString = new StringBuilder();

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    digitString.Append(c);
                }
            }

            // Set the TextBox text after filtering is complete
            publishyearlabel.Text = digitString.ToString();
            publishyearlabel.SelectionStart = publishyearlabel.TextLength;
        }

        private void quantitylabel_TextChanged_1(object sender, EventArgs e)
        {

            string text = quantitylabel.Text;
            StringBuilder digitString = new StringBuilder();

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    digitString.Append(c);
                }
            }

            // Set the TextBox text after filtering is complete
            quantitylabel.Text = digitString.ToString();
            quantitylabel.SelectionStart = quantitylabel.TextLength;
        }

        private void pricelabel_TextChanged_1(object sender, EventArgs e)
        {
            string text = pricelabel.Text;
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

            // Set the TextBox text after filtering is complete
            pricelabel.Text = digitString.ToString();
            pricelabel.SelectionStart = pricelabel.TextLength;


        }

        private void isbnlabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
