using System;
using System.Collections;
using System.Net;

namespace Task2
{
	public class Schuhe 
	{
		//private fields
		private decimal _preis;
		private double _schuhgroesse;
		private string _farbe;
		private string _marke;
		//Constructor
		public Schuhe (decimal preis, double schuhgroesse, string farbe, string marke)
		{
			Preis = preis;
			Schuhgroesse = schuhgroesse;
			Farbe = farbe;
			Marke = marke;

		}
			

		public void changePreis(decimal neuPreis)
		{
			Preis = neuPreis;

		}



		//public property
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
				if (value < 0) {
				
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


		public string ToString(){
			return ("Marke: " + Marke +"\n"+"Schuhgröße: " + Schuhgroesse+"\n"+"Farbe: " + Farbe  +"\n"+"Preis: " + Preis + "€\n" ); 
	
		}


	}

}