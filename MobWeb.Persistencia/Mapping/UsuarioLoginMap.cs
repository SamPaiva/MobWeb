using MobWeb.Modelo;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MobWeb.Persistencia.Mapping
{
    public class UsuarioLoginMap : EntityTypeConfiguration<UsuarioLogin>
    {
        public UsuarioLoginMap()
        {
            ToTable("UsuarioLogin");

            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Usuario).HasMaxLength(150).IsRequired();

            Property(c => c.Senha).HasMaxLength(150).IsRequired();


        }
    }
}
