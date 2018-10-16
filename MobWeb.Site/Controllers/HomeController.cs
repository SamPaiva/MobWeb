using MobWeb.Modelo;
using MobWeb.Persistencia.Context;
using System.Linq;
using System.Web.Mvc;

namespace MobWeb.Site.Controllers
{
    public class HomeController : Controller
    {
        private EFContext db = new EFContext();

        // GET: Home
        public ActionResult Index()
        {
            if (Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Login(UsuarioLogin user)
        {
            if (ModelState.IsValid)
            {
                var v = db.UsuarioLogin.Where(c => c.Usuario.Equals(c.Usuario) && c.Senha.Equals(c.Senha)).FirstOrDefault();

                if (v != null)
                {
                    Session["usuarioLogadoID"] = new UsuarioLogin();
                    Session["nomeUsuarioLogado"] = v.Usuario.ToString();
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(user);
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }

    }
}