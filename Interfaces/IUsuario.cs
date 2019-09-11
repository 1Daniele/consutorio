using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Interfaces
{
    [ServiceContract]
    public interface IUsuario
    {
        [OperationContract]
        void Cadastrar(Usuario obj);

        [OperationContract]
        Usuario Buscar(int id);

        [OperationContract]
        List<Usuario> Listar();

        [OperationContract]
        void Deletar(int id);

        [OperationContract]
        void Editar(Usuario objNovo);

         [OperationContract]
        bool login(string usuario, string senha);
    }

 }
