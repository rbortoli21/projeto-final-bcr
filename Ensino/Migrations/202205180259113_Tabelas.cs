﻿namespace Ensino.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tabelas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Aluno", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Aluno", "Email", c => c.String());
        }
    }
}
