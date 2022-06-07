using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ensino.Models.Repositories.Interfaces
{
    public interface ITurmaRepository
    {
        List<Turma> Obter();
        Turma ObterPorId(int id);
        Turma Cadastrar(Turma objeto);
        Turma Deletar(Turma objeto);
        IEnumerable<Turma> BuscaPorTexto(TextBox textbox);
    }
}
