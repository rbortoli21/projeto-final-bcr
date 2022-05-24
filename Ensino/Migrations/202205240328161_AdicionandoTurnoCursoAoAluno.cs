namespace Ensino.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionandoTurnoCursoAoAluno : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aluno", "TurnoCurso", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Aluno", "TurnoCurso");
        }
    }
}
