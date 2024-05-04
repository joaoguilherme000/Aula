﻿using System;
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
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {
            InitializeComponent();
        }

        public void buscaCodigo(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionarios where codFunc = @codFunc;";
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32, 11).Value = codigo;

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            lstPesquisar.Items.Add(DR.GetString(1));

            Conexao.fecharConexao();
        }
        public void buscaNome(string nomeFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionarios where nome like '%@nome%';";
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.String, 100).Value = nomeFunc;

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            while (DR.Read())
            {
                lstPesquisar.Items.Add(DR.GetString(0));
            }

            Conexao.fecharConexao();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //buscaCodigo(Convert.ToInt32(txtDescricao.Text));
            buscaNome(txtDescricao.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
        }

        private void lstPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se algum item está selecionado
            if (lstPesquisar.SelectedItem != null)
            {
                string nome = lstPesquisar.SelectedItem.ToString();
                frmFuncionarios abrir = new frmFuncionarios(nome);
                abrir.Show();
                this.Hide();
            }
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("funcionou");
            }
        }
    }
}
