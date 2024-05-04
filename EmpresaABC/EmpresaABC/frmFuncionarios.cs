using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

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

        public void buscarCodigoFunc()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codFunc+1 from tbFuncionarios order by codFunc desc;";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
            Conexao.fecharConexao();
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
            comm.CommandText = "select * from tbFuncionarios where nome = "+nome+";";
            comm.CommandType = CommandType.Text;
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
            WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();
            // string end = ws.consultaCEP(mskCEP.Text);
            // txtEndereço.Text = end
        }

        private void mskCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                // busca o cep
            }
        }
    }
}
