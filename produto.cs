using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OnDesp
{
    public partial class produto : Form
    {
        private SQLiteConnection conexao;
        private tela_inicial _principal;
        public produto(tela_inicial principal)
        {
            InitializeComponent();
            _principal = principal;
            conexao = new SQLiteConnection(@"Data Source=D:\Visual Studio\OnDesp\OnDesp\onlinedesp.db;Version=3;");
            
        }   
       
        private void bt_voltar_Click(object sender, EventArgs e)
        {
             
            this.Close();  
            _principal.Show();



        }

        private void produto_Load(object sender, EventArgs e)
        {
            conexao.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM produtos", conexao);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexao.Close();

        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            conexao.Open();
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO produtos (nome, marca, quantidade, preco, g_ml, validade) VALUES (@nome, @marca, @qtd, @preco, @gml, @validade)", conexao);
              
            cmd.Parameters.AddWithValue("@nome", inp_nome.Text);
            cmd.Parameters.AddWithValue("@marca", inp_marca.Text);
            cmd.Parameters.AddWithValue("@qtd", Convert.ToInt32(inp_quant.Text));
            cmd.Parameters.AddWithValue("@preco", Convert.ToDouble(inp_preco.Text));
            cmd.Parameters.AddWithValue("@gml", inp_gml.Text);
            cmd.Parameters.AddWithValue("@validade", inp_val.Text);

            cmd.ExecuteNonQuery();

            conexao.Close();
            MessageBox.Show("Produto salvo com sucesso!");
            inp_nome.Clear();
            inp_marca.Clear();
            inp_quant.Clear();
            inp_preco.Clear();
            inp_gml.Clear();
            inp_val.Clear();

            
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inp_gml_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void inp_quant_TextChanged(object sender, EventArgs e)
        {

        }

        private void Listagem_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inp_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
