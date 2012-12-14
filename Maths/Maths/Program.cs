using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiplication(-3,10));
        }

        static int Multiplication(int a, int b)
        {
            if (a == 0 || b == 0) //produit nul
                return 0;

            bool negatif = false; //vrai si a < 0 ou b < 0

            if (a < 0 && b < 0) //si a et b negatifs alors resultat toujours positif
            {
                a = -a;
                b = -b;
            }
            
            if (a < 0) //si a negatif alors on change la variable negatif et on change le a en -a pour avoir un entier positif
            {
                negatif = true;
                a = -a;
            }

            if (b < 0) //pareil que pour le a
            {
                negatif = true;
                b = -b;
            }


            int resultat = 0; //variable pour stocker le resultat final
            for (int i = 0; i < a; i++)
            {
                resultat += b; //on ajoute à resultat la valeur de b, 'a' fois
            }
            if (negatif) //si la variable negatif est vraie alors on rajoute un moins devant le resultat final
                return (-resultat);
            else
                return resultat;
        }

        static int Division(int a, int b)
        {

            if (a == 0 || b == 0) //nul
                return 0;

            bool negatif = false; //vrai si a < 0 ou b < 0

            if (a < 0 && b < 0) //si a et b negatifs alors resultat toujours positif
            {
                a = -a;
                b = -b;
            }

            if (a < 0) //si a negatif alors on change la variable negatif et on change le a en -a pour avoir un entier positif
            {
                negatif = true;
                a = -a;
            }

            if (b < 0) //pareil que pour le a
            {
                negatif = true;
                b = -b;
            }


            int i = 0; //compte combien de fois b rentre dans a
            for (; a > 0; i++)
            {
                a = a - b; //on soustrait b à a 'i' fois tant que a n'est pas nul
            }
            if (negatif)
                return (-i);
            else
                return i;
               
        }

        static int Factorielle(int n)
        {
            if (n == 1)
                return 1;

            if (n == 0 || n < 0)
                return 1;

            int resultat = n; //variable initiale pour stocker le resultat initialisée à n

            for (int i = n - 1; i > 1; i--) //à chaque itération i décremente donc n est multiplié à chaque fois par n-1
            {
                resultat *= i;
            }
            return resultat;
        }

        static int Fibonacci(int n)
        {
            if (n == 0 || n < 0)
                return 0;
            if (n == 1)
                return 1;

            return (Fibonacci(n - 1) + Fibonacci(n - 2)); //recursif
        }
    }
}
