namespace MobWeb.Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AttMap : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuario", "Email", c => c.String(maxLength: 150));
            AlterColumn("dbo.Usuario", "Telefone", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuario", "Telefone", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Usuario", "Email", c => c.String(nullable: false, maxLength: 150));
        }
    }
}
