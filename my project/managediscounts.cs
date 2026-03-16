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
    public partial class managediscounts : UserControl
    {
        List<Discount> discounts = new List<Discount>();

        private static managediscounts instance;

        public static managediscounts Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new managediscounts();
                }
                return instance;
            }
        }
        public managediscounts()
        {
            InitializeComponent();
            discounts = DataBase.Instance.GetDiscounts();
            ViewDiscounts();
        }

        public List<Discount> DiscountList
        {
            get { return discounts; } set { discounts = value; }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddDiscountForm newadddiscount = new AddDiscountForm();
            newadddiscount.ShowDialog();
            Discount newdiscount = new Discount(newadddiscount.BookISBN, newadddiscount.Percentage, newadddiscount.Type);
            DataBase.Instance.AddNewDiscount(newdiscount);
            discounts.Add(newdiscount);
            ViewDiscounts();
        }

        public void ViewDiscounts()
        {
            dataGridView2.DataSource = null;
            dataGridView2.Refresh();

            dataGridView2.DataSource = discounts;

        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                UpdateDiscountForm newupform = new UpdateDiscountForm();

                newupform.BookISBN = selectedRow.Cells["BookISBN"].Value.ToString();
                newupform.Percentage = Convert.ToDouble(selectedRow.Cells["Percentage"].Value);
                newupform.Type = selectedRow.Cells["Type"].Value.ToString();
                newupform.ShowDialog();

                Discount bookToDiscount = discounts.Find(discount => discount.BookISBN == newupform.BookISBN);

                DataBase.Instance.UpdateDiscount(newupform.BookISBN, newupform.Percentage, newupform.Type);

                bookToDiscount.BookISBN = newupform.BookISBN;
                bookToDiscount.Percentage = newupform.Percentage;
                bookToDiscount.Type = newupform.Type;

                ViewDiscounts();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                string bookISBN = selectedRow.Cells["BookISBN"].Value.ToString();
                double percentage = Convert.ToDouble(selectedRow.Cells["Percentage"].Value);
                string type = selectedRow.Cells["Type"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete the following discount?\n\n" +
                                                      $"Book ISBN: {bookISBN}\n" +
                                                      $"Percentage: {percentage}%\n" +
                                                      $"Type: {type}\n",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remove the discount from the list
                    Discount discountToDelete = discounts.Find(discount => discount.BookISBN == bookISBN);
                    if (discountToDelete != null)
                    {
                        DataBase.Instance.DeleteDiscount(bookISBN);
                        discounts.Remove(discountToDelete);
                        ViewDiscounts();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBox.Text.ToLower(); // Convert search text to lowercase for case-insensitive search

            // Filter discounts list based on search text
            List<Discount> filteredDiscounts = discounts.Where(discount =>
                discount.BookISBN.ToLower().Contains(searchText) ||
                discount.Type.ToLower().Contains(searchText)
            ).ToList();

            // Update DataGridView to display the filtered discounts
            dataGridView2.DataSource = null;
            dataGridView2.Refresh();
            dataGridView2.DataSource = filteredDiscounts;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
