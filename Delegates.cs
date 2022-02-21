using System;

namespace Teste
{

    class Retangulo
    {

        // Declarando delegate
        public delegate void retanguloDelegate(double altura, double largura);


        // Declarando método "area"
        public void area(double altura, double largura)
        {
            Console.WriteLine("Área é: {0}", (largura * altura));
        }


        // Declarando método "perimetro"
        public void perimetro(double altura, double largura)
        {
            Console.WriteLine("Perímetro é: {0} ", 2 * (largura + altura));
        }


        // Método Main: entryPoint da aplicação
        public static void Main(String[] args)
        {

            // Criando o objeto da classe
            // "Retangulo" é nomeado como "ret"
            Retangulo ret = new Retangulo();

            // Criando objeto delegate nomeado como "retDele"
            // e passando o método "area" como parâmetro por meio do objeto da classe "ret"
            retanguloDelegate retDele = new retanguloDelegate(ret.area);

            // Multicasting do delegate: meio que une a chamada dos dois métodos
            retDele += ret.perimetro;

            Console.Title = "Uso de delegates";

            // Passando os valores como parâmetro para os dois métodos (area e perimetro)
            // utilizando o operador "Invoke" nativo dos delegates
            retDele.Invoke(6.3, 4.2);
            Console.WriteLine();

            // Chamando os métodos novamente com outros valores
            retDele.Invoke(16.3, 10.3);
            Console.WriteLine();

            // Removendo a atribuição do método "perimetro"
            retDele -= ret.perimetro;

            retDele.Invoke(2, 5);
        }
    }
}
