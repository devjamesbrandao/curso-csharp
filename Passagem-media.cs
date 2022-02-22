namespace Topics;
class Teste
{
    // Passagem multidimensional (params): permite a passagem de uma quantidade de parâmetros 
    // variada, ou seja, não precisa ser pre-definida na função
    public static void Media(params int[] v)
    {
        int soma = 0;

        foreach (int a in v)
        {
            soma = soma + a;
        }

        Console.WriteLine("Média: " + soma / v.Length);
    }
}

class MainParams
{
    public static void Main(string[] args)
    {
        Teste.Media(20, 30, 40);
        Teste.Media(20, 30, 40, 50, 60);
        int[] array = new int[] { 20, 30, 40, 50, 60 };
        Teste.Media(array);
    }
}