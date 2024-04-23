using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240423_dolg_autoszalon
{
	internal class Szemelyauto : Jarmu
	{
		int UlesekSzama { get; set; }
		double Fogyasztas { get; set; }
		public string Szin { get; set; }
		public Szemelyauto(string gyarto, string modell, int evjarat, int alapar, int kilometerAllas, int ulesekSzama, double fogyasztas, string szin) : base(gyarto, modell, evjarat, alapar, kilometerAllas)
		{
			UlesekSzama = ulesekSzama;
			Fogyasztas = fogyasztas;
			Szin = szin;
		}
		public override void JarmuInfo()
		{
			base.JarmuInfo();
            Console.WriteLine($"Ulesek szama: {UlesekSzama}");
            Console.WriteLine($"Fogyasztas: {Fogyasztas}");
			Console.WriteLine($"Szin: {Szin}");

		}
		public void SzinFrissitese(string ujSzin)
		{
			Szin = ujSzin;
		}
		public void KenyelmiExtraBeszerelese(string ExtraNeve)
		{
			int ArMennyivelTobb;
			switch (ExtraNeve)
			{
				case "a":
					ArMennyivelTobb = 2000;
					break;
				case "b":
					ArMennyivelTobb = 3000;
					break;
				case "c":
					ArMennyivelTobb = 6000;
					break;
				case "d":
					ArMennyivelTobb = 15000;
					break;
				case "e":
					ArMennyivelTobb = 100;
					break;
				default:
					ArMennyivelTobb = 42;
					break;
			}
			AlapAr = AlapAr + ArMennyivelTobb;
		}
	}

}

