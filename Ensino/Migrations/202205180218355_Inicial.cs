namespace Ensino.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aluno",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Email = c.String(),
                        Telefone = c.String(nullable: false),
                        Responsavel = c.String(nullable: false),
                        Matricula = c.String(nullable: false),
                        Endereco = c.String(nullable: false),
                        Curso_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Curso", t => t.Curso_Id, cascadeDelete: true)
                .Index(t => t.Curso_Id);
            
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Turno = c.String(nullable: false),
                        QuantidadeAlunos = c.Int(nullable: false),
                        CargaHoraria = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Aluno", "Curso_Id", "dbo.Curso");
            DropIndex("dbo.Aluno", new[] { "Curso_Id" });
            DropTable("dbo.Curso");
            DropTable("dbo.Aluno");
        }
    }
}
