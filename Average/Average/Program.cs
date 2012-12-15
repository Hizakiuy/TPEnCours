using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combien de nombres ?");
            string nStr = Console.ReadLine(); //input
            int n = 0; //initialisation pour la fonction TryParse
            int temp = 0; //pour la fonction TryParse

            if (int.TryParse(nStr, out temp) == false) //verifie si c'est bien un entier
                Console.Write("Ce n'est pas un entier");
            else
            {
                n = Convert.ToInt32(nStr); //si c'en est un, il le passe en int
                Average(n); //et applique la fonction sur ce nombre
            }
                
            Console.ReadLine();
            
        }

        static void Average(int n)
        {
            int somme = 0; //initialisation de la somme des nombres à 0 vu que c'est une somme
            int temp = 0; //pour tryparse
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Nombre " + i); //demande le ieme nombre
                string newString = Console.ReadLine();

                if (int.TryParse(newString, out temp) == false) //verifie si c'est un entier
                {
                    Console.WriteLine(newString + " n'est pas un entier");
                    i = n; //arrete la boucle
                    temp += 1; /*je me sers de la variable 'temp' du TryParse pour eviter d'afficher
                               la moyenne même si j'entre autre chose que des entiers*/
                }
                else
                {
                    somme += Convert.ToInt32(newString); //ajoute le ieme nombre à la somme des autres
                    temp = 0; //si la conversion a réussi, je remet temp à 0 pour la condition d'affichage de la moyenne
                }
            }
            if (temp == 0) //si aucune exception ne s'est déclanchée, on affiche la moyenne
                Console.WriteLine("La moyenne est de " + (float)somme / n);
        }
    }
}
