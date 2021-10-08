using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Generics();

            List<int> Inteiros = new List<int>{1,2,3,4,5};

            CalculaService Calcula = new CalculaService();

            Console.WriteLine(Calcula.Maior(Inteiros));

        }

        public static void Generics()
        {
            //Uso de GENERICS
            PrintService<int> Service = new PrintService<int>();

            Console.Write("Quantos valores? ");

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++) {
                int y = int.Parse(Console.ReadLine());
                Service.AddValor(y);
            }

            Service.Imprime();

            Console.WriteLine("First: " + Service.Primeiro());
        }

    }

}
