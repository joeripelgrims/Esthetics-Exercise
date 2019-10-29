
namespace Parlor_Library
{
	public class Service
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
		public Service()
		{
			name = "Unknown name";
			cost = "Unknown cost";
			length = "Unknown length";
			description = "Unknown description";
			list = "Unknown list";
		}
		public Service(string serviceName, string serviceCost, string serviceLength, string serviceDescription, string serviceList)
		{
			name = serviceName;
			cost = serviceCost;
			length = serviceLength;
			description = serviceDescription;
			list = serviceList;
		}
	}
}
