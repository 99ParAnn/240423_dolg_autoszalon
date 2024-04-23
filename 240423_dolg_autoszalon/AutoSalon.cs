using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace _240423_dolg_autoszalon
{
	internal class AutoSalon
	{
		List<Jarmu> Jarmuvek;
		public AutoSalon() { Jarmuvek = new List<Jarmu>(); }
		public void JarmuvekListazasa()
		{
			foreach (var jarmu in Jarmuvek)
			{
				jarmu.JarmuInfo();
                Console.WriteLine("-----------------");
            }
		}
		public void UjJarmuHozzaadasa(Jarmu jarmu) {
			Jarmuvek.Add(jarmu);
		}
		public bool JarmuEladasa(string Gyarto, string Modell)
		{
            int index = 0;
			do
			{
				if (Jarmuvek[index].Modell == Modell && Jarmuvek[index].Gyarto == Gyarto)
				{
					Jarmuvek.Remove(Jarmuvek[index]);
					Console.WriteLine("Jarmu eladasa sikeres!");
				}
				index++;
			} while (index < Jarmuvek.Count && !(Jarmuvek[index].Modell == Modell && Jarmuvek[index].Gyarto == Gyarto));

            return index < Jarmuvek.Count;
		}
		public Jarmu JarmuKeresese(string Gyarto, string Modell)
		{
			int index = 0;
			while (index > Jarmuvek.Count && !(Jarmuvek[index].Modell == Modell && Jarmuvek[index].Gyarto == Gyarto))
			{
				index++;
			}
			return index < Jarmuvek.Count ? Jarmuvek[index] : null;
		} 
	}
}
