using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Haut de la tour");
            string haut = Console.ReadLine();

            Console.WriteLine("Etage decor");
            string decor = Console.ReadLine();

            Console.WriteLine("Etage vide");
            string vide = Console.ReadLine();

            Console.WriteLine("Bas de la tour");
            string bas = Console.ReadLine();

            Console.WriteLine("File moi le nombre d'etages batard");
            int etages = Convert.ToInt32(Console.ReadLine());
            
            if (etages <= 0)
                Console.WriteLine("Casse toi bollos");
            else
                Towers(etages, haut, decor, vide, bas);

            Console.ReadLine();
        }

        static void Towers(int etages, string haut, string decor, string vide, string bas)
        {
            Console.WriteLine("Tiens ta tour wesh");
            Console.WriteLine();

            Console.WriteLine(haut);
            
            for (int j = 0; j < etages; j++)
            {
                Console.WriteLine(decor);
            }
            Console.WriteLine(vide);
            Console.WriteLine(bas);
        }
    }
}
