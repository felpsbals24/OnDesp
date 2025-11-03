namespace OnDesp
{
    partial class produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(produto));
            this.bt_voltar = new System.Windows.Forms.Button();
            this.inp_nome = new System.Windows.Forms.TextBox();
            this.inp_marca = new System.Windows.Forms.TextBox();
            this.inp_quant = new System.Windows.Forms.TextBox();
            this.inp_preco = new System.Windows.Forms.TextBox();
            this.inp_gml = new System.Windows.Forms.TextBox();
            this.inp_val = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inp_buscar = new System.Windows.Forms.TextBox();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.Listagem_produtos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Listagem_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_voltar
            // 
            this.bt_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltar.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_voltar.ForeColor = System.Drawing.Color.DarkOrange;
            this.bt_voltar.Location = new System.Drawing.Point(713, 415);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(75, 23);
            this.bt_voltar.TabIndex = 1;
            this.bt_voltar.Text = "VOLTAR";
            this.bt_voltar.UseVisualStyleBackColor = false;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // inp_nome
            // 
            this.inp_nome.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.inp_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inp_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inp_nome.Location = new System.Drawing.Point(154, 143);
            this.inp_nome.Name = "inp_nome";
            this.inp_nome.Size = new System.Drawing.Size(100, 13);
            this.inp_nome.TabIndex = 2;
            this.inp_nome.TextChanged += new System.EventHandler(this.inp_nome_TextChanged);
            // 
            // inp_marca
            // 
            this.inp_marca.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.inp_marca.Location = new System.Drawing.Point(154, 178);
            this.inp_marca.Name = "inp_marca";
            this.inp_marca.Size = new System.Drawing.Size(100, 20);
            this.inp_marca.TabIndex = 3;
            // 
            // inp_quant
            // 
            this.inp_quant.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.inp_quant.Location = new System.Drawing.Point(154, 220);
            this.inp_quant.Name = "inp_quant";
            this.inp_quant.Size = new System.Drawing.Size(100, 20);
            this.inp_quant.TabIndex = 4;
            this.inp_quant.TextChanged += new System.EventHandler(this.inp_quant_TextChanged);
            // 
            // inp_preco
            // 
            this.inp_preco.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.inp_preco.Location = new System.Drawing.Point(154, 262);
            this.inp_preco.Name = "inp_preco";
            this.inp_preco.Size = new System.Drawing.Size(100, 20);
            this.inp_preco.TabIndex = 5;
            // 
            // inp_gml
            // 
            this.inp_gml.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.inp_gml.Location = new System.Drawing.Point(154, 304);
            this.inp_gml.Name = "inp_gml";
            this.inp_gml.Size = new System.Drawing.Size(100, 20);
            this.inp_gml.TabIndex = 6;
            this.inp_gml.TextChanged += new System.EventHandler(this.inp_gml_TextChanged);
            // 
            // inp_val
            // 
            this.inp_val.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.inp_val.Location = new System.Drawing.Point(154, 363);
            this.inp_val.Name = "inp_val";
            this.inp_val.Size = new System.Drawing.Size(100, 20);
            this.inp_val.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(72, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(65, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "MARCA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(32, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "QUANTIDADE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "PRECO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(56, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "G/ML";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "VALIDADE";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // inp_buscar
            // 
            this.inp_buscar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.inp_buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inp_buscar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.inp_buscar.Location = new System.Drawing.Point(544, 116);
            this.inp_buscar.Name = "inp_buscar";
            this.inp_buscar.Size = new System.Drawing.Size(146, 13);
            this.inp_buscar.TabIndex = 14;
            // 
            // bt_buscar
            // 
            this.bt_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_buscar.FlatAppearance.BorderSize = 0;
            this.bt_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar.Location = new System.Drawing.Point(713, 87);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(75, 56);
            this.bt_buscar.TabIndex = 15;
            this.bt_buscar.UseVisualStyleBackColor = false;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar.Location = new System.Drawing.Point(154, 415);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(100, 23);
            this.bt_cadastrar.TabIndex = 16;
            this.bt_cadastrar.Text = "CADASTRAR";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // Listagem_produtos
            // 
            this.Listagem_produtos.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.Listagem_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listagem_produtos.Location = new System.Drawing.Point(471, 166);
            this.Listagem_produtos.Name = "Listagem_produtos";
            this.Listagem_produtos.Size = new System.Drawing.Size(281, 217);
            this.Listagem_produtos.TabIndex = 18;
            this.Listagem_produtos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Listagem_produtos_CellContentClick);
            // 
            // produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Listagem_produtos);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.inp_buscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inp_val);
            this.Controls.Add(this.inp_gml);
            this.Controls.Add(this.inp_preco);
            this.Controls.Add(this.inp_quant);
            this.Controls.Add(this.inp_marca);
            this.Controls.Add(this.inp_nome);
            this.Controls.Add(this.bt_voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "produto";
            this.Load += new System.EventHandler(this.produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listagem_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_voltar;
        private System.Windows.Forms.TextBox inp_nome;
        private System.Windows.Forms.TextBox inp_marca;
        private System.Windows.Forms.TextBox inp_quant;
        private System.Windows.Forms.TextBox inp_preco;
        private System.Windows.Forms.TextBox inp_gml;
        private System.Windows.Forms.TextBox inp_val;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inp_buscar;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.DataGridView Listagem_produtos;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Label label1;
    }
}