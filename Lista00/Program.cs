using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Insira o número:");
            num = int.Parse(Console.ReadLine());

           
            int fatorial = 1;
            for (int i = num; i > 0; i--)
            {
                fatorial *= i;
            }

            Console.WriteLine(fatorial);

            Console.ReadLine();

        }
    }
}
