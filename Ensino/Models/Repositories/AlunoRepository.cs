﻿using AutoMapper;
using Ensino.Data;
using Ensino.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Models.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private DataContext _dbContext;
        public AlunoRepository()
        {
            _dbContext = new DataContext();
        }

        public Aluno Alterar(Aluno alunoAtual, Aluno alunoNovo)
        {
            alunoAtual.Nome = alunoNovo.Nome;
            alunoAtual.Curso = alunoNovo.Curso;
            alunoAtual.Email = alunoNovo.Email;
            alunoAtual.Endereco = alunoNovo.Endereco;
            alunoAtual.Telefone = alunoNovo.Telefone;
            alunoAtual.Responsavel = alunoNovo.Responsavel;
            alunoAtual.NomeCurso = alunoNovo.NomeCurso;

            _dbContext.SaveChanges();

            return alunoAtual;
        }

        public Aluno Cadastrar(Aluno aluno)
        {
            if (_dbContext.Alunos.Where(a => a.CPF == aluno.CPF).Any())
                throw new DuplicateWaitObjectException($"O aluno de CPF \"{aluno.CPF}\" já está cadastrado.");
            else
            {
                _dbContext.Alunos.Add(aluno);
                _dbContext.SaveChanges();
            }
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
