using Jala_university.Aula8.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jala_university.Aula8.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class AlunoController : Controller
{
    private readonly Aluno _Aluno;

    public AlunoController()
    {
        var dataNascimento = new DataDeNascimento(1980, 22, 12, "Coordinated Universal Time");
        _Aluno = new Aluno(new Nome("Pedro"), dataNascimento);
    }


    [HttpGet]
    public IActionResult GetAlunoBirthday()
    {
        return Ok(_Aluno.DataDeNascimento.ToString());
    }

    [HttpGet]
    public IActionResult GetAlunoAge()
    {
        return Ok(_Aluno.Idade);
    }
}