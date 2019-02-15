using System;

namespace NamuDarbai2
{
	class Program
	{
		
		public static void Main(string[] args)
		{
			// Masyvo sukurimas
			MasyvasIO ArrayIO 		= new MasyvasIO();
			
			int ilgis     = ArrayIO.PildykIlgi();
			int[] masyvas = ArrayIO.PildykMasyva(ilgis);
			
			ArrayIO.SpausdinkMasyva(masyvas);
			
			
			// Masyvo apdorojimas
			Apdorok ArrayHelper 	= new Apdorok(masyvas);
			
			if(ArrayHelper.neigiamiKartojasi.Length > 0) {
				Console.WriteLine("");
				Console.WriteLine("Neigiami kartojantys elementai");
				ArrayIO.SpausdinkMasyva(ArrayHelper.neigiamiKartojasi);
			} else {
				Console.WriteLine("Neigiamu kartojanciu elementu nerasta");
			}
			
			// Masyvo rusiavimas
			Rikiavimas SortHelper 	= new Rikiavimas(masyvas);
			
			Console.WriteLine("");
			Console.WriteLine("Originalus masyvas: ");
			ArrayIO.SpausdinkMasyva(masyvas);
			
			Console.WriteLine("Mazejimo tvarka");
			ArrayIO.SpausdinkMasyva(SortHelper.RikiuokM());
			
			Console.WriteLine("Didejimo tvarka");
			ArrayIO.SpausdinkMasyva(SortHelper.RikiuokD());
			
			Console.ReadKey(true);
		}
	}
}