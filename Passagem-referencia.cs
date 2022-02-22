namespace Topics;
class Referencia
{
    // Passagem referência (ref): passagem de referência, passa o endereço da variável; 
    // não precisa manipular o valor dentro da função que recebe a variável;
    public static void PassagemReferencia(ref int v)
    {
        v = 7; 
        Console.WriteLine("Valor no Método :" + v);
    }
}

class MainPassagemReferencia
{
    public static void Main(string[] args)
    {
        int v = 1;
        Referencia.PassagemReferencia(ref v);
        Console.WriteLine("Valor no Main :" + v);
    }
}