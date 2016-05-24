using System;
using Task2;
using NUnit.Framework;
using Newtonsoft.Json;
namespace Task2
{
	public class Test
	{
		[Test]
		public void Test01()
		{
			Schuhe var1 = new Schuhe (99M,18d,"gelb","nike",ShoeUnit.European);
			var1.changePreis (88M);
			Assert.IsTrue (var1.Preis == 88M);
		}
		[Test]
		public void Test02()
		{
			Schuhe var1 = new Schuhe (99M,18d,"yellow","nike",ShoeUnit.European);
			Assert.IsTrue (var1.Farbe == "gelb");
		}
		[Test]
		public void Test03()
		{
			Schuhe[] arr = new Schuhe[] {
				new Schuhe (99M,18d,"gelb","nike",ShoeUnit.European),
				new Schuhe (99M,18d,"gelb","nike",ShoeUnit.European),
				new Schuhe (99M,18d,"yellow","nike",ShoeUnit.European),
				new Schuhe (99M,18d,"yellow","nike",ShoeUnit.European),
				new Schuhe (99M,18d,"yellow","nike",ShoeUnit.European),
			};
			var json = JsonConvert.SerializeObject (arr);
			Console.WriteLine (json);
		}
	}
}

