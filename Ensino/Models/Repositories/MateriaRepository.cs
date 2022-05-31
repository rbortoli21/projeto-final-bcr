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
    public class MateriaRepository : IBaseRepository<Materia>
    {
        private DataContext _dbContext;
        public MateriaRepository() => _dbContext = new DataContext();
        public Materia Alterar(Materia materiaAtual, Materia materiaNova)
        {
            if (_dbContext.Materias.Where(m => m.Nome == materiaNova.Nome && m.Curso_Id == materiaNova.Curso_Id).Any())
                throw new DuplicateWaitObjectException();
            materiaAtual.Nome = materiaNova.Nome;
            materiaAtual.NomeProfessor = materiaNova.NomeProfessor;
            materiaAtual.Professor_Id = materiaNova.Professor_Id;
            materiaAtual.NomeCurso = materiaNova.NomeCurso;
            materiaAtual.Curso_Id = materiaNova.Curso_Id;
            materiaAtual.NomeTurno = materiaNova.NomeTurno;

            _dbContext.SaveChanges();

            return materiaAtual;
        }
        public Materia Cadastrar(Materia materia)
        {
            if(_dbContext.Materias.Where(m => m.Nome == materia.Nome).Where(m => m.NomeTurno == materia.NomeTurno).Where(m => m.Curso_Id == materia.Curso_Id).Any())
                throw new DuplicateWaitObjectException();
            _dbContext.Materias.Add(materia);
            _dbContext.SaveChanges();

            return materia;
        }
        public Materia Deletar(Materia materia)
        {
            if (_dbContext.Materias.Where(m => m.Id == materia.Id).Any())
            {
                _dbContext.Materias.Remove(materia);
                _dbContext.SaveChanges();
            }
            return materia;
         }
        public List<Materia> Obter()
        => _dbContext.Materias.ToList();
        public Materia ObterPorId(int id)
        => _dbContext.Materias.ToList().FirstOrDefault(m => m.Id == id);
        public List<Materia> BuscaPorTexto(TextBox textbox)
        {
            List<Materia> busca = new List<Materia>();
            foreach (var objeto in Obter())
            {
                if (objeto.Id.ToString().ToLower().Contains(textbox.Text.ToLower()))
                    busca.Add(objeto);
                else if (objeto.Nome.ToLower().Contains(textbox.Text.ToLower()))
                    busca.Add(objeto);
                else if (objeto.NomeCurso.ToString().ToLower().Contains(textbox.Text.ToLower()))
                    busca.Add(objeto);
                else if (objeto.NomeProfessor.ToString().ToLower().Contains(textbox.Text.ToLower()))
                    busca.Add(objeto);
                else if (objeto.NomeTurno.ToLower().Contains(textbox.Text.ToLower()))
                    busca.Add(objeto);
            }
            return busca;
        }
    }
}
