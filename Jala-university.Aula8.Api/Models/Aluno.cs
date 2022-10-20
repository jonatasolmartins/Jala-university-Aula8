namespace Jala_university.Aula8.Api.Models;

public class Aluno
{
    public DateTime DataDeNascimento { get; set; }
    public string Nome { get; set; }

    public int Idade { get; set; }

    public Aluno(Nome nome, DataDeNascimento dataDeNascimento)
    {
        Nome = nome;
        DataDeNascimento = dataDeNascimento;
        Idade = dataDeNascimento;
    }
}