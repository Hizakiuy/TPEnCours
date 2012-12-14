using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyPrintNumbers.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tappes le premier num wesh");//min
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tappes le deuxieme num wesh");//max
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Et le pas maggle");//pas
            int p = Convert.ToInt32(Console.ReadLine());
            PrintNumbers(a, b, p);//applique fonction
            Console.ReadLine();
        }

        static void PrintNumbers(int a, int b, int p)
        {
            for (int i = a; i <= b; i += p)//boucle commençant à a, jusqu'a b, d'un pas de p
            {
                if (i == b) //verifier si i est bien le dernier, pour afficher le "et" avant le dernier nombre
                    Console.WriteLine(" et " + i);
                else
                {
                    if (i == b - p) //enlever la virgule avant le "et"
                        Console.Write(i);
                    else
                        Console.Write(i + ", "); //les autres cas
                }
            }
        }
    }
}
