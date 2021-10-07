using System;

namespace Arvauspeli_osa2
{
	class Arvauspeli_osa2
	{
		static void Main(string[] args)
		{
			// Muutetaan peliä niin, että pelaaja voi arvata luvun uudelleen
			// niin kauan, kuin arvaus oli väärä

			int salainenLuku = 50;
			int pelaajanArvaus = int.Parse(Console.ReadLine());


			// Ympäröi if-lause while-loopilla, jonka vertailu on aina true
			// Siirrä pelaajan arvauksen lukeminen loopin alkuun
			// Huom! muuttujaa ei esitellä uudelleen (int pelaajanArvaus = ...)
			// vaan sille vain asetetaan uusi arvo (pelaajanArvaus = ...)
			// Homaa myös, että ohjelman alussa muuttujalle riittää pelkkä esittely (int pelaajanArvaus;) eli sille ei vielä aseteta mitään arvoa

			if (pelaajanArvaus == salainenLuku)
			{
				Console.WriteLine("Arvasit oikein!");
				// Tässä kohdassa ollaan varmoja, että pelaaja on arvannut oikein
				// ja hänelle on tulostettu tieto siitä
				// Loopista voidaan siis poistua käyttämällä break sanaa

			}
			else
			{
				Console.WriteLine("Arvasit väärin! Kokeile uudelleen");
			}
		}
	}
}
