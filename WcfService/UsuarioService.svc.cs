using Controllers.Repositorios;
using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "UsuarioService" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione UsuarioService.svc ou UsuarioService.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class UsuarioService : IUsuario
    {
        private UsuarioRep rep = new UsuarioRep();

        public void Cadastrar(Usuario obj)
        {
            rep.Cadastrar(obj);
        }

        public Usuario Buscar(int id)
        {
            return rep.Buscar(id);
        }


        public List<Usuario> Listar()
        {
            return rep.Listar();
        }

        public void Deletar(int id)
        {
            rep.Deletar(id);
        }

        public void Editar(Usuario objNovo)
        {
            rep.Editar(objNovo);
        }

        public bool login(string usuario, string senha)
        {
           
            return rep.Login(usuario, senha);
        }
    }
}
