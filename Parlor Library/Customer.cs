using System;
using System.Collections.Generic;
using System.Text;

namespace Parlor_Library
{
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
}
