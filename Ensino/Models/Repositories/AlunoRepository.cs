using Ensino.Data;
using Ensino.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Models.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private DataContext _dbContext;
        public AlunoRepository() => _dbContext = new DataContext();
        
        public void Alterar()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Aluno aluno)
        {
            _dbContext.Alunos.Add(aluno);
            _dbContext.SaveChanges();
        }

        public void Deletar(Aluno aluno)
        {
            _dbContext.Alunos.Remove(aluno);
            _dbContext.SaveChanges();
        } 

        public List<Aluno> Obter()
        => _dbContext.Alunos.ToList();
        public Aluno ObterPorId(int id)
        => _dbContext.Alunos.ToList().FirstOrDefault(aluno => aluno.Id == id);

    }
}
