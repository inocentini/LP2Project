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
    public partial class FormCadastraPessoa : Form
    {
        private bool editar = false; //Atributo responsável pela verificação se ocorrerá uma edição ou uma visualização

        public FormCadastraPessoa(Pessoa p, bool edicao)
        {
            //Construtor utilizado para quando se quer editar ou visualizar as informações de uma pessoa
            editar = edicao;
            InitializeComponent();
            setDTO(p);
            txtCPF.ReadOnly = true;
            txtCPF.TabStop = false;
            if (!editar)
            {
                //Se "editar" for false, então está sendo feita uma visualização, por isso a edição dos campos é desabilitada
                this.Text = "Visualizando pessoa";
                txtEmail.ReadOnly = true;
                txtEmail.TabStop = false;
                txtNome.ReadOnly = true;
                txtNome.TabStop = false;
                txtTelefone.ReadOnly = true;
                txtTelefone.TabStop = false;
                btnCancelar.Text = "Voltar";
                btnSalvar.Hide();
            }
            else
            {
                this.Text = "Editando pessoa";
            }
        }

        public FormCadastraPessoa()
        {
            //Construtor padrão para o cadastro, utilizado quando se quer adicionar uma pessoa nova
            InitializeComponent();
        }

        private Pessoa getDTO()
        {
            //Método utilizado para se obter uma pessoa a partir das informações digitadas pelo usuário
            Pessoa p = new Pessoa();
            p.Nome = txtNome.Text;
            p.Cpf = txtCPF.Text;
            p.Email = txtEmail.Text;
            p.Telefone = txtTelefone.Text;

            return p;
        }

        private void setDTO(Pessoa p)
        {
            //Método utilizado para se preencher os campos a partir de uma pessoa informada
            txtNome.Text = p.Nome;
            txtCPF.Text = p.Cpf;
            txtEmail.Text = p.Email;
            txtTelefone.Text = p.Telefone;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "Salvar"
            if (IsComplete())
            {
                PessoaDAO database = new PessoaDAO();
                if (editar)
                {
                    //Se os campos foram todos preenchidos e se está realizando uma edição, chama o método "Editar" para o objeto DTO
                    database.Editar(getDTO());
                    Dispose();
                }
                else
                {
                    //Se os campos foram todos preenchidos e se está realizando uma adição, verifica-se se o CPF informado já não existe no banco para realizar "Salvar" com o objeto DTO
                    Pessoa p = getDTO();
                    if (database.Read(p.Cpf) == null)
                    {
                        database.Salvar(getDTO());
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("O CPF já está cadastrado!", "Erro: utilize um CPF diferente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos!", "Erro!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool IsComplete()
        {
            //Método utilizado para se verificar se os campos estão preenchidos, primeiro se desabilita as máscaras dos campos para se verificar
            txtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtCPF.Text.Trim() == "" || txtNome.Text.Trim() =="" || txtEmail.Text.Trim() =="" || txtTelefone.Text.Trim()=="")
            {
                //Reabilita as máscaras e retorna "false" se algum dos campos estiver vazio
                txtCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
                txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
                return false;
            }
            //Reabilita as máscaras e retorna "true" se nenhum campo estiver vazio
            txtCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Evento do botão "Cancelar", fecha o form
            Dispose();
        }

        private void txtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            //Evento que verifica se a tecla "Enter" é pressionada em um campo de texto, se for, clica no botão "Salvar"
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.PerformClick();

                //Altera os argumentos da função para que não possa ocorrer repetidas vezes o evento ao se apertar a tecla rapidamente
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
