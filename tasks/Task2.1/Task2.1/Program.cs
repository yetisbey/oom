using System;
using System.IO;
using Newtonsoft.Json;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task2

{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//while (true){


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


			var arr = new ISchuhWare[] {
				new Schuhe (99M, 18d, "gelb", "nike", ShoeUnit.European),
				new Schuhe (99M, 18d, "gelb", "nike", ShoeUnit.European),
				new Schuhe (99M, 18d, "yellow", "nike", ShoeUnit.European),
				new Schuhe (99M, 18d, "yellow", "nike", ShoeUnit.American),
				new Schuhe (99M, 18d, "yellow", "nike", ShoeUnit.American),
				new SchuhBand (50, "grün", 0.2),
				new SchuhBand (45, "gelb", 0.2)
			};
			var settings = new JsonSerializerSettings () {
				Formatting = Formatting.Indented,
				TypeNameHandling = TypeNameHandling.Auto
			};
			var json = JsonConvert.SerializeObject (arr, settings);
			Console.WriteLine (json);
			var path = Environment.GetFolderPath (Environment.SpecialFolder.Desktop);
			var filename = Path.Combine (path, "Schuhe.json");

			File.WriteAllText (filename, json);

			var readSchuhe = File.ReadAllText (filename);
			var g = JsonConvert.DeserializeObject<ISchuhWare[]> (readSchuhe, settings);
			foreach (var item in g) {
				item.ToString ();
			}


			var sub = new Subject <Schuhe> ();
			sub
				.Where (x => x.Preis >= 30)
			.Subscribe (x => Console.WriteLine ("Received: " + x));

			var t = new Thread (() => {
				var i = new [] {
					new Schuhe (10M, 18.4, "gelb", "nike", ShoeUnit.European),
					new Schuhe (30M, 18.0, "schwarz", "timberland", ShoeUnit.European),
					new Schuhe (99M, 18.2, "orange", "addidas", ShoeUnit.European),

				};
				int c = 0;

				while (true) {
					Thread.Sleep (250);
					sub.OnNext (i [c]);
					Console.WriteLine ($"sent {i}");
					c++;
					if (c >= 3)
						c = 0;
											
				}
			});
			t.Start ();

			 


		}
		


	}


}
