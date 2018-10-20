using Microsoft.Ajax.Utilities;
using MobWeb.Modelo;
using MobWeb.Persistencia.Context;
using MobWeb.Servico.Services;
using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MobWeb.Site.Controllers
{
    public class ClientesController : Controller
    {
        private ClienteServico clienteServico = new ClienteServico();
        private EFContext db = new EFContext();
        
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

        public ActionResult AdicionarCliente(Cliente cliente, string cnpj)
        {
            var result = db.Clientes.Where(c => c.Cnpj.Contains(cnpj)).FirstOrDefault();
            if (result != null)
            {
                TempData["mensagem"] = "Por favor insira um CNPJ não cadastrado";
                return RedirectToAction("AdicionarCliente");
                
            }

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

        public ActionResult EditarCliente(Cliente cliente, string cnpj)
        {
            var result = db.Clientes.Where(c => c.Cnpj.Contains(cnpj)).FirstOrDefault();

            if (result != null)
            {
                TempData["mensagem"] = "Por favor insira um CNPJ não cadastrado";
                return RedirectToAction("EditarCliente");

            }

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
        
        public JsonResult CheckCnpj(string cnpj)
        {

            System.Threading.Thread.Sleep(200);
            var result = db.Clientes.Where(c => c.Cnpj.Contains(cnpj)).FirstOrDefault();
            if(result != null)
            {
                return Json(1);
            }
            else
            {
                return Json(0);
                
            }
        }
    }
}