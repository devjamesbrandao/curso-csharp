using System;
using Interfaces.Entidades;

namespace Interfaces.Services
{
    public class CalculaNotaServico
    {
        public double PrecoPorHora {get; set;}

        public double PrecoPorDia {get; set;}

        private ITaxaServico _taxaServico;

        public CalculaNotaServico(double PrecoPorHora, double PrecoPorDia, ITaxaServico TaxaServico)
        {
            this.PrecoPorDia = PrecoPorDia;
            this.PrecoPorHora = PrecoPorHora;
            _taxaServico = TaxaServico;
        }

        public void CalculaNota(DadosVeiculo Dados)
        {
            TimeSpan Duracao = Dados.Final.Subtract(Dados.Inicio);

            double PagamentoBase = 0.0;

            if(Duracao.TotalHours <= 12)
            {
                PagamentoBase = PrecoPorHora * Math.Ceiling(Duracao.TotalHours);
            } else 
            {
                PagamentoBase = PrecoPorDia * Math.Ceiling(Duracao.TotalDays);
            }

            //O serviço calcula a Taxa
            double Taxa = _taxaServico.Taxa(PagamentoBase);

            //Gera a nota fiscal
            Dados.NotaFiscal = new NotaFiscal(PagamentoBase, Taxa);

        }

    }
}