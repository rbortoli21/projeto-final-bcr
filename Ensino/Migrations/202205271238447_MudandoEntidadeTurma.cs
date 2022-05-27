namespace Ensino.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MudandoEntidadeTurma : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Turma", "Curso_Id", "dbo.Curso");
            DropIndex("dbo.Turma", new[] { "Curso_Id" });
            AlterColumn("dbo.Turma", "Curso_Id", c => c.Int(nullable: false));
            AddForeignKey("dbo.Turma", "Curso_Id", "dbo.Curso", "Id");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Turma", "Curso_Id", c => c.Int());
            CreateIndex("dbo.Turma", "Curso_Id");
            AddForeignKey("dbo.Turma", "Curso_Id", "dbo.Curso", "Id");
        }
    }
}
