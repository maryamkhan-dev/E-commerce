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
    public partial class customermanageorders : UserControl
    {
        List<customerorderhistory> orderlist = new List<customerorderhistory>();    
    //   List<customerorderhistory> dummyOrders = new List<customerorderhistory>
    //{
    //    new customerorderhistory { OrderID = "1", OrderDate = DateTime.Now.ToString(), OrderStatus = "Pending" },
    //    new customerorderhistory { OrderID = "2", OrderDate = DateTime.Now.ToString(), OrderStatus = "Delivered" },
    //    new customerorderhistory { OrderID = "3", OrderDate = DateTime.Now.ToString(), OrderStatus = "Cancelled" }
    //};



        public customermanageorders()
        {
            InitializeComponent();
            PopulateAllOrderHistory();
        }

        public void PopulateAllOrderHistory()
        {
            flowLayoutPanel1.Controls.Clear();

            orderlist.Clear();
            orderlist = DataBase.Instance.GetCustomerOrderHistory();

            foreach (var order in orderlist)
            {
                order.OrderItems = DataBase.Instance.GetOrderItemsOfOrder(order.OrderID);
                int numberoforderitems = order.OrderItems.Count;
                order.Height += 50 * numberoforderitems;
                order.AddItem(); 
                flowLayoutPanel1.Controls.Add(order);
            }
        }

        public void PopulateReturnOrderHistory()
        {
            flowLayoutPanel1.Controls.Clear();

            orderlist.Clear();

            orderlist = DataBase.Instance.GetCustomerReturnedOrderHistory();

            foreach (var order in orderlist)
            {
                order.OrderItems = DataBase.Instance.GetOrderItemsOfOrder(order.OrderID);
                int numberoforderitems = order.OrderItems.Count;
                order.Height += 50 * numberoforderitems;
                order.AddItem();
                flowLayoutPanel1.Controls.Add(order);
            }
        }

        private static customermanageorders instance;

        public static customermanageorders Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new customermanageorders();
                }
                return instance;
            }
        }

        private void filterordersbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(filterordersbox.Text == "Returned Orders")
            {
                Console.WriteLine("in return");
                PopulateReturnOrderHistory();
            }
            else
            {
                Console.WriteLine("not in return");

                PopulateAllOrderHistory();

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customermanageorders_Load(object sender, EventArgs e)
        {

        }
    }
}
