using System;

namespace Task2
{
	class MainClass
	{
		

		public static void Main (string[] args)
		{
			while (true) {


				Console.WriteLine ("Hello Everybod!");

				Console.WriteLine ("Marke: ");
				var a = Console.ReadLine ();
				Console.WriteLine ("Farbe: ");
				var b = Console.ReadLine ();
				Console.WriteLine ("Schuhgroesse");
				var c1 = Console.ReadLine ();
				Console.WriteLine ("Preis:");
				var d1 = Console.ReadLine ();


				try {
					var c = Convert.ToDouble (c1);
					var d = Convert.ToDecimal (d1);
					Schuhe eingabe = new Schuhe (d, c, b, a, ShoeUnit.European);	
					Console.WriteLine (eingabe.ToString ());
					
				} catch (Exception ex) {
					Console.WriteLine (ex.Message);
				} 

			}

			Schuhe asdf = new Schuhe (123m, 12, "adf", "asef", ShoeUnit.European);
			asdf.ToString ();

		}




	}


}
