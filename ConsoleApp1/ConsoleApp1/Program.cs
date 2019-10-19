using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Imie:"); //wyswietl linie
            Console.Write("Janusz");

            /*
             * #
             * ##
             * ###
             * ####
             */

            Console.WriteLine("\n#\n##\n###\n####");

            string name;
            name = "Kamil";
            Console.WriteLine("Masz na imię: " ,name);

            int age = 20;
            Console.WriteLine("Masz na imię: {0}, wiek {1}",name, age);

            sbyte age1 = 20;
            Console.WriteLine("Masz na imię: {0}, wiek {1}",name, age1);

            //uzytkownik podaje z klawiatury dlugosc boku oblicz pole kwadratu//

            Console.WriteLine("\n Podaj bok a: ");
            string a = Console.ReadLine();
            Console.WriteLine("Bok a wynosi: " + a);

            Double result = double.Parse(a) * double.Parse(a);
            Console.WriteLine("Pole kwadratu a wynosi: " + result);

            /*Oblicz pole trojkata 
             * dane podaje uzytkownik z klawiatury
             */

            Double result1 = double.Parse(a) * double.Parse(a) /2;
            Console.WriteLine("Pole trojkata a wynosi: " + result1);

            uint x = 10;
            Console.WriteLine(x);

            string str;
            int liczba;
            Console.Write("Podaj licbe calkowita: ");
            str = Console.ReadLine();

            if(int.TryParse(str, out liczba) == false)
            {
                Console.WriteLine("Zły format liczby!");
            }
            else
            {
                Console.WriteLine("Liczba wynosi: {0}", liczba);

            }


            Console.Clear();

            Console.ReadKey();
        }
    }
}
