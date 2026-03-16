using my_project.my_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_project
{
    public partial class manageinventory : UserControl
    {
        private static manageinventory instance;

        private List<Book> books = new List<Book>();


        private string selectedTitle;
        private string selectedAuthor;
        private string selectedISBN;
        private string selectedPublisher;
        private string selectedYear;
        private int selectedQuantity;
        private double selectedPrice;
        public static manageinventory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new manageinventory();
                }
                return instance;
            }
        }

        
        public manageinventory()
        {
            InitializeComponent();
            books = DataBase.Instance.GetInventory();
            ViewBooks();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void manageinventory_Load(object sender, EventArgs e)
        {

        }

        public void DeleteBook(string isbn)
        {
            Book bookToDelete = books.Find(book => book.ISBN == isbn);
            if (bookToDelete != null)
            {
                DataBase.Instance.DeleteBookInInventory(isbn);
                books.Remove(bookToDelete);
                ViewBooks(); 
            }
        }

        public void ViewBooks()
        {
            dataGridView1.DataSource = null; 
            dataGridView1.Refresh(); 

            dataGridView1.DataSource = books; 
        }


        private void addBookBtn_Click(object sender, EventArgs e)
        {
            AddBookForm newaddform = new AddBookForm();
            newaddform.ShowDialog();

            Book newbook = new Book(newaddform.BookTitle, newaddform.BookAuthor, newaddform.BookISBN, newaddform.BookPublisher, newaddform.BookPublishYear, newaddform.BookQuantity, newaddform.BookPrice);
            DataBase.Instance.AddBookInInventory(newbook);
            books.Add(newbook);

            ViewBooks();

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                UpdateBookForm newupform = new UpdateBookForm();

                newupform.BookTitle = selectedRow.Cells["Title"].Value.ToString();
                newupform.BookAuthor = selectedRow.Cells["Author"].Value.ToString();
                newupform.BookISBN = selectedRow.Cells["ISBN"].Value.ToString();
                newupform.BookPublisher = selectedRow.Cells["Publisher"].Value.ToString();
                newupform.BookPublishYear = selectedRow.Cells["Year"].Value.ToString();
                newupform.BookQuantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                newupform.BookPrice = Convert.ToDouble(selectedRow.Cells["Price"].Value);

                newupform.ShowDialog();

                Book bookToUpdate = books.FirstOrDefault(book => book.ISBN == newupform.BookISBN);

                DataBase.Instance.UpdateBookInInventory(newupform.BookTitle, newupform.BookAuthor, newupform.BookISBN, newupform.BookPublisher, newupform.BookPublishYear, newupform.BookQuantity, newupform.BookPrice);

                bookToUpdate.Title = newupform.BookTitle;
                bookToUpdate.Author = newupform.BookAuthor;
                bookToUpdate.Publisher = newupform.BookPublisher;
                bookToUpdate.Year = newupform.BookPublishYear;
                bookToUpdate.Price = newupform.BookPrice;
                bookToUpdate.Quantity = newupform.BookQuantity;

                ViewBooks();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string title = selectedRow.Cells["Title"].Value.ToString();
                string author = selectedRow.Cells["Author"].Value.ToString();
                string isbn = selectedRow.Cells["ISBN"].Value.ToString();
                string publisher = selectedRow.Cells["Publisher"].Value.ToString();
                string year = selectedRow.Cells["Year"].Value.ToString();
                int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                double price = Convert.ToDouble(selectedRow.Cells["Price"].Value);

                DialogResult result = MessageBox.Show($"Are you sure you want to delete the following book?\n\n" +
                                                      $"Title: {title}\n" +
                                                      $"Author: {author}\n" +
                                                      $"ISBN: {isbn}\n" +
                                                      $"Publisher: {publisher}\n" +
                                                      $"Year: {year}\n" +
                                                      $"Quantity: {quantity}\n" +
                                                      $"Price: {price}\n",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Book bookToDelete = books.Find(book => book.ISBN == isbn);
                    if (bookToDelete != null)
                    {
                        DataBase.Instance.DeleteBookInInventory(isbn);
                        books.Remove(bookToDelete);
                        ViewBooks();
                    }

                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string title = selectedRow.Cells["Title"].Value.ToString();
                string author = selectedRow.Cells["Author"].Value.ToString();
                string isbn = selectedRow.Cells["ISBN"].Value.ToString();
                string publisher = selectedRow.Cells["Publisher"].Value.ToString();
                string year = selectedRow.Cells["Year"].Value.ToString();
                int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                double price = Convert.ToDouble(selectedRow.Cells["Price"].Value);

                ViewBookForm newbookform = new ViewBookForm(isbn, title, author, publisher, year, quantity, price);
                newbookform.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please select a book to view.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
