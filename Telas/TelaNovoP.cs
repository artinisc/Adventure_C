using Adventure.Estrutura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure.Telas
{
    public partial class TelaNovoP : Form
    {

        public string nome { get; set; }
        public int resposta { get; set; }

        public TelaNovoP()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btAvancar_Click(object sender, EventArgs e)
        {
            this.nome = this.imputNome.Text;
            this.resposta = 1;
            this.Close();
        }

        private void imputNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.resposta = 2;
            this.Close();
        }
    }
}
