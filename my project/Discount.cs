using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_project
{
    public class Discount
    {
        private string bookISBN;
        private double percentage;
        private string type;

        public Discount()
        {
            bookISBN = "";
            percentage = 0.0;
            type = "";
        }

        public Discount(string bookISBN, double percentage, string type)
        {
            this.bookISBN = bookISBN;
            this.percentage = percentage;
            this.type = type;
        }

        public string BookISBN
        {
            get { return bookISBN; }
            set { bookISBN = value; }
        }

        public double Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
