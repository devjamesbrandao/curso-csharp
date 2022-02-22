
namespace Topics;
public class Funcionario
{
    public string Nome { get; set; }
    public string SobreNome { get; set; }
    public DateTime Nascimento { get; set; }
    public int Idade { get; set; }
    
    public static List<Funcionario> GetFuncionarios()
    {
        return new List<Funcionario>()
    {
        new Funcionario()
        {
            Nome = "Jose Carlos",
            SobreNome = "Macoratti",
            Nascimento =  Convert.ToDateTime("11/09/1975")
        },
        new Funcionario()
        {
            Nome = "Jefferson",
            SobreNome = "Ribeiro",
            Nascimento = Convert.ToDateTime("20/08/1992")
        },
        new Funcionario()
        {
            Nome = "Janice",
            SobreNome = "Santos",
            Nascimento = Convert.ToDateTime("13/06/1990")
        }
    };
    }
}
