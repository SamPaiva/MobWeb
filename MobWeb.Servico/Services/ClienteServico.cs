using MobWeb.Modelo;
using MobWeb.Persistencia.DAL;
using System.Linq;

namespace MobWeb.Servico.Services
{
    public class ClienteServico
    {
        private ClienteDAL clienteDAL = new ClienteDAL();

        public IQueryable<Cliente> ObterClientePorNome()
        {
            return clienteDAL.ListarClientes();
        }

        public Cliente ObterCLientePorId(long id)
        {
            return clienteDAL.ObterClientePorId(id);
        }

        public void GravarCliente(Cliente cliente)
        {
            clienteDAL.GravarCliente(cliente);
        }

        public void EditarCliente(Cliente cliente)
        {
           clienteDAL.EditarCliente(cliente);
        } 

        public Cliente EliminarClientePorId(long id)
        {
            return clienteDAL.EliminarClientePorId(id);
        }
    }
}
