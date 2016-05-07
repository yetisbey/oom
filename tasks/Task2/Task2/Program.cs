using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;

namespace Task2
{
	public class Book
	{
		private double p_price;

		public Book (string bookName, decimal bookID, decimal price  )
		{


			Console.WriteLine ("somthing else!");

		}

		public string bookName {get;set;}
		public decimal bookID {get; set;}
		public decimal price {get; private set; }


		public void GetNewPrice (decimal newPrice)
		{
			if(newPrice<0) throw new Exception("PRICE HAS TO BE POSITIV."); 

		}
	}

}


