using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace EmpresaABC
{
    public partial class frmCadFunc : Form
    {
        public frmCadFunc()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public frmCadFunc(string nome)
        {
            InitializeComponent();
            habilitarCampos();
            txtNome.Text = nome;
            carregaUsuario(txtNome.Text);
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        public void carregaUsuario(String nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where nome = @nome";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 30).Value = nome;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            txtCodigo.Text = DR.GetInt32(0).ToString();
            txtNome.Text = DR.GetString(1);
            txtSenha.Text = DR.GetString(2);
            Conexao.fecharConexao();
        }

        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtRepetir.Clear();
        }

        public void habilitarCampos()
        {
            txtCodigo.Enabled = true;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            txtRepetir.Enabled = true;

            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnCadastrar.Enabled = true;
            txtNome.Focus();

        }

        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtRepetir.Enabled = false;


            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnCadastrar.Enabled = false;

        }

        public void excluirUsuario(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbUsuarios where codFunc = @codFunc";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32, 11).Value = codFunc;

            MySqlConnection conexao = Conexao.obterConexao();
            if (conexao != null)
            {
                try
                {
                    comm.Connection = conexao;
                    int res = comm.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Excluido com Sucesso");
                        limparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao Excluir Usuario");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Excluir funcionário: " + ex.Message);
                }
                finally
                {
                    Conexao.fecharConexao();
                }
            }
            else
            {
                MessageBox.Show("Não foi possível estabelecer conexão com o banco de dados");
            }
        }

        public void cadastrarUsuario()
        {
            MySqlCommand conm = new MySqlCommand();
            conm.CommandText = "insert into tbUsuarios(nome, senha) values(@nome, @senha)";

            conm.Parameters.AddWithValue("@nome", txtNome.Text);
            conm.Parameters.AddWithValue("@senha", txtSenha.Text);

            MySqlConnection conexao = Conexao.obterConexao();
            if (conexao != null)
            {
                try
                {
                    conm.Connection = conexao;
                    int res = conm.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Usuario cadastrado com sucesso");
                        limparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao cadastrar Usuario");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar Usuario: " + ex.Message);
                }
                finally
                {
                    Conexao.fecharConexao();
                }
            }
            else
            {
                MessageBox.Show("Não foi possível estabelecer conexão com o banco de dados");
            }
        }

        public void alterarUsuario(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbUsuario set nome= @nome, senha= @senha, where codUsu= @codUsu";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.AddWithValue("@nome", txtNome.Text);
            comm.Parameters.AddWithValue("@email", txtSenha.Text);
            comm.Parameters.Add("@codUsu", MySqlDbType.Int32, 11).Value = codFunc;

            MySqlConnection conexao = Conexao.obterConexao();
            if (conexao != null)
            {
                try
                {
                    comm.Connection = conexao;
                    int res = comm.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Alterado com sucesso");
                        limparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao Alterar Usuario");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Alterar Usuario: " + ex.Message);
                }
                finally
                {
                    Conexao.fecharConexao();
                }
            }
            else
            {
                MessageBox.Show("Não foi possível estabelecer conexão com o banco de dados");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text.Equals("")
                || txtSenha.Text.Equals("")
                || txtRepetir.Text.Equals(""))
            {
                MessageBox.Show("Algum campo vazio!!",
                "Mensagem do sistema", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                cadastrarUsuario();
                desabilitarCampos();
                btnNovo.Enabled = true;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            txtCodigo.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarUsuarios abrir = new frmPesquisarUsuarios();
            abrir.Show();
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluirUsuario(Convert.ToInt32(txtCodigo.Text));
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarUsuario(Convert.ToInt32(txtCodigo.Text));
        }
    }
}
