namespace Ensino.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterandoTabelasNovamente3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aluno", "NomeCurso", c => c.String(nullable: false));
            AlterColumn("dbo.Aluno", "CPF", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Aluno", "CPF", c => c.String(nullable: false));
            DropColumn("dbo.Aluno", "NomeCurso");
        }
    }
}
