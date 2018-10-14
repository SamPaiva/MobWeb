using MobWeb.Modelo;
using MobWeb.Servico.Services;
using System.Web.Mvc;

namespace MobWeb.Site.Controllers
{
    public class UsuariosController : Controller
    {
        private UsuarioServico usuarioServico = new UsuarioServico();

        // GET: Usuario
        public ActionResult ListarUsuario()
        {
            return View(usuarioServico.ObterUsuariosPorNome());
        }

        #region - AdicionarUsuario

        public ActionResult AdicionarUsuario()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]

        public ActionResult AdicionarUsuario(Usuario usuario)
        {
            usuarioServico.GravarUsuario(usuario);
            return RedirectToAction("ListarUsuario");
        }
    }
}