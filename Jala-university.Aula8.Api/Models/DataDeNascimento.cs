using System.Globalization;

namespace Jala_university.Aula8.Api.Models;

public readonly struct DataDeNascimento
{
    private int Ano { get; init; }
    private int Dia { get; init; }
    private int Mes { get; init; }
    private string TimeZone { get; init; }

    public DataDeNascimento(int ano, int dia, int mes, string timezone)
    {
        Ano = ano;
        Dia = dia;
        Mes = mes;
        TimeZone = timezone;
    }

    public static implicit operator DateTime(DataDeNascimento dataNascimento)
    {
        var birthDay = DateTime.ParseExact($"{dataNascimento.Ano}-{dataNascimento.Mes}-{dataNascimento.Dia} 00:00",
            "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
        return birthDay;
    }

    public static implicit operator int(DataDeNascimento dataDeNascimento) =>
        DateTime.Now.Year - DateTime.Parse(dataDeNascimento.ToString()).Year;

    public override string ToString()
    {
        var birthDay =
            DateTime.ParseExact($"{Ano}-{Mes}-{Dia} 00:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
        return birthDay.Date.ToString(CultureInfo.InvariantCulture);
    }
}