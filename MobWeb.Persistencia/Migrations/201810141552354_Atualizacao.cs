namespace MobWeb.Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacao : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "NomeFantasia", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "NomeFantasia", c => c.String(maxLength: 200));
        }
    }
}
