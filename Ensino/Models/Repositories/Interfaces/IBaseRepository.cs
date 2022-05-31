using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ensino.Models.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        List<T> Obter();
        T ObterPorId(int id);
        T Cadastrar(T objeto);
        T Alterar(T objetoAtual, T objetoNovo);
        T Deletar(T objeto);
        List<T> BuscaPorTexto(TextBox textbox);
    }
}
