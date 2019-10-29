using System;
using System.Collections.Generic;

namespace Parlor_Library
{
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
}
