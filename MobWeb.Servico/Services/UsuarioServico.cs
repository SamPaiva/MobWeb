using MobWeb.Modelo;
using MobWeb.Persistencia.DAL;
using System.Linq;

namespace MobWeb.Servico.Services
{
    public class UsuarioServico
    {
        private UsuarioDAL usuarioDAL = new UsuarioDAL();

        public IQueryable<Usuario> ObterUsuariosPorNome()
        {
            return usuarioDAL.ListarUsuarios();
        } 

        public Usuario ObterUsuarioPorId(long id)
        {
            return usuarioDAL.ObterUsuarioPorId(id);
        }

        public void GravarUsuario(Usuario usuario)
        {
            usuarioDAL.GravarUsuario(usuario);
        }

        public void EditarUsuario(Usuario usuario)
        {
            usuarioDAL.EditarUsuario(usuario);
        }

        public Usuario EliminarUsuarioPorId(long id)
        {
            return usuarioDAL.EliminarUsuarioPorId(id);
        }
    }
}
