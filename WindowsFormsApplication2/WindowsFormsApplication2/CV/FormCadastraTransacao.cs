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
    public partial class FormCadastraTransacao : Form
    {
        private bool editar = new bool(); //Atributo utilizado para definir se está ocorrendo uma edição ou visualização
        private int id = new int(); //Atributo que guarda o id da transação no caso de uma edição
        private Dictionary<int, ProdutoTransacao> dictProdutosDgv = new Dictionary<int, ProdutoTransacao>(); //Dictionary utilizado para guardar os produtos que estão atualmente sendo escolhidos
        private Dictionary<int, ProdutoTransacao> dictProdutosAnteriores = new Dictionary<int, ProdutoTransacao>(); //Dictionary utilizado para guardar os produtos que inicialmente estavam na transação no caso de uma edição
        private Produto prod; //Atributo que guarda o produto obtido pela pesquisa, que pode ser adicionado à lista de produtos
        private RadioButton escolhido = new RadioButton(); //Atributo que guarda o RadioButton que está escolhido no momento
        private bool reescolha = false; //Atributo que será utilizado caso se mude o botão escolhido

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

        public FormCadastraTransacao()
        {
            //Construtor padrão utilizado na adição de uma nova transação
            InitializeComponent();
        }

        public FormCadastraTransacao(Transacao cv, bool edicao)
        {
            //Construtor utilizado para a edição e visualização de transações
            Editar = edicao;
            InitializeComponent();
            setDTO(cv);
            this.id = cv.Id;

            if (!Editar)
            {
                //Se "Editar" for "false", está ocorrendo uma visualização, por isso todos os controles de edição são desabilitados
                this.Text = "Visualizando transação";
                txtNomeProduto.Hide();
                txtValor.ReadOnly = true;
                txtValor.TabStop = false;
                txtValor.Increment = 0;
                txtValor.Controls[0].Enabled = false;
                txtQuantidade.Hide();
                txtDescricao.Hide();
                rdbCompra.Enabled = false;
                rdbUso.Enabled = false;
                dtpData.Hide();
                btnAdd.Hide();
                btnRemover.Hide();
                txtData.Visible = true;
                dgvProdutos.Height = 325;
                dgvProdutos.Top = 145;

                //É mudada a cor da seleção do DataGridView para a mesma cor das linhas que não estão selecionadas
                dgvProdutos.ClearSelection();
                dgvProdutos.DefaultCellStyle.SelectionBackColor = dgvProdutos.DefaultCellStyle.BackColor;
                dgvProdutos.DefaultCellStyle.SelectionForeColor = dgvProdutos.DefaultCellStyle.ForeColor;
                txtData.Text = dtpData.Value.Date.ToShortDateString();
                btnCancelar.Text = "Voltar";
                btnSalvar.Hide();
            }
            else
            {
                this.Text = "Editando transação";
            }
        }

        private Transacao getDTO()
        {
            //Método utilizado para se obter uma transação a partir das informações digitadas e dos produtos escolhidos
            Transacao cv = new Transacao();
            cv.Data = dtpData.Value;
            cv.Valor = double.Parse(txtValor.Text);
            cv.Compra = rdbCompra.Checked;

            //Cada produto escolhido na DGV (que está no "DictProdutosDgv") é adicionado numa lista e a lista é passada para a transação
            List<ProdutoTransacao> lproduto = new List<ProdutoTransacao>();
            foreach(KeyValuePair<int,ProdutoTransacao> pv in dictProdutosDgv)
            {
                ProdutoTransacao pve = new ProdutoTransacao(pv.Value.Prod, pv.Value.Quantidade);
                lproduto.Add(pve);
            }

            cv.Lista = lproduto;

            return cv;
        }

        private void setDTO(Transacao cv)
        {
            //Método utilizado para preencher os campos com uma transação informada
            dtpData.Value = cv.Data;
            txtValor.Text = cv.Valor.ToString();

            //Se for uma compra, marca o RadioButton "compra", senão, o "uso"
            if (cv.Compra)
            {
                rdbCompra.Checked = true;
            }
            else
            {
                rdbUso.Checked = true;
            }

            //Adiciona nos dictionaries todos os produtos da transação e realiza um "Fill" para que a DataGridView seja preenchida
            foreach(ProdutoTransacao pv in cv.Lista)
            {
                dictProdutosDgv.Add(pv.Prod.Id, pv);
                int id = pv.Prod.Id;
                dictProdutosAnteriores.Add(id, new ProdutoTransacao(pv.Prod,pv.Quantidade));
            }
            Fill();
        }

        bool IsCompleteForm()
        {
            //Método utilizado para verificar se algum campo pertinente às transações foi deixado em branco
            if(dictProdutosDgv.Count==0||dtpData.Value.ToString().Trim() == "" || txtValor.ToString().Trim() == "")
            {
                return false;
            }
            return true;
        }

        bool IsCompleteProd()
        {
            //Método utilizado para verificar se o produto que se está tentando adicionar é válido e se a quantidade não é 0
            if((prod!=null)&&(txtQuantidade.Text != "0,00")){
                return true;
            }else
            {
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Evento no botão de adição de produto ao dictionary de produtos da transação
            if (IsCompleteProd())
            {
                if (dictProdutosDgv.ContainsKey(prod.Id))
                {
                    //Se o produto já está no dictionary, apenas aumenta a sua quantidade
                    dgvProdutos.Rows.Clear();
                    dictProdutosDgv[prod.Id].Quantidade += double.Parse(txtQuantidade.Text);
                    txtQuantidade.Text = "0";
                    Fill();
                }
                else
                {
                    //Se o produto é novo no dictionary, realiza sua adição
                    ProdutoTransacao prodvenda = new ProdutoTransacao(prod, double.Parse(txtQuantidade.Text));
                    dgvProdutos.Rows.Add(prod.Id, prod.Nome, txtQuantidade.Text);
                    dictProdutosDgv.Add(prod.Id, prodvenda);
                    txtQuantidade.Text = "0";
                }
                AtualizaMaximo();
            }
            else
            {
                MessageBox.Show("Verifique se o produto foi encontrado e se a quantidade foi preenchida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Fill()
        {
            //Método utilizado para preencher a DataGridView de produtos da transação com os produtos do dictionary "dictProdutosDgv"
            foreach(KeyValuePair<int,ProdutoTransacao> p in dictProdutosDgv)
            {
                dgvProdutos.Rows.Add(p.Key, p.Value.Prod.Nome, p.Value.Quantidade);
            }
        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {
            //Evento que busca se existe um produto com o nome informado pelo usuário e o coloca em "prod". Se ele existir, atualiza o campo que informa sua descrição e atualiza o máximo que pode ser adicionado de sua quantidade
            ProdutoDAO db = new ProdutoDAO();
            prod = db.Read(txtNomeProduto.Text);
            if(prod != null)
            {
                txtDescricao.Text = prod.Detalhes;
            }else
            {
                txtDescricao.Text = "";
            }
            AtualizaMaximo();
        }

        private void rdbCompra_CheckedChanged(object sender, EventArgs e)
        {
            //Impede que seja adicionado um valor de compra no caso de um uso
            if (rdbCompra.Checked)
            {
                txtValor.Enabled = true;
            }
            else
            {
                txtValor.Enabled = false;
                txtValor.Value = 0;
            }

            //Evento que é chamado toda vez que se muda uma opção nos RadioButtons
            if ((!reescolha) && (dgvProdutos.Rows.Count != 0))
            {
                //Se o evento não é chamado pela segunda vez mas há produtos já adicionados da lista

                //Define reescolha para "true" para que o evento não entre em loop caso haja a intenção de cancelar a escolha
                reescolha = true;

                if (escolhido.Checked)
                {
                    //Se já existe um botão escolhido, mostra uma mensagem alertando que mudar a opção resetará os produtos adicionados
                    DialogResult resultado = MessageBox.Show("Mudar o tipo de transação resetará os produtos adicionados, continuar mesmo assim?", "Você tem certeza disto?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (resultado == DialogResult.OK)
                    {
                        //Se o usuário optar por resetar, limpa o "dictProdutosDgv" e redefine o valor de "escolhido"
                        dictProdutosDgv.Clear();
                        dgvProdutos.Rows.Clear();
                        escolhido = rdbCompra.Checked ? rdbCompra : rdbUso;
                    }
                    else if (resultado == DialogResult.Cancel)
                    {
                        //Senão, marca novamente o que estava anteriormente (note que nesses casos o evento ocorreria novamente se "reescolha" não estivesse definida como "true"
                        rdbCompra.Checked = false;
                        rdbUso.Checked = false;
                        if (escolhido.Name == "rdbCompra")
                        {
                            rdbUso.Checked = true;
                        }
                        else
                        {
                            rdbCompra.Checked = true;
                        }
                    }
                }

                //Volta "reescolha" para false e redefine "escolhido", além de atualizar o valor máximo do produto atualmente selecionado
                reescolha = false;
                escolhido = rdbCompra.Checked ? rdbCompra : rdbUso;
                AtualizaMaximo();
            }
            else if (!reescolha)
            {
                //Se não for uma reescolha mas nenhum RadioButton estiver escolhido, apenas atualiza o valor máximo do produto atualmente selecionado
                AtualizaMaximo();
            }
        }

        private void AtualizaMaximo()
        {
            //Método utilizado para atualizar o valor máximo do produto selecionado (que deve ser o que está em estoque num uso ou um valor alto qualquer numa compra)
            txtQuantidade.Text = "0";

            if(prod != null)
            {
                //Se o produto selecionado existir
                if (rdbCompra.Checked)
                {
                    //Se for uma compra, define o máximo como "99999"
                    txtQuantidade.Maximum = 99999;
                }
                else if (rdbUso.Checked)
                {
                    //Se for um uso
                    if (dictProdutosDgv.ContainsKey(prod.Id))
                    {
                        //Se o produto já está adicionado no dictionary dos produtos atuais
                        if (dictProdutosAnteriores.ContainsKey(prod.Id))
                        {
                            /*Se o produto já estava adicionado no dictionary dos produtos da transação que está sendo editada, seu máximo recebe o seu estoque somado do que estava anteriormente, menos a quantidade atual
                            Para exemplificar, se o produto tem estoque 0 mas se está mudando um uso que antes era de 4 unidades para 2 unidades, seu máximo receberá 0+4-2, ou seja, 2*/
                            txtQuantidade.Maximum = decimal.Parse(((prod.Quantidade + dictProdutosAnteriores[prod.Id].Quantidade) - dictProdutosDgv[prod.Id].Quantidade).ToString());
                        }
                        else
                        {
                            //Se o produto não estava nos produtos da transação editada, seu máximo recebe o estoque dele menos a quantidade que já está no "dictProdutosDgv"
                            txtQuantidade.Maximum = decimal.Parse((prod.Quantidade - dictProdutosDgv[prod.Id].Quantidade).ToString());
                        }
                    }
                    else
                    {
                        //Se o produto não estava ainda no dictionary, seu máximo recebe sua quantidade em estoque
                        txtQuantidade.Maximum = decimal.Parse(prod.Quantidade.ToString());
                    }
                }
            }
            else
            {
                //Se o produto não é encontrado, seu máximo é 0
                txtQuantidade.Maximum = 0;
            }

            //Seu mínimo é sempre redefinido como 0 para impossibilitar problemas eventuais que possam ocorrer numa das operações acima
            txtQuantidade.Minimum = 0;
            txtQuantidade.Text = "0";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Evento do botão de remoção de um produto da lista
            if (dgvProdutos.CurrentRow != null)
            {
                //Se houver um ou mais produto(s) selecionado(s)
                foreach (DataGridViewRow row in dgvProdutos.SelectedRows)
                {
                    //Para cada produto selecionado
                    if (Editar)
                    {
                        //Se for uma edição, não exclui propriamente o produto do dictionary para que ele possa ser removido do banco, mas sim define sua quantidade para 0
                        dictProdutosDgv[int.Parse(row.Cells[0].Value.ToString())].Quantidade = 0;
                    }
                    else
                    {
                        //Se não for uma edição, remove o produto do dictionary
                        dictProdutosDgv.Remove(int.Parse(row.Cells[0].Value.ToString()));
                    }

                    //Remove as linhas da DataGridView
                    dgvProdutos.Rows.Remove(row);
                }
                AtualizaMaximo();
            }
            else
            {
                MessageBox.Show("Selecione uma transação!", "Você deve selecionar uma transação.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Evento do botão "Salvar" da transação
            if (IsCompleteForm())
            {
                //Se tudo estiver completo
                TransacaoDAO database = new TransacaoDAO();
                Transacao cv = getDTO();
                if (Editar)
                {
                    cv.Id = id;
                    database.Editar(cv,dictProdutosAnteriores);
                    Dispose();
                }
                else
                {
                    database.Salvar(cv);
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
            //Evento do botão "cancelar"
            Dispose();
        }

        private void dtpData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evento que verifica se a tecla "Enter" é pressionada em um campo de texto, se for, clica no botão "Salvar"
                btnSalvar.PerformClick();

                //Altera os argumentos da função para que não possa ocorrer repetidas vezes o evento ao se apertar a tecla rapidamente
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtNomeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evento que verifica se a tecla "Enter" é pressionada em um campo de texto referente ao produto, se for, clica no botão "Adicionar"
                btnAdd.PerformClick();

                //Altera os argumentos da função para que não possa ocorrer repetidas vezes o evento ao se apertar a tecla rapidamente
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
