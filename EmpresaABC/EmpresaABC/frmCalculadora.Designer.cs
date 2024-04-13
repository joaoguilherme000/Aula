
namespace EmpresaABC
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVariavel1 = new System.Windows.Forms.Label();
            this.lblVariavel2 = new System.Windows.Forms.Label();
            this.txtVariavel1 = new System.Windows.Forms.TextBox();
            this.txtVariavel2 = new System.Windows.Forms.TextBox();
            this.gpbOperador = new System.Windows.Forms.GroupBox();
            this.rdbAdicao = new System.Windows.Forms.RadioButton();
            this.rdbSubtracao = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdbDivisao = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbOperador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVariavel1
            // 
            this.lblVariavel1.AutoSize = true;
            this.lblVariavel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariavel1.Location = new System.Drawing.Point(66, 51);
            this.lblVariavel1.Name = "lblVariavel1";
            this.lblVariavel1.Size = new System.Drawing.Size(78, 20);
            this.lblVariavel1.TabIndex = 0;
            this.lblVariavel1.Text = "Variavel 1";
            // 
            // lblVariavel2
            // 
            this.lblVariavel2.AutoSize = true;
            this.lblVariavel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariavel2.Location = new System.Drawing.Point(66, 141);
            this.lblVariavel2.Name = "lblVariavel2";
            this.lblVariavel2.Size = new System.Drawing.Size(78, 20);
            this.lblVariavel2.TabIndex = 1;
            this.lblVariavel2.Text = "Variavel 2";
            // 
            // txtVariavel1
            // 
            this.txtVariavel1.Location = new System.Drawing.Point(165, 51);
            this.txtVariavel1.Name = "txtVariavel1";
            this.txtVariavel1.Size = new System.Drawing.Size(158, 20);
            this.txtVariavel1.TabIndex = 2;
            // 
            // txtVariavel2
            // 
            this.txtVariavel2.Location = new System.Drawing.Point(165, 141);
            this.txtVariavel2.Name = "txtVariavel2";
            this.txtVariavel2.Size = new System.Drawing.Size(158, 20);
            this.txtVariavel2.TabIndex = 3;
            // 
            // gpbOperador
            // 
            this.gpbOperador.Controls.Add(this.rdbDivisao);
            this.gpbOperador.Controls.Add(this.rdbMultiplicacao);
            this.gpbOperador.Controls.Add(this.rdbSubtracao);
            this.gpbOperador.Controls.Add(this.rdbAdicao);
            this.gpbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOperador.Location = new System.Drawing.Point(124, 231);
            this.gpbOperador.Name = "gpbOperador";
            this.gpbOperador.Size = new System.Drawing.Size(167, 229);
            this.gpbOperador.TabIndex = 4;
            this.gpbOperador.TabStop = false;
            this.gpbOperador.Text = "Operador";
            // 
            // rdbAdicao
            // 
            this.rdbAdicao.AutoSize = true;
            this.rdbAdicao.Location = new System.Drawing.Point(24, 38);
            this.rdbAdicao.Name = "rdbAdicao";
            this.rdbAdicao.Size = new System.Drawing.Size(99, 24);
            this.rdbAdicao.TabIndex = 0;
            this.rdbAdicao.TabStop = true;
            this.rdbAdicao.Text = "Adição (+)";
            this.rdbAdicao.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            this.rdbSubtracao.AutoSize = true;
            this.rdbSubtracao.Location = new System.Drawing.Point(24, 83);
            this.rdbSubtracao.Name = "rdbSubtracao";
            this.rdbSubtracao.Size = new System.Drawing.Size(120, 24);
            this.rdbSubtracao.TabIndex = 1;
            this.rdbSubtracao.TabStop = true;
            this.rdbSubtracao.Text = "Subtração (-)";
            this.rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            this.rdbMultiplicacao.AutoSize = true;
            this.rdbMultiplicacao.Location = new System.Drawing.Point(24, 128);
            this.rdbMultiplicacao.Name = "rdbMultiplicacao";
            this.rdbMultiplicacao.Size = new System.Drawing.Size(138, 24);
            this.rdbMultiplicacao.TabIndex = 2;
            this.rdbMultiplicacao.TabStop = true;
            this.rdbMultiplicacao.Text = "Multiplicação (*)";
            this.rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbDivisao
            // 
            this.rdbDivisao.AutoSize = true;
            this.rdbDivisao.Location = new System.Drawing.Point(24, 173);
            this.rdbDivisao.Name = "rdbDivisao";
            this.rdbDivisao.Size = new System.Drawing.Size(96, 24);
            this.rdbDivisao.TabIndex = 3;
            this.rdbDivisao.TabStop = true;
            this.rdbDivisao.Text = "Divisão (/)";
            this.rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(489, 49);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 20);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(493, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Orange;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalcular.Location = new System.Drawing.Point(473, 215);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(155, 50);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Orange;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.Location = new System.Drawing.Point(473, 300);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(155, 50);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Orange;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(473, 382);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(155, 50);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.gpbOperador);
            this.Controls.Add(this.txtVariavel2);
            this.Controls.Add(this.txtVariavel1);
            this.Controls.Add(this.lblVariavel2);
            this.Controls.Add(this.lblVariavel1);
            this.Name = "frmCalculadora";
            this.Text = "frmCalculadora";
            this.gpbOperador.ResumeLayout(false);
            this.gpbOperador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVariavel1;
        private System.Windows.Forms.Label lblVariavel2;
        private System.Windows.Forms.TextBox txtVariavel1;
        private System.Windows.Forms.TextBox txtVariavel2;
        private System.Windows.Forms.GroupBox gpbOperador;
        private System.Windows.Forms.RadioButton rdbDivisao;
        private System.Windows.Forms.RadioButton rdbMultiplicacao;
        private System.Windows.Forms.RadioButton rdbSubtracao;
        private System.Windows.Forms.RadioButton rdbAdicao;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}