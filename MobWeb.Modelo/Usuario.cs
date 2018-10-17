using System.ComponentModel;

namespace MobWeb.Modelo
{
    public class Usuario
    {
        public long UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }

        [DisplayName("E-mail")]
        public string Email { get; set; }
        public string Telefone { get; set; }

    }
}
