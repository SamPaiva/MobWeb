using MobWeb.Modelo;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MobWeb.Persistencia.Mapping
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");

            Property(x => x.ClienteId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.NomeFantasia).HasMaxLength(200).IsRequired();

            Property(c => c.Numero).IsRequired();

            Property(c => c.Municipio).HasMaxLength(150).IsRequired();

            Property(c => c.Logradouro).HasMaxLength(150);

            Property(c => c.RazaoSocial).HasMaxLength(150).IsRequired();

            Property(c => c.Bairro).HasMaxLength(200).IsRequired();

            Property(c => c.Cep).HasMaxLength(20).IsRequired();

            Property(c => c.Cnpj).HasMaxLength(50).IsRequired();

            Property(c => c.Complemento).HasMaxLength(150);

            Property(c => c.Endereco).HasMaxLength(250).IsRequired();
        }
    }
}
