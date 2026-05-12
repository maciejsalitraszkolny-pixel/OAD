using System;

namespace KalkulatorRabatow
{
    public interface IRabat
    {
        double Oblicz(double kwota);
    }

    public class BrakRabatu : IRabat
    {
        public double Oblicz(double kwota) => kwota;
    }

    public class RabatProcentowy : IRabat
    {
        public double Oblicz(double kwota) => kwota * 0.90;
    }

    public class RabatStaly : IRabat
    {
        public double Oblicz(double kwota)
        {
            double wynik = kwota - 20;
            return wynik < 0 ? 0 : wynik;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double cenaWejsciowa = PobierzCene();
            WyswietlMenu();
            int wybor = PobierzWybor();
            
            IRabat wybranyRabat = WybierzObiektRabatu(wybor);
            double cenaKoncowa = wybranyRabat.Oblicz(cenaWejsciowa);

            WyswietlWynik(cenaKoncowa);
        }

        static double PobierzCene()
        {
            double cena;
            while (true)
            {
                Console.Write("Podaj cenę produktu: ");
                if (double.TryParse(Console.ReadLine(), out cena) && cena >= 0)
                {
                    return cena;
                }
                Console.WriteLine("Błąd! Podaj poprawną liczbę dodatnią.");
            }
        }

        static void WyswietlMenu()
        {
            Console.WriteLine("\n--- Wybierz rodzaj rabatu ---");
            Console.WriteLine("1 – Brak rabatu");
            Console.WriteLine("2 – Rabat 10%");
            Console.WriteLine("3 – Rabat 20 zł");
            Console.WriteLine("-----------------------------");
        }

        static int PobierzWybor()
        {
            int wybor;
            while (true)
            {
                Console.Write("Twój wybór (1-3): ");
                if (int.TryParse(Console.ReadLine(), out wybor) && wybor >= 1 && wybor <= 3)
                {
                    return wybor;
                }
                Console.WriteLine("Nieprawidłowa opcja. Wybierz 1, 2 lub 3.");
            }
        }

        static IRabat WybierzObiektRabatu(int wybor)
        {
            return wybor switch
            {
                1 => new BrakRabatu(),
                2 => new RabatProcentowy(),
                3 => new RabatStaly(),
                _ => new BrakRabatu()
            };
        }

        static void WyswietlWynik(double wynik)
        {
            Console.WriteLine($"\nOstateczna cena po zastosowaniu rabatu: {wynik:F2} zł");
            Console.ReadKey();
        }
    }
}