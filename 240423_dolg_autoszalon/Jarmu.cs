using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240423_dolg_autoszalon
{
	internal class Jarmu
	{
		public string Gyarto { get; set; }
		public string Modell { get; set; }
		public int Evjarat { get; set; }
		public int AlapAr { get; set; }
		public int KilometerAllas { get; set; }

		public Jarmu(string gyarto, string modell, int evjarat, int alapar, int kilometerAllas)
		{
			Gyarto = gyarto;
			Modell = modell;
			Evjarat = evjarat;
			AlapAr = alapar;
			KilometerAllas = kilometerAllas;
		}
		virtual public void JarmuInfo()
		{
			Console.WriteLine($"Gyarto: {Gyarto}");
			Console.WriteLine($"Modell: {Modell}");
			Console.WriteLine($"Evjarat:{Evjarat}");
			Console.WriteLine($"Alapar: {AlapAr}");
			Console.WriteLine($"Kilometerallas: {KilometerAllas}");
		}
		public int ArKalkulacio()
		{
			int HanyEvesAKocsi = DateTime.Now.Year-Evjarat;
			int KalkulaltAr = AlapAr - HanyEvesAKocsi * 100000;
			return KalkulaltAr > 1000000 ? KalkulaltAr : 1000000;
			//nemtom mennyibe kerül egy kocsi, de nem akarom, hogy véletlenül negatív pénzért adjuk el
			//úgyhogy min 1 millióért adjuk
		}
		public void KmAllasFrissites(int km)
		{
			KilometerAllas += km;
		}

	}

}
