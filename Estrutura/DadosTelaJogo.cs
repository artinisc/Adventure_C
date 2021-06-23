using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Estrutura
{
    public class DadosTelaJogo
    {
        public bool EstadoBtAvancar { get; set; }
        public bool EstadoBtOp1 { get; set; }
        public bool EstadoBtOp2 { get; set; }
        public bool EstadoBtOp3 { get; set; }
        public bool EstadoBtMenu { get; set; }
        public bool EstadoTxtDesc { get; set; }
        public bool EstadoPainelStat { get; set; }
        public bool EstadoCarisma { get; set; }
        public bool EstadoInteligencia { get; set; }
        public bool EstadoResistencia { get; set; }
        public bool EstadoForca { get; set; }
        public bool EstadoSabedoria { get; set; }
        public bool EstadoAgilidade { get; set; }
        public bool EstadoSaude { get; set; }
        public bool EstadoDinheiro { get; set; }
        public List<string> ImgFundo { get; set; }
        public string ImgBtOp1 { get; set; }
        public string ImgBtOp2 { get; set; }
        public string ImgBtOp3 { get; set; }
        public string ImgTxtDesc { get; set; }
        public string ImgPainelStat { get; set; }
        public string TxtBtOp1 { get; set; }
        public string TxtBtOp2 { get; set; }
        public string TxtBtOp3 { get; set; }
        public List<string> TxtTxtDesc { get; set; }
        public int TxtCarisma { get; set; }
        public int TxtInteligencia { get; set; }
        public int TxtResistencia { get; set; }
        public int TxtForca { get; set; }
        public int TxtSabedoria { get; set; }
        public int TxtAgilidade { get; set; }
        public int TxtSaude { get; set; }
        public int TxtDinheiro { get; set; }
    }
}
