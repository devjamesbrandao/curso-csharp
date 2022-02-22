using System.Text;
namespace Topics;
public class Nomes
{
    /*nameof: obtém a string de uma variável, pode ser o nome ou tipo, por exemplo*/

    public string Nome {get; set;}

    public Nomes(string nome)
    {
        Nome = nome;
    }

    static void Main(string[] args)
    {
        Nomes nomes = new Nomes("Teste");

        Console.WriteLine($"{nomes.MetodoNameOf("Top")}");
    }

    public string MetodoNameOf(string parametro)
    {
        StringBuilder nomes = new StringBuilder();

        nomes.AppendLine(string.Format("Classe  : {0}", nameof(Nomes)));
        nomes.AppendLine(string.Format("Classe  : {0}", nameof(Nome)));
        nomes.AppendLine(string.Format("Classe  : {0}", nameof(MetodoNameOf)));
        nomes.AppendLine(string.Format("Classe  : {0}", nameof(parametro)));

        return nomes.ToString();
    }
}