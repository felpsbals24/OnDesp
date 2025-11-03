using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OnDesp

{

    public partial class tela_inicial : Form
    {
        public tela_inicial()
        {
            InitializeComponent();
        }

        private void bt_produtos_Click(object sender, EventArgs e)
        {

            produto nova_tela = new produto(this);
            nova_tela.Show();
            this.Hide();
            
             
        }

        private void bt_receita_Click(object sender, EventArgs e)
        {
            receitas nova_tela = new receitas(this);  
            this.Hide();
            nova_tela.Show();

        }

        private void tela_inicial_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
        }
    }
}
