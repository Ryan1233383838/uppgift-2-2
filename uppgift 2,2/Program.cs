using System;
namespace Uppgift_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur långt kan Elin hoppa i längdhopp. Mätt i meter?");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur långt kan Alma hoppa i längdhopp. Mätt i meter?");
            int tal2 = int.Parse(Console.ReadLine());
            int summa = tal1 - tal2;
            Console.WriteLine("Elin hoppade " + summa + " meter längre än Alma");
        }
    }
}