using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
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
            txtSenha.Clear();
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
            txtSenha.Enabled = true;
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
            txtSenha.Enabled = false;
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
            conm.CommandText = "insert into tbFuncionarios(nome, email, cpf, telCel, endereco, numero, cep, bairro, cidade, estado) values(@nome, @email, @cpf,@telCel, @endereco, @numero, @cep, @bairro, @cidade, @estado);";
            conm.CommandType = CommandType.StoredProcedure;

            conm.Parameters.Clear();
            conm.Parameters.Add("@nome",MySqlDbType.VarChar,100).Value = txtNome.Text;
            conm.Parameters.Add("@email",MySqlDbType.VarChar,100).Value = txtEmail.Text;
            conm.Parameters.Add("@cpf",MySqlDbType.VarChar,14).Value = mskCPF.Text;
            conm.Parameters.Add("@telCel",MySqlDbType.VarChar,10).Value = mskCelular.Text;
            conm.Parameters.Add("@endereco",MySqlDbType.VarChar,100).Value = txtEndereço.Text;
            conm.Parameters.Add("@numero",MySqlDbType.VarChar,5).Value = txtNumero.Text;
            conm.Parameters.Add("@cep",MySqlDbType.VarChar,9).Value = mskCEP.Text;
            conm.Parameters.Add("@bairro",MySqlDbType.VarChar,100).Value = txtBairro.Text;
            conm.Parameters.Add("@cidade",MySqlDbType.VarChar,100).Value = txtCidade.Text;
            conm.Parameters.Add("@estado",MySqlDbType.VarChar,100).Value = cbbEstado.Text;

            conm.Connection = Conexao.obterConexao();
            int res = conm.ExecuteNonQuery();
            MessageBox.Show("Cadastrado com sucesso");
            limparCampos();
            Conexao.fecharConexao();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text.Equals("")
                || txtNome.Text.Equals("")
                || txtBairro.Text.Equals("")
                || txtSenha.Text.Equals("")
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
