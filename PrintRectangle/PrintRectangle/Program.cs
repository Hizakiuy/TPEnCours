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
            int temp = 0; //variable pour le TryParse

            Console.WriteLine("Largeur du rectangle :"); 
            string largeurStr = Console.ReadLine(); //input
            int largeur = 0; //initialiser largeur à 0 à cause de TryParse

            if (int.TryParse(largeurStr, out temp) == false) //verifie si c'est bien un entier
                Console.Write(largeurStr + " n'est pas un entier");
            else
            {
                largeur = Convert.ToInt32(largeurStr); //si c'en est un, l'entier largeur passe à la valeur de largeurStr

                Console.WriteLine("File moi la longueur aussi batard");
                string longueurStr = Console.ReadLine(); //intput
                int longueur = 0; //initialiser longueur à 0 à cause de TryParse

                if (int.TryParse(longueurStr, out temp) == false) //verifie si c'est bien un entier
                    Console.Write(longueurStr + " n'est pas un entier");
                else
                {
                    longueur = Convert.ToInt32(longueurStr); //si c'en est un, l'entier longueur passe à la valeur de largeurStr

                    if (largeur <= 0 || longueur <= 0) //verifie si les valeurs sont positives ou 0
                        Console.WriteLine("Je veux des valeurs positives quand même hein.");
                    else
                        PrintSquare(largeur, longueur); //applique la fonction
                }
            }
            Console.ReadLine();
        }

        static void PrintSquare(int largeur, int longueur)
        {
            string line = ""; //string utilisée pour accumuler les espaces à l'interieur du rectangle
            string etoiles = ""; //string utilisée pour accumuler les etoiles du bord d'en haut et d'en bas du rectangle

            for (int i = 2; i < largeur; i++)
            {
                line = line + " "; //ajoute un espace à chaque itération, jusqu'à ce que la ligne est ramplie d'espaces
            }

            for (int k = 0; k < largeur; k++)
            {
                etoiles = etoiles + "*"; //ajoute des étoieles pour remplir la ligne de largeur 'largeur'
            }

            Console.WriteLine(etoiles); //affiche le côté d'en haut
            for (int j = 2; j < longueur; j++)
            {
                Console.WriteLine("*" + line + "*"); //affiche une ligne vide avec des étoiles sur le côté 'longueur-2' fois
            }
            Console.WriteLine(etoiles); //affiche le côté d'en bas
        }
    }
}
