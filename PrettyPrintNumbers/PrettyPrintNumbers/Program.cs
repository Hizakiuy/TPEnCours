using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyPrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int temp; //variable temporaire pour gerer la sortie de la fonction TryParse

            Console.WriteLine("Tu veux partir de quel nombre?");//min
            string aStr = Console.ReadLine(); //input clavier
            int a = 0; //variable initialisée à 0 car on ne sait pas si la valeur entrée par l'utilisateur est bien un entier

            Console.WriteLine("Jusqu'au quel?");               //max
            string bStr = Console.ReadLine();
            int b = 0;

            Console.WriteLine("Et le pas stp:");               //pas
            string pStr = Console.ReadLine();
            int p = 0;


            if (int.TryParse(aStr, out temp) == false ||
                int.TryParse(bStr, out temp) == false ||
                int.TryParse(pStr, out temp) == false)
                Console.WriteLine("Je veux des entiers moi. Try again.");
            else
            {
                a = a + Convert.ToInt32(aStr);
                b = b + Convert.ToInt32(bStr);
                p = p + Convert.ToInt32(pStr);


                if (a >= b) //verification si le deuxieme est plus grand que le premier 
                    Console.WriteLine("Le premier nombre doit être inferieur au deuxieme");
                else
                    PrintNumbers(a, b, p);//applique fonction //ne marche pas si le pas dépasse la derniere valeur...
            }
            Console.ReadLine();
        }

        static void PrintNumbers(int a, int b, int p)
        {
            for (int i = a; i <= b; i += p)//boucle commençant à a, jusqu'a b, d'un pas de p
            {
                if (i == b) //verifier si i est bien le dernier, pour afficher le "et" avant le dernier nombre
                    Console.WriteLine(" et " + i);
                else if (i == b - p) //enlever la virgule avant le "et"
                    Console.Write(i);
                else
                    Console.Write(i + ", "); //les autres cas
            }
        }
    }
}
