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
        public int Resposta { get; set; }
        public int ContTexto { get; set; }
        public int ContImg { get; set; }
        public List<string> Texto { get; set; }
        public List<string> Imagem { get; set; }

        public TelaJogo(DadosTelaJogo dadosTela)
        {
            PastaImagem = Application.StartupPath + @"\Imagens\";

            InitializeComponent();

            this.Texto = dadosTela.TxtTxtDesc;
            this.Imagem = dadosTela.ImgFundo;

            this.BackgroundImage = Image.FromFile(PastaImagem + dadosTela.ImgFundo[0]);
            this.btOp1.BackgroundImage = Image.FromFile(PastaImagem + dadosTela.ImgBtOp1);
            this.btOp2.BackgroundImage = Image.FromFile(PastaImagem + dadosTela.ImgBtOp2);
            this.btOp3.BackgroundImage = Image.FromFile(PastaImagem + dadosTela.ImgBtOp3);
            this.painelStat.BackgroundImage = Image.FromFile(PastaImagem + dadosTela.ImgPainelStat);
            this.textoDesc.BackgroundImage = Image.FromFile(PastaImagem + dadosTela.ImgTxtDesc);

            this.btOp1.Text = dadosTela.TxtBtOp1;
            this.btOp2.Text = dadosTela.TxtBtOp2;
            this.btOp3.Text = dadosTela.TxtBtOp3;
            this.textoDesc.Text = dadosTela.TxtTxtDesc[0];
            this.vlCarisma.Text = Convert.ToString(dadosTela.TxtCarisma);
            this.vlInteligencia.Text = Convert.ToString(dadosTela.TxtInteligencia);
            this.vlResistencia.Text = Convert.ToString(dadosTela.TxtResistencia);
            this.vlForca.Text = Convert.ToString(dadosTela.TxtForca);
            this.vlSabedoria.Text = Convert.ToString(dadosTela.TxtSabedoria);
            this.vlAgilidade.Text = Convert.ToString(dadosTela.TxtAgilidade);
            this.vlSaude.Text = Convert.ToString(dadosTela.TxtSaude);
            this.vlDinheiro.Text = Convert.ToString(dadosTela.TxtDinheiro);

            this.btAvancar.Visible = dadosTela.EstadoBtAvancar;
            this.btMenu.Visible = dadosTela.EstadoBtMenu;
            this.btOp1.Visible = dadosTela.EstadoBtOp1;
            this.btOp2.Visible = dadosTela.EstadoBtOp2;
            this.btOp3.Visible = dadosTela.EstadoBtOp3;
            this.textoDesc.Visible = dadosTela.EstadoTxtDesc;
            this.painelStat.Visible = dadosTela.EstadoPainelStat;
            this.vlCarisma.Visible = dadosTela.EstadoCarisma;
            this.vlInteligencia.Visible = dadosTela.EstadoInteligencia;
            this.vlResistencia.Visible = dadosTela.EstadoResistencia;
            this.vlForca.Visible = dadosTela.EstadoForca;
            this.vlSabedoria.Visible = dadosTela.EstadoSabedoria;
            this.vlAgilidade.Visible = dadosTela.EstadoAgilidade;
            this.vlSaude.Visible = dadosTela.EstadoSaude;
            this.vlDinheiro.Visible = dadosTela.EstadoDinheiro;

            btOp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btOp1.FlatAppearance.BorderSize = 0;
            btOp1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btOp1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btOp1.BackColor = Color.Transparent;

            btOp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btOp2.FlatAppearance.BorderSize = 0;
            btOp2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btOp2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btOp2.BackColor = Color.Transparent;

            btOp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btOp3.FlatAppearance.BorderSize = 0;
            btOp3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btOp3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btOp3.BackColor = Color.Transparent;

            this.textoDesc.Padding = new Padding(20, 20, 0, 0);
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

        private void btOp1_Click(object sender, EventArgs e)
        {
            this.Resposta = 1;
            this.Close();
        }

        private void btOp2_Click(object sender, EventArgs e)
        {
            this.Resposta = 2;
            this.Close();
        }

        private void btOp3_Click(object sender, EventArgs e)
        {
            this.Resposta = 3;
            this.Close();

        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            this.Resposta = 0;
            this.Close();
        }

        private void btAvancar_Click(object sender, EventArgs e)
        {
            this.ContTexto++;
            if (this.Texto[this.ContTexto].Equals("img"))
            {
                this.ContImg++;
                this.ContTexto++;
                this.BackgroundImage = Image.FromFile(PastaImagem + this.Imagem[ContImg]);

                if (this.Texto[ContTexto].Equals("opt"))
                {
                    this.ContTexto++;
                    this.textoDesc.Text = this.Texto[ContTexto];

                    this.btAvancar.Visible = false;
                    this.btOp1.Visible = true;
                    this.btOp2.Visible = true;
                    this.btOp3.Visible = true;
                }
                else if(this.Texto[ContTexto].Equals("Fim"))
                {
                    this.Resposta = 8;
                    this.Close();
                }
                else
                {
                    this.textoDesc.Text = this.Texto[ContTexto];
                }
            }
            else if (this.Texto[this.ContTexto].Equals("Fim"))
            {
                this.Resposta = 8;
                this.Close();
            }
            else if (this.Texto[ContTexto].Equals("opt"))
            {
                this.ContTexto++;
                this.textoDesc.Text = this.Texto[ContTexto];

                this.btAvancar.Visible = false;
                this.btOp1.Visible = true;
                this.btOp2.Visible = true;
                this.btOp3.Visible = true;
            }
            else
            {
                this.textoDesc.Text = this.Texto[ContTexto];
            }
        }
    }
}
