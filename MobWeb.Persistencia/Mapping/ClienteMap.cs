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

            Property(c => c.NomeFantasia).HasMaxLength(200);

            Property(c => c.Numero).IsRequired();

            Property(c => c.Municipio).HasMaxLength(150).IsRequired();

            Property(c => c.Logradouro).HasMaxLength(150);

            Property(c => c.RazaoSocial).HasMaxLength(150).IsRequired();

            Property(c => c.Bairro).HasMaxLength(200).IsRequired();

            Property(c => c.Cep);

            Property(c => c.Cnpj).IsRequired();

            Property(c => c.Complemento).HasMaxLength(150);

            Property(c => c.Endereco).HasMaxLength(250).IsRequired();
        }
    }
}
