namespace MobWeb.Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "Cep", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "Cep", c => c.Int(nullable: false));
        }
    }
}
