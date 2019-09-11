using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers.Context;
using Entidades;

namespace Controllers.Repositorios
{
    public class UsuarioRep
    {
        public void Cadastrar(Usuario obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Usuarios.Add(obj);
                ctx.SaveChanges();
            }


        }


        public Usuario Buscar(int id)
        {
            Usuario obj = new Usuario();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Usuarios.Find(id);
            }
            return obj;
        }


        public List<Usuario> Listar()
        {

            using (var ctx = new SistemaContext())
            {
                var Usuarios = (from obj in ctx.Usuarios select obj).OrderBy(x => x.User).ToList();
                return Usuarios;
            }

        }


        public void Deletar(int id)
        {
            using (var ctx = new SistemaContext())
            {
                Usuario obj = ctx.Usuarios.Find(id);
                ctx.Usuarios.Remove(obj);
                ctx.SaveChanges();
            }
        }

        public void Editar(Usuario objNovo)
        {
            using (var ctx = new SistemaContext())
            {
                Usuario objAntigo = ctx.Usuarios.Find(objNovo.Id);
                objAntigo.User = objNovo.User;
                objAntigo.Senha = objNovo.Senha;
               
                ctx.SaveChanges();
            }
        }

        public  bool Login(string usuario, string senha )
        {
            using (var ctx = new SistemaContext())
            {
                var Usuarios = ctx.Usuarios.Where(u=> u.User == usuario && u.Senha == senha).FirstOrDefault();

                if  (Usuarios != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
