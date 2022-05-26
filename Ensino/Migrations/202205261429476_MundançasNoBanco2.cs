namespace Ensino.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MundançasNoBanco2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Professor", "Turno", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Professor", "Turno");
        }
    }
}
