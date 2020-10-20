using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS2_Aula_01_09_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int Valor = 0;
            int Qtn100 = 0, Qtn50 = 0, Qtn1 = 0;

            Console.WriteLine("Qual valor:");
            Valor = Convert.ToInt32(Console.ReadLine());

            // 1234 / 100 = 12 (int/int = int)
            Qtn100 = Valor / 100; // 12 
            Qtn50 = (Valor - Qtn100 * 100 ) / 50;
            Qtn1 = (Valor - Qtn100 * 100 - Qtn50 * 50 ) / 1;


            Console.WriteLine("O Valor : " + Valor);
            Console.WriteLine("nota 100 : " + Qtn100);
            Console.WriteLine("nota 50 : " + Qtn50);
            Console.WriteLine("nota 1 : " + Qtn1);

            Console.ReadKey();



        }
    }
}
