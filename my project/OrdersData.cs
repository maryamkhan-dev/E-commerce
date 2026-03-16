using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_project
{
    public class OrdersData
    {

        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public string BookISBN { get; set; }
        public string OrderDate { get; set; }
        public double TotalPrice { get; set; }

        public int NumberOfOrders {  get; set; }    

        public string BookTitle { get; set; }
        public double Revenue {  get; set; }    

        public int PurchaseCount { get; set; }  

        public double AverageOrderValue {  get; set; }




    }
}
