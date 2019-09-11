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
    public partial class frmLogin : Form
    {
        UsuarioService service = new UsuarioService();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       
        private void login_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Informe o login e a senha.");
                return;
            }

            try
            {
               
                
                if(service.login(txtUsuario.Text.ToString(), txtSenha.Text.ToString()) == true)
                {
                    MessageBox.Show("BemVindo, " + txtUsuario.Text + "!", "Sucesso!");
                    frmPrincipal frm = new frmPrincipal();
                    frm.ShowDialog();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuário e Senha incorretos.");
                    return;
                }
               
             

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Realizar o login " + ex.Message);
            }
        }

       
    }
}
