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
    public partial class frmPesquisarUsuarios : Form
    {
        public frmPesquisarUsuarios()
        {
            InitializeComponent();
        }

        public void buscaCodigo(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where codUsu = @codUsu;";
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@codUsu", MySqlDbType.Int32, 11).Value = codigo;

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            lstPesquisar.Items.Add(DR.GetString(1));

            Conexao.fecharConexao();
        }
        public void buscaNome(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where nome like '%" + nome + "%';";
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.String, 100).Value = nome;

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            while (DR.Read())
            {
                lstPesquisar.Items.Add(DR.GetString(1));
            }

            Conexao.fecharConexao();
        }


        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("funcionou");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            buscaCodigo(Convert.ToInt32(txtDescricao.Text));
        }

        private void lstPesquisar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Verifica se algum item está selecionado
            if (lstPesquisar.SelectedItem != null)
            {
                string nome = lstPesquisar.SelectedItem.ToString();
                frmCadFunc abrir = new frmCadFunc(nome);
                abrir.Show();
                this.Hide();
            }
        }
    }
}
