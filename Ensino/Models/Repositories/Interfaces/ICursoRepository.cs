using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Models.Repositories.Interfaces
{
    public interface ICursoRepository
    {
        Task<List<Curso>> Obter();
        Curso ObterPorId(int id);
        Curso Cadastrar(Curso aluno);
        Curso Alterar(Curso cursoAtual, Curso cursoNovo);
        void Deletar(Curso aluno);
    }
}
