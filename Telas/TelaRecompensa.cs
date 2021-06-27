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
    public partial class TelaRecompensa : Form
    {
        public string PastaImagem { get; set; }
        public int Resposta { get; set; }

        public TelaRecompensa(DadosTelaRecompensa dadosRecompensa)
        {
            PastaImagem = Application.StartupPath + @"\Imagens\";

            InitializeComponent();

            this.BackgroundImage = Image.FromFile(PastaImagem + @"Recompenca\Recompensas.jpg");
            this.descR.BackgroundImage = Image.FromFile(PastaImagem + @"Recompenca\tituloR.png");
            this.btR1.BackgroundImage = Image.FromFile(PastaImagem + @"Recompenca\iconeR.png");
            this.btR2.BackgroundImage = Image.FromFile(PastaImagem + @"Recompenca\iconeR.png");
            this.btR3.BackgroundImage = Image.FromFile(PastaImagem + @"Recompenca\iconeR.png");
            this.descR1.BackgroundImage = Image.FromFile(PastaImagem + @"Recompenca\descR.png");
            this.descR2.BackgroundImage = Image.FromFile(PastaImagem + @"Recompenca\descR.png");
            this.descR3.BackgroundImage = Image.FromFile(PastaImagem + @"Recompenca\descR.png");

            this.btR1.Text = dadosRecompensa.txtBt1;
            this.btR2.Text = dadosRecompensa.txtBt2;
            this.btR3.Text = dadosRecompensa.txtBt3;
            this.descR1.Text = dadosRecompensa.txtDesc1;
            this.descR2.Text = dadosRecompensa.txtDesc2;
            this.descR3.Text = dadosRecompensa.txtDesc3;

            this.btR1.Visible = dadosRecompensa.EstadoBt1;
            this.btR2.Visible = dadosRecompensa.EstadoBt2;
            this.btR3.Visible = dadosRecompensa.EstadoBt3;
            this.descR1.Visible = dadosRecompensa.EstadoDesc1;
            this.descR2.Visible = dadosRecompensa.EstadoDesc2;
            this.descR3.Visible = dadosRecompensa.EstadoDesc3;

            btR1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btR1.FlatAppearance.BorderSize = 0;
            btR1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btR1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btR1.BackColor = Color.Transparent;

            btR2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btR2.FlatAppearance.BorderSize = 0;
            btR2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btR2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btR2.BackColor = Color.Transparent;

            btR3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btR3.FlatAppearance.BorderSize = 0;
            btR3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btR3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btR3.BackColor = Color.Transparent;

            this.descR1.Padding = new Padding(30, 30, 30, 30);
            this.descR2.Padding = new Padding(30, 30, 30, 30);
            this.descR3.Padding = new Padding(30, 30, 30, 30);
        }

        private void TelaRecompensa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btR1_Click(object sender, EventArgs e)
        {
            this.Resposta = 1;
            this.Close();
        }

        private void btR2_Click(object sender, EventArgs e)
        {
            this.Resposta = 2;
            this.Close();
        }

        private void btR3_Click(object sender, EventArgs e)
        {
            this.Resposta = 3;
            this.Close();
        }
    }
}
