using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDemo
{
    public class Customer
    {
        // Private Fields
        private string _firstName;
        private string _lastName;
        private string _email;
        private int _age;

        // Default Constructor
        public Customer()
        {
            _firstName = "Empty First Name";
            _lastName = "Empty Last Name";
            _email = "default@example.com";
            _age = 30; // Default age
        }

        // Constructor with optional parameters
        public Customer (string firstName,string lastName, string email ="notprovided@example.com", int age = 0)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _age = age;
        }
             
        // Public properties for accessing private fields
        public  string FirstName {  
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}
