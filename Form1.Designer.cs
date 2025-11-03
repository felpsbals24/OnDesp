namespace OnDesp
{
    partial class tela_inicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_inicial));
            this.bt_receita = new System.Windows.Forms.Button();
            this.bt_produtos = new System.Windows.Forms.Button();
            this.desligar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_receita
            // 
            this.bt_receita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_receita.FlatAppearance.BorderSize = 0;
            this.bt_receita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_receita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_receita.Location = new System.Drawing.Point(78, 203);
            this.bt_receita.Name = "bt_receita";
            this.bt_receita.Size = new System.Drawing.Size(246, 65);
            this.bt_receita.TabIndex = 0;
            this.bt_receita.UseVisualStyleBackColor = false;
            this.bt_receita.Click += new System.EventHandler(this.bt_receita_Click);
            // 
            // bt_produtos
            // 
            this.bt_produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_produtos.FlatAppearance.BorderSize = 0;
            this.bt_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_produtos.ForeColor = System.Drawing.Color.Orange;
            this.bt_produtos.Location = new System.Drawing.Point(476, 203);
            this.bt_produtos.Name = "bt_produtos";
            this.bt_produtos.Size = new System.Drawing.Size(271, 65);
            this.bt_produtos.TabIndex = 1;
            this.bt_produtos.TabStop = false;
            this.bt_produtos.UseVisualStyleBackColor = false;
            this.bt_produtos.Click += new System.EventHandler(this.bt_produtos_Click);
            // 
            // desligar
            // 
            this.desligar.BackColor = System.Drawing.Color.Red;
            this.desligar.FlatAppearance.BorderSize = 0;
            this.desligar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desligar.Location = new System.Drawing.Point(702, 412);
            this.desligar.Name = "desligar";
            this.desligar.Size = new System.Drawing.Size(81, 28);
            this.desligar.TabIndex = 2;
            this.desligar.Text = "Sair";
            this.desligar.UseVisualStyleBackColor = false;
            this.desligar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tela_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.desligar);
            this.Controls.Add(this.bt_produtos);
            this.Controls.Add(this.bt_receita);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tela_inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnDesp";
            this.Load += new System.EventHandler(this.tela_inicial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_receita;
        private System.Windows.Forms.Button bt_produtos;
        private System.Windows.Forms.Button desligar;
    }
}

