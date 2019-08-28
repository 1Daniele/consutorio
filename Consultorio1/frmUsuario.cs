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
    public partial class frmUsuario : Form
    {
        UsuarioService service = new UsuarioService();
     
        private string ValidarCad()
        {
            ts.ForeColor = Color.Red;
            if (txtUsuario.Text == string.Empty)
            {
                return "Preencha o campo Usuario!";
            }
           
            else if (txtSenha.Text == string.Empty)
            {
                return "Preencha o campo Senha";
            }
            else
            {
                ts.ForeColor = Color.Black;
                return "Sucesso";
            }
        }
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ts.Text = "";
            try
            {
                ts.Text = ValidarCad();
                if (ts.Text == "Sucesso")
                {
                    service.Cadastrar(objGerado());
                    MessageBox.Show("Cadastro Efetuado com Sucesso");
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }
        public Usuario objGerado()
        {
            Usuario obj = new Usuario();
            obj.User = txtUsuario.Text;
            obj.Senha = txtSenha.Text;
           

            return obj;
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {

            frmConUsuario frm = new frmConUsuario();
            frm.ShowDialog();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public void Limpar()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }
    }
    }
