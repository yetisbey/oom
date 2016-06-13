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
			Assert.IsTrue (var1.Preis == 176M);
		}
		[Test]
		public void Test02()
		{
			Schuhe var1 = new Schuhe (99M, 15d, "green", "nike", ShoeUnit.European);
			double b = 1;
			double c = 1;
			var1.ConvertToMUnit (var1.Schuhgroesse, b, c);
			Assert.IsTrue (var1.Schuhgroesse == 15.0);
		}
		[Test]
		public void Test03()
		{

			Schuhe var1 = new Schuhe (99M, 18d, "yellow", "nike", ShoeUnit.European);
			var1.GetGroesse(18);
			Assert.IsTrue (var1.Schuhgroesse == 18);

		}
		[Test]
		public void Test04()
		{
			Schuhe var2 = new Schuhe (100M, 38d, "grün", "adidas", ShoeUnit.American);
			var2.GetGroesse (38);
			Assert.IsTrue (var2.Schuhgroesse == 38);

		}
		[Test]
		public void Test05()
		{
			Schuhe var1 = new Schuhe (123m, 12, "adf", "asef", ShoeUnit.European);
			var1.checkColor("adf" );
			Assert.IsTrue (var1.Farbe == "Grün" );


		}
		[Test]
		public void Test06()
		{
			SchuhBand band = new SchuhBand (18d,"gelb", 18);
			band.GetGroesse (38);
			Assert.IsTrue (band.Laenge ==18);

		}
		[Test]
		public void Test07()
		{	
			SchuhBand band = new SchuhBand (18d,"schwarz", 18);
			band.checkColor ("irgendwas");
			Assert.IsTrue (band.Farbe=="Rosa");
		}
		[Test]
		public void Test08()
		{
			Schuhe var1 = new Schuhe (99M,18d,"yellow","nike",ShoeUnit.European);
			Assert.IsTrue (var1.Farbe == "yellow");

		}
	}
}

