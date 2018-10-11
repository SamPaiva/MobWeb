using MobWeb.Modelo;
using MobWeb.Persistencia.Context;
using System.Data.Entity;
using System.Linq;

namespace MobWeb.Persistencia.DAL
{
    public class UsuarioDAL
    {
        private EFContext db = new EFContext();

        public IQueryable<Usuario> ListarUsuarios()
        {
            return db.Usuarios.OrderBy(c => c.Nome);
        }

        public Usuario ObterUsuarioPorId(long id)
        {
            return db.Usuarios.Where(c => c.UsuarioId == id).First();
        }

        public void GravarUsuario(Usuario usuario)
        {
            if (usuario.UsuarioId == null)
            {
                db.Usuarios.Add(usuario);
            }
            else
            {
                db.Entry(usuario).State = EntityState.Modified;
            }

            db.SaveChanges();
        }

        public Usuario EliminarUsuarioPorId(long id)
        {
            Usuario usuario = db.Usuarios.Find(id);
            db.Usuarios.Remove(usuario);
            db.SaveChanges();
            return usuario;
        }
    }
}
