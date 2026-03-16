using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_project
{
    public class Coupon
    {
        private string couponcode;
        private double discount;

        public Coupon(string code, double dis)
        {
            couponcode = code;  
            discount= dis;
        }

        public Coupon()
        {

        }
        public string Couponcode
        {
            get { return couponcode; }  
            set { couponcode = value; } 
        }

        public double Discount
        { get { return discount; } 
          set { discount = value; }
        }

    }
}
