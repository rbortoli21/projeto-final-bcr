using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Models.Repositories.Interfaces
{
    public interface IAlunoRepository
    {
        List<Aluno> Obter();
        Aluno ObterPorId(int id);
        Aluno Cadastrar(Aluno aluno);
        Aluno Alterar(Aluno alunoAtual, Aluno alunoNovo);
        Aluno Deletar(Aluno aluno);
    }
}
