using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ensino.Models.Repositories.Interfaces
{
    public interface ICursoRepository
    {
        List<Curso> Obter();
        Curso ObterPorId(int id);
        Curso Cadastrar(Curso objeto);
        Curso Alterar(Curso objetoAtual, Curso objetoNovo);
        Curso Deletar(Curso objeto);
        IEnumerable<Curso> BuscaPorTexto(TextBox textbox);
    }
}
