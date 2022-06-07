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
    public class CursoRepository : ICursoRepository
    {
        private DataContext _dbContext;
        public CursoRepository() => _dbContext = new DataContext();
        public Curso Alterar(Curso cursoAtual, Curso cursoNovo)
        {
            if (_dbContext.Cursos.Where(c => c.Turno == cursoNovo.Turno).Where(c => c.Nome == cursoNovo.Nome).Any())
                if(cursoAtual.Id != _dbContext.Cursos.Where(c => c.Turno == cursoNovo.Turno).Where(c => c.Nome == cursoNovo.Nome).FirstOrDefault().Id)
                    throw new DuplicateWaitObjectException();
            
            cursoAtual.CargaHoraria = cursoNovo.CargaHoraria;
            cursoAtual.Nome = cursoNovo.Nome;
            cursoAtual.Turno = cursoNovo.Turno;
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
        public void ListarAlunos(Curso curso)
        {
            curso.QuantidadeAlunos = _dbContext.Alunos.ToList().Where(a => a.Curso_Id == curso.Id).Count();
            _dbContext.SaveChanges();
        }
        public IEnumerable<Curso> BuscaPorTexto(TextBox textbox)
        {
            var busca = from t in Obter()
                        where t.Nome.ToLower().Contains(textbox.Text.ToLower()) ||
                            t.CargaHoraria.ToString().ToLower().Contains(textbox.Text.ToLower()) ||
                            t.Id.ToString().ToLower().Contains(textbox.Text.ToLower()) ||
                            t.Turno.ToLower().Contains(textbox.Text.ToLower())
                        select t;
            return busca.ToList();
        }
    }
}
