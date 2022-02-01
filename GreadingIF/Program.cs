using System;

namespace GreadingIF
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

			if (userResult == 'A')

			{
				Console.WriteLine("Suurepärane!");
			}

			else if (userResult == 'B')

			{
				Console.WriteLine("Väga hea!");
			}

			else if (userResult == 'C')

			{
				Console.WriteLine("Hea!");
			}

			else if (userResult == 'D')

			{
				Console.WriteLine("Rahuldav!");
			}

			else if (userResult == 'E')

			{
				Console.WriteLine("Kasin!");
			}
			else if (userResult == 'F')

			{
				Console.WriteLine("Puudulik!");
			}

			else
				Console.WriteLine("Vale väärtus!");

		}
	}
}
