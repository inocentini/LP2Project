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
    public partial class FormAlteraSenha : Form
    {
        //Form utilizado para alterar a senha do usuário que está logado ou de um login específico

        private Login l = new Login();

        public FormAlteraSenha()
        {
            //Neste construtor se obtém as informações de quem está logado para serem editadas
            InitializeComponent();
            l = Sessao.login;
        }

        public FormAlteraSenha(Login l)
        {
            //Neste construtor se obtém as informações de um login específico passado como parâmetro
            this.l = l;
        }

        private void FormAlteraSenha_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Como esse form é um "filho" MDI, ele não é realmente fechado pois não é instanciado toda vez, e sim "escondido"
            this.Hide();

            //Ao definir a property "Cancel" dos argumentos do evento como true, se cancela o comportamento padrão (dispose)
            e.Cancel = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Ao clicar no botão cancelar, é chamado o evento de fechamento do form (visto acima)
            this.Close();
        }

        private bool IsComplete()
        {
            //Função utilizada para verificar se os campos foram preenchidos
            if(txtNovaSenha.Text.Trim() == "" || txtSenhaAtual.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Evento do clique no botão "Salvar"
            LoginDAO db = new LoginDAO();

            if (IsComplete())
            {
                //Se os campos estão preenchidos, se obtém a senha digitada para confirmação
                l.Senha = txtSenhaAtual.Text;

                if (db.Login(l))
                {
                    //Se a senha para confirmação for correta, edita o login com a nova senha informada e fecha o form
                    l.Senha = txtNovaSenha.Text;
                    db.Editar(l);
                    this.Close();
                }
                else
                {
                    //Se a confirmação retorna false, mostra esta mensagem de erro
                    MessageBox.Show("Erro! Senha inválida!", "Tente novamente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Se algum dos campos está vazio, retorna esta mensagem de erro
                MessageBox.Show("Erro! Os campos não podem estar vazios!", "Tente novamente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormAlteraSenha_Activated(object sender, EventArgs e)
        {
            //Se o form é chamado outra vez, limpa os campos de texto, já que o "load" não é executado quando o form tem sua visibilidade alterada
            txtNovaSenha.Text = "";
            txtSenhaAtual.Text = "";
        }
    }
}
