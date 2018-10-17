using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MobWeb.Modelo
{
    public class Cliente
    {
        public long ClienteId { get; set; }

        [DisplayName("R. Social")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("N. Fantasia")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("End.")]
        public string Endereco { get; set; }

        [DisplayName("Logra.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Núm.")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string  Bairro { get; set; }

        [DisplayName("Compl.")]
        public string Complemento { get; set; }

        [DisplayName("Município")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Municipio { get; set; }

        [DisplayName("CEP")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Cep { get; set; }

    }
}
