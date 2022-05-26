namespace Ensino.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MundançasNoBanco : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Aluno", "Curso_Id", "dbo.Curso");
            DropForeignKey("dbo.Aluno", "Turma_Id", "dbo.Turma");
            DropIndex("dbo.Aluno", new[] { "Curso_Id" });
            DropIndex("dbo.Aluno", new[] { "Turma_Id" });
            AlterColumn("dbo.Aluno", "Curso_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Aluno", "Turma_Id", c => c.Int(nullable: false));
            AddForeignKey("dbo.Aluno", "Turma_Id", "dbo.Turma", "Id");
            AddForeignKey("dbo.Aluno", "Curso_Id", "dbo.Curso", "Id");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Aluno", "Turma_Id", c => c.Int());
            AlterColumn("dbo.Aluno", "Curso_Id", c => c.Int());
            CreateIndex("dbo.Aluno", "Turma_Id");
            CreateIndex("dbo.Aluno", "Curso_Id");
            AddForeignKey("dbo.Aluno", "Turma_Id", "dbo.Turma", "Id");
            AddForeignKey("dbo.Aluno", "Curso_Id", "dbo.Curso", "Id");
        }
    }
}
