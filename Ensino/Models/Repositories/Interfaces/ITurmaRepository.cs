using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Models.Repositories.Interfaces
{
    public interface ITurmaRepository
    {
        void ListarAlunos(Turma turma);
        List<Turma> Obter();
        Turma ObterPorId(int id);
        Turma Cadastrar(Turma turma);
        Turma Deletar(Turma turma);
    }
}
