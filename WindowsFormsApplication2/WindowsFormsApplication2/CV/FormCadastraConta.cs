using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseManager
{
    public partial class FormCadastraConta : Form
    {
        private bool editar = new bool(); //Atributo responsável pela verificação se ocorrerá uma edição ou uma visualização
        private int id = new int(); //Atributo utilizado para se obter o id numa edição
        private Pessoa resp = new Pessoa(); //Atributo utilizado para se guardar a pessoa responsável pela conta

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

        public FormCadastraConta(Conta c, bool edicao, bool nonAdmin)
        {
            //Construtor para o caso de uma edição ou visualização de conta, para quem é responsável dela ou para os administradores
            Editar = edicao;
            InitializeComponent();
            SetDTO(c);
            this.id = c.Id;
            if (!Editar)
            {
                //Se é uma visualização, impossibilita a modificação de todos os campos
                this.Text = "Visualizando conta";
                cbbNome.Enabled = false;
                txtDetalhes.ReadOnly = true;
                txtDetalhes.TabStop = false;
                txtValor.ReadOnly = true;
                txtValor.TabStop = false;
                txtValor.Increment = 0;
                txtValor.Controls[0].Enabled = false;
                dtpVencimento.Hide();
                btnResponsavel.Hide();
                txtVencimento.Visible = true;
                txtVencimento.Text = dtpVencimento.Value.ToShortDateString();
                btnCancelar.Text = "Voltar";
                btnSalvar.Hide();
            }
            else
            {
                //Se é uma edição, verifica se quem está editando uma conta é uma pessoa normal (que só pode editar contas que ela é responsável) ou um administrador
                this.Text = "Editando conta";
                if (nonAdmin)
                {
                    btnResponsavel.Hide();
                }
            }
        }

        public FormCadastraConta(bool nonAdmin)
        {
            //Construtor usado para a adição de uma conta
            InitializeComponent();
            if (nonAdmin)
            {
                //Se quem está editando não é administrador, a opção de escolher o responsável pela conta é desabilitada
                btnResponsavel.Hide();
                resp = Sessao.login.P;
                txtResponsavel.Text = Sessao.login.P.Nome;
            }
        }

        private Conta GetDTO()
        {
            //Método utilizado para se obter uma conta a partir dos valores informados pelo usuário
            Conta c = new Conta();
            c.Nome = cbbNome.Text;
            c.Detalhes = txtDetalhes.Text;
            c.Valor = double.Parse(txtValor.Text);
            c.Vencimento = dtpVencimento.Value;
            c.Responsavel = resp;

            return c;
        }

        private void SetDTO(Conta c)
        {
            //Método utilizado para se preencher os campos a partir de uma conta informada
            cbbNome.Text = c.Nome;
            txtDetalhes.Text = c.Detalhes;
            txtValor.Text = c.Valor.ToString();
            dtpVencimento.Value = c.Vencimento;
            txtResponsavel.Text = c.Responsavel.Nome;
            PessoaDAO dbp = new PessoaDAO();
            resp = dbp.Read(c.Responsavel.Cpf);
        }

        private bool IsComplete()
        {
            //Método utilizado para verificar se os campos estão preenchidos
            if (cbbNome.Text.Trim() == "" || txtDetalhes.Text.Trim() == "" || txtValor.Text.Trim() == "" || txtResponsavel.Text.Trim() == "" || dtpVencimento.Value.ToString().Trim() == "")
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
                ContaDAO database = new ContaDAO();
                Conta c = GetDTO();
                if (Editar)
                {
                    DialogResult dl = MessageBox.Show("Editar uma conta definirá todas as pessoas como não pagas. Deseja continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if(dl == DialogResult.Yes)
                    {
                        //Se for uma edição, chama o método "Editar" para a conta obtida pelo "GetDTO"
                        c.Id = id;
                        database.Editar(c);
                        Dispose();
                    }
                }
                else
                {
                    //Se for uma adição, chama o método "Salvar"
                    database.Salvar(c);
                    Dispose();
                }
            }
            else
            {
                //Se algum dos campos não foi preenchido, mostra uma mensagem de erro
                MessageBox.Show("Verifique se todos os campos estão preenchidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResponsavel_Click(object sender, EventArgs e)
        {
            //Evento do botão para a escolha de um responsável
            FormPesquisaPessoa pesquisaResponsavel = new FormPesquisaPessoa();
            pesquisaResponsavel.Selecionado = resp;
            pesquisaResponsavel.ShowDialog(this);

            //O atributo "resp" recebe o que estiver na propriedade "Selecionado" do Form chamado
            resp = pesquisaResponsavel.Selecionado;

            if(resp != null)
            {
                //Se alguma pessoa tiver sido selecionada, adiciona o nome dela no campo do responsável
                txtResponsavel.Text = resp.Nome;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
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
