namespace Topics;
class Saida
{
    // Passagem saída (out): similar à anterior, porém acontece um erro se a variável 
    // passada não sofrer alteração dentro da função
    public static void PassagemSaida(out int v)
    {
        v = 7;
        Console.WriteLine("Valor no Método :" + v);
    }
}

class MainPassagemSaida
{
    public static void Main(string[] args)
    {
        int v = 1;
        Saida.PassagemSaida(out v);
        Console.WriteLine("Valor no Main :" + v);
    }
}