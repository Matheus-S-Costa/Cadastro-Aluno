namespace CadastroAluno.Models;

public class Aluno
{
    public int Id {get; set;}

    public string? Nome {get; set;}
    public string? Email {get; set;}
    public string? Senha {get; set;}
    public string? Nascimento {get; set;}
    public string? Cpf {get; set;}
    public string? Telefone {get; set;}
    public int Ra {get; set;}
    public string? Faculdade {get; set;}
    public string? Curso {get; set;}
    public string? Instituicao1 {get; set;}
    public string? Instituicao2 {get; set;}
}