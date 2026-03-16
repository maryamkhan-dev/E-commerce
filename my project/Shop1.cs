using my_project.my_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_project
{
    public partial class Shop1 : UserControl
    {
        List<eachbookinshop> shopitems = new List<eachbookinshop>(); 
        
        private static Shop1 instance;

        public static Shop1 Instance
        {
            get
            {
                if( instance == null)
                {
                    instance = new Shop1();
                }
                return instance;
            }
        }
        public Shop1()
        {
            InitializeComponent();
            
        }

        public void makeshop()
        {
            shopitems = DataBase.Instance.GetShopItems();

            foreach (eachbookinshop item in shopitems) 
            {
                flowLayoutPanel1.Controls.Add(item);

            }
        }
        private void Shop1_Load(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var newitem = (eachbookinshop)item;
                newitem.Visible = newitem.titlelabel.Text.ToLower().ToLower().Contains(searchBox.Text.Trim().ToLower());
            }
        }
        public void ViewBooks()
        {
        //    dataGridView1.DataSource = null; // Clear the existing data source
         //   dataGridView1.Refresh(); // Refresh the DataGridView

          //  dataGridView1.DataSource = books; // Set the data source to the updated list of books
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addtocartBtn_Click(object sender, EventArgs e)
        {
            
        }

        public void ShowPrompt(string title)
        {
            titleinaddtocart.Text = title;  
            panel1.Visible = true;
            Timer timer = new Timer();
            timer.Interval = 1500;
            timer.Tick += (sender, e) =>
            {
                panel1.Visible = false;
                timer.Stop();
                timer.Dispose();
            };

            timer.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
