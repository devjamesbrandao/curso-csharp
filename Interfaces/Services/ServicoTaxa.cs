namespace Interfaces.Services
{
    public class ServicoTaxa : ITaxaServico
    {
        public double Taxa(double Quantia)
        {
            if(Quantia <= 100)
            {
                return Quantia * 0.2;
            } else 
            {
                return Quantia * 0.15;
            }
        }
    }
}