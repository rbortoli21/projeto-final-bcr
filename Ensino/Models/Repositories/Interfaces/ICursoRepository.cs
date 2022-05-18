using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Models.Repositories.Interfaces
{
    public interface ICursoRepository
    {
        List<Curso> Obter();
        Curso ObterPorId(int id);
        Curso Cadastrar(Curso aluno);
        void Alterar();
        void Deletar(Curso aluno);
    }
}
