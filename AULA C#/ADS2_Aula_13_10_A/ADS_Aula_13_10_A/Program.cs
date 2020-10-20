using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_Aula_13_10_A
{
    class Program
    {
        // struct ---> Registro 
        public struct Endereco
        {
            public string Rua;
            public int CEP;
        }
        public struct Pessoa // public 
        { // registro  de pessoa
            public string Nome;
            public int Idade;
            public double RG;
            public double CPF;
            public Endereco End;
        }

        public static void BemVindo()
        {
            Console.WriteLine("Bem Vindo!!!");
      //      Console.WriteLine("Aula de C#");
        }

        public static void SemStruct()
        {
            // sem struct registro
            
            string Nome, Nome1, Nome2; // var1 var2 var3
            int Idade, Idade1,  Idade2;// var1 var2 var3
            double RG, RG1, RG2;// var1 var2 var3 Quantidade de digitos (float = double)
	        double CPF, CPF1, CPF2; 

            Nome = "joao";
            Idade = 20;
            RG = 123456;

            Console.WriteLine("Nome : " + Nome + " Idade : " + Idade + " RG : " + RG);

            Console.Write("Nome : ");
            Nome = Console.ReadLine();
            Console.Write("Idade : ");
            Idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("RG : ");
            RG = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nome : " + Nome + " Idade : " + Idade + " RG : " + RG);
            Console.ReadKey();
            // fim do sem struct
            
        }

        public static void ComStruct()
        {
            int a; // var qualquer
            Pessoa Pe = new Pessoa();
            Pessoa P1 = new Pessoa();
            Pessoa P2 = new Pessoa();

            BemVindo();

            Pe.Nome = "Paulo";
            Pe.Idade = 22;
            Pe.RG = 654321;
            Pe.End.Rua = "13maio";
            Pe.End.CEP = 123;


            Console.WriteLine("Nome : " + Pe.Nome + " Idade : " + Pe.Idade + " RG : " + Pe.RG);

        //    BemVindo();

            Console.Write("Nome : ");
            Pe.Nome = Console.ReadLine();
            Console.Write("Idade : ");
            Pe.Idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("RG : ");
            Pe.RG = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nome : " + Pe.Nome + " Idade : " + Pe.Idade + " RG : " + Pe.RG);
         //   BemVindo();
            Console.ReadKey();

            P1.Nome = Pe.Nome;
            P1.Idade = Pe.Idade;
            P1.RG = Pe.RG;

            P2 = Pe;

            Console.WriteLine("Nome : " + P1.Nome + " Idade : " + P1.Idade + " RG : " + P1.RG);
            Console.WriteLine("Nome : " + P2.Nome + " Idade : " + P2.Idade + " RG : " + P2.RG);
         //   BemVindo();
            Console.ReadKey();
            // com struct registro

         
        }



        static void Main(string[] args)
        {
            int tmp;

            for (tmp = 10; tmp != 0;)
            {
                Console.WriteLine(" 1 - Sem Struct");
                Console.WriteLine(" 2 - Com Struct");
                Console.WriteLine(" 0 - Sair");
                tmp = Convert.ToInt32(Console.ReadLine());

                if (tmp == 1)
                {                    
                    SemStruct();
                    Console.Clear();
                }
                else if (tmp == 2)
                {                    
                    ComStruct();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine(" Opcao Invalida");
                }
            }
            Console.Clear();
            Console.WriteLine(" Fim do Programa");
            Console.ReadKey();

        }
    }
}
