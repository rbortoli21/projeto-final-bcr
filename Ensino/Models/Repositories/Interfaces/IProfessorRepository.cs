using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ensino.Models.Repositories.Interfaces
{
    public interface IProfessorRepository
    {
        List<Professor> Obter();
        Professor ObterPorId(int id);
        Professor Cadastrar(Professor objeto);
        Professor Alterar(Professor objetoAtual, Professor objetoNovo);
        Professor Deletar(Professor objeto);
        IEnumerable<Professor> BuscaPorTexto(TextBox textbox);
    }
}
