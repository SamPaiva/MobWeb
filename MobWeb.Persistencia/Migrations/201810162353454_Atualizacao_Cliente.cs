namespace MobWeb.Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacao_Cliente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "Cnpj", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Cliente", "Cep", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "Cep", c => c.String());
            AlterColumn("dbo.Cliente", "Cnpj", c => c.Int(nullable: false));
        }
    }
}
