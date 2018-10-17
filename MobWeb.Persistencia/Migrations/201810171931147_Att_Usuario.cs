namespace MobWeb.Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Att_Usuario : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuario", "Telefone", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuario", "Telefone", c => c.Int(nullable: false));
        }
    }
}
