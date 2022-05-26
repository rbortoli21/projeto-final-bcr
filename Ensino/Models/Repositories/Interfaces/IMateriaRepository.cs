using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Models.Repositories.Interfaces
{
    public interface IMateriaRepository
    {
        List<Materia> Obter();
        Materia ObterPorId(int id);
        Materia Cadastrar(Materia materia);
        Materia Alterar(Materia materiaAtual, Materia materiaNova);
        void Deletar(Materia materia);
    }
}
