using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS2_Aula_06_10_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;  // i j k ( x y z ) contador
            int inicio, fim;
            double soma=0;
                        
            Console.WriteLine(" Inicio Programa");

            //Console.WriteLine(" qual o numero inicio:");
            //inicio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" qual o numero final:");
            i = Convert.ToInt32(Console.ReadLine());
            //0 = Par  --> inicio + inicio%2 = 0
            //1 = impar --> inicio + inicio%2 = 2
            //  0/2 = 0 sobra 0    
            //  1/2 = 0 sobra 1
            //  2/2 = 1 sobra 0
            //  3/2 = 1 sonra 1
            //  4/2 = 2 sobra 0
            //  5/2 = 2 sobra 1

            int x;

            for (i=10, x=1 ; i>0 ; i=i-2,x++ )
            {
                soma = soma + i; //acc
                Console.WriteLine("Valor "+ x +" : " + i); // + " somoa ate : "+soma);
                             
            }
            

            Console.WriteLine("Soma dos par :" + soma);



            Console.WriteLine(" Fim Programa");
            Console.ReadKey();

/*
            for (i = 0; i < 20; i = i + 1)
            {
                if ((i % 2) == 0)  // ==1  ou !=0
                {
                    //  Console.WriteLine("Valor PAR i : " + i);
                }
                else
                {
                    Console.WriteLine("Valor IMPAR i : " + i);
                }
                //i++; // i = i + 1;  

            }
*/
        }
    }
}
