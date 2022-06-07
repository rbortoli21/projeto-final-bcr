using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ensino.Models.Repositories.Interfaces
{
    public interface IMateriaRepository
    {
        List<Materia> Obter();
        Materia ObterPorId(int id);
        Materia Cadastrar(Materia objeto);
        Materia Alterar(Materia objetoAtual, Materia objetoNovo);
        Materia Deletar(Materia objeto);
        IEnumerable<Materia> BuscaPorTexto(TextBox textbox);
    }
}
