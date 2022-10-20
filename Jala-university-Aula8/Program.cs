// See https://aka.ms/new-console-template for more information


var minhaclasse = new MinhaClasse();
var numero = 56;
Console.WriteLine(numero);
Console.WriteLine(minhaclasse.NumeroMaiorQueZero(numero));

Console.WriteLine(numero);

public class MinhaClasse
{
    public string Nome { get; set; }

    public bool NumeroMaiorQueZero(int numero)
    {
        numero = 0;
        return numero > 0;
    }
}

public struct MinhaStruct
{
    public string Nome { get; set; }
    public int idade { get; set; }
    public bool Casado { get; set; }
}