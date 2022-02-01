using System;

namespace GreadingSwitch
{
	class Program
	{
		static void Main(string[] args)
		{

			// Programm küsib, mis hinde kasutaja sai;
			// Kui kastuaja sai "A" , konsool kuvab "Suurepärane!";
			// Kui kasutaja sai "B" , konsool kuvab "Väga hea!";
			// Kui kasutaja sai "C" , konsool kuvab "Hea!";
			// Kui kasutaja sai "D" , konsool kuvab "Rahuldav!";
			// Kui kasutaja sai "E" , konsool kuvab "Kasin!";
			// Kui kasutaja sai "F" , konsool kuvab "Puudulik!";
			// Kui kastuaja sisestab midagi muud, siis konsool kuvab "Vale väärtus!";

			Console.WriteLine("Sisesta oma tulemus!");
			char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

			switch (userResult)
			{
				case 'A':
					Console.WriteLine("Suurepärane!");
					break;
				
				case 'B':
					Console.WriteLine("Väga hea!");
					break;

				case 'C':
					Console.WriteLine("Hea!");
					break;

				case 'D':
					Console.WriteLine("Rahuldav!");
					break;

				case 'E':
					Console.WriteLine("Kasin!");
					break;

				case 'F':
					Console.WriteLine("Puudulik!");
					break;

				default:
					Console.WriteLine("Vale väärtus!");
					break;

			}




		}
	}
}
