using MobWeb.Modelo;
using MobWeb.Persistencia.Mapping;
using MobWeb.Persistencia.Migrations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MobWeb.Persistencia.Context
{
    public class EFContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new UsuarioLoginMap());

            base.OnModelCreating(modelBuilder);
        }

        public EFContext() : base("MobWeb")
        {
            Database.SetInitializer<EFContext>(new MigrateDatabaseToLatestVersion<EFContext, Configuration>());            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioLogin> UsuarioLogin { get; set; }
    }
}
