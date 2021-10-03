using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            // string origem = @"C:\Users\JAMES\Documents\Projetos-C#\Arquivos\Teste.txt";

            // string destino = @"C:\Users\JAMES\Documents\Projetos-C#\Arquivos\Teste2.txt";

            // try
            // {
            //     //Instancia um objeto
            //     FileInfo file = new FileInfo(origem);

            //     //Copia para outro destino
            //     file.CopyTo(destino);

            //     //Cria array com informações do arquivo
            //     string[] lines = File.ReadAllLines(destino);

            //     //Imprime as informações do arquivo
            //     foreach(string linha in lines)
            //     {
            //         Console.WriteLine(linha);
            //     }

            // } 
            // catch(IOException e)
            // {
            //     Console.WriteLine("Ueeepaaa!");
            //     Console.WriteLine(e.Message);
            // }

            FileAndStream();
        }

        public static void FileAndStream()
        {

            string caminho = @"C:\Users\JAMES\Documents\Projetos-C#\Arquivos\Teste.txt";

            try
            {
                //Abre o texto
                using(StreamReader st = File.OpenText(caminho))
                {
                    //Verifica se já é o fim da linha, se for, encerra o programa; caso não, continua;
                    while(!st.EndOfStream)
                    {
                        //Guarda o valor da linha em uma variável
                        string linha = st.ReadLine();

                        string[] valores = linha.Split(",");

                        Console.WriteLine("Valor: " + (int.Parse(valores[valores.Length - 1]) * Double.Parse(valores[valores.Length - 2])));
                    }
                }

            } 
            catch(IOException e)
            {
                Console.WriteLine("Ueeepaaa!");
                Console.WriteLine(e.Message);
            }

        }

        public static void EscreverArquivo()
        {

            string caminho = @"C:\Users\JAMES\Documents\Projetos-C#\Arquivos\Teste.txt";
            string destino = @"C:\Users\JAMES\Documents\Projetos-C#\Arquivos\Teste2.txt";

            try
            {

                //Le o arquivo
                string[] linhas = File.ReadAllLines(caminho);

                //Escreve a partir da última linha
                using(StreamWriter sw = File.AppendText(destino))
                {
                    //Busca as linhas lidas grava-a no arquivo desejado
                    foreach(string linha in linhas)
                    {
                        sw.WriteLine(linha.ToUpper());
                    }
                }

            } 
            catch(IOException e)
            {
                Console.WriteLine("Ueeepaaa!");
                Console.WriteLine(e.Message);
            }

        }

    }
}
