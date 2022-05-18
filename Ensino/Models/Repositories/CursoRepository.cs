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

        public void Alterar()
        {
            throw new NotImplementedException();
        }

        public Curso Cadastrar(Curso curso)
        {
            _dbContext.Cursos.Add(curso);
            _dbContext.SaveChanges();
            return curso;
        }

        public void Deletar(Curso curso)
        {
            _dbContext.Cursos.Remove(curso);
            _dbContext.SaveChanges();
        }

        public List<Curso> Obter()
        => _dbContext.Cursos.ToList();
        public Curso ObterPorId(int id)
        => _dbContext.Cursos.ToList().FirstOrDefault(curso => curso.Id == id);

    }
}
