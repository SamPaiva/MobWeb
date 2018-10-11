namespace MobWeb.Modelo
{
    public class Cliente
    {
        public long ClienteId { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public int Cnpj { get; set; }
        public string Endereco { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string  Bairro { get; set; }
        public string Complemento { get; set; }
        public string Municipio { get; set; }
        public int Cep { get; set; }

    }
}
