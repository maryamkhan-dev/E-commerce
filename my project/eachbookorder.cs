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
    public partial class eachbookorder : UserControl
    {
        public eachbookorder()
        {
            InitializeComponent();
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void address_Click(object sender, EventArgs e)
        {

        }

        private void orderidlabel_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void quantity_Click(object sender, EventArgs e)
        {

        }

        public string Username
        {
            get { return username.Text; }
            set { username.Text = value; }
        }

        public string Address
        {
            get { return address.Text; }
            set { address.Text = value; }
        }

        public string OrderID
        {
            get { return orderidlabel.Text; }
            set { orderidlabel.Text = value; }
        }

        public string OrderDate
        {
            get { return date.Text; }
            set { date.Text = value; }
        }

        public string Total
        {
            get { return total.Text; }
            set { total.Text = value; }
        }

        public string Quantity
        {
            get { return quantity.Text; }
            set { quantity.Text = value; }
        }
    }
}
