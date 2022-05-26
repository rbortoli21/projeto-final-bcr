using Ensino.Data;
using Ensino.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Models.Repositories
{
    public class ProfessorRepository : IProfessorRepository
    {
        private DataContext _dbContext;
        public ProfessorRepository()
        {
            _dbContext = new DataContext();
        }
        public Professor Alterar(Professor professorAtual, Professor professorNovo)
        {
            professorAtual.Nome = professorNovo.Nome;
            professorAtual.Email = professorNovo.Email;
            professorAtual.Endereco = professorNovo.Endereco;
            professorAtual.Telefone = professorNovo.Telefone;
            professorAtual.Turno = professorNovo.Turno;

            _dbContext.SaveChanges();

            return professorAtual;
        }

        public Professor Cadastrar(Professor professor)
        {
            if (_dbContext.Alunos.Where(a => a.CPF == professor.CPF).Any())
                throw new DuplicateWaitObjectException($"Professor já está cadastrado.");
            _dbContext.Professores.Add(professor);
            _dbContext.SaveChanges();

            return professor;
        }

        public void Deletar(Professor professor)
        {
            if (_dbContext.Professores.Where(c => c.CPF == professor.CPF).Any())
            {
                _dbContext.Professores.Remove(professor);
                _dbContext.SaveChanges();
            }
        }

        public List<Professor> Obter()
        {
            return _dbContext.Professores.ToList();
        }

        public Professor ObterPorId(int id)
        {
            return _dbContext.Professores.ToList().FirstOrDefault(p => p.Id == id);
        }
    }
}
