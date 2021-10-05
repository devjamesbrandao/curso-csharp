using System;
using System.Globalization;
using Interfaces.Entidades;
using Interfaces.Services;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Gera um objeto com os dados do Veículo
            DadosVeiculo DadosVeiculo = new DadosVeiculo(start, finish, new Veiculo(model));

            //Cria uma nova instância do serviço
            CalculaNotaServico Calcula = new CalculaNotaServico(hour, day, new ServicoTaxa());

            //Calcula valores
            Calcula.CalculaNota(DadosVeiculo);

            Console.WriteLine("Nota Fiscal:");
            Console.WriteLine(DadosVeiculo.NotaFiscal);

        }
    }
}
