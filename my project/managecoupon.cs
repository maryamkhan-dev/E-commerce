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
    public partial class managecoupon : UserControl
    {
        List<Coupon> couponslist = new List<Coupon>();

        private static managecoupon instance;
        public static managecoupon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new managecoupon();
                }
                return instance;
            }
        }


        public managecoupon()
        {
            InitializeComponent();
            couponslist = DataBase.Instance.GetCoupons();
            ViewCoupons();
        }

        public void ViewCoupons()
        {
            dataGridView2.DataSource = null;
            dataGridView2.Refresh();

            dataGridView2.DataSource = couponslist;

        }
        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void processBtn_Click(object sender, EventArgs e) //addbtn
        {
            AddCouponForm newaddcoupon = new AddCouponForm();
            newaddcoupon.ShowDialog();
            Coupon newcoupon = new Coupon(newaddcoupon.CouponCode, Convert.ToDouble(newaddcoupon.DiscountAmount));
            DataBase.Instance.AddNewCoupon(newcoupon);
            couponslist.Add(newcoupon);
            ViewCoupons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                string code = selectedRow.Cells["CouponCode"].Value.ToString();
                string discount = selectedRow.Cells["Discount"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete the following book?\n\n" +
                                                      $"Coupon Code: {code}\n" +
                                                      $"Discount Amount: {discount}\n",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataBase.Instance.DeleteCoupon(code);
                    Coupon coupnToDelete = couponslist.Find(coupon => coupon.Couponcode == code);
                    if (coupnToDelete != null)
                    {
                        DataBase.Instance.DeleteBookInInventory(code);
                        couponslist.Remove(coupnToDelete);
                        ViewCoupons();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void viewBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                List<Coupon> filteredCoupons = couponslist.Where(coupon =>
                    coupon.Couponcode.Contains(searchTerm) ||
                    coupon.Discount.ToString().Contains(searchTerm)).ToList();

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = filteredCoupons;
            }
            else
            {
                ViewCoupons(); 
            }
        }
    }
}
