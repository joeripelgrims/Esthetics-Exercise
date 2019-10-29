using System;
using System.Collections.Generic;

namespace Parlor_Library
{
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
