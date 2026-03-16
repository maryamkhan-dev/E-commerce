using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_project
{
    public class Customer
    {
        private string username;
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string password;
        private string state;
        private string phoneNumber;
        private string email;

        public Customer(string username, string password, string firstName, string lastName, string address, string city, string state, string phoneNumber, string email)
        {
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;   
            this.address = address;
            this.city = city;
            this.state = state;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public Customer()
        {

        }

        public string Password
        {
            get { return password; }
            set { password = value; }   
        }


        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
