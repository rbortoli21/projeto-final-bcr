namespace Ensino.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterandoTabelasNovamente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Curso", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Curso", "Turno", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Curso", "Turno", c => c.String());
            AlterColumn("dbo.Curso", "Nome", c => c.String());
        }
    }
}
