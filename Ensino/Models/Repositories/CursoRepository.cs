using Ensino.Data;
using Ensino.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Models.Repositories
{
    public class CursoRepository : ICursoRepository
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
            return cursoAtual;
        }
        public Curso Cadastrar(Curso curso)
        {
            if (_dbContext.Cursos.Where(c => c.Turno == curso.Turno).Where(c => c.Nome == curso.Nome).Any())
                throw new DuplicateWaitObjectException();
            else
            {
                _dbContext.Cursos.Add(curso);
                _dbContext.SaveChanges();
            }
            return curso;
        }

        public void Deletar(Curso curso)
        {
            if (_dbContext.Cursos.Where(c => c.Id == curso.Id).Any())
            {
                _dbContext.Cursos.Remove(curso);
                _dbContext.SaveChanges();
            }
        }
        public List<Curso> Obter()
        => _dbContext.Cursos.ToList();
        public Curso ObterPorId(int id)
        => _dbContext.Cursos.ToList().FirstOrDefault(curso => curso.Id == id);

    }
}
