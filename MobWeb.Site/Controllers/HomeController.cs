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
            if (Session["usuarioLogadoID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
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
                    Session["usuarioLogadoID"] = v.Id.ToString();
                    Session["nomeUsuarioLogado"] = v.Usuario.ToString();
                    return RedirectToAction("Index");
                }
            }

            return View(user);
        }
    }
}