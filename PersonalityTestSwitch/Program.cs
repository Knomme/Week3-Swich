using System;

namespace PersonalityTestSwitch
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
			string userColor = Console.ReadLine().ToLower();


			switch (userColor)
			{
				case "punane":
					Console.WriteLine("Oled romantiline!");
					break;

				case "sinine":
					Console.WriteLine("Oled töökas!");
					break;

				case "roheline":
					Console.WriteLine("Oled looduse sõber!");
					break;

				default:
					Console.WriteLine($"Oled {userColor} ükssarvik!");
					break;
			}

			Console.WriteLine("Kena päeva!");




		}
	}
}
