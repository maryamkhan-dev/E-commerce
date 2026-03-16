using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_project
{
    public class Manager
    {

        private string username;
        private string firstName;
        private string lastName;
        private string password;
        private string phoneNumber;
        private string email;
        private string joiningdate;
        private string type;

        public Manager(string username, string password, string firstName, string lastName, string joiningdate, string type, string phoneNumber, string email)
        {
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.joiningdate = joiningdate;
            this.type = type;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public Manager()
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

        public string JoiningDate
        {
            get { return joiningdate; }
            set { joiningdate = value; }
        }


        public string Type
        {
            get { return type; }
            set { type = value; }
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
