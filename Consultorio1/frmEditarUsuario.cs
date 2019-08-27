using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace Consultorio1
{
    public partial class frmEditarUsuario : Form
    {
        public string status;
        Usuario obj = new Usuario();
        UsuarioService service = new UsuarioService();
        public frmEditarUsuario(Usuario obj)
        {
            InitializeComponent();
            IniciarFormulario(obj);
        }
        private void IniciarFormulario(Usuario objP)
        {
            this.obj = objP;
            lblCodigo.Text = this.obj.Id.ToString();
            txtUsuario.Text = this.obj.User;
            txtSenha.Text = this.obj.Senha;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            ts.Text = ValidarCad();
            if (ts.Text == "Sucesso")
            {
                if (lblCodigo.Text != this.obj.Id.ToString())
                {
                    status = "apagado";
                    MessageBox.Show("Este Registro acabou de ser excluido por outro usuário");
                }
                else
                {
                    status = "editado";
                    this.obj.User = txtUsuario.Text;
                    this.obj.Senha = txtSenha.Text;
                    service.Editar(this.obj);
                    this.Close();
                }
            }
        }

        private string ValidarCad()
        {
            throw new NotImplementedException();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            if (ValidarExclusao())
            {
                service.Deletar(this.obj.Id);
                MessageBox.Show("Excluido com sucesso!");
                status = "apagado";
                this.Close();
            }
        }

        public bool ValidarExclusao()
        {
            DialogResult con = MessageBox.Show("Deseja excluir este registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (con.ToString().ToUpper() == "YES")
                return true;
            else
                return false;
        }
    }
}