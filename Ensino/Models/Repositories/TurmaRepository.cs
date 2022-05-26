using Ensino.Data;
using Ensino.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Models.Repositories
{
    public class TurmaRepository : ITurmaRepository
    {
        private DataContext _dbContext;
        public TurmaRepository()
        {
            _dbContext = new DataContext(); 
        }
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
        {
            return _dbContext.Turmas.ToList();
        }

        public Turma ObterPorId(int id)
        {
            return _dbContext.Turmas.ToList().FirstOrDefault(t => t.Id == id);
        }
    }
}
