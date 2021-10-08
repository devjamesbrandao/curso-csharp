using System;

namespace Generics.Entidades
{
    public class Produto : IComparable
    {
        public string Nome { get; set; }

        public double Valor {get; set;}

        public Produto(string Nome, double Valor)
        {
            this.Nome = Nome;
            this.Valor = Valor;
        }

        public int CompareTo(object obj)
        {
            //Verifica se o objeto é do tipo Produto
            if(!(obj is Produto))
            {
                throw new ArgumentException("Objeto não é do tipo Produto");
            }

            //Castng para Produto
            Produto Compara = obj as Produto;

            //Retorna o objeto comparado
            return this.Valor.CompareTo(Compara);

        }
    }
}