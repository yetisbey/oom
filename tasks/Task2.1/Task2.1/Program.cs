using System;
using System.IO;
using Newtonsoft.Json;

namespace Task2
{
	class MainClass
	{
		

		public static void Main (string[] args)
		{
			//while (true) {


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

			//}

			Schuhe asdf = new Schuhe (123m, 12, "adf", "asef", ShoeUnit.European);
			asdf.ToString ();


			Schuhe[] arr = new Schuhe[] {
				new Schuhe (99M,18d,"gelb","nike",ShoeUnit.European),
				new Schuhe (99M,18d,"gelb","nike",ShoeUnit.European),
				new Schuhe (99M,18d,"yellow","nike",ShoeUnit.European),
				new Schuhe (99M,18d,"yellow","nike",ShoeUnit.American),
				new Schuhe (99M,18d,"yellow","nike",ShoeUnit.American),
			};
			var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
			var json = JsonConvert.SerializeObject (arr, settings);
			Console.WriteLine (json);
			var path = Environment.GetFolderPath (Environment.SpecialFolder.Desktop);
			var filename = Path.Combine (path, "Schuhe.json");

			File.WriteAllText (filename, json);

			var readSchuhe = File.ReadAllText (filename);
			var g = JsonConvert.DeserializeObject<Schuhe[]>(readSchuhe, settings);
			foreach (var item in g) {
				item.ToString ();
			}
		
		}




	}


}
