using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MobWeb.Modelo
{
    public class Usuario
    {
        public long UsuarioId { get; set; }

        public string Nome { get; set; }
        public string Apelido { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

    }
}
