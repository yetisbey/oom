using System;

namespace Task2
{
	public class SchuhBand : ISchuhWare
	{
		private double _laenge;
		private string _farbe;
		private double Einheit { get; }

		//Constructor
		public SchuhBand (double laenge, string farbe, double einheit)
		{
			Laenge = laenge;
			Farbe = farbe;
			Einheit = einheit;

		}

		public double GetGroesse(int s)
		{
			return ConvertToMUnit(Laenge, Einheit, s);

		}
		public void checkColor(string neuFarbe)
		{
			neuFarbe = "Rosa";
			Farbe = neuFarbe;

		}


		public double Laenge
		{
			get {
				return _laenge; 
			}
			set {
				if (value < 0)
					throw new Exception ("Länge muss positiv sein.");
				_laenge = value;
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
	

		public double ConvertToMUnit(double value, double von, double zu)
		{
			/*value = value / von;
			value = value * zu;
			return value;*/
			return value / von * zu;
		}
	}
}

