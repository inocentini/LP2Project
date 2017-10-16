using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    public partial class FormCadastraProduto : Form
    {
        private bool editar = new bool();
        private int id = new int();

        public bool Editar
        {
            get
            {
                return editar;
            }

            set
            {
                editar = value;
            }
        }

        public FormCadastraProduto(Produto p, bool edicao) //objeto
        {
            Editar = edicao;
            InitializeComponent();
            setDTO(p);
            this.id = p.Id;
            if (!Editar)
            {
                txtNome.ReadOnly = true;
                txtNome.TabStop = false;
                txtDetalhes.ReadOnly = true;
                txtDetalhes.TabStop = false;
                txtQuantidade.ReadOnly = true;
                txtQuantidade.Increment = 0;
                txtQuantidade.Controls[0].Enabled = false;
                txtQuantidade.TabStop = false;
                btnCancelar.Text = "Voltar";
                btnSalvar.Hide();
            }
        }

        public FormCadastraProduto()
        {
            InitializeComponent();
        }

        private Produto getDTO()
        {
            Produto p = new Produto();
            p.Nome = txtNome.Text;
            p.Detalhes = txtDetalhes.Text;
            p.Quantidade = double.Parse(txtQuantidade.Text);
                 
            return p;
        }

        private void setDTO(Produto p)
        {
            txtNome.Text = p.Nome;
            txtDetalhes.Text = p.Detalhes;
            txtQuantidade.Text = p.Quantidade.ToString();
        }

        private bool IsComplete()
        {
            if (txtNome.Text.Trim() == "" || txtDetalhes.Text.Trim() == "" || txtQuantidade.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (IsComplete())
            {
                ProdutoDAO database = new ProdutoDAO();
                Produto p = getDTO();
                if (Editar)
                {
                    p.Id = id;
                    database.Editar(p);
                    Dispose();
                }
                else
                {
                    database.Salvar(p);
                    Dispose();
                }
            }
            else
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
