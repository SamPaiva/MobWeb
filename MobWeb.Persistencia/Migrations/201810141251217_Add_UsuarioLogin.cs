namespace MobWeb.Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_UsuarioLogin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UsuarioLogin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usuario = c.String(nullable: false, maxLength: 150),
                        Senha = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UsuarioLogin");
        }
    }
}
