using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MobWeb.Modelo
{
    public class Cliente
    {
        public long ClienteId { get; set; }

        [DisplayName("R. Social")]
        public string RazaoSocial { get; set; }

        [DisplayName("N. Fantasia")]
        public string NomeFantasia { get; set; }

        [DisplayName("CNPJ")]
        
        public int Cnpj { get; set; }

        [DisplayName("End.")]
        
        public string Endereco { get; set; }

        [DisplayName("Logra.")]
        public string Logradouro { get; set; }

        [DisplayName("Núm.")]
        
        public int Numero { get; set; }
        
        public string  Bairro { get; set; }

        [DisplayName("Compl.")]
        public string Complemento { get; set; }

        [DisplayName("Município")]
        
        public string Municipio { get; set; }

        [DisplayName("CEP")]
        public int Cep { get; set; }

    }
}
