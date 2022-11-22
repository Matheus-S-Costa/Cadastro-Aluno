using CadastroAluno.Models;
using CadastroAluno.Services;

using Microsoft.AspNetCore.Mvc;

namespace CadastroAluno.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
    public AlunoController()
    {
    }

    [HttpGet]
    public ActionResult<List<Aluno>> GetAll() => AlunoService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Aluno> Get(int id)
    {
        var aluno = AlunoService.Get(id);

        if (aluno == null)
            return NotFound();

        return aluno;
    }
    //Post: inserir novo aluno
    [HttpPost]
    public IActionResult Create(Aluno aluno)
    {
        if (aluno == null)
            return BadRequest();
        
        aluno = AlunoService.Add(aluno);

        return CreatedAtAction(nameof(Get), new{ Id = aluno.Id}, aluno);
    }
    //Put: atualizar aluno pelo id
    [HttpPut("{id}")]
    public IActionResult update(int id, Aluno novoAluno)
    {
        if (novoAluno == null)
            return BadRequest();
        if (id != novoAluno.Id)
            return BadRequest();
        
        var aluno = AlunoService.Get(id);

        if (aluno == null)
            return NotFound();
        
        AlunoService.Update(novoAluno);

        return NoContent();
    }
    //Delete: remover aluno pelo id
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var aluno = AlunoService.Get(id);

        if (aluno == null)
            return NotFound();
        
        AlunoService.Delete(id);

        return NoContent();
    }
}