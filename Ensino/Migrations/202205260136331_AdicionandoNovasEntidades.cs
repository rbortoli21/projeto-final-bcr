namespace Ensino.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionandoNovasEntidades : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Turma",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeCurso = c.String(),
                        TurnoCurso = c.String(),
                        QtdAlunos = c.Int(nullable: false),
                        Curso_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Curso", t => t.Curso_Id)
                .Index(t => t.Curso_Id);
            
            AddColumn("dbo.Aluno", "Turma_Id", c => c.Int());
            CreateIndex("dbo.Aluno", "Turma_Id");
            AddForeignKey("dbo.Aluno", "Turma_Id", "dbo.Turma", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Aluno", "Turma_Id", "dbo.Turma");
            DropForeignKey("dbo.Turma", "Curso_Id", "dbo.Curso");
            DropIndex("dbo.Turma", new[] { "Curso_Id" });
            DropIndex("dbo.Aluno", new[] { "Turma_Id" });
            DropColumn("dbo.Aluno", "Turma_Id");
            DropTable("dbo.Turma");
        }
    }
}
