using my_project.my_project;
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
    public partial class AddBookForm : Form
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
            get { return  authorlabel.Text; }   
            set { authorlabel.Text = value; }
        }

        public string BookPublisher
        {
            get { return publisherlabel.Text; }
            set { publisherlabel.Text = value;}
        }

        public string BookPublishYear
        {
            get { return publishyearlabel.Text; }
            set { publishyearlabel.Text = value;}
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


        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private void isbn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void author_TextChanged(object sender, EventArgs e)
        {

        }

        private void publisher_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            string text = isbnlabel.Text;
            StringBuilder digitString = new StringBuilder();

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    digitString.Append(c);
                }
            }

            string cleanedISBN = digitString.ToString();
            if (cleanedISBN.Length != 13)
            {
                MessageBox.Show("ISBN must be exactly 13 digits long.", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            this.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void isbnlabel_TextChanged(object sender, EventArgs e)
        {
            string text = isbnlabel.Text;
            StringBuilder digitString = new StringBuilder();

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    digitString.Append(c);
                }
            }

            isbnlabel.Text = digitString.ToString();
            isbnlabel.SelectionStart = isbnlabel.TextLength;
        }

        private void isbnlabel_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void publishyearlabel_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void quantitylabel_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void pricelabel_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void publishyearlabel_TextChanged(object sender, EventArgs e)
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

            publishyearlabel.Text = digitString.ToString();
            publishyearlabel.SelectionStart = publishyearlabel.TextLength;
        }

        private void quantitylabel_TextChanged(object sender, EventArgs e)
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

            quantitylabel.Text = digitString.ToString();
            quantitylabel.SelectionStart = quantitylabel.TextLength;
        }

        private void pricelabel_TextChanged(object sender, EventArgs e)
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

            pricelabel.Text = digitString.ToString();
            pricelabel.SelectionStart = pricelabel.TextLength;
        }

    }
}
