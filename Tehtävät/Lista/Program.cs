using System;

namespace Lista
{
	class Program
	{
		static void Main(string[] args)
		{
			// Täyty Lista luokka niin että ohjelma toimii
			Lista omaLista = new Lista();
			omaLista.Lisaa(2);
			Console.WriteLine(omaLista.Koko()); // Tulostaa 1
			omaLista.Lisaa(5);
			Console.WriteLine(omaLista.Koko()); // Tulostaa 2
			omaLista.Lisaa(10);
			Console.WriteLine(omaLista.Koko()); // Tulostaa 4
			omaLista.Lisaa(52);
			Console.WriteLine(omaLista.Koko()); // Tulostaa 4
			omaLista.Lisaa(74);
			Console.WriteLine(omaLista.Koko()); // Tulostaa 8

		}
	}

	// Esitellään uusi luokka
	class Lista
	{
		// Vähimmäis muuttujat, jotka tarvitaan listan toiminnallisuuteen
		// Pidetään muuttujat yksityisinä, koska muuttujien ulkopuolinen
		// manipuloiminen rikkoisi listan
		private int[] data;
		private uint kaytossaOlevaKoko;

		// Luokan konstruktori
		public Lista()
		{
			// Alusta lista niin että sen taulukon koko on yksi ja kaytossaOlevaKoko nolla

		}

		// Funktio, jolla lisätään uusi alkio listaan
		public void Lisaa(int luku)
		{
			// Katsotaan, onko kaikki taulukon alkiot käytössä
			if (kaytossaOlevaKoko >= data.Length)
			{
				// Kaikki alkiot ovat käytössä, joten taulukko täytyy kirjoittaa uudelleen
				// Esittele uusi taulukko, jonka koko on kaksi kertaa vanhan taulukon koko
				// Tämän jälkeen tee for-loop, jossa kopioit vanhan taulukon alkiot uuteen taulukkoon
				// Lopuksi aseta uusi taulukko data muuttujaan

			}
			else
			{
				// Jos data taulukossa on tilaa niin lisätään vain uusi luku kaytossaOlevaKoko indeksille

			}
			// Lopuksi täytyy muistaa kasvattaa kaytossaOlevaKoko muuttujaa yhdellä

		}

		public int Koko()
		{
			return data.Length;
		}
	}
}
