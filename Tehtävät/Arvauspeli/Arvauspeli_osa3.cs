using System;

namespace Arvauspeli_osa3
{
	class Arvauspeli_osa3
	{
		static void Main(string[] args)
		{
			// Muutetaan ohjelmaa niin, että salainen luku on satunnainen
			// C# kielestä löytyy satunnaislukugeneraattori nimeltään Random
			// Se on olio, joka pitää ensin luoda
			// Olio luodaan new sanalla:
			// <tyyppi> <nimi> = new <tyyppi>();


			// Tämän jälkeen voidaan käyttää Random olion funktiota .Next()
			// Funktio tarvitsee kaksi parametriä, satunnaisen luvun ala- sekä yläraja
			// Esimerkiksi: olionNimi.Next(0, 100);
			int salainenLuku = 50;
			int pelaajanArvaus;

			while (true)
			{
				pelaajanArvaus = int.Parse(Console.ReadLine());

				// Muokataan if-else lausetta niin, että se kertoo onko väärä arvaus liian iso vai pieni

				// Luo ensin else-if lohko
				// Vertaa onko arvattu luku isompi kuin salainen luku
				// Ilmoita pelaajalle sen sisällä, että arvaus oli liian iso

				// Luo lopuksi else lohko
				// Ensimmäiseen lohkoon mennään jos arvaus on oikein, seuraavaan jos se on liian iso
				// Loogisesti viimeiseen lohkoon tullaan siis vain jos arvaus oli liian pieni
				// Ilmoita pelaajalle sen sisällä, että arvaus oli liian pieni

				if (pelaajanArvaus == salainenLuku)
				{
					Console.WriteLine("Arvasit oikein!");
					break;
				}


			}
		}
	}
}
