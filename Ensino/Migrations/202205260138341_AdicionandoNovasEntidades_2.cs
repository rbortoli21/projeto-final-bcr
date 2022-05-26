namespace Ensino.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionandoNovasEntidades_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Materia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        NomeCurso = c.String(),
                        NomeProfessor = c.String(),
                        Curso_Id = c.Int(),
                        Professor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Curso", t => t.Curso_Id)
                .ForeignKey("dbo.Professor", t => t.Professor_Id)
                .Index(t => t.Curso_Id)
                .Index(t => t.Professor_Id);
            
            CreateTable(
                "dbo.Professor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Endereco = c.String(),
                        Telefone = c.String(),
                        Email = c.String(),
                        CPF = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Materia", "Professor_Id", "dbo.Professor");
            DropForeignKey("dbo.Materia", "Curso_Id", "dbo.Curso");
            DropIndex("dbo.Materia", new[] { "Professor_Id" });
            DropIndex("dbo.Materia", new[] { "Curso_Id" });
            DropTable("dbo.Professor");
            DropTable("dbo.Materia");
        }
    }
}
