namespace MobWeb.Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alteracoes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuario", "Nome", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuario", "Nome", c => c.String(nullable: false, maxLength: 150));
        }
    }
}
