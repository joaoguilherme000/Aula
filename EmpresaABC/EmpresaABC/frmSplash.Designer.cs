
namespace EmpresaABC
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pctSplash = new System.Windows.Forms.PictureBox();
            this.prgSplash = new System.Windows.Forms.ProgressBar();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.lblPorc = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pctSplash
            // 
            this.pctSplash.Image = ((System.Drawing.Image)(resources.GetObject("pctSplash.Image")));
            this.pctSplash.Location = new System.Drawing.Point(230, 96);
            this.pctSplash.Name = "pctSplash";
            this.pctSplash.Size = new System.Drawing.Size(300, 225);
            this.pctSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSplash.TabIndex = 0;
            this.pctSplash.TabStop = false;
            // 
            // prgSplash
            // 
            this.prgSplash.Location = new System.Drawing.Point(230, 400);
            this.prgSplash.Name = "prgSplash";
            this.prgSplash.Size = new System.Drawing.Size(300, 26);
            this.prgSplash.Step = 2;
            this.prgSplash.TabIndex = 1;
            this.prgSplash.Value = 50;
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.Location = new System.Drawing.Point(359, 458);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(18, 20);
            this.lblPorcentagem.TabIndex = 2;
            this.lblPorcentagem.Text = "0";
            this.lblPorcentagem.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPorc
            // 
            this.lblPorc.AutoSize = true;
            this.lblPorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorc.Location = new System.Drawing.Point(372, 458);
            this.lblPorc.Name = "lblPorc";
            this.lblPorc.Size = new System.Drawing.Size(23, 20);
            this.lblPorc.TabIndex = 3;
            this.lblPorc.Text = "%";
            this.lblPorc.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(654, 496);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_click);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblPorc);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.prgSplash);
            this.Controls.Add(this.pctSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loja ABC - Splash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctSplash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctSplash;
        private System.Windows.Forms.ProgressBar prgSplash;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Label lblPorc;
        private System.Windows.Forms.Button btnEntrar;
    }
}