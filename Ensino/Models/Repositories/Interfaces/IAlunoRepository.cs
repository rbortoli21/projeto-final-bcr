using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ensino.Models.Repositories.Interfaces
{
    public interface IAlunoRepository
    {
        List<Aluno> Obter();
        Aluno ObterPorId(int id);
        Aluno Cadastrar(Aluno objeto);
        Aluno Alterar(Aluno objetoAtual, Aluno objetoNovo);
        Aluno Deletar(Aluno objeto);
        IEnumerable<Aluno> BuscaPorTexto(TextBox textbox);
    }
}
