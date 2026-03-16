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
    public partial class UpdateDiscountForm : Form
    {
        List<Book> books = new List<Book>();    
        public UpdateDiscountForm()
        {
            InitializeComponent();
            books = DataBase.Instance.GetInventory();
        }

        public string BookISBN
        {
            get { return bookcombobox.Text; }
            set { bookcombobox.Text = value;}
        }

        public double Percentage
        {
            get { return Convert.ToDouble(percentagelabel.Text); }
            set { percentagelabel.Text = value.ToString(); }
        }

        public string Type
        {
            get { return typelabel.Text; }
            set { typelabel.Text = value; } 
        }

        private void updateBtn_Click(object sender, EventArgs e)
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
    }
}
