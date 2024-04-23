using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _240423_dolg_autoszalon
{
	internal class Terepjaro : Jarmu
	{
		string Hajtas {get; set;}
		bool OffroadKepessegek { get;set;}
		int VontatoKepesseg { get; set;}
		public Terepjaro(string gyarto, string modell, int evjarat, int alapar, int kilometerAllas, string hajtas, bool offroadKepessegek, int VontatoKepesseg) : base(gyarto, modell, evjarat, alapar, kilometerAllas)
		{
			Hajtas = hajtas;
			OffroadKepessegek = offroadKepessegek;

		}
		public override void JarmuInfo()
		{
			base.JarmuInfo();
            Console.WriteLine("");
        }
		public void VontatoKepessegBeallitasa(int kepesseg)
		{
			VontatoKepesseg = kepesseg;
		}
		//csak azt írom meg, ami a feladatban van, de ezzel több problémát is látok
		//mi van, ha a kocsi már fel van szerelve; +alapból nullára kellene-e állítanom az offroad képességeket
		//a feladat nem érinti, úgyhogy én sem, mert nincs annyi időm
		public void OffroadCsomagFelszerel()
		{
			int ArMennyivelTobb = 20000;
			AlapAr = AlapAr + ArMennyivelTobb;
			OffroadKepessegek = true;
		}
	}
}
