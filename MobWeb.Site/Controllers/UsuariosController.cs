using MobWeb.Modelo;
using MobWeb.Servico.Services;
using System.Net;
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

        #region - Adicionar Usuario

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

        #endregion

        #region - Editar Usuario

        public ActionResult EditarUsuario(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Usuario usuario = usuarioServico.ObterUsuarioPorId((long)id);

            if (usuario == null)
            {
                return HttpNotFound();
            }

            return View(usuario);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]

        public ActionResult EditarUsuario(Usuario usuario)
        {
            usuarioServico.EditarUsuario(usuario);
            return RedirectToAction("ListarUsuario");
        }

        #endregion

        #region - Deletar Usuário

        public ActionResult DeletarUsuario(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Usuario usuario = usuarioServico.ObterUsuarioPorId((long)id);

            if (usuario == null)
            {
                return HttpNotFound();
            }

            return View(usuario);
        }

        [HttpPost]

        public ActionResult DeletarUsuario(long id)
        {
            usuarioServico.EliminarUsuarioPorId(id);
            return RedirectToAction("ListarUsuario");

        }

        #endregion

        
    }
}