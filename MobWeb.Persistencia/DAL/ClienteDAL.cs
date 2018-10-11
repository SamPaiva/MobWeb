using MobWeb.Modelo;
using MobWeb.Persistencia.Context;
using System.Data.Entity;
using System.Linq;

namespace MobWeb.Persistencia.DAL
{
    public class ClienteDAL
    {
        private EFContext db = new EFContext();

        public IQueryable<Cliente> ListarClientes()
        {
            return db.Clientes.OrderBy(c => c.NomeFantasia);
        }

        public Cliente ObterClientePorId(long id)
        {
            return db.Clientes.Where(c => c.ClienteId == id).First();
        }

        public void GravarCliente(Cliente cliente)
        {
            if (cliente.ClienteId == null)
            {
                db.Clientes.Add(cliente);
            }
            else
            {
                db.Entry(cliente).State = EntityState.Modified;
            }

            db.SaveChanges();
        }

        public Cliente EliminarClientePorId(long id)
        {
            Cliente cliente = db.Clientes.Find(id);
            db.Clientes.Remove(cliente);
            db.SaveChanges();
            return cliente;
        }
    }
}
