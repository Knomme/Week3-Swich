using System;

namespace PersonalityTest
{
	class Program
	{
		static void Main(string[] args)
		{
			// Programm palub kasutajal sisestada tema lemmiku värvi;
			// Kui kasutaja sisestab "Punane" , konsool kuvab "Oled romantiline";
			// Kui kasutaja sisestab "Sinine" , konsool kuvab "Oled töökas";
			// Kui kasutaja sisestab "Roheline" , konsool kuvab "Oled looduse sõber";
			// Kui kasutaja sisestab midagi muud, konsool kuvab "Oled {userColor} ükssarvik;


			Console.WriteLine("Sisesta oma lemmik värv");
			string userColor = Console.ReadLine();

			if (userColor == "punane")

			{
				Console.WriteLine("Oled romantiline!");
			}

			else if (userColor == "sinine")
			{
				Console.WriteLine("Oled töökas!");
			}

			else if (userColor == "roheline")

			{
				Console.WriteLine("Oled looduse sõber!");
			}

			else

			{
				Console.WriteLine($"Oled {userColor} ükssarvik!");

			}

			Console.WriteLine("Kena päeva!");






		}
	}
}
