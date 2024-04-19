﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaABC
{
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            lstPesquisar.Items.Add(txtDescricao.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
        }

        private void lstPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lstPesquisar.SelectedIndex;
            string nome = lstPesquisar.SelectedItem.ToString();
            MessageBox.Show("o numero da linha " + i + " " + nome);
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
