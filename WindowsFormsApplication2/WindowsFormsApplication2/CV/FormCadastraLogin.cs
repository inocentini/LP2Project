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
    public partial class FormCadastraLogin : Form
    {
        private bool editar = false; //Atributo responsável pela verificação se ocorrerá uma edição ou uma visualização
        private Login l;

        public FormCadastraLogin() 
        {
            //Construtor padrão para o cadastro, utilizado quando se quer adicionar um login novo
            InitializeComponent();
        }

        public FormCadastraLogin(Login l)
        {
            //Construtor utilizado para quando se quer editar as informações do login
            InitializeComponent();

            //Como a edição de senha não é realizada por aqui, os campos de adição de senha são "escondidos"
            this.Text = "Modificando usuário";
            this.MinimumSize = new Size(this.Width, 280);
            this.MaximumSize = new Size(this.Width, 280);
            this.Height = 300;

            //Posiciona o botão de salvar e o de cancelar mais acima se for uma edição (já que não haverá campo de senha)
            btnSalvar.Location = new Point(btnSalvar.Location.X, 190);
            btnCancelar.Location = new Point(btnCancelar.Location.X, 190);

            this.l = l;
            SetDTO(this.l.P);
            SetDTOL(this.l);
            txtCPF.ReadOnly = true;
            txtUser.ReadOnly = true;
            txtSenha.Visible = false;
            labSenha.Visible = false;

            editar = true;
        }

        private Login GetDTOL()
        {
            //Método utilizado para se obter um login a partir das informações digitadas pelo usuário
            Login l = new Login();
            l.Nome = txtUser.Text;
            l.Senha = txtSenha.Text;

            return l;
        }

        private void SetDTOL(Login l)
        {
            //Método utilizado para se preencher os campos a partir de um login informado
            txtUser.Text = l.Nome;
        }

        private Pessoa GetDTO()
        {
            //Método utilizado para se obter uma pessoa a partir das informações digitadas pelo usuário
            Pessoa p = new Pessoa();
            p.Nome = txtNome.Text;
            p.Cpf = txtCPF.Text;
            p.Email = txtEmail.Text;
            p.Telefone = txtTelefone.Text;

            return p;
        }

        private void SetDTO(Pessoa p)
        {
            //Método utilizado para se preencher os campos a partir de uma pessoa informada
            txtNome.Text = p.Nome;
            txtCPF.Text = p.Cpf;
            txtEmail.Text = p.Email;
            txtTelefone.Text = p.Telefone;
        }

        private bool IsComplete()
        {
            //Método utilizado para se verificar se os campos estão preenchidos numa adição de usuário, primeiro se desabilita as máscaras dos campos para se verificar
            txtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtCPF.Text.Trim() == "" || txtNome.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtTelefone.Text.Trim() == "" || txtUser.Text.Trim() == "" || txtSenha.Text.Trim() == "")
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

        private bool IsCompleteEdicao()
        {
            //Método utilizado como o método acima, porém para a edição de um usuário
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtNome.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtTelefone.Text.Trim() == "")
            {
                txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
                return false;
            }
            txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Evento de clique no botão "Salvar"
            if (editar)
            {
                if (IsCompleteEdicao())
                {
                    //Se estiver ocorrendo a edição e os campos estão todos preenchidos, edita as informações do usuário informado
                    PessoaDAO databasep = new PessoaDAO();

                    Pessoa p = GetDTO();

                    databasep.Editar(p);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Campo inválido ou vazio.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (IsComplete() && Pessoa.verificaCPF(txtCPF.Text))
                {
                    //Se estiver ocorrendo a adição e os campos estão todos preenchidos, salva as informações do usuário
                    LoginDAO database = new LoginDAO();
                    PessoaDAO databasep = new PessoaDAO();

                    Login l = GetDTOL();
                    Pessoa p = GetDTO();

                    l.P = p;

                    if (database.HasAdmin())
                    {
                        //Se não existe nenhum administrador no programa, para que não ocorram problemas de falta de administrador caso algum imprevisto ocorra, o programa estabelece que o cadastrado é um administrador
                        MessageBox.Show("Bem vindo ao House Manager! Como primeiro usuário, você terá previlégios de administrador. Para gerenciar os administradores, consulte a área administrativa.", "Bem vindo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        l.Admin = true;
                    }
                    database.Salvar(l);
                    databasep.Salvar(p);
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Verifique se você preencheu todos os campos e se o CPF fornecido é válido.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Evento do botão "Cancelar", fecha o form
            Close();
        }

        private void txtCPF_KeyDown(object sender, KeyEventArgs e)
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

        private void FormCadastraLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (editar)
            {
                //Se estiver ocorrendo uma edição, o form estará sendo chamado como "filho" de um form MDI, então ele é apenas "escondido"
                this.Hide();
                //Cancela o evento padrão de fechamento ("Dispose")
                e.Cancel = true;
            }
            else
            {
                //Se estiver ocorrendo uma adição, o form é chamado apenas pelo login ou pela lista de pessoas da área administrativa que não são MDI, então realiza o "Dispose"
                Dispose();
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (char.IsControl(e.KeyChar)) || (char.IsSeparator(e.KeyChar)))){
                e.Handled = true;
            }
        }
    }
}
