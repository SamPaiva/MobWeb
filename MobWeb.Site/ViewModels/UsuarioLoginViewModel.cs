using System.ComponentModel.DataAnnotations;

namespace MobWeb.Site.ViewModels
{
    public class UsuarioLoginViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por Favor insira um nome de Usuário Válido")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Por Favor insira uma senha Válida")]
        public string Senha { get; set; }
    }
}