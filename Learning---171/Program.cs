using System;
using System.IO;

namespace Learning___171
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {
                    Calc();
                    Console.WriteLine("Jesli chcesz zakończyć program wpisz Tak / tak. Jeśli chcesz dalej kontynować wciśjnij inny przycisk:");
                    string end = Console.ReadLine();
                    if (end == "Tak" || end == "tak" || end == "tAk" || end == "tAk")
                    {
                        break;
                    }
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        private static void Calc()
        {
            Console.WriteLine("Kalkulator dietetyczny!");
            Console.WriteLine("Podaj liczbę kalorii z danego produktu: ");
            double kcla = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę gramów tłuszczu z danego produktu: ");

            double gramTł = int.Parse(Console.ReadLine());

            if (gramTł <= 0)
            {
                Console.WriteLine("Nieprawidłowa liczba kalorii lub gramów tłuszczu!");

            }



            double kcalTł = gramTł * 9;

            if (kcalTł > kcla)
            {
                Console.WriteLine("Nieprawidłowa liczba kalorii lub gramów tłuszczu!");

            }

            double procrent = kcalTł / kcla;

            Console.WriteLine("=====================");
            Console.WriteLine($"Liczba kalorii pochodzących z tłuszczu: {procrent.ToString("p")}.");
            Console.WriteLine($"Liczba kalorii to {kcalTł}.");

            StreamWriter inputDate = File.CreateText("Numbers.text");
            inputDate.WriteLine($"Liczba kalorii pochodzących z tłuszczu: {procrent.ToString("p")}.");
            inputDate.WriteLine($"Liczba kalorii to {kcalTł}.");
            inputDate.Close();
        }
    }
}
