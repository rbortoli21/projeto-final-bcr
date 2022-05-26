using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Models.Repositories.Interfaces
{
    public interface IProfessorRepository
    {
        List<Professor> Obter();
        Professor ObterPorId(int id);
        Professor Cadastrar(Professor professor);
        Professor Alterar(Professor professorAtual, Professor professorNovo);
        void Deletar(Professor professor);
    }
}
