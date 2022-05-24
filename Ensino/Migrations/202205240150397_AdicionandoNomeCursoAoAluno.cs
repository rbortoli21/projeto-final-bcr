namespace Ensino.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionandoNomeCursoAoAluno : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aluno", "NomeCurso", c => c.String());
            AddColumn("dbo.Aluno", "CPF", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Aluno", "CPF");
            AlterColumn("dbo.Aluno", "NomeCurso", c => c.String(nullable: false));
        }
    }
}
