using System;
using System.Collections.Generic;
using System.Text;

namespace Parlor_Library
{
    public abstract class Person // This abstract class can't be instantiated directly.
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string TelephoneNumber { get; set; }
        public abstract string Contact(); // This method will require implementation on all subclasses, unlike an interface.
        public virtual string Card() // Example of a virtual method that we can optionally use in subclasses.
        {
            var sb = new StringBuilder();
            var timeStamp = string.Format("Sent on {0:D} at {0:t}", DateTime.Now);
            sb.AppendLine(timeStamp);
            sb.AppendLine("1");
            sb.AppendLine(Name);
            sb.AppendLine(EmailAddress);
            sb.AppendLine(TelephoneNumber);
            return sb.ToString();
        }

    }
    public class Customer : Person
    {
        static public List<string> customers = new List<string>() { "Joeri Pelgrims", "Joey Pelgrims", "Monique Reynders", "Marcel Pelgrims", "Jose Pelgrims" };
        public string Appointment { get; set; }
        static public void AddCustomer()
        {
            Console.Clear();
            Console.WriteLine("Adding a new customer. Please write the full name:");
            customers.Add(Console.ReadLine());
        }
        static public void ShowCustomerList()
        {
            Console.Clear();
            Console.WriteLine("Customer list:");
            int i = 1;
            foreach (string customer in customers)
            {
                Console.Write($"[{i}] ");
                Console.WriteLine(customer);
                i++;
            }
        }
        static public void RemoveCustomer()
        {
            Console.Clear();
            Console.WriteLine("Removing a customer. Please select who to remove:");
            Customer.ShowCustomerList();
            customers.RemoveAt(int.Parse(Console.ReadLine()) - 1);
        }
        public override string Contact() // Example of overridden mandatory abstract class.
        {
            return "bananas";
        }
        public override string Card() // Example of overridden optional virtual class.
        {
            var original = base.Card();
            var sb = new StringBuilder(original);
            sb.AppendLine("This is a confidential message.");
            return sb.ToString();
        }

        /* TODO
         
        public Customer()
        {
            name = "Unnamed Customer";
            emailAddress = "someone@someplace.something";
            telephoneNumber = "123-456";
            appointments = "Unknown appointment";
        }
        public Customer(string customerName, string customerEmailAddress, string customerTelephoneNumber, string customerAppointments)
        {
            name = customerName;
            emailAddress = customerEmailAddress;
            telephoneNumber = customerTelephoneNumber;
            appointments = customerAppointments;
        }*/
    }
    public class Parlors
    {
        public string Location { get; set; }
        public string Name { get; set; }
        public string TelephoneNumber { get; set; }
        public string ServicesList { get; set; }
        public string EmailAddress { get; set; }

        static public void addParlor() { }
        // Add a parlor to the database.
        static public void removeParlor() { }
        // Remove a parlor from the database.
        static public void editParlor() { }
        // Edit the data of the parlor.
        static public void showParlors() { }
        // Show a list of currently open parlors.

        // Basic constructor. No parameters.
        public Parlors()
        {
            Name = "Unnamed schools.";
            Location = "Unnamed place.";
            TelephoneNumber = "123-4567";
            ServicesList = "Unlisted services.";
            EmailAddress = "something@someone.someplace";
        }
        // Constructor overload 1. 4 parameters.
        public Parlors(string parlorName, string parlorLocation, string parlorTelephoneNumber, string parlorServicesList, string parlorEmailAddress)
        {
            Name = parlorName;
            Location = parlorLocation;
            TelephoneNumber = parlorTelephoneNumber;
            ServicesList = parlorServicesList;
            EmailAddress = parlorEmailAddress;
        }
        // TODO: VALIDATION, TRIM, CASE

        // Redefining the ToString() method so that its output is predictable. Do this for each class.
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(", ");
            sb.Append(Location);
            sb.Append(", ");
            sb.Append(TelephoneNumber);
            sb.Append(", ");
            sb.Append(EmailAddress);
            return sb.ToString();
        }
    }
    public class Appointments
    {
        public static Queue<string> appointments = new Queue<string>();

        private string Date { get; set; }
        private string Name { get; set; }
        private string Purpose { get; set; }
        private string List { get; set; }

        public static void showAppointmentsList()
        {
            Console.Clear();
            Console.WriteLine("Current appointments:");
            foreach (string apt in appointments)
            {
                Console.WriteLine(apt);
            }
        }
        public static void addAppointment()
        {
            Console.Clear();
            Console.WriteLine("Create an appointment for:");
            appointments.Enqueue(Console.ReadLine());
        }
        public static void removeAppointment()
        {
            Console.Clear();
            Console.WriteLine("Complete appointment:");
            appointments.Dequeue();
        }
        public static void editAppointment() { }
        //public Appointments()
        //{
        //    name = "Unknown name";
        //    date = "31/12/1999";
        //    purpose = "Unknown purpose";
        //    List = "Empty list";
        //}
        //public Appointments(string appointmentDate, string appointeeName, string appointmentPurpose, string appointmentList)
        //{
        //    name = appointeeName;
        //    date = appointmentDate;
        //    purpose = appointmentPurpose;
        //    List = appointmentList;
        //}
    }
    public class Services
    {
        private string name { get; set; }
        private string cost { get; set; }
        private string length { get; set; }
        private string description { get; set; }
        private string list { get; set; }

        static public void showServicesList() { }
        // Get a list of available services, their cost and length.
        static public void addService() { }
        // Add a service to the database.
        static public void removeService() { }
        // Remove a service from the database.
        static public void showService() { }
        // Show a specified service's details.
        public Services()
        {
            name = "Unknown name";
            cost = "Unknown cost";
            length = "Unknown length";
            description = "Unknown description";
            list = "Unknown list";
        }
        public Services(string serviceName, string serviceCost, string serviceLength, string serviceDescription, string serviceList)
        {
            name = serviceName;
            cost = serviceCost;
            length = serviceLength;
            description = serviceDescription;
            list = serviceList;
        }
    }
    public class Product
    {
        public static Dictionary<string, string> pricelist = new Dictionary<string, string>();

        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

        static public void sellProduct()
        {
            Console.Clear();
            Console.WriteLine("Removing product from inventory:");
            pricelist.Remove(Console.ReadLine());
        }

        static public void stockProduct()
        {
            Console.Clear();
            Console.WriteLine("Adding product to inventory:");
            //pricelist.Add(Console.ReadLine(), Console.ReadLine());
            pricelist[Console.ReadLine()] = Console.ReadLine();
        }

        static public void showProducts()
        {
            Console.Clear();
            Console.WriteLine("Product list:");
            foreach (KeyValuePair<string, string> product in pricelist)
            {
                Console.WriteLine(product);
            }
        }

        static public void searchProducts() { }
        // Search product catalog by name.
        // TO DO:
        /*
        public Product()
        {
            list = "Unknown list";
            description = "Unknown description.";
            priceList = "Unknown pricelist.";
        }
        public Product(string productList, string productDescription, string productPriceList)
        {
            list = productPriceList;
            description = productDescription;
            priceList = productPriceList;
        }
        */
    }
}

