using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using WcfService;

namespace Consultorio1
{
    public partial class frmConUsuario : Form
    {
        UsuarioService service = new UsuarioService();
        public frmConUsuario()
        {
            InitializeComponent();
            IniciarForm();
        }
        public void IniciarForm()
        {
            var lista = service.Listar();
            if (lista == null)
            {
                MessageBox.Show("Não existem dentistas cadastrados");
            }
            else
            {
                char letraAnterior = '#';
                int numTabela = -1;
                DataGridView data = new DataGridView();

                foreach (var dado in lista)
                {
                    char primeiraLetra = dado.User.Trim()[0];
                    if (primeiraLetra.ToString().ToUpper() == letraAnterior.ToString().ToUpper())
                    {
                        GerarLinha(data, dado);
                    }
                    else
                    {
                        numTabela = numTabela + 1;
                        tc.TabPages.Add(primeiraLetra.ToString().ToUpper());
                        DataGridView dg = new DataGridView();
                        data = dg;
                        tc.TabPages[numTabela].Controls.Add(dg);
                        GerarTabela(dg);
                        GerarLinha(dg, dado);
                    }

                    letraAnterior = primeiraLetra;
                }

            }
        }

        private void GerarTabela(DataGridView dg)
        {
            dg.ReadOnly = true;
            dg.AllowUserToAddRows = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.AllowUserToResizeColumns = false;
            dg.AllowUserToResizeRows = false;
            dg.Dock = DockStyle.Fill;
            dg.RowHeadersVisible = false;
            dg.BackgroundColor = Color.White;
            dg.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
            dg.DefaultCellStyle.SelectionForeColor = Color.White;
            dg.CellBorderStyle = DataGridViewCellBorderStyle.None;


            dg.Columns.Add("Codigo", "Código");
            dg.Columns[0].Visible = false;

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "User";

            link.Name = "User";
            dg.Columns.Add(link);


            dg.CellContentClick += new DataGridViewCellEventHandler(this.tb_click);
        }
        private void tb_click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = sender as DataGridView;
            try
            {
                if (e.ColumnIndex == 1 && e.RowIndex != -1)
                {
                    var id = dg.Rows[e.RowIndex].Cells[0].Value;
                    Usuario obj = service.Buscar(Convert.ToInt32(id));

                    var form = new frmEditarUsuario(obj);
                    form.ShowDialog();

                    if (form.status == "apagado")
                    {
                        this.Close();
                        frmConDentista frm = new frmConDentista();
                        frm.ShowDialog();
                    }
                    if (form.status == "editado")
                    {
                        dg.Rows.RemoveAt(e.RowIndex);
                        GerarLinha(dg, obj);
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao selecionar o dentista " + ex.Message);
            }
        }

        private void GerarLinha(DataGridView data, Usuario dado)
        {
            int linhaAtual = data.Rows.Add();
            data.Rows[linhaAtual].Cells[0].Value = dado.Id;
            data.Rows[linhaAtual].Cells[1].Value = dado.User;
          
    }
    }
}
