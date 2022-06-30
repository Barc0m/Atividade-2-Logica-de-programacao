using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, r, r2, r3, r4;

            Console.WriteLine("Digite o primeiro número");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            n2 = Convert.ToDouble(Console.ReadLine());

            r = n1 + n2;
            r2 = n1 - n2;
            r3 = n1 / n2;
            r4 = n1 * n2;

            Console.WriteLine("Adição: " + r + "\nSubtração: " + r2 + "\nDivisão: " + r3 + "\nMultiplicação: " + r4);
            Console.ReadKey();
        }
    }
}
