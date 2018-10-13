using System.ComponentModel;

namespace MobWeb.Modelo
{
    public class Cliente
    {
        public long ClienteId { get; set; }

        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }

        [DisplayName("Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [DisplayName("CNPJ")]
        public int Cnpj { get; set; }

        [DisplayName("Endereço")]
        public string Endereco { get; set; }
        public string Logradouro { get; set; }

        [DisplayName("Número")]
        public int Numero { get; set; }
        public string  Bairro { get; set; }
        public string Complemento { get; set; }

        [DisplayName("Município")]
        public string Municipio { get; set; }

        [DisplayName("CEP")]
        public int Cep { get; set; }

    }
}
