using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnDesp
{
    public partial class receitas : Form
    {
        private tela_inicial _principal;
        public receitas(tela_inicial principal) 
        
        {
            InitializeComponent();
            _principal = principal;
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            _principal.Show();
            this.Close();
            
             
        }

        private void receitas_Load(object sender, EventArgs e)
        {

        }
    }
}
