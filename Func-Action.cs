using Topics;

// Referências: mestre Macoratti
// -> http://www.macoratti.net/14/11/c_deleg1.htm

class Programa
{
    static void Main(string[] args)
    {
        // Predicate: avalia uma condição e sempre retorna um boleano

        // Action: executa uma ação, porém não retorna um valor
        List<Funcionario> funcionarios = Funcionario.GetFuncionarios();

        // Utilizando Action
        Action<Funcionario> minhaAction = new Action<Funcionario>(CalculaIdade);
        funcionarios.ForEach(minhaAction);

        // Utilizando expressão lambda
        funcionarios.ForEach(f => f.Idade = DateTime.Now.Year - f.Nascimento.Year);

        foreach (Funcionario funci in funcionarios)
        {   
            Console.WriteLine(funci.Nome + " " + funci.Idade.ToString());
        }

        Console.ReadKey();
    }
    

    public static void UtilizarFunc()
    {
        // Func: utilizado sempre que a função retorna um valor
        Func<Aluno, string> verificaNome = aluno => 
        {
            if(aluno.Nome.StartsWith("J"))
                return aluno.Nome + " - ";
            else
                return "O Aluno não atende o critério.";
        };

        Console.WriteLine(verificaNome(new Aluno() { Id = 12, Nome = "James" }));
        Console.WriteLine(verificaNome(new Aluno() { Id = 10, Nome = "Laura" }));
        Console.WriteLine(verificaNome(new Aluno() { Id = 7, Nome = "Gustavo" }));
        Console.ReadKey();
    }

    private static void CalculaIdade(Funcionario func)
    {
        func.Idade = DateTime.Now.Year - func.Nascimento.Year;
    }
}

