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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace my_project
{
    public partial class ViewBookOrderForm : Form
    {
        List<Book> books = new List<Book> ();   
        List<eachbookorder> eachbookorders = new List<eachbookorder> ();    
        public ViewBookOrderForm()
        {
            InitializeComponent();

            books = DataBase.Instance.GetInventory();
            comboBox1.DataSource = books;
            comboBox1.DisplayMember = "ISBNAndTitle";
            comboBox1.ValueMember = "ISBN";
        }
    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void author_Click(object sender, EventArgs e)
        {

        }

        private void quantity_Click(object sender, EventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void year_Click(object sender, EventArgs e)
        {

        }

        private void publisher_Click(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedISBN = comboBox1.SelectedValue.ToString();
            Book selectedBook = books.Find(book => book.ISBN == selectedISBN);

            if (selectedBook != null)
            {
                Author = selectedBook.Author;
                Quantity = selectedBook.Quantity.ToString();
                Price = selectedBook.Price.ToString("C");
                Year = selectedBook.Year.ToString();
                Publisher = selectedBook.Publisher;
                Title = selectedBook.Title;
            }

            PopulateBookOrders(selectedISBN);
        }
        private void PopulateBookOrders(string isbn)
        {
            eachbookorders.Clear();
            eachbookorders = DataBase.Instance.GetOrdersForBook(isbn);

            flowLayoutPanel1.Controls.Clear();
            foreach (var order in eachbookorders)
            {
                flowLayoutPanel1.Controls.Add(order);
            }
        }
        public string Author
        {
            get { return author.Text; }
            set { author.Text = value; }
        }

        public string Quantity
        {
            get { return quantity.Text; }
            set { quantity.Text = value; }
        }

        public string Price
        {
            get { return price.Text; }
            set { price.Text = value; }
        }

        public string Year
        {
            get { return year.Text; }
            set { year.Text = value; }
        }

        public string Publisher
        {
            get { return publisher.Text; }
            set { publisher.Text = value; }
        }

        public string Title
        {
            get { return title.Text; }
            set { title.Text = value; }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
