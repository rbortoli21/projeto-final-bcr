namespace Ensino.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teste : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Aluno", "Curso_Id", "dbo.Curso");
            DropIndex("dbo.Aluno", new[] { "Curso_Id" });
            AlterColumn("dbo.Aluno", "Nome", c => c.String());
            AlterColumn("dbo.Aluno", "CPF", c => c.String());
            AlterColumn("dbo.Aluno", "Telefone", c => c.String());
            AlterColumn("dbo.Aluno", "Email", c => c.String());
            AlterColumn("dbo.Aluno", "Responsavel", c => c.String());
            AlterColumn("dbo.Aluno", "Endereco", c => c.String());
            AlterColumn("dbo.Aluno", "Curso_Id", c => c.Int());
            CreateIndex("dbo.Aluno", "Curso_Id");
            AddForeignKey("dbo.Aluno", "Curso_Id", "dbo.Curso", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Aluno", "Curso_Id", "dbo.Curso");
            DropIndex("dbo.Aluno", new[] { "Curso_Id" });
            AlterColumn("dbo.Aluno", "Curso_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Aluno", "Endereco", c => c.String(nullable: false));
            AlterColumn("dbo.Aluno", "Responsavel", c => c.String(nullable: false));
            AlterColumn("dbo.Aluno", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Aluno", "Telefone", c => c.String(nullable: false));
            AlterColumn("dbo.Aluno", "CPF", c => c.String(nullable: false));
            AlterColumn("dbo.Aluno", "Nome", c => c.String(nullable: false));
            CreateIndex("dbo.Aluno", "Curso_Id");
            AddForeignKey("dbo.Aluno", "Curso_Id", "dbo.Curso", "Id", cascadeDelete: true);
        }
    }
}
