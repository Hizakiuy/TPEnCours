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
            Console.WriteLine("File moi la largeur batard");
            int largeur = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("File moi la longueur aussi batard");
            int longueur = Convert.ToInt32(Console.ReadLine());
            
            if (largeur <= 0 || longueur <= 0)
                Console.WriteLine("Casse toi bollos");
            else
                PrintSquare(largeur,longueur);
            
            Console.ReadLine();
        }

        static void PrintSquare(int largeur, int longueur)
        {
            string line = "";
            string etoiles = "";

                for (int i = 2; i < largeur; i++)
                {
                    line = line + " ";
                }

                for (int k = 0; k < largeur; k++)
                {
                    etoiles = etoiles + "*";
                }

                Console.WriteLine(etoiles);
                for (int j = 2; j < longueur; j++)
                {
                Console.WriteLine("*" + line + "*");
                }
                Console.WriteLine(etoiles);
        }
    }
}
