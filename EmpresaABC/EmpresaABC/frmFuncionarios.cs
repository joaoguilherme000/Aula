using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using RestSharp;
using RestSharp.Deserializers;

namespace EmpresaABC
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public frmFuncionarios(string nome)
        {
            InitializeComponent();
            habilitarCampos();
            txtNome.Text = nome;
            carregaFuncionarios(txtNome.Text);
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            txtCodigo.Enabled = false;
            buscarCodigoFunc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alterarFuncionario(Convert.ToInt32(txtCodigo.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEmail.Clear();
            txtEndereço.Clear();
            txtNumero.Clear();
            mskCelular.Text = "";
            mskCEP.Text = "";
            mskCPF.Text = "";
            cbbEstado.Text = "";
        }

        public void habilitarCampos()
        {
            txtCodigo.Enabled = true;
            txtNome.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereço.Enabled = true;
            txtNumero.Enabled = true;
            mskCelular.Enabled = true;
            mskCEP.Enabled = true;
            mskCPF.Enabled = true;
            cbbEstado.Enabled = true;

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
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereço.Enabled = false;
            txtNumero.Enabled = false;
            mskCelular.Enabled = false;
            mskCEP.Enabled = false;
            mskCPF.Enabled = false;
            cbbEstado.Enabled = false;


            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnCadastrar.Enabled = false;

        }
        // metodo cadastrar funcionarios
        public void cadastrarFuncionarios()
        {
            MySqlCommand conm = new MySqlCommand();
            conm.CommandText = "insert into tbFuncionarios(nome, email, cpf, telCel, endereco, numero, cep, bairro, cidade, estado) values(@nome, @email, @cpf,@telCel, @endereco, @numero, @cep, @bairro, @cidade, @estado)";

            conm.Parameters.AddWithValue("@nome", txtNome.Text);
            conm.Parameters.AddWithValue("@email", txtEmail.Text);
            conm.Parameters.AddWithValue("@cpf", mskCPF.Text);
            conm.Parameters.AddWithValue("@telCel", mskCelular.Text);
            conm.Parameters.AddWithValue("@endereco", txtEndereço.Text);
            conm.Parameters.AddWithValue("@numero", txtNumero.Text);
            conm.Parameters.AddWithValue("@cep", mskCEP.Text);
            conm.Parameters.AddWithValue("@bairro", txtBairro.Text);
            conm.Parameters.AddWithValue("@cidade", txtCidade.Text);
            conm.Parameters.AddWithValue("@estado", cbbEstado.Text);

            MySqlConnection conexao = Conexao.obterConexao();
            if (conexao != null)
            {
                try
                {
                    conm.Connection = conexao;
                    int res = conm.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Funcionário cadastrado com sucesso");
                        limparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao cadastrar funcionário");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar funcionário: " + ex.Message);
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

        public void carregaFuncionarios(String nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionarios where nome = @nome";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            txtCodigo.Text = DR.GetInt32(0).ToString();
            txtNome.Text = DR.GetString(1);
            txtEmail.Text = DR.GetString(2);
            mskCPF.Text = DR.GetString(3);
            mskCelular.Text = DR.GetString(4);
            txtEndereço.Text = DR.GetString(5);
            txtNumero.Text = DR.GetString(6);
            mskCEP.Text = DR.GetString(7);
            txtBairro.Text = DR.GetString(8);
            txtCidade.Text = DR.GetString(9);
            cbbEstado.Text = DR.GetString(10);
            Conexao.fecharConexao();
        }

        public void buscarCodigoFunc()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT IFNULL(MAX(codFunc), 0) + 1 AS NextCode FROM tbFuncionarios;";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            using (MySqlDataReader DR = comm.ExecuteReader())
            {
                if (DR.Read())
                {
                    int nextCode = DR.GetInt32("NextCode");
                    txtCodigo.Text = nextCode.ToString();
                }
                else
                {
                    // Handle case where no rows are returned
                    // For example, set a default value for txtCodigo.Text
                    txtCodigo.Text = "1"; // Assuming default code is 1
                }
            }

            Conexao.fecharConexao();
        }

        public void funcaoCarregaFuncionario()
        {
            habilitarCampos();
            txtCodigo.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text.Equals("")
                || txtBairro.Text.Equals("")
                || txtCidade.Text.Equals("")
                || txtEmail.Text.Equals("")
                || txtEndereço.Text.Equals("")
                || txtNumero.Text.Equals("")
                || mskCelular.Text.Equals("     -")
                || mskCEP.Text.Equals("     -")
                || mskCPF.Text.Equals("   .   .   -")
                || cbbEstado.Text.Equals(""))
            {
                MessageBox.Show("Algum campo vazio!!",
                "Mensagem do sistema", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                cadastrarFuncionarios();
                desabilitarCampos();
                btnNovo.Enabled = true;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisar abrir = new frmPesquisar();
            abrir.Show();
            this.Hide();
        }


        public void buscaCEP(string cep)
        {


        }

        private void mskCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                RestClient restClient = new RestClient(string.Format("https://viacep.com.br/ws/{0}/json", mskCEP.Text));
                RestRequest restRequest = new RestRequest(Method.GET);

                IRestResponse restResponse = restClient.Execute(restRequest);

                DadosRetorno dadosRetorno = new JsonDeserializer().Deserialize<DadosRetorno>(restResponse);

                mskCEP.Text = dadosRetorno.cep;
                txtEndereço.Text = dadosRetorno.logradouro;
                txtBairro.Text = dadosRetorno.bairro;
                txtCidade.Text = dadosRetorno.localidade;
                cbbEstado.Text = dadosRetorno.uf;

                txtNumero.Focus();

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            txtNome.Focus();
        }

        public void alterarFuncionario(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbFuncionarios set nome= @nome, email= @email, cpf= @cpf, telCel= @telcel, endereco= @endereco, numero= @numero, cep= @cep, bairro= @bairro, cidade= @cidade, estado= @estado where codFunc= @codFunc";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.AddWithValue("@nome", txtNome.Text);
            comm.Parameters.AddWithValue("@email", txtEmail.Text);
            comm.Parameters.AddWithValue("@cpf", mskCPF.Text);
            comm.Parameters.AddWithValue("@telCel", mskCelular.Text);
            comm.Parameters.AddWithValue("@endereco", txtEndereço.Text);
            comm.Parameters.AddWithValue("@numero", txtNumero.Text);
            comm.Parameters.AddWithValue("@cep", mskCEP.Text);
            comm.Parameters.AddWithValue("@bairro", txtBairro.Text);
            comm.Parameters.AddWithValue("@cidade", txtCidade.Text);
            comm.Parameters.AddWithValue("@estado", cbbEstado.Text);
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32,11).Value = codFunc;

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
                        MessageBox.Show("Falha ao Alterar funcionário");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Alterar funcionário: " + ex.Message);
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

        public void excluirFuncionario(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbFuncionarios where codFunc = @codFunc";
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
                        MessageBox.Show("Falha ao cadastrar funcionário");
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluirFuncionario(Convert.ToInt32(txtCodigo.Text));
        }
    }
}
