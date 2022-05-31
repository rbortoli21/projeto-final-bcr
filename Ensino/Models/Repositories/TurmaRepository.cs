using Ensino.Data;
using Ensino.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ensino.Models.Repositories
{
    public class TurmaRepository : IBaseRepository<Turma>
    {
        private DataContext _dbContext;
        public TurmaRepository() => _dbContext = new DataContext();
        public Turma Cadastrar(Turma turma)
        {
            if (_dbContext.Turmas.Where(t => t.Id == turma.Id).Any())
                throw new DuplicateWaitObjectException($"Turma já está cadastrada.");
            _dbContext.Turmas.Add(turma);
            _dbContext.SaveChanges();

            return turma;
        }
        public Turma Deletar(Turma turma)
        {
            if (_dbContext.Turmas.Where(t => t.Id == turma.Id).Any())
            {
                _dbContext.Turmas.Remove(turma);
                _dbContext.SaveChanges();
            }
            return turma;
        }
        public List<Turma> Obter()
        => _dbContext.Turmas.ToList();
        public Turma ObterPorId(int id)
        => _dbContext.Turmas.ToList().FirstOrDefault(t => t.Id == id);
        public Turma Alterar(Turma objetoAtual, Turma objetoNovo)
        => throw new NotImplementedException();
        public void ListarAlunos(Turma turma)
        {
            turma.QtdAlunos = _dbContext.Alunos.ToList().Where(a => a.Turma_Id == turma.Id).Count();
            _dbContext.SaveChanges();
        }
        public List<Turma> BuscaPorTexto(TextBox textbox)
        {
            List<Turma> busca = new List<Turma>();
            foreach (var objeto in Obter())
            {
                if (objeto.Id.ToString().ToLower().Contains(textbox.Text.ToLower()))
                    busca.Add(objeto);
                else if (objeto.NomeCurso.ToLower().Contains(textbox.Text.ToLower()))
                    busca.Add(objeto);
                else if (objeto.QtdAlunos.ToString().ToLower().Contains(textbox.Text.ToLower()))
                    busca.Add(objeto);
                else if (objeto.TurnoCurso.ToString().ToLower().Contains(textbox.Text.ToLower()))
                    busca.Add(objeto);
            }
            return busca;
        }
    }
}
