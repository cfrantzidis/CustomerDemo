using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Customer instance
            Customer customer = new Customer("Christos", "Frantzidis", "cfrantzidis@lincoln.ac.uk", 41);

            // Using the default constructor
            Customer customer1 = new Customer();

            // Using the constructor that takes two parameters
            Customer customer2 = new Customer("John", "Stevenson");

            // Access and display customer details
            Console.WriteLine($"Default Customer1 Details: {customer1.FirstName} {customer1.LastName}, Email: {customer1.Email}, Age: {customer1.Age} ");
            Console.WriteLine($"Customer2 Details: {customer2.FirstName} {customer2.LastName}, Email: {customer2.Email}, Age: {customer2.Age} ");
            Console.WriteLine($"Customer Details: {customer.FirstName} {customer.LastName}, Email: { customer.Email}, Age: { customer.Age} ");

            // Modify customer details
            customer.FirstName = "Jane";
            customer.LastName = "Smith";
            customer.Email = "jane.smith@example.com";
            customer.Age = 28;

            // Display updated details
            Console.WriteLine($"Updated Customer Details: {customer.FirstName} {customer.LastName}, Email: {customer.Email}, Age: {customer.Age} ");
            Console.WriteLine("------------------------");
            Console.WriteLine("This is an additional change");
            Console.WriteLine("This is an additional change");
            Console.WriteLine("This is an additional change");
            Console.WriteLine("This is an additional change");
            Console.WriteLine("This is an additional change");
            Console.WriteLine("This is an additional change");
            Console.WriteLine("This is an additional change");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
