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
            int n = Convert.ToInt32(Console.ReadLine());
            Average(n);
        }

        static void Average(int n)
        {
            int somme = 0;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Nombre " + i);
                somme += Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
