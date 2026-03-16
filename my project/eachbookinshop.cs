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
    public partial class eachbookinshop : UserControl
    { 
        public eachbookinshop()
        {
            InitializeComponent();
            
        }
   
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void eachbookinshop_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        public void setPanelVisbility(bool value)
        {
            panel1.Visible = value; 
        }
        public string ItemTitle
        {
            get => titlelabel.Text;
            set => titlelabel.Text = value;
        }

        public string ItemAuthor
        {
            get => authortext.Text;
            set => authortext.Text = value;
        }

        public string ItemISBN
        {
            get => isbntext.Text;
            set => isbntext.Text = value;
        }

        public string ItemPublisher
        {
            get => publishertext.Text;
            set => publishertext.Text = value;
        }

        public string ItemYear
        {
            get => datetext.Text;
            set => datetext.Text = value;
        }


        public double ItemDiscountedPrice
        {
            get => double.Parse(discountedprice.Text);
            set => discountedprice.Text = value.ToString();
        }

        public double ItemPrice
        {
            get => double.Parse(pricetext.Text);
            set => pricetext.Text = value.ToString();
        }

        private void addtocartBtn_Click(object sender, EventArgs e)
        {
             managecart.Instance.AddItemInCart(this.ItemTitle, this.ItemISBN, this.ItemAuthor, this.ItemPrice);
            Shop1.Instance.ShowPrompt(this.ItemTitle);

        }

        private void isbntext_Click(object sender, EventArgs e)
        {

        }

        private void publishertext_Click(object sender, EventArgs e)
        {

        }

        private void discountedprice_Click(object sender, EventArgs e)
        {

        }

        private void discountpricelabel_Click(object sender, EventArgs e)
        {

        }

        private void titlelabel_Click(object sender, EventArgs e)
        {

        }

        private void datetext_Click(object sender, EventArgs e)
        {

        }
    }
}
