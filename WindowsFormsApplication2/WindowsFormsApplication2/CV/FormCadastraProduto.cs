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

namespace HouseManager
{
    public partial class FormCadastraProduto : Form
    {
        private bool editar = new bool(); //Atributo responsável pela verificação se ocorrerá uma edição ou uma visualização
        private int id = new int(); //Atributo utilizado para se obter o id numa edição

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
            //Construtor para o caso de uma edição ou visualização de um produto
            Editar = edicao;
            InitializeComponent();
            setDTO(p);
            this.id = p.Id;
            if (!Editar)
            {
                //Se é uma visualização, impossibilita a modificação de todos os campos
                this.Text = "Visualizando produto";
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
            else
            {
                this.Text = "Editando produto";
            }
        }

        public FormCadastraProduto()
        {
            //Construtor padrão para o cadastro, utilizado quando se quer adicionar um produto novo
            InitializeComponent();
        }

        private Produto getDTO()
        {
            //Método utilizado para se obter um produto a partir dos valores informados pelo usuário
            Produto p = new Produto();
            p.Nome = txtNome.Text;
            p.Detalhes = txtDetalhes.Text;
            p.Quantidade = double.Parse(txtQuantidade.Text);
                 
            return p;
        }

        private void setDTO(Produto p)
        {
            //Método utilizado para se preencher os campos a partir de um produto informado
            txtNome.Text = p.Nome;
            txtDetalhes.Text = p.Detalhes;
            txtQuantidade.Text = p.Quantidade.ToString();
        }

        private bool IsComplete()
        {
            //Método utilizado para verificar se os campos estão preenchidos
            if (txtNome.Text.Trim() == "" || txtDetalhes.Text.Trim() == "" || txtQuantidade.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Evento do botão salvar
            if (IsComplete())
            {
                ProdutoDAO database = new ProdutoDAO();
                Produto p = getDTO();
                if (Editar)
                {   
                    //Se for uma edição, chama o método "Editar" para o produto obtido pelo "GetDTO"
                    p.Id = id;
                    database.Editar(p);
                    Dispose();
                }
                else
                {
                    //Se for uma adição, chama o método "Salvar"
                    database.Salvar(p);
                    Dispose();
                }
            }
            else
            {
                //Se algum dos campos não foi preenchido, mostra uma mensagem de erro
                MessageBox.Show("Verifique se todos os campos estão preenchidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Evento do botão para cancelar
            Dispose();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            //Evento para quando se aperta "Enter" em algum dos campos de digitação
            if (e.KeyCode == Keys.Enter)
            {
                //Se o argumento do evento que indica a tecla apertada indicar que ela é a tecla "Enter", realiza um clique no botão salvar
                btnSalvar.PerformClick();

                //Altera os argumentos da função para que não possa ocorrer repetidas vezes o evento ao se apertar a tecla rapidamente
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
