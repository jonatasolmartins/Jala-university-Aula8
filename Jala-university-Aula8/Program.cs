// See https://aka.ms/new-console-template for more information


var minhaclasse = new MinhaClasse();

var numero = 56;
Console.WriteLine(numero);
Console.WriteLine(minhaclasse.ValidarSeNumeroMaiorQueZero(numero));
Console.WriteLine(numero);

var outroNumero = 22;
Console.WriteLine(outroNumero);
Console.WriteLine(minhaclasse.PassandoParameterPorReferencia(ref outroNumero));
Console.WriteLine(outroNumero);

public class MinhaClasse
{
    public bool ValidarSeNumeroMaiorQueZero(int numero)
    {
        numero = 0;
        return numero > 0;
    }
    
    public bool PassandoParameterPorReferencia(ref int numero)
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