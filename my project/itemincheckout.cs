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
    public partial class itemincheckout : UserControl
    {
        private string title;
        private string author;
        private int quantity;
        private double price;
        private string isbn;

        public string Title
        {
            get { return title; }
            set { title = value; titleincheckout.Text = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; authorincheckout.Text = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; quantityincheckout.Text = value.ToString(); }
        }

        public double Price
        {
            get { return price; }
            set { price = value; priceincheckout.Text = value.ToString("C"); }
        }

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value;  isbnincheckout.Text = value; }
        }

        public itemincheckout()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titleincheckout_Click(object sender, EventArgs e)
        {

        }

        private void authorincheckout_Click(object sender, EventArgs e)
        {

        }

        private void quantityincheckout_Click(object sender, EventArgs e)
        {

        }

        private void priceincheckout_Click(object sender, EventArgs e)
        {

        }

        private void itemincheckout_Load(object sender, EventArgs e)
        {

        }
    }
}
