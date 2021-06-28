using Adventure.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure
{
    public partial class TelaPrincipal : Form
    {
        int responde = 0;

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        public int Resposta { get; set; }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtNovoJogo_Click(object sender, EventArgs e)
        {
            this.Resposta = 1;
            this.Close();
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            this.Resposta = 0;
            this.Close();
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void BtContinuar_Click(object sender, EventArgs e)
        {
            this.Resposta = 2;
            this.Close();
        }
    }
}
