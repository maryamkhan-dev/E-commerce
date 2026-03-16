using my_project.my_project;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;

namespace my_project
{
    public class DataBase
    {
        private List<Book> books = new List<Book>();

        SqlConnection cn = new SqlConnection("Data Source = DESKTOP-UEM7MOJ\\SQLEXPRESS;Initial Catalog=22i2514_22i8764_Project; Integrated Security=True");
        //SqlConnection cn = new SqlConnection("Data Source = DESKTOP-DD0QNRO\\SQLEXPRESS;Initial Catalog=Paper_Trails; Integrated Security=True");
        SqlCommand cm;
        SqlDataReader dr;


        private static DataBase instance;

        public static DataBase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataBase();
                }
                return instance;
            }
        }


        public bool UserNameExists(string username)
        {
            bool userExists = false;
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT dbo.UsernameExists(@username)", cn);
                cm.Parameters.AddWithValue("@username", username);
                int result = Convert.ToInt32(cm.ExecuteScalar());
                if (result == 1)
                {
                    userExists = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UserNameExists error");
            }
            finally { cn.Close(); }

            return userExists;
        }

        public bool CheckUser(string username, string password, string type)
        {
            bool check = false;
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT dbo.CheckUser(@username, @password, @type)", cn);
                cm.Parameters.AddWithValue("@username", username);
                cm.Parameters.AddWithValue("@password", password);
                cm.Parameters.AddWithValue("@type", type);

                int result = Convert.ToInt32(cm.ExecuteScalar());
                if (result == 1)
                {
                    check = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CheckUser error");
            }
            finally { cn.Close(); }
            return check;
        }

        public void AddNewCustomer(string customerUsername, string customerFname, string customerLname, string customerEmail, string customerPassword, string customerAddress, string customerPhonenumber, string customerCity, string customerState)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("EXECUTE AddNewCustomer @customerUsername, @customerFname, @customerLname, @customerEmail, @customerPassword, @customerAddress, @customerPhonenumber, @customerCity, @customerState", cn);

                cm.Parameters.AddWithValue("@customerUsername", customerUsername);
                cm.Parameters.AddWithValue("@customerFname", customerFname);
                cm.Parameters.AddWithValue("@customerLname", customerLname);
                cm.Parameters.AddWithValue("@customerEmail", customerEmail);
                cm.Parameters.AddWithValue("@customerPassword", customerPassword);
                cm.Parameters.AddWithValue("@customerAddress", customerAddress);
                cm.Parameters.AddWithValue("@customerPhonenumber", customerPhonenumber);
                cm.Parameters.AddWithValue("@customerCity", customerCity);
                cm.Parameters.AddWithValue("@customerState", customerState);

                cm.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AddNewCustomer error");
            }
            finally { cn.Close(); }
        }

        public void AddNewManager(string managerUsername, string managerFname, string managerLname, string managerEmail, string managerPassword, string managerPhonenumber, DateTime managerJoiningDate, string managerType)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("EXECUTE AddNewManager @managerUsername, @managerFname, @managerLname, @managerEmail, @managerPassword, @managerPhonenumber, @managerJoiningDate, @managerType", cn);
                cm.Parameters.AddWithValue("@managerUsername", managerUsername);
                cm.Parameters.AddWithValue("@managerFname", managerFname);
                cm.Parameters.AddWithValue("@managerLname", managerLname);
                cm.Parameters.AddWithValue("@managerEmail", managerEmail);
                cm.Parameters.AddWithValue("@managerPassword", managerPassword);
                cm.Parameters.AddWithValue("@managerPhonenumber", managerPhonenumber);
                cm.Parameters.AddWithValue("@managerJoiningDate", managerJoiningDate);
                cm.Parameters.AddWithValue("@managerType", managerType);

                cm.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AddNewManager error");
            }

            finally { cn.Close(); }

        }

        public void UpdateCustomerProfile(string customerUsername, string customerFname, string customerLname, string customerEmail, string customerPassword, string customerAddress, string customerPhonenumber, string customerCity, string customerState)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("UPDATE Users SET " +
                    "First_Name = @customerFname, " +
                    "Last_Name = @customerLname, Email = @customerEmail, Password = @customerPassword, " +
                    "Phone_Number = @customerPhonenumber " +
                    "WHERE Username = @customerUsername; " +
                    "UPDATE Customer SET " +
                    "Shipping_Address = @customerAddress, " +
                    "Shipping_City = @customerCity, Shipping_State = @customerState " +
                    "WHERE Username = @customerUsername", cn);

                cm.Parameters.AddWithValue("@customerUsername", customerUsername);
                cm.Parameters.AddWithValue("@customerFname", customerFname);
                cm.Parameters.AddWithValue("@customerLname", customerLname);
                cm.Parameters.AddWithValue("@customerEmail", customerEmail);
                cm.Parameters.AddWithValue("@customerPassword", customerPassword);
                cm.Parameters.AddWithValue("@customerAddress", customerAddress);
                cm.Parameters.AddWithValue("@customerCity", customerCity);
                cm.Parameters.AddWithValue("@customerState", customerState);

                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UpdateCustomerProfile error");
            }
            finally { cn.Close(); }

        }

        public void UpdateDiscount(string BookISBN, double percent, string type)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("UPDATE Discounts " +
                                    "SET Percentage = @Percentage, Type = @Type " +
                                    "WHERE BookISBN = @BookISBN", cn);

                cm.Parameters.AddWithValue("@BookISBN", BookISBN);
                cm.Parameters.AddWithValue("@Percentage", percent);
                cm.Parameters.AddWithValue("@Type", type);

                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UpdateDiscount error");
            }
            finally { cn.Close(); }

        }
        public void MakeCartForNewCustomer(string username)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO Cart (CustomerID, Creation_date) VALUES (@CustomerID, GETDATE()); SELECT SCOPE_IDENTITY();", cn);

                cm.Parameters.AddWithValue("@CustomerID", username);

                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UpdateQuantityOfItem error");
            }
            finally { cn.Close(); }
        }



        public void UpdateManagerProfile(string managerUsername, string managerFname, string managerLname, string managerEmail, string managerPassword, string managerjoiningdate, string managerPhonenumber, string managertype)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("UPDATE Users SET " +
                    "First_Name = @customerFname, " +
                    "Last_Name = @customerLname, Email = @customerEmail, Password = @customerPassword, " +
                    "Phone_Number = @customerPhonenumber " +
                    "WHERE Username = @customerUsername; " +
                    "UPDATE Manager SET " +
                    "Joining_Date = @Joining_Date, " +
                    "managerType = @managertype " +
                    "WHERE Username = @customerUsername", cn);

                cm.Parameters.AddWithValue("@Username", managerUsername);
                cm.Parameters.AddWithValue("@Fname", managerFname);
                cm.Parameters.AddWithValue("@Lname", managerLname);
                cm.Parameters.AddWithValue("@Email", managerEmail);
                cm.Parameters.AddWithValue("@Last_Name", managerPassword);
                cm.Parameters.AddWithValue("@Joining_Date", managerjoiningdate);
                cm.Parameters.AddWithValue("@managertype", managertype);

                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UpdateManagerProfile error");
            }
            finally { cn.Close(); }

        }

        public void DeleteProfile(string Username, string customerPassword)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("UPDATE Users SET Account_status = 'deleted' WHERE Username = @Username", cn);
                cm.Parameters.AddWithValue("@Username", Username);
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DeleteProfile error");
            }
            finally
            {
                cn.Close();
            }
        }


        public Manager GetManager(string username)
        {
            Manager manager = new Manager();
            try
            {
                cn.Open();
                cm = new SqlCommand("EXECUTE GetManagerDetails @Username", cn);
                cm.Parameters.AddWithValue("@Username", username);

                dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    manager.Username = dr["Username"].ToString();
                    manager.FirstName = dr["First_Name"].ToString();
                    manager.LastName = dr["Last_Name"].ToString();
                    manager.Email = dr["Email"].ToString();
                    manager.Password = dr["Password"].ToString();
                    manager.PhoneNumber = dr["Phone_Number"].ToString();
                    manager.JoiningDate = dr["Joining_Date"].ToString();
                    manager.Type = dr["Manager_Type"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetManager error");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                    dr.Close();
                }
            }

            return manager;
        }

        public Customer GetCustomer(string username)
        {
            // query to find info of customer using username
            Customer customer = null;

            try
            {
                cn.Open();
                cm = new SqlCommand("EXECUTE GetCustomerDetails @Username", cn);
                cm.Parameters.AddWithValue("@Username", username);

                dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    customer = new Customer
                    {
                        Username = dr["Username"].ToString(),
                        FirstName = dr["First_Name"].ToString(),
                        LastName = dr["Last_Name"].ToString(),
                        Email = dr["Email"].ToString(),
                        Password = dr["Password"].ToString(),
                        PhoneNumber = dr["Phone_Number"].ToString(),
                        Address = dr["Shipping_Address"].ToString(),
                        City = dr["Shipping_City"].ToString(),
                        State = dr["Shipping_State"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetCustomer error");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                    dr.Close();
                }
            }

            return customer;
        }


        public List<eachbookinshop> GetShopItems()
        {
            List<eachbookinshop> shopitems = new List<eachbookinshop>();

            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT ISBN, Title, Author, Publisher, Quantity, Price, Discounted_Price, Publication_Year FROM Books WHERE isDeleted = 0", cn);

                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    eachbookinshop newItem = new eachbookinshop
                    {
                        ItemISBN = dr["ISBN"].ToString(),
                        ItemTitle = dr["Title"].ToString(),
                        ItemAuthor = dr["Author"].ToString(),
                        ItemPublisher = dr["Publisher"].ToString(),
                        ItemPrice = Convert.ToDouble(dr["Price"]),
                        ItemDiscountedPrice = Convert.ToDouble(dr["Discounted_Price"]),
                        ItemYear = dr["Publication_Year"].ToString(),
                    };

                    if (newItem.ItemPrice == newItem.ItemDiscountedPrice)
                    {
                        newItem.discountpricelabel.Visible = false;
                        newItem.discountedprice.Visible = false;
                        newItem.setPanelVisbility(false);
                    }
                    else
                    {
                        newItem.ItemPrice = newItem.ItemDiscountedPrice;

                    }

                    shopitems.Add(newItem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetShopItems error");
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return shopitems;
        }

        public void UpdateQuantityOfItem(string bookisbn, int quantity)
        {
            //this item already exists so using customers username, then cart of that customer then find the cartitem and add 1
            string username = CustomerScreen.Instance.CurrentCustomer.Username;
            try
            {
                cn.Open();
                cm = new SqlCommand("UPDATE CartItems SET Quantity = @quantity " +
                                    "WHERE CartID = (SELECT CartID FROM Cart " +
                                    "WHERE CustomerID = @CustomerID)" +
                                    "AND BookISBN = @BookISBN", cn);

                cm.Parameters.AddWithValue("@quantity", quantity);
                cm.Parameters.AddWithValue("@CustomerID", username);
                cm.Parameters.AddWithValue("@BookISBN", bookisbn);

                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UpdateQuantityOfItem error");
            }
            finally { cn.Close(); }

        }

        public void AddItemInCustomerCart(string bookisbn)
        {
            //this item doesnot exists so using customer username, then cart then add and set its quantity to 1
            string username = CustomerScreen.Instance.CurrentCustomer.Username;

            try
            {
                cn.Open();
                cm = new SqlCommand("EXECUTE InsertCartItem @CustomerID, @BookISBN", cn);
                cm.Parameters.AddWithValue("@CustomerID", username);
                cm.Parameters.AddWithValue("@BookISBN", bookisbn);

                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AddItemInCustomerCart error");
            }
            finally { cn.Close(); }
        }

        public List<eachitemincart> getCustomerItemsinCart(string customerusername)
        {
            List<eachitemincart> cartItems = new List<eachitemincart>();

            try
            {
                cn.Open();
                cm = new SqlCommand("EXECUTE GetCartItems @CustomerID", cn);
                cm.Parameters.AddWithValue("@CustomerID", customerusername);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    eachitemincart newItem = new eachitemincart
                    {
                        ItemISBN = dr["BookISBN"].ToString(),
                        ItemTitle = dr["Title"].ToString(),
                        ItemAuthor = dr["Author"].ToString(),
                        Quantity = Convert.ToInt32(dr["Quantity"]),
                        ItemPrice = Convert.ToDouble(dr["Price"])
                    };
                    cartItems.Add(newItem);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "getCustomerItemsinCart error");
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return cartItems;
        }

        public List<customerorderhistory> GetCustomerOrderHistory()
        {
            List<customerorderhistory> orderhistorylist = new List<customerorderhistory>();
            string username = CustomerScreen.Instance.CurrentCustomer.Username;

            try
            {
                cn.Open();
                cm = new SqlCommand("EXECUTE GetCustomerOrders @CustomerID", cn);
                cm.Parameters.AddWithValue("@CustomerID", username);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    customerorderhistory newItem = new customerorderhistory
                    {
                        OrderID = dr["OrderID"].ToString(),
                        OrderDate = dr["Order_Date"].ToString(),
                        OrderStatus = dr["Status"].ToString(),
                        OrderCouponAmount = dr["CouponCode"].ToString(),
                        TotalPrice = dr["Order_Total"].ToString(),
                        DeliveryFee = dr["Delivery_fee"].ToString(),
                    };
                    orderhistorylist.Add(newItem);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetCustomerOrderHistory error");
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return orderhistorylist;
        }

        public List<customerorderhistory> GetCustomerReturnedOrderHistory()
        {
            List<customerorderhistory> returnedOrderHistoryList = new List<customerorderhistory>();
            string username = CustomerScreen.Instance.CurrentCustomer.Username;

            try
            {
                cn.Open();

                // Define the SQL query to retrieve orders with returned order items for a specific customer
                string query = @"SELECT  o.OrderID, o.Order_Date, o.Status, o.Order_Total, o.Delivery_Fee, o.CouponCode
                         FROM Orders o
                         INNER JOIN OrderItems oi ON o.OrderID = oi.OrderID
                         INNER JOIN Returns r ON oi.OrderID = r.OrderID AND oi.BookISBN = r.BookISBN
                         WHERE o.CustomerID = @Username";

                cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@Username", username);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    // Create a new customerorderhistory object for each returned order
                    customerorderhistory orderHistory = new customerorderhistory
                    {
                        OrderID = dr["OrderID"].ToString(),
                        OrderDate = dr["Order_Date"].ToString(),
                        OrderStatus = dr["Status"].ToString(),
                        DeliveryFee = dr["Delivery_Fee"].ToString(),
                        TotalPrice = dr["Order_Total"].ToString(),
                        OrderCouponAmount = dr["CouponCode"].ToString()
                    };

                    // Add the order history to the list
                    returnedOrderHistoryList.Add(orderHistory);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetCustomerReturnedOrderHistory Error");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return returnedOrderHistoryList;
        }


        public List<eachiteminorderhistory> GetOrderItemsOfOrder(string Orderid)
        {
            List<eachiteminorderhistory> orderitems = new List<eachiteminorderhistory>();

            try
            {
                cn.Open();
                cm = new SqlCommand("EXECUTE GetOrderItems @OrderID", cn);
                int orderIDInt = Convert.ToInt32(Orderid);
                cm.Parameters.AddWithValue("@OrderID", orderIDInt);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    eachiteminorderhistory newItem = new eachiteminorderhistory
                    {
                        ItemQuantity = dr["Quantity"].ToString(),
                        ItemTitle = dr["Title"].ToString(),
                        ItemPrice = dr["Price"].ToString(),
                        ItemStatus = dr["Status"].ToString(),
                        ItemISBN = dr["BookISBN"].ToString(),
                        OrderID = Orderid
                    };

                    orderitems.Add(newItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetOrderItemsOfOrder error");
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return orderitems;
        }


        public void ReturnOrderItem(string isbn, int orderid)
        {
            try
            {
                cn.Open();

                string query = @"INSERT INTO Returns (OrderID, BookISBN, Refund_Amount)
                         SELECT @OrderID, @ISBN, (b.Price * oi.Quantity) AS Refund_Amount
                         FROM OrderItems oi
                         JOIN Books b ON oi.BookISBN = b.ISBN
                         WHERE oi.OrderID = @OrderID AND oi.BookISBN = @ISBN";

                cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@OrderID", orderid);
                cm.Parameters.AddWithValue("@ISBN", isbn);

                int rowsAffected = cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ReturnOrderItem Error");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        public void RemoveItemFromCustomerCart(eachitemincart item)
        {
            //// get the current customer's username
            string username = CustomerScreen.Instance.CurrentCustomer.Username;

            try
            {
                cn.Open();
                cm = new SqlCommand("EXECUTE DeleteCartItem @CustomerID, @BookISBN", cn);
                cm.Parameters.AddWithValue("@CustomerID", username);
                cm.Parameters.AddWithValue("@BookISBN", item.ItemISBN);

                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RemoveItemFromCustomerCart error");
            }
            finally
            {
                cn.Close();
            }
        }

        public void ClearCart()
        {
            string username = CustomerScreen.Instance.CurrentCustomer.Username;
            try
            {
                cn.Open();
                cm = new SqlCommand("EXECUTE ClearCartItems @CustomerID", cn);
                cm.Parameters.AddWithValue("@CustomerID", username);

                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ClearCartItems Error");
            }
            finally
            {
                cn.Close();

            }

        }

        public void DeleteCoupon(string couponCode)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("UPDATE Coupons SET Validity = 'InValid' WHERE CouponCode  = @couponCode", cn);
                cm.Parameters.AddWithValue("@couponCode", couponCode);
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DeleteCoupon Error");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        public void DeleteDiscount(string isbn)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("DELETE Discounts WHERE BookISBN  = @BookISBN", cn);
                cm.Parameters.AddWithValue("@BookISBN", isbn);
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DeleteDiscount Error");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }


        public Coupon validateCoupon(string couponCode)
        {
            Coupon coupon = new Coupon();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM Coupons WHERE CouponCode = @CouponCode", cn);
            cm.Parameters.AddWithValue("@CouponCode", couponCode);

            dr = cm.ExecuteReader();

            if (dr.Read())
            {
                coupon.Couponcode = dr["CouponCode"].ToString();
                coupon.Discount = Convert.ToDouble(dr["Discount_Amount"]);
            }

            dr.Close();

            cm = new SqlCommand("SELECT * FROM Coupons WHERE CouponCode = @CouponCode AND Validity = 'Valid'", cn);
            cm.Parameters.AddWithValue("@CouponCode", couponCode);
            dr = cm.ExecuteReader();

            if (!dr.Read())
            {
                // If coupon is not valid, set it to null
                coupon = null;
            }

            dr.Close();
            cn.Close();
            return coupon;
        }

        public OrderConfirmationScreen MakeNewOrderForCustomer(List<itemincheckout> itemsInCheckout, Coupon currentCoupon)
        {
            OrderConfirmationScreen orderConfirmation = new OrderConfirmationScreen();
            orderConfirmation.setList(itemsInCheckout);
            orderConfirmation.CustomerAddress = CustomerScreen.Instance.CurrentCustomer.Address;
            orderConfirmation.CustomerPhoneNumber = CustomerScreen.Instance.CurrentCustomer.PhoneNumber;


            
            try
            {
                string username = CustomerScreen.Instance.CurrentCustomer.Username;

                cn.Open();

                // total price calculate
                double deliveryFee = 50;
                double subtotal = 0;
                foreach (var item in itemsInCheckout)
                {
                    subtotal += (item.Price);
                }

                if (currentCoupon != null)
                {
                    subtotal -= currentCoupon.Discount;
                }

                orderConfirmation.OrderSubTotal = subtotal.ToString();

                cm = new SqlCommand("EXECUTE InsertNewOrder @Username, @DeliveryFee, @CouponCode", cn);
                cm.Parameters.AddWithValue("@Username", username);
                cm.Parameters.AddWithValue("@DeliveryFee", deliveryFee);

                if (currentCoupon == null)
                {
                    cm.Parameters.AddWithValue("@CouponCode", DBNull.Value);
                    orderConfirmation.CouponDiscount = "0";
                }
                else
                {
                    string couponCode = currentCoupon.Couponcode;
                    orderConfirmation.OrderCoupon = currentCoupon.Discount.ToString();
                    cm.Parameters.AddWithValue("@CouponCode", couponCode);
                }


                int orderID = (int)cm.ExecuteScalar();
                orderConfirmation.OrderID = orderID.ToString();

                foreach (var item in itemsInCheckout)
                {
                    cm = new SqlCommand("EXECUTE InsertOrderItems @OrderID, @BookISBN, @Quantity", cn);
                    cm.Parameters.AddWithValue("@OrderID", orderID);
                    cm.Parameters.AddWithValue("@BookISBN", item.ISBN);
                    cm.Parameters.AddWithValue("@Quantity", item.Quantity);
                    cm.ExecuteNonQuery();
                }

                cm = new SqlCommand("SELECT dbo.CalculateOrderTotal(@OrderID)", cn);
                cm.Parameters.AddWithValue("@OrderID", orderID);

                double totalPrice = Convert.ToDouble(cm.ExecuteScalar());
                Console.WriteLine(totalPrice);
                Console.WriteLine("fer");
                cm = new SqlCommand("UPDATE Orders SET Order_Total = @TotalPrice WHERE OrderID = @orderid", cn);
                cm.Parameters.AddWithValue("@OrderID", orderID);
                cm.Parameters.AddWithValue("@TotalPrice", totalPrice);
                cm.ExecuteNonQuery();

                orderConfirmation.OrderTotalPrice = totalPrice.ToString();


                orderConfirmation.OrderStatus = "Pending";
                orderConfirmation.OrderDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                orderConfirmation.OrderDeliveryFee = deliveryFee.ToString();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MakeNewOrderForCustomer Error");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return orderConfirmation;

        }

        public List<Book> GetInventory()
        {
            List<Book> inventory = new List<Book>();

            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT * FROM Books", cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    bool isdeleted = Convert.ToBoolean(dr["isDeleted"]);

                    if (!isdeleted)
                    {
                        Book book = new Book
                        {
                            ISBN = dr["ISBN"].ToString(),
                            Title = dr["Title"].ToString(),
                            Author = dr["Author"].ToString(),
                            Publisher = dr["Publisher"].ToString(),
                            Quantity = Convert.ToInt32(dr["Quantity"]),
                            Price = Convert.ToDouble(dr["Price"]),
                            DiscountedPrice = Convert.ToDouble(dr["Discounted_Price"]),
                            Year = dr["Publication_Year"].ToString()
                        };

                        inventory.Add(book);
                    }
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetInventory error");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return inventory;
        }

        public List<CustomerOrder> GetOrders()
        {
            List<CustomerOrder> orderlist = new List<CustomerOrder>();

            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT * FROM Orders", cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    CustomerOrder neworder = new CustomerOrder()
                    {
                        OrderID = Convert.ToInt16(dr["OrderID"]),
                        OrderDate = Convert.ToDateTime(dr["Order_Date"]),
                        OrderStatus = dr["Status"].ToString(),
                        DeliveryFee = Convert.ToDouble(dr["Delivery_Fee"]),
                    };

                    // Check for null values before converting
                    if (!dr.IsDBNull(dr.GetOrdinal("Order_Total")))
                    {
                        neworder.OrderTotal = Convert.ToDouble(dr["Order_Total"]);
                    }

                    if (!dr.IsDBNull(dr.GetOrdinal("CouponCode")))
                    {
                        neworder.CouponCode = dr["CouponCode"].ToString();
                    }

                    orderlist.Add(neworder);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetOrder error");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return orderlist;
        }

        public ViewOrderForm GetOrderDetails(int orderId)
        {
            ViewOrderForm newForm = new ViewOrderForm();

            try
            {
                cn.Open();

                // Define the SQL query with JOIN operations to fetch order details
                string query = @"SELECT o.OrderID, o.Order_Date, o.Status, o.Order_Total, o.Delivery_Fee, o.CouponCode,
                                    c.Username, c.Shipping_Address, 
                                    b.ISBN, b.Title, b.Author, b.Publication_Year, b.Publisher,
                                    oi.Quantity, b.Price
                                 FROM Orders o
                                 INNER JOIN Customer c ON o.CustomerID = c.Username
                                 INNER JOIN OrderItems oi ON o.OrderID = oi.OrderID
                                 INNER JOIN Books b ON oi.BookISBN = b.ISBN
                                 WHERE o.OrderID = @OrderId";

                cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@OrderId", orderId);
                dr = cm.ExecuteReader();

                // Populate the ViewOrderForm with fetched data
                if (dr.Read())
                {
                    newForm.OrderID = dr["OrderID"].ToString();
                    newForm.OrderDate = dr["Order_Date"].ToString();
                    newForm.OrderStatus = dr["Status"].ToString();
                    newForm.OrderTotal = dr["Order_Total"].ToString();
                    newForm.DeliveryFee = dr["Delivery_Fee"].ToString();
                    newForm.CouponCode = dr["CouponCode"].ToString();
                    newForm.UserName = dr["Username"].ToString();
                    //newForm.FirstName = reader["First_name"].ToString();
                    //newForm.LastName = reader["Last_name"].ToString();
                    newForm.Address = dr["Shipping_Address"].ToString();
                    //newForm.PhoneNumber = reader["Phone_Number"].ToString();
                    //newForm.Email = reader["Email"].ToString();

                    // Add each ordered book's details
                    do
                    {
                        eachorderbook book = new eachorderbook();
                        book.ISBN = dr["ISBN"].ToString();
                        book.Title = dr["Title"].ToString();
                        book.Author = dr["Author"].ToString();
                        book.Year = dr["Publication_Year"].ToString();
                        book.Publisher = dr["Publisher"].ToString();
                        book.Quantity = dr["Quantity"].ToString();
                        book.Price = dr["Price"].ToString();
                        newForm.BookInOrder.Add(book);
                    } while (dr.Read());
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return newForm;
        }

        public void AddBookInInventory(Book newbook)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO Books (ISBN, Title, Author, Publisher, Quantity, Price, Discounted_Price, Publication_Year) " +
                    "VALUES (@isbn, @title, @author, @publisher, @quantity, @price, @discountedPrice, @publicationYear)", cn);
                cm.Parameters.AddWithValue("@isbn", newbook.ISBN);
                cm.Parameters.AddWithValue("@title", newbook.Title);
                cm.Parameters.AddWithValue("@author", newbook.Author);
                cm.Parameters.AddWithValue("@publisher", newbook.Publisher);
                cm.Parameters.AddWithValue("@quantity", newbook.Quantity);
                cm.Parameters.AddWithValue("@price", newbook.Price);
                cm.Parameters.AddWithValue("@discountedPrice", newbook.Price);
                cm.Parameters.AddWithValue("@publicationYear", newbook.Year);


                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AddBookInInventory Error");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

        }

        public void AddNewCoupon(Coupon newcoupon)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO Coupons (CouponCode, Discount_Amount, Validity) VALUES (@Couponcode, @discountAmount, 'Valid')", cn);
                cm.Parameters.AddWithValue("@discountAmount", newcoupon.Discount);
                cm.Parameters.AddWithValue("@Couponcode", newcoupon.Couponcode);


                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AddCoupon Error");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        public void AddNewDiscount(Discount newdiscount)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO Discounts (BookISBN, Percentage, Type) VALUES (@BookISBN, @Percentage, @Type)", cn);
                cm.Parameters.AddWithValue("@BookISBN", newdiscount.BookISBN);
                cm.Parameters.AddWithValue("@Percentage", newdiscount.Percentage);
                cm.Parameters.AddWithValue("@Type", newdiscount.Type);
                cm.ExecuteNonQuery();

                cm = new SqlCommand("SELECT Price FROM Books WHERE ISBN = @BookISBN", cn);
                cm.Parameters.AddWithValue("@BookISBN", newdiscount.BookISBN);
                double originalPrice = Convert.ToDouble(cm.ExecuteScalar());

                double newDiscountedPrice = originalPrice - (originalPrice * (newdiscount.Percentage / 100));

                cm = new SqlCommand("UPDATE Books SET Discounted_Price = @NewDiscountedPrice WHERE ISBN = @BookISBN", cn);
                cm.Parameters.AddWithValue("@NewDiscountedPrice", newDiscountedPrice);
                cm.Parameters.AddWithValue("@BookISBN", newdiscount.BookISBN);
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AddDiscount Error");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }


        public List<Coupon> GetCoupons()
        {
            List<Coupon> coupons = new List<Coupon>();

            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT CouponCode, Discount_Amount, Validity FROM Coupons WHERE Validity = 'Valid'", cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    Coupon newCoupon = new Coupon
                    {
                        Couponcode = (dr["CouponCode"]).ToString(),
                        Discount = Convert.ToDouble(dr["Discount_Amount"]),
                    };

                    coupons.Add(newCoupon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetCoupons error");
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return coupons;
        }


        public List<Discount> GetDiscounts()
        {
            List<Discount> discounts = new List<Discount>();

            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT BookISBN, Percentage, Type FROM Discounts", cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    Discount newDiscount = new Discount
                    {
                        BookISBN = (dr["BookISBN"]).ToString(),
                        Percentage = Convert.ToDouble(dr["Percentage"]),
                        Type = (dr["Type"]).ToString()

                    };

                    discounts.Add(newDiscount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetDiscount error");
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return discounts;
        }

        public void DeleteBookInInventory(string isbn)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("UPDATE Books SET isDeleted = 1 WHERE ISBN = @isbn", cn);
                cm.Parameters.AddWithValue("@isbn", isbn);

                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DeleteBookInInventory Error");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        public void UpdateOrderStatus(int orderid, string status)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("UPDATE Orders SET Status = @status WHERE OrderID = @orderid", cn);
                cm.Parameters.AddWithValue("@status", status);
                cm.Parameters.AddWithValue("@OrderID", orderid);


                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UpdateOrderStatus Error");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
        public void UpdateBookInInventory(string title, string author, string isbn, string publisher, string year, int quantity, double price)
        {
            try
            {
                cn.Open();
                string query = @"UPDATE Books
                                 SET 
                                    Title = @title,
                                    Author = @author,
                                    Publisher = @publisher,
                                    Publication_Year = @year,
                                    Quantity = @quantity,
                                    Price = @price
                                 WHERE ISBN = @isbn";

                cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@title", title);
                cm.Parameters.AddWithValue("@author", author);
                cm.Parameters.AddWithValue("@isbn", isbn);
                cm.Parameters.AddWithValue("@publisher", publisher);
                cm.Parameters.AddWithValue("@year", year);
                cm.Parameters.AddWithValue("@quantity", quantity);
                cm.Parameters.AddWithValue("@price", price);

                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UpdateBookInInventory Error");
            }
            finally
            {
                cn.Close();
            }
        }

        public List<CustomerOrder> GetReturnedOrders()
        {
            List<CustomerOrder> returnedOrders = new List<CustomerOrder>();

            try
            {
                cn.Open();

                // Define the SQL query to retrieve orders with items in the return table
                string query = @"SELECT  o.OrderID, o.Order_Date, o.Status, o.Order_Total, o.Delivery_Fee, o.CouponCode
                         FROM Orders o
                         INNER JOIN OrderItems oi ON o.OrderID = oi.OrderID
                         INNER JOIN Returns r ON oi.OrderID = r.OrderID AND oi.BookISBN = r.BookISBN";

                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    // Create a new CustomerOrder object for each returned order
                    CustomerOrder neworder = new CustomerOrder()
                    {
                        OrderID = Convert.ToInt16(dr["OrderID"]),
                        OrderDate = Convert.ToDateTime(dr["Order_Date"]),
                        OrderStatus = dr["Status"].ToString(),
                        DeliveryFee = Convert.ToDouble(dr["Delivery_Fee"]),
                    };

                    // Check for null values before converting
                    if (!dr.IsDBNull(dr.GetOrdinal("Order_Total")))
                    {
                        neworder.OrderTotal = Convert.ToDouble(dr["Order_Total"]);
                    }

                    if (!dr.IsDBNull(dr.GetOrdinal("CouponCode")))
                    {
                        neworder.CouponCode = dr["CouponCode"].ToString();
                    }

                    // Add the returned order to the list
                    returnedOrders.Add(neworder);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetReturnedOrders Error");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return returnedOrders;
        }

        public List<OrdersData> GetNumberOfOrdersPerCustomer()
        {
            List<OrdersData> orders = new List<OrdersData>();

            try
            {
                cn.Open();

                string query = @"SELECT CustomerID, COUNT(OrderID) AS NumberOfOrders
                         FROM Orders
                         GROUP BY CustomerID";

                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    OrdersData order = new OrdersData
                    {
                        CustomerID = dr["CustomerID"].ToString(),
                        NumberOfOrders = Convert.ToInt32(dr["NumberOfOrders"])
                    };

                    orders.Add(order);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return orders;
        }

        public List<OrdersData> GetRevenueByEachBookNotReturned()
        {
            List<OrdersData> revenueList = new List<OrdersData>();

            try
            {
                cn.Open();
                cm = new SqlCommand("GetRevenueByEachBookNotReturned", cn);
                cm.CommandType = CommandType.StoredProcedure;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    OrdersData revenueData = new OrdersData
                    {
                        BookTitle = dr["BookTitle"].ToString(),
                        BookISBN = dr["BookISBN"].ToString(),
                        Revenue = Convert.ToDouble(dr["Revenue"])
                    };

                    revenueList.Add(revenueData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return revenueList;
        }

        public List<OrdersData> GetRevenueByEachCustomer()
        {
            List<OrdersData> revenueList = new List<OrdersData>();

            try
            {
                cn.Open();
                cm = new SqlCommand("GetRevenueByEachCustomer", cn);
                cm.CommandType = CommandType.StoredProcedure;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    OrdersData revenueData = new OrdersData
                    {
                        CustomerID = dr.IsDBNull(dr.GetOrdinal("Username")) ? null : dr["Username"].ToString(),
                        Revenue = dr.IsDBNull(dr.GetOrdinal("Revenue")) ? 0.0 : Convert.ToDouble(dr["Revenue"])
                    };

                    revenueList.Add(revenueData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return revenueList;
        }

        public List<OrdersData> GetMostBoughtBook()
        {
            List<OrdersData> mostBoughtBooks = new List<OrdersData>();

            try
            {
                cn.Open();
                cm = new SqlCommand("GetMostBoughtBook", cn);
                cm.CommandType = CommandType.StoredProcedure;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    OrdersData bookData = new OrdersData
                    {
                        BookISBN = dr["BookISBN"].ToString(),
                        BookTitle = dr["Title"].ToString(),
                        PurchaseCount = Convert.ToInt32(dr["PurchaseCount"])
                    };

                    mostBoughtBooks.Add(bookData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return mostBoughtBooks;
        }
        public List<OrdersData> GetAverageOrderValuePerCustomer()
        {
            List<OrdersData> averageOrderValues = new List<OrdersData>();

            try
            {
                cn.Open();
                cm = new SqlCommand("GetAverageOrderValuePerCustomer", cn);
                cm.CommandType = CommandType.StoredProcedure;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    OrdersData orderData = new OrdersData
                    {
                        CustomerID = dr["CustomerID"].ToString(),
                        AverageOrderValue = Convert.ToDouble(dr["AverageOrderValue"])
                    };

                    averageOrderValues.Add(orderData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetAverageOrderValuePerCustomer Error");
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return averageOrderValues;
        }

        public double GetAverageNumberOfItemsPerOrder()
        {
            double averageNumberOfItems = 0;

            try
            {
                cn.Open();
                cm = new SqlCommand("GetAverageNumberOfItemsPerOrder", cn);
                cm.CommandType = CommandType.StoredProcedure;
                object result = cm.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    averageNumberOfItems = Convert.ToDouble(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetAverageNumberOfItemsPerOrder Error");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return averageNumberOfItems;
        }

        public List<eachbookorder> GetOrdersForBook(string isbn)
        {
            List<eachbookorder> orders = new List<eachbookorder>();

            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT o.OrderID, o.Order_Date, c.Username, c.Shipping_Address, oi.Quantity, o.Order_Total FROM Orders o JOIN Customer c ON o.CustomerID = c.Username JOIN OrderItems oi ON o.OrderID = oi.OrderID JOIN Books b ON oi.BookISBN = b.ISBN WHERE b.ISBN = @ISBN", cn);
                cm.Parameters.AddWithValue("@ISBN", isbn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    eachbookorder order = new eachbookorder
                    {
                        OrderID = dr["OrderID"].ToString(),
                        OrderDate = dr["Order_Date"].ToString(),
                        Username = dr["Username"].ToString(),
                        Address = dr["Shipping_Address"].ToString(),
                        Quantity = dr["Quantity"].ToString(),
                        Total = dr["Order_Total"].ToString()
                    };

                    orders.Add(order);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return orders;
        }

    }
}

