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
    public partial class TelaNovaC : Form
    {
        public string PastaImagem { get; set; }
        public int Resposta { get; set; }

        public TelaNovaC()
        {
            PastaImagem = Application.StartupPath + @"\Imagens\";

            InitializeComponent();

            this.BackgroundImage = Image.FromFile(PastaImagem + @"Classe\Fundo_Basico.jpg");
            this.Descricao.BackgroundImage = Image.FromFile(PastaImagem + @"Classe\textoDescricao.png");
            this.nomeGuerreiro.BackgroundImage = Image.FromFile(PastaImagem + @"Classe\nomeGuerreiro.png");
            this.nomeMago.BackgroundImage = Image.FromFile(PastaImagem + @"Classe\nomeMago.png");
            this.nomeArqueiro.BackgroundImage = Image.FromFile(PastaImagem + @"Classe\nomeArqueiro.png");
            this.imgGuerreiro.BackgroundImage = Image.FromFile(PastaImagem + @"Classe\Guerreiro.png");
            this.imgMago.BackgroundImage = Image.FromFile(PastaImagem + @"Classe\Mago.png");
            this.imgArqueiro.BackgroundImage = Image.FromFile(PastaImagem + @"Classe\Arqueiro.png");

        }

        private void btGuerreiro_Click(object sender, EventArgs e)
        {
            this.Resposta = 1;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Resposta = 2;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Resposta = 3;
            this.Close();
        }
    }
}
