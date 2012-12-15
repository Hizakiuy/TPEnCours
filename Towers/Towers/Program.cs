using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Towers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Haut de la tour");
            string haut = Console.ReadLine();//input haut

            Console.WriteLine("Etage decor");
            string decor = Console.ReadLine();//input decor

            Console.WriteLine("Etage vide");
            string vide = Console.ReadLine();//input vide

            Console.WriteLine("Bas de la tour");
            string bas = Console.ReadLine();//input bas

            Console.WriteLine("Combien d'etages");
            int temp = 0; //variable pour TryParse
            int etages = 0; //initialisée à 0 pour TryParse
            string etagesStr = Console.ReadLine(); //input nr. d'étages

            if (int.TryParse(etagesStr, out temp) == false) //verifie si c'est bien un entier
                Console.Write(etagesStr + " n'est pas un entier");
            else
            {
                etages = Convert.ToInt32(etagesStr); //si c'en est un, l'entier etages passe à la valeur de etagesStr

                if (etages < 0) //verifie si le nombre d'étages n'est pas negatif
                    Console.WriteLine("Etage negatif...t'es con ou quoi? Casse toi!");
                else
                    Towers(etages, haut, decor, vide, bas); //applique la fonction
            }

            Console.ReadLine();
        }

        static void Towers(int etages, string haut, string decor, string vide, string bas)
        {
            Console.WriteLine();
            Console.WriteLine("Tiens ta tour");
            Console.WriteLine();

            Console.WriteLine(haut); //affiche le haut

            for (int j = 0; j < etages; j++) //bouche pour afficher l'interieur de la tour
            {
                Console.WriteLine(vide); //affiche l'étage vide
                Console.WriteLine(decor); //affiche l'étage décoré
            }
            Console.WriteLine(vide); //affiche un étage vide avant le bas
            Console.WriteLine(bas); //affiche le bas
        }
    }
}
