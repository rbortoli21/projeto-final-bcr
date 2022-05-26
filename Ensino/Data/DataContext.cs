using Ensino.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("PgConexao") { }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Turma> Turmas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        { 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
