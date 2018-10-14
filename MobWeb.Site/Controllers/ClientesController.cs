using MobWeb.Modelo;
using MobWeb.Servico.Services;
using System.Net;
using System.Web.Mvc;

namespace MobWeb.Site.Controllers
{
    public class ClientesController : Controller
    {
        private ClienteServico clienteServico = new ClienteServico();
        
        // GET: Clientes

        public ActionResult ListarClientes()
        {
            return View(clienteServico.ObterClientePorNome());
        }

        #region - Adicionar Cliente
        public ActionResult AdicionarCliente()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]

        public ActionResult AdicionarCliente(Cliente cliente)
        {
            clienteServico.GravarCliente(cliente);
            return RedirectToAction("ListarClientes");
        }

        #endregion

        #region - Editar CLiente

        public ActionResult EditarCliente(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Cliente cliente = clienteServico.ObterCLientePorId((long)id);

            if (cliente == null)
            {
                return HttpNotFound();
            }

            return View(cliente);
        }

        [HttpPost]

        public ActionResult EditarCliente(Cliente cliente)
        {
            clienteServico.EditarCliente(cliente);
            return RedirectToAction("ListarClientes");
        }

        #endregion

        #region - Deletar Cliente

        public ActionResult DeletarCliente(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Cliente cliente = clienteServico.ObterCLientePorId((long)id);

            if (cliente == null)
            {
                return HttpNotFound();
            }

                return View(cliente);
        }

        [HttpPost]
        public ActionResult DeletarCliente(long id)
        {
            Cliente cliente = clienteServico.EliminarClientePorId(id);
            return RedirectToAction("ListarClientes");
        }

        #endregion
    }
}