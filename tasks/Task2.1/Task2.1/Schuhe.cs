﻿using System;
using System.Collections;
using System.Net;


namespace Task2
{
	public enum ShoeUnit
	{
		American,
		European
	}

	public enum MUnit
	{
		Zoll = 254,
		Cm = 100
	}

	public class Schuhe : ISchuhWare
	{
		//private fields / properties
		private decimal _preis;
		private double _schuhgroesse;
		private string _farbe;
		private string _marke;
		private ShoeUnit Einheit { get; }

		//Constructor
		public Schuhe (decimal preis, double schuhgroesse, string farbe, string marke, ShoeUnit einheit)
		{
			Einheit = einheit;
			Preis = preis;
			Schuhgroesse = schuhgroesse;
			Farbe = farbe;
			Marke = marke;




		}

		public double GetGroesse(int s)
		{
			return ConvertToShoeUnit(Schuhgroesse, Einheit, (ShoeUnit)s);

		}
			
		//methode 
		public void changePreis(decimal neuPreis)
		{
			Preis = neuPreis;

		}

		public double ConvertToShoeUnit (double schuhGroesse, ShoeUnit von, ShoeUnit zu)
		{
			switch (von) {
			case ShoeUnit.American:
				var sgza = (schuhGroesse + 22) / 3;
				var sgcma = ConvertToMUnit (sgza, MUnit.Zoll, MUnit.Cm);
				return (sgcma + 1.5) * 1.5;
			case ShoeUnit.European:
				var sgcme = (schuhGroesse / 1.5) - 1.5;
				var sgze = ConvertToMUnit (sgcme, MUnit.Cm, MUnit.Zoll);
				return sgze * 3 - 22; 
			default:
				return 0;
			}


		}

		public double ConvertToMUnit(double value, MUnit von, MUnit zu)
		{
			/*value = value / von;
			value = value * zu;
			return value;*/
			return (value / ((int)von / 100) * ((int)zu / 100));
		}




		//public property getter/setter
		public decimal Preis
		{
			
			get
			{ 
				return _preis; 
			}
			set
			{ 
				if (value < 0) 
				{
					throw new Exception("Preis muss positiv sein.");
				}
				_preis = value;
			}
		}

		public double Schuhgroesse
		{
			get
			{ 
				return _schuhgroesse;
			}
			set 
			{ 
				if (value < 10 || value >48) {
				
					throw new Exception ("Ungültiger Schuhegoesse");

				}
				_schuhgroesse = value;

			}
		}

		public string Farbe
		{
			get 
			{
				return _farbe;
			}
			set
			{
				_farbe = value;

			}
		}

		public string Marke
		{
			get
			{ 
				return _marke;
			}
			set
			{ 
				_marke = value;
			}
		}


		public override string ToString(){
			return ("Marke: " + Marke +"\n"+"Schuhgröße: " + Schuhgroesse+"\n"+"Farbe: " + Farbe  +"\n"+"Preis: " + Preis + "€\n" ); 
	
		}


	}

}