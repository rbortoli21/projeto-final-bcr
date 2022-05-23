namespace Ensino.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterandoTabelasNovamente2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Aluno", "Curso_Id", "dbo.Curso");
            DropIndex("dbo.Aluno", new[] { "Curso_Id" });
            AlterColumn("dbo.Aluno", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Aluno", "CPF", c => c.String(nullable: false));
            AlterColumn("dbo.Aluno", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Aluno", "Telefone", c => c.String(nullable: false));
            AlterColumn("dbo.Aluno", "Responsavel", c => c.String(nullable: false));
            AlterColumn("dbo.Aluno", "Matricula", c => c.String(nullable: false));
            AlterColumn("dbo.Aluno", "Endereco", c => c.String(nullable: false));
            AlterColumn("dbo.Aluno", "Curso_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Aluno", "Curso_Id");
            AddForeignKey("dbo.Aluno", "Curso_Id", "dbo.Curso", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Aluno", "Curso_Id", "dbo.Curso");
            DropIndex("dbo.Aluno", new[] { "Curso_Id" });
            AlterColumn("dbo.Aluno", "Curso_Id", c => c.Int());
            AlterColumn("dbo.Aluno", "Endereco", c => c.String());
            AlterColumn("dbo.Aluno", "Matricula", c => c.String());
            AlterColumn("dbo.Aluno", "Responsavel", c => c.String());
            AlterColumn("dbo.Aluno", "Telefone", c => c.String());
            AlterColumn("dbo.Aluno", "Email", c => c.String());
            AlterColumn("dbo.Aluno", "CPF", c => c.String());
            AlterColumn("dbo.Aluno", "Nome", c => c.String());
            CreateIndex("dbo.Aluno", "Curso_Id");
            AddForeignKey("dbo.Aluno", "Curso_Id", "dbo.Curso", "Id");
        }
    }
}
