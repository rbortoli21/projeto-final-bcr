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
        void Cadastrar(Aluno aluno);
        void Alterar();
        void Deletar(Aluno aluno);
    }
}
