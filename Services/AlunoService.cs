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
                new Aluno { Id = 1, Nome = "Ana", Nota = 98},
                new Aluno { Id = 2, Nome = "Bia", Nota = 99}
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