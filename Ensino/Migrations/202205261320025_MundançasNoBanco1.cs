namespace Ensino.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MundançasNoBanco1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Materia", "Curso_Id", "dbo.Curso");
            DropForeignKey("dbo.Materia", "Professor_Id", "dbo.Professor");
            DropIndex("dbo.Materia", new[] { "Curso_Id" });
            DropIndex("dbo.Materia", new[] { "Professor_Id" });
            AlterColumn("dbo.Materia", "Curso_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Materia", "Professor_Id", c => c.Int(nullable: false));
            AddForeignKey("dbo.Materia", "Professor_Id", "dbo.Professor", "Id");
            AddForeignKey("dbo.Materia", "Curso_Id", "dbo.Curso", "Id");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Materia", "Professor_Id", c => c.Int());
            AlterColumn("dbo.Materia", "Curso_Id", c => c.Int());
            CreateIndex("dbo.Materia", "Professor_Id");
            CreateIndex("dbo.Materia", "Curso_Id");
            AddForeignKey("dbo.Materia", "Professor_Id", "dbo.Professor", "Id");
            AddForeignKey("dbo.Materia", "Curso_Id", "dbo.Curso", "Id");
        }
    }
}
