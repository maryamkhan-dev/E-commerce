using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_project
{
    namespace my_project
    {
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
            public string Publisher { get; set; } 
            public string Year { get; set; } 
            public int Quantity { get; set; }
            public double Price { get; set; }

            //       public bool IsDeleted {  get; set; }
            //       
            public string ISBNAndTitle
            {
                get { return $"{ISBN} - {Title}"; }
            }

            public double DiscountedPrice { get; set; } 

            public Book(string title, string author, string isbn, string publisher, string year, int quantity, double price)
            {
                Title = title;
                Author = author;
                ISBN = isbn;
                Publisher = publisher;
                Year =  year;
                Quantity = quantity;
                Price = price;
                DiscountedPrice = price;
           //     IsDeleted = false;
            }

            public Book()
            {
            }
        }
    }
}
