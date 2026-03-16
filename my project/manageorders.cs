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
    public partial class manageorders : UserControl
    {
        private static manageorders instance;

        private List<CustomerOrder> customerorder = new List<CustomerOrder>();


        public static manageorders Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new manageorders();
                }
                return instance;
            }
        }
        public manageorders()
        {
            InitializeComponent();
            customerorder = DataBase.Instance.GetOrders();
            ViewOrders();
        }

        public void ViewOrders()
        {
            dataGridView2.DataSource = null;
            dataGridView2.Refresh();

            dataGridView2.DataSource = customerorder;

        }

        private void manageorders_Load(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBox.Text.ToLower(); 

            List<CustomerOrder> filteredOrders = customerorder.Where(order =>
                order.OrderID.ToString().Contains(searchText) ||
                order.OrderDate.ToString("yyyy-MM-dd").Contains(searchText) || 
                order.OrderStatus.ToLower().Contains(searchText) ||
                order.OrderTotal.ToString().Contains(searchText) ||
                order.DeliveryFee.ToString().Contains(searchText) ||
                (order.CouponCode != null && order.CouponCode.ToLower().Contains(searchText)) 
            ).ToList();

            dataGridView2.DataSource = null;
            dataGridView2.Refresh();
            dataGridView2.DataSource = filteredOrders;
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                int orderId = Convert.ToInt32(selectedRow.Cells["OrderID"].Value);


                ViewOrderForm viewOrderForm = DataBase.Instance.GetOrderDetails(orderId);
                viewOrderForm.DisplayOrderedBooks();
                viewOrderForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row to view the order details.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void processBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                int orderId = Convert.ToInt32(selectedRow.Cells["OrderID"].Value);
                string orderStatus = selectedRow.Cells["OrderStatus"].Value.ToString();

                string message = $"Order ID: {orderId}\nOrder Status: {orderStatus}\n\nDo you want to update the order status to 'Delivered'?";
                DialogResult result = MessageBox.Show(message, "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {

                        CustomerOrder orderToUpdate = customerorder.Find(order => order.OrderID == orderId);
                        if (orderToUpdate != null)
                        {
                            orderToUpdate.OrderStatus = "Delivered";
                        }

                        DataBase.Instance.UpdateOrderStatus(orderId, "Delivered");

                        MessageBox.Show("Order status updated to 'Delivered'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ViewOrders();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating order status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update the order status.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filterordersbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterordersbox.Text == "Returned Orders")
            {
                customerorder = DataBase.Instance.GetReturnedOrders();
                ViewOrders();
            }
            else if (filterordersbox.Text == "Discounted Orders")
            {
                customerorder = customerorder.Where(order => order.CouponCode != null).ToList();

                ViewOrders();
            }
            else
            {
                customerorder = DataBase.Instance.GetOrders();
                ViewOrders();
            }
        }

        private void viewreportBtn_Click(object sender, EventArgs e)
        {
            OrderReports orderreportform = new OrderReports();  
            orderreportform.ShowDialog();   
        }

        private void viewbookreport_Click(object sender, EventArgs e)
        {
            ViewBookOrderForm viewbookdetails = new ViewBookOrderForm();
            viewbookdetails.ShowDialog();
        }
    }
}
