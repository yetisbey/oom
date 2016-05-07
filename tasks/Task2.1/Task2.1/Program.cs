using System;

namespace Task2
{
	class MainClass
	{
		

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello Everybod!");

			Console.WriteLine ("Marke: ");
			var a = Console.ReadLine ();
			Console.WriteLine ("Farbe: ");
			var b = Console.ReadLine ();
			Console.WriteLine ("Schuhgroesse");
			var c = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine ("Preis:");
			var d = Convert.ToDecimal (Console.ReadLine ());


		
			Schuhe eingabe = new Schuhe (d, c, b, a);


			Console.WriteLine (eingabe.ToString ());
		}




	}


}
