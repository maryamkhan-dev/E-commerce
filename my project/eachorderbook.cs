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
    public partial class eachorderbook : UserControl
    {
        public eachorderbook()
        {
            InitializeComponent();
        }

        public string ISBN
        {
            get { return isbnlabel.Text; }
            set { isbnlabel.Text = value; }
        }

        public string Author
        {
            get { return authorlabel.Text; }
            set { authorlabel.Text = value; }   
        }
        public string Title
        {
            get { return titlelabel.Text; }
            set { titlelabel.Text = value; }
        }

        public string Quantity
        {
            get { return quantitylabel.Text; }
            set { quantitylabel.Text = value; }
        }

        public string Price
        {
            get { return pricelabel.Text; }
            set { pricelabel.Text = value; }
        }

        public string Year
        {
            get { return yearlabel.Text; }
            set { yearlabel.Text = value; }
        }

        public string Publisher
        {
            get { return publisherlabel.Text; }
            set { publisherlabel.Text = value; }
        }
        private void authorlabel_Click(object sender, EventArgs e)
        {

        }

        private void isbnlabel_Click(object sender, EventArgs e)
        {

        }

        private void titlelabel_Click(object sender, EventArgs e)
        {

        }

        private void quantitylabel_Click(object sender, EventArgs e)
        {

        }

        private void pricelabel_Click(object sender, EventArgs e)
        {

        }

        private void yearlabel_Click(object sender, EventArgs e)
        {

        }

        private void publisherlabel_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
