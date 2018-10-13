namespace MobWeb.Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Long(nullable: false, identity: true),
                        RazaoSocial = c.String(nullable: false, maxLength: 150),
                        NomeFantasia = c.String(maxLength: 200),
                        Cnpj = c.Int(nullable: false),
                        Endereco = c.String(nullable: false, maxLength: 250),
                        Logradouro = c.String(maxLength: 150),
                        Numero = c.Int(nullable: false),
                        Bairro = c.String(nullable: false, maxLength: 200),
                        Complemento = c.String(maxLength: 150),
                        Municipio = c.String(nullable: false, maxLength: 150),
                        Cep = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioId = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150),
                        Apelido = c.String(maxLength: 150),
                        Email = c.String(nullable: false, maxLength: 150),
                        Telefone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
            DropTable("dbo.Cliente");
        }
    }
}
