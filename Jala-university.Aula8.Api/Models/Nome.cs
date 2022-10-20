namespace Jala_university.Aula8.Api.Models;

public struct Nome
{
    private string Name { get; set; }

    public Nome(string nome)
    {
        Name = nome ?? throw new ArgumentNullException("Nome não pode ser null");
    }

    public static implicit operator string(Nome nomeAluno)
    {
        return nomeAluno.Name;
    }
}