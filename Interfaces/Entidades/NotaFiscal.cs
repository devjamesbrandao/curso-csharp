using System.Globalization;

namespace Interfaces.Entidades
{
    public class NotaFiscal
    {
        public double PagamentoBase {get; set;}

        public double Taxa {get; set;}

        public NotaFiscal(double PagamentoBase, double Taxa)
        {
            this.PagamentoBase = PagamentoBase;
            this.Taxa = Taxa;
        }

        public double Total
        {
            get { return PagamentoBase + Taxa; }
        }

        public override string ToString()
        {
            return "Basic payment: "
                + PagamentoBase.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + Total.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}