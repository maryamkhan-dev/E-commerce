using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_project.my_project
{
    public partial class ViewBookForm : Form
    {
        public ViewBookForm(string isbn, string title, string author, string publisher, string year, int quantity, double price )
        {
            InitializeComponent();
            isbnlabel.Text = isbn;  
            titlelabel.Text = title;
            authorlabel.Text = author;  
            publisherlabel.Text = publisher;
            publishDatelabel.Text = year;
            quantitylabel.Text = quantity.ToString();
            pricelabel.Text = price.ToString(); 


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewBookForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
