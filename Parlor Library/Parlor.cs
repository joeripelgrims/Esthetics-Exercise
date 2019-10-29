using System.Text;

namespace Parlor_Library
{
	public class Parlor
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
		public Parlor()
		{
			Name = "Unnamed schools.";
			Location = "Unnamed place.";
			TelephoneNumber = "123-4567";
			ServicesList = "Unlisted services.";
			EmailAddress = "something@someone.someplace";
		}
		// Constructor overload 1. 4 parameters.
		public Parlor(string parlorName, string parlorLocation, string parlorTelephoneNumber, string parlorServicesList, string parlorEmailAddress)
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
}
