

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przychodnia
{
    class Program
    {
        private static Przychodnia przychodnia = new Przychodnia();
        private static char klawisz;
        public static void WczytajKlawisz()
        {
            klawisz = Convert.ToChar(Console.ReadLine());
        }
        public static void DodajLekarza()
        {
            string imie = "";
            string nazwisko = "";
            string specjalnosc = "";
            Console.WriteLine("Dodaj Lekarza!!!!!!");
            while (String.IsNullOrEmpty(imie))
            {
                Console.WriteLine("Podaj imie");
                imie = Console.ReadLine();
            }

            while (String.IsNullOrEmpty(nazwisko))
            {
                Console.WriteLine("Podaj nazwisko");
                nazwisko = Console.ReadLine();
            }
            while (String.IsNullOrEmpty(specjalnosc))
            {
                Console.WriteLine("Podaj specjalnosc");
                specjalnosc = Console.ReadLine();
            }


            przychodnia.UstawLekarza(imie, nazwisko, specjalnosc);
            Console.WriteLine("Dodano Lekarza!");


        }
        public static void Legenda()
        {
            Console.WriteLine("Co chcesz zrobić?");

            Console.WriteLine("A - Dodaj pacjenta do kolejki");
            Console.WriteLine("B - wypisz liste pacjentów");
            Console.WriteLine("C - Generuj Raport");
            Console.WriteLine("X - wyjście z aplikacji");
        }

        public static void Aplikacja()
        {
            string imie = "";
            string nazwisko = "";

            string choroba = "";
            int wiek = 130;
            if (klawisz == 'A' || klawisz == 'a')
            {
                while (String.IsNullOrEmpty(imie))
                {
                    Console.WriteLine("Podaj imie");
                    imie = Console.ReadLine();
                }

                while (String.IsNullOrEmpty(nazwisko))
                {
                    Console.WriteLine("Podaj nazwisko");
                    nazwisko = Console.ReadLine();
                }
                while (String.IsNullOrEmpty(choroba))
                {
                    Console.WriteLine("Podaj Chorobe");
                    choroba = Console.ReadLine();
                }
                Console.WriteLine("Podaj wiek pcjenta");
                while (!int.TryParse(Console.ReadLine(), out wiek) || wiek > 120 || wiek < 0)
                {
                    Console.WriteLine("Podaj poprawy wiek ");

                }
                przychodnia.DodajDoKolejki(imie,nazwisko,wiek,choroba);
            }
            else if (klawisz == 'B' || klawisz == 'b')
            {
                Console.WriteLine(przychodnia.ToString());
            }
            else if (klawisz == 'c' || klawisz == 'C')
            {
                Console.WriteLine("Wygenerowano!!!!!!!");
                przychodnia.GenerujRaport();
            }
            else if (klawisz == 'X' || klawisz == 'X')
            {
                Environment.Exit(0);
            }
            

        }
        static void Main(string[] args)
        {
            DodajLekarza();
            if (przychodnia.CzyLekarz())
            {
                while (true)
                {
                    Legenda();
                    WczytajKlawisz();
                    Aplikacja();
                }
            }
   
            
        }
    }
}
