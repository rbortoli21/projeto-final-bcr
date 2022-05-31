using Ensino.Data;
using Ensino.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ensino.Models.Repositories
{
    public class CursoRepository : IBaseRepository<Curso>
    {
        private DataContext _dbContext;
        public CursoRepository() => _dbContext = new DataContext();
        public Curso Alterar(Curso cursoAtual, Curso cursoNovo)
        {
            if (_dbContext.Cursos.Where(c => c.Turno == cursoNovo.Turno).Where(c => c.Nome == cursoNovo.Nome).Any())
                throw new DuplicateWaitObjectException();
            cursoAtual.Nome = cursoNovo.Nome;
            cursoAtual.Turno = cursoNovo.Turno;
            cursoAtual.CargaHoraria = cursoNovo.CargaHoraria;
            cursoAtual.QuantidadeAlunos = _dbContext.Alunos.ToList().Where(a => a.NomeCurso == cursoNovo.Nome).Where(a => a.TurnoCurso == cursoNovo.Turno).Count();
            _dbContext.SaveChanges();
            return cursoAtual;
        }
        public Curso Cadastrar(Curso curso)
        {
            if (_dbContext.Cursos.Where(c => c.Turno == curso.Turno).Where(c => c.Nome == curso.Nome).Any())
                throw new DuplicateWaitObjectException();
            _dbContext.Cursos.Add(curso);
            _dbContext.SaveChanges();

            return curso;
        }
        public Curso Deletar(Curso curso)
        {
            if (_dbContext.Cursos.Where(c => c.Id == curso.Id).Any())
            {
                _dbContext.Cursos.Remove(curso);
                _dbContext.SaveChanges();
            }
            return curso;
        }
        public List<Curso> Obter()
        => _dbContext.Cursos.ToList();
        public Curso ObterPorId(int id)
        => _dbContext.Cursos.ToList().FirstOrDefault(curso => curso.Id == id);
        public List<Curso> BuscaPorTexto(TextBox textbox)
        {
            List<Curso> busca = new List<Curso>();
            foreach (var objeto in Obter())
            {
                if (objeto.Id.ToString().ToLower().Contains(textbox.Text.ToLower()))
                    busca.Add(objeto);
                else if (objeto.Nome.ToLower().Contains(textbox.Text.ToLower()))
                    busca.Add(objeto);
                else if (objeto.CargaHoraria.ToString().ToLower().Contains(textbox.Text.ToLower()))
                    busca.Add(objeto);
                else if (objeto.QuantidadeAlunos.ToString().ToLower().Contains(textbox.Text.ToLower()))
                    busca.Add(objeto);
                else if (objeto.Turno.ToLower().Contains(textbox.Text.ToLower()))
                    busca.Add(objeto);
            }
            return busca;
        }
    }
}
