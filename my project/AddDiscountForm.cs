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
    public partial class AddDiscountForm : Form
    {
        List<Book> books = new List<Book>();


        public string BookISBN
        {
            get
            {
                return ((Book)bookcombobox.SelectedItem).ISBN;
            }
        }

        public double Percentage
        {
            get { return Convert.ToDouble(percentagelabel.Text); }
        }

        public string Type 
        { 
            get { return typelabel.Text; }  
        }

        public AddDiscountForm()
        {
            InitializeComponent();
            books = DataBase.Instance.GetInventory();
            List<string> discountedISBNs = managediscounts.Instance.DiscountList.Select(discount => discount.BookISBN).ToList();
            List<Book> availableBooks = books.Where(book => !discountedISBNs.Contains(book.ISBN)).ToList();
            bookcombobox.DataSource = availableBooks;
            bookcombobox.DisplayMember = "ISBNAndTitle";
            bookcombobox.ValueMember = "ISBN";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(percentagelabel.Text) || string.IsNullOrEmpty(typelabel.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Close();
        }

        private void percentagelabel_TextChanged(object sender, EventArgs e)
        {
            string text = percentagelabel.Text;
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

            percentagelabel.Text = digitString.ToString();
            percentagelabel.SelectionStart = percentagelabel.TextLength;
        }

        private void typelabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AddDiscountForm_Load(object sender, EventArgs e)
        {

        }
    }
}
