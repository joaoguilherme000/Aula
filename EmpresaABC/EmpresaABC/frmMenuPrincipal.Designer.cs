
namespace EmpresaABC
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(52, 91);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(169, 165);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Location = new System.Drawing.Point(52, 308);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(169, 165);
            this.btnFuncionarios.TabIndex = 1;
            this.btnFuncionarios.Text = "Funcionarios";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(309, 91);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(169, 165);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Location = new System.Drawing.Point(563, 91);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(169, 165);
            this.btnFornecedores.TabIndex = 3;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = true;
            this.btnFornecedores.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Location = new System.Drawing.Point(309, 308);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(169, 165);
            this.btnVendas.TabIndex = 4;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(563, 308);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(169, 165);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(603, 512);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(169, 37);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnFornecedores);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnFuncionarios);
            this.Controls.Add(this.btnClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loja ABC - Menu principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnVoltar;
    }
}