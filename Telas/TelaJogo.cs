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
    public partial class TelaJogo : Form
    {
        public string PastaImagem { get; set; }
        public string ImagemFundo { get; set; }
        public TelaJogo(DadosTelaJogo dadosTela1)
        {
            PastaImagem = Application.StartupPath + @"\Imagens\";
            ImagemFundo = dadosTela1.ImgFundo;

            InitializeComponent();
            //this.teste.Visible = false;
            this.BackgroundImage = Image.FromFile(PastaImagem + ImagemFundo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaJogo_Load(object sender, EventArgs e)
        {
            
        }

        private void TelaJogo_Load_1(object sender, EventArgs e)
        {

        }
    }
}
