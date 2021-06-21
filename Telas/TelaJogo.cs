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

        public TelaJogo(DadosTelaJogo dadosTela)
        {
            PastaImagem = Application.StartupPath + @"\Imagens\";

            InitializeComponent();
            this.BackgroundImage = Image.FromFile(PastaImagem + dadosTela.ImgFundo);
            this.btOp1.BackgroundImage = Image.FromFile(PastaImagem + dadosTela.ImgBtOp1);
            this.btOp2.BackgroundImage = Image.FromFile(PastaImagem + dadosTela.ImgBtOp2);
            this.btOp3.BackgroundImage = Image.FromFile(PastaImagem + dadosTela.ImgBtOp3);
            this.painelStat.BackgroundImage = Image.FromFile(PastaImagem + dadosTela.ImgPainelStat);
            this.textoDesc.BackgroundImage = Image.FromFile(PastaImagem + dadosTela.ImgTxtDesc);

            this.btOp1.Text = dadosTela.TxtBtOp1;
            this.btOp2.Text = dadosTela.TxtBtOp2;
            this.btOp3.Text = dadosTela.TxtBtOp3;
            this.textoDesc.Text = dadosTela.TxtTxtDesc;
            this.vlCarisma.Text = dadosTela.TxtCarisma;
            this.vlInteligencia.Text = dadosTela.TxtInteligencia;
            this.vlResistencia.Text = dadosTela.TxtResistencia;
            this.vlForca.Text = dadosTela.TxtForca;
            this.vlSabedoria.Text = dadosTela.TxtSabedoria;
            this.vlAgilidade.Text = dadosTela.TxtAgilidade;
            this.vlSaude.Text = dadosTela.TxtSaude;
            this.vlDinheiro.Text = dadosTela.TxtDinheiro;

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
