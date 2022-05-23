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
        
        public Aluno Alterar(Aluno alunoAtual, Aluno alunoNovo)
        {
            if(_dbContext.Alunos.Where(c => c.CPF== alunoNovo.CPF).Any())
                throw new DuplicateWaitObjectException();
            alunoAtual.Nome = alunoNovo.Nome;
            alunoAtual.CPF = alunoNovo.CPF;
            alunoAtual.Curso = alunoNovo.Curso;
            alunoAtual.Email = alunoNovo.Email;
            alunoAtual.Endereco = alunoNovo.Endereco;
            alunoAtual.Matricula = alunoNovo.Matricula;
            alunoAtual.Telefone = alunoNovo.Telefone;
            alunoAtual.Responsavel = alunoNovo.Responsavel;
            return alunoAtual;
        }

        public Aluno Cadastrar(Aluno aluno)
        {
            _dbContext.Alunos.Add(aluno);
            _dbContext.SaveChanges();
            return aluno;
        }

        public Aluno Deletar(Aluno aluno)
        {
            if (_dbContext.Alunos.Where(c => c.Id == aluno.Id).Any())
            {
                _dbContext.Alunos.Remove(aluno);
                _dbContext.SaveChanges();
            }
            return aluno;
        } 

        public List<Aluno> Obter()
        => _dbContext.Alunos.ToList();
        public Aluno ObterPorId(int id)
        => _dbContext.Alunos.ToList().FirstOrDefault(aluno => aluno.Id == id);

    }
}
