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
    public partial class TelaFimJogo : Form
    {
        public string PastaImagem { get; set; }
        
        public TelaFimJogo(string tipoFim)
        {
            PastaImagem = Application.StartupPath + @"\Imagens\";

            InitializeComponent();

            this.BackgroundImage = Image.FromFile(PastaImagem + @"Fim\FinalJogo.jpg");
            this.imagemFim.BackgroundImage = Image.FromFile(PastaImagem + @"Fim\" + tipoFim+".png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
