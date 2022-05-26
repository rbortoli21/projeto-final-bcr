using Ensino.Data;
using Ensino.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Models.Repositories
{
    public class MateriaRepository : IMateriaRepository
    {
        private DataContext _dbContext;
        public MateriaRepository()
        {
            _dbContext = new DataContext();
        }
        public Materia Alterar(Materia materiaAtual, Materia materiaNova)
        {
            if (_dbContext.Materias.Where(m => m.Nome == materiaNova.Nome).Where(m => m.Curso_Id == materiaNova.Curso_Id).Any())
                throw new DuplicateWaitObjectException();
            materiaAtual.Nome = materiaNova.Nome;
            materiaAtual.NomeProfessor = materiaNova.NomeProfessor;
            materiaAtual.Professor_Id = materiaNova.Professor_Id;
            materiaAtual.NomeCurso = materiaNova.NomeCurso;
            materiaAtual.Curso_Id = materiaNova.Curso_Id;
            materiaAtual.NomeTurno = materiaNova.NomeTurno;

            return materiaAtual;
        }

        public Materia Cadastrar(Materia materia)
        {
            if(_dbContext.Materias.Where(m => m.Nome == materia.Nome).Where(m => m.Curso_Id == materia.Curso_Id).Any())
                throw new DuplicateWaitObjectException();
            _dbContext.Materias.Add(materia);
            _dbContext.SaveChanges();

            return materia;
        }

        public void Deletar(Materia materia)
        {
            if (_dbContext.Materias.Where(m => m.Id == materia.Id).Any())
            {
                _dbContext.Materias.Remove(materia);
                _dbContext.SaveChanges();
            }
         }

        public List<Materia> Obter()
        {
            return _dbContext.Materias.ToList();
        }

        public Materia ObterPorId(int id)
        {
            return _dbContext.Materias.ToList().FirstOrDefault(m => m.Id == id);
        }
    }
}
