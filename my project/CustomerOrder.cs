using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_project
{
    public class CustomerOrder
    {
        private int orderID;
        private DateTime orderDate;
        private string orderStatus;
        private double orderTotal;
        private double deliveryFee;
        private string couponCode;

        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public string OrderStatus
        {
            get { return orderStatus; }
            set { orderStatus = value; }
        }

        public double OrderTotal
        {
            get { return orderTotal; }
            set { orderTotal = value; }
        }

        public double DeliveryFee
        {
            get { return deliveryFee; }
            set { deliveryFee = value; }
        }

        public string CouponCode
        {
            get { return couponCode; }
            set { couponCode = value; }
        }

        public CustomerOrder()
        {
        }

        public CustomerOrder(int orderID, DateTime orderDate, string orderStatus, double orderTotal, double deliveryFee, string couponCode)
        {
            this.orderID = orderID;
            this.orderDate = orderDate;
            this.orderStatus = orderStatus;
            this.orderTotal = orderTotal;
            this.deliveryFee = deliveryFee;
            this.couponCode = couponCode;
        }
    }
}
