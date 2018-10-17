namespace MobWeb.Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsuarioAtt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuario", "Nome", c => c.String(maxLength: 150));
            AlterColumn("dbo.Usuario", "Email", c => c.String(maxLength: 150));
            AlterColumn("dbo.Usuario", "Telefone", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuario", "Telefone", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Usuario", "Email", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Usuario", "Nome", c => c.String(nullable: false, maxLength: 150));
        }
    }
}
