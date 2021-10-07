using System;

namespace Injecao_de_Dependencia
{
    //Sem injeção de dependência
    public class InjecaoService1 : IInjecaoService
    {
        public string Imprime(string Texto) => $"Imprimir: {Texto} - Serviço 1";
    }

    //Com injeção de dependência: preciso dizer qual classe implementará a interface
    // Injetar dependência siginifica dizer qual classe ou serviço eu vou utilizar; 
    // Para tanto, preciso injetar no construtor do construtor a interface a qual define os métodos que utilizarei
    //Nota: com a injeção de dependência, eu deixo de apontar para um objeto concreto (classe) e aponto para uma interface
    // Vantagem: se eu precisar mudar o serviço, mudar a implementação da interface
    public class InjecaoService2 : IInjecaoService
    {
        public string Imprime(string Texto) => $"Imprimir: {Texto} - Serviço 2";
    }

    // public class Controller
    // {
    //     public string Impressora(string Impressao)
    //     {
    //         //A classe Controller está acoplada à classe InjecaoService1
    //         var servico = new InjecaoService1();

    //         return servico.Imprime(Impressao);

    //     }
    // }

    public class Controller2
    {
        private readonly IInjecaoService _injecaoService;

        public Controller2(IInjecaoService injecaoService)
        {
            _injecaoService = injecaoService ?? throw new ArgumentNullException(nameof(injecaoService));
        }

        public string Impressora(string Impressao) => _injecaoService.Imprime(Impressao);

    }

}