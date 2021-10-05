using System;

namespace Interfaces.Entidades
{
    public class DadosVeiculo
    {
        public DateTime Inicio {get; set;}
        
        public DateTime Final {get; set;}

        public Veiculo Veiculo {get; set;}

        public NotaFiscal NotaFiscal {get; set;}

        public DadosVeiculo(DateTime Inicio, DateTime Final, Veiculo Veiculo)
        {
            this.Inicio = Inicio;
            this.Final = Final;
            this.Veiculo = Veiculo;
        }

    }
}