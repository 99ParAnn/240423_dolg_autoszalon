using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240423_dolg_autoszalon
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1.
			Szemelyauto toyota = new Szemelyauto("Toyota", "Corolla", 2021, 8000000, 15000,5,6.5,"Feher");
			Terepjaro landrover = new Terepjaro("Land Rover", "Defender",2020, 15000000, 20000,"4WD",true,3500);
			AutoSalon peldaSalon = new AutoSalon();
			peldaSalon.UjJarmuHozzaadasa(toyota);
			peldaSalon.UjJarmuHozzaadasa(landrover);
			//4.
			peldaSalon.JarmuvekListazasa();

			//2.
            peldaSalon.JarmuEladasa("Toyota", "Corolla");
			peldaSalon.JarmuvekListazasa();

			//3.
			peldaSalon.JarmuKeresese("Land Rover", "Defender").JarmuInfo();
		}
	}
}
