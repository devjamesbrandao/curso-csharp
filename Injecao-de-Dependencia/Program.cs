using System;

namespace Injecao_de_Dependencia
{
    class Program
    {
        static void Main(string[] args)
        {

            //Sem DI
            // var controller = new Controller();

            // string resultado = controller.Impressora("Macoratti");

            // Console.WriteLine(resultado);

            // Console.ReadLine();

            //Com DI
            //Nota: veja que, caso eu precise mudar qual serviço irei implementar, basta informar o nome do serviço
            //porém, esse serviço precisa implementar a interface definida
            var controller = new Controller2(null);

            string resultado = controller.Impressora("James");

            Console.WriteLine(resultado);

        }
    }
}
