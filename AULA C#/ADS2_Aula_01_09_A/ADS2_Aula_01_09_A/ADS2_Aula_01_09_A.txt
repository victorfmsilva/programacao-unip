using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS2_Aula_01_09_A
{
    class Program
    {
        static void Main(string[] args)
        {
           // exe A           
            Console.WriteLine("Ola Mundo");

            // exe B
            double ValorA; // var do typo inteiro com o nome ValorA (ValorA <> Valora)
            double ValorB;
            double ValorC; // maior que float
            double ValorD = 0;
            double ValorE = 0;
            string Aux;
            

            ValorA = 0;
            ValorB = 0;
            ValorC = 0;

            Console.WriteLine("qual o nome:");
            Aux = Console.ReadLine();

            Console.WriteLine("qual o Valor A: ");
            ValorA = Convert.ToDouble( Console.ReadLine() );

            Console.WriteLine("qual o Valor B: ");
            ValorB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("qual o Valor C: ");
            ValorC = Convert.ToDouble(Console.ReadLine());

            ValorD = (ValorA + ValorB + ValorC) /3 ;


            Console.WriteLine("Nome: " + Aux);
            Console.WriteLine("Valor A: " + ValorA);
            Console.WriteLine("Valor B: " + ValorB);
            Console.WriteLine("Valor C: " + ValorC);
            Console.WriteLine("Valor media: " + ValorD);



            ValorE = 10 / 2; // 5
            Console.WriteLine("Valor E: " + ValorE);
            ValorE = 10 % 2; // 0
            Console.WriteLine("Valor E: " + ValorE);

            ValorE = 10 / 3; // 3
            Console.WriteLine("Valor E: " + ValorE);
            ValorE = 10 % 3; // 1
            Console.WriteLine("Valor E: " + ValorE);


            Console.ReadKey(); // 

        }
    }
}
