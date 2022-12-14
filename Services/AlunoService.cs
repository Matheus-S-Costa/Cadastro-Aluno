using CadastroAluno.Models;

namespace CadastroAluno.Services;

public static class AlunoService
{
        static List<Aluno> Alunos { get; }
        static int proximoId = 3;

        static AlunoService()
        {
            Alunos = new List<Aluno>
            {
                new Aluno { Id = 1, Nome = "Ana", Email="refused@teste.com", Senha="teste", Nascimento="04/05/2000", Cpf="000000000-00", Telefone="(31)00000-0000", Ra= 320137871, Faculdade="Una", Curso="Gastronomia", Instituicao1="Ulisboa-PORT", Instituicao2="Eduportugal-PORT"},
                new Aluno { Id = 2, Nome = "Bia", Email="teste@example.com", Senha="teste2", Nascimento="01/01/2000", Cpf="000000000-11", Telefone="(31)94000-0000", Ra= 320137870, Faculdade="Una", Curso="Psicologia", Instituicao1="Ulisboa", Instituicao2="Eduportugal"}
            };
        }
    public static List<Aluno> GetAll() => Alunos;
    public static Aluno? Get(int id) => Alunos.FirstOrDefault(a => a.Id == id);

    public static Aluno Add(Aluno aluno)
    {
        aluno.Id = proximoId++;
        Alunos.Add(aluno);

        return aluno;
    }
    public static void Delete(int id)
    {
        var aluno = Get(id);
        if(aluno is null)
            return;
        Alunos.Remove(aluno);
    }
    public static void Update(Aluno aluno)
    {
        var indice = Alunos.FindIndex(a => a.Id == aluno.Id);
        if(indice == -1)
            return;

    Alunos[indice] = aluno;
    }
}