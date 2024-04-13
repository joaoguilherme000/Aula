using System;
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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verifica se foram inseridos valores válidos nos TextBox
            if (!double.TryParse(txtNumero1.Text, out double num1) || !double.TryParse(txtNumero2.Text, out double num2))
            {
                MessageBox.Show("Por favor, insira números válidos.");
                return;
            }

            // Verifica qual operador foi selecionado
            double resultado = 0;
            if (rdbAdicao.Checked)
            {
                resultado = num1 + num2;
            }
            else if (rdbSubtracao.Checked)
            {
                resultado = num1 - num2;
            }
            else if (rdbMultiplicacao.Checked)
            {
                resultado = num1 * num2;
            }
            else if (rdbDivisao.Checked)
            {
                // Verifica se não estamos tentando dividir por zero
                if (num2 == 0)
                {
                    MessageBox.Show("Não é possível dividir por zero.");
                    return;
                }
                resultado = num1 / num2;
            }

            // Exibe o resultado
            MessageBox.Show("O resultado é: " + resultado.ToString());
        }
    }
}
