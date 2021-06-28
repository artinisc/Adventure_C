using Adventure.Estrutura;
using Adventure.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure.PartesJogo
{
    public class Prologo
    {
        public int Resposta { get; set; }

        #region Controle
        public Personagem cap1(Personagem personagem)
        {

            Tela1(personagem);

            if (this.Resposta != 0 && personagem.Estado == true)
            {
                switch (Resposta)
                {
                    case 1:
                        personagem.Escolhas.RecebeuInformacoesLaboratorio = true;
                        Tela2R1(personagem);
                        personagem.Etapa = "inicio";
                        break;
                    case 2:
                        Tela2R2(personagem);
                        personagem.Etapa = "inicio";
                        break;
                    case 3:
                        Tela2R3(personagem);
                        personagem.Etapa = "fim";
                        personagem.Estado = false;
                        break;
                }
            }
            return personagem;
        }
        #endregion

        #region Tela1
        public void Tela1(Personagem personagem)
        {
            DadosTelaJogo dadosTela = new DadosTelaJogo()
            {
                EstadoBtAvancar = false,
                EstadoBtOp1 = true,
                EstadoBtOp2 = true,
                EstadoBtOp3 = true,
                EstadoBtMenu = true,
                EstadoTxtDesc = true,
                EstadoPainelStat = true,
                EstadoCarisma = true,
                EstadoInteligencia = true,
                EstadoResistencia = true,
                EstadoForca = true,
                EstadoSabedoria = true,
                EstadoAgilidade = true,
                EstadoSaude = true,
                EstadoDinheiro = true,
                ImgFundo = new List<string>()
                {
                    @"Prologo\Corredor.jpg"
                },
                ImgBtOp1 = @"Genericas\Fundo_Op.png",
                ImgBtOp2 = @"Genericas\Fundo_Op.png",
                ImgBtOp3 = @"Genericas\Fundo_Op.png",
                ImgTxtDesc = @"Genericas\FundoText.png",
                ImgPainelStat = @"Genericas\Painel_Stat.jpg",
                TxtBtOp1 = "Olhar para traz",
                TxtBtOp2 = "Continuar ao laboratorio",
                TxtBtOp3 = "Gritar e sair correndo...",
                TxtTxtDesc = new List<string>() 
                {
                    "O dia é 6 de agosto de 1945...\n" +
                     "Voce caminha tranquilamento pelos corredores \n"+
                     "do Instituto Nacional de Pesquisas Energeticas \n"+
                     "de Hiroshima no Japão.\n" +
                     "Dr." + personagem.Nome + " espere!\n"
                },
                TxtCarisma = personagem.Carisma,
                TxtInteligencia = personagem.Inteligencia,
                TxtResistencia = personagem.Restencia,
                TxtForca = personagem.Forca,
                TxtSabedoria = personagem.Magia,
                TxtAgilidade = personagem.Agilidade,
                TxtSaude = personagem.Saude,
                TxtDinheiro = personagem.Dinheiro
            };

            TelaJogo tela = new TelaJogo(dadosTela);
            Application.Run(tela);

            this.Resposta = tela.Resposta;
        }
        #endregion

        #region Resposta 1
        public void Tela2R1(Personagem personagem)
        {
            DadosTelaJogo dadosTela = new DadosTelaJogo()
            {
                EstadoBtAvancar = true,
                EstadoBtOp1 = false,
                EstadoBtOp2 = false,
                EstadoBtOp3 = false,
                EstadoBtMenu = true,
                EstadoTxtDesc = true,
                EstadoPainelStat = true,
                EstadoCarisma = true,
                EstadoInteligencia = true,
                EstadoResistencia = true,
                EstadoForca = true,
                EstadoSabedoria = true,
                EstadoAgilidade = true,
                EstadoSaude = true,
                EstadoDinheiro = true,
                ImgFundo = new List<string>()
                {
                    @"Prologo\CorredorProfessora.jpg"
                    ,
                    @"Prologo\LaboratorioEsfera.jpg"
                    ,
                    @"Prologo\Clarao.jpg"
                },
                ImgBtOp1 = @"Genericas\Fundo_Op.png",
                ImgBtOp2 = @"Genericas\Fundo_Op.png",
                ImgBtOp3 = @"Genericas\Fundo_Op.png",
                ImgTxtDesc = @"Genericas\FundoText.png",
                ImgPainelStat = @"Genericas\Painel_Stat.jpg",
                TxtBtOp1 = "",
                TxtBtOp2 = "",
                TxtBtOp3 = "",
                TxtTxtDesc = new List<string>()
                {
                    "Voce vira e ve uma jovem garota vindo em \n" +
                     "sua direção...\n"+
                     "Professor que bom que encontrei o senhor!\n" +
                     "O general Yamamoto veio essa manhã ao \n"+
                     "laboratorio com um artefato bastante \n" +
                     "interessante.\n"
                    ,
                    "Acredito que pode ajudar em muito nossa \n" +
                     "pesquisa com super condutores...\n"
                    ,
                    "Segundo ele o artefato foi recuperado de um \n" +
                     "navio da marinha americana vindo do pacifico\n"+
                     "sul, proximo a Antartida.\n" +
                     "Fiz alguns testes iniciais e ao dar uma discarga\n"+
                     "eletrica o objeto manteve a corrente eletrica \n" +
                     "circulando ao seu redor, aparentemente sem\n"
                     ,
                    " perdas, como se estivesse suspença por \n" +
                     "alguma força eletromagnetica.\n"+
                     "Enfim, bom proveito, vou levar o relatorio \n" +
                     "até a direção.\n"
                    ,
                    "img"
                    ,
                    "Voce segue ao laboratorio, e ve sobre a \n" +
                     "mesa de testes uma esfera flutuando e rodeada \n"+
                     "por uma corrente eletrica.\n" +
                     "Ao me aproximar percebo que éla parece feita\n"+
                     "em um materia metalico, porem diferente dos \n" +
                     "que conhesso, este é um pouco fosco, como se \n"+
                     "   tivesse um fino revestimento ceramico."
                    ,
                    "Porem voce não consegue observar por\n" +
                     "muito tempo...\n"
                    ,
                    "img"
                    ,
                    "Repentinamente o objeto começa a emitir um \n" +
                     "som metalico e a sala é tomada por um clarão\n"+
                     "ofuscante!\n" +
                     "Por um momento tudo fica escuro e voce sente \n"+
                     "como se estivece girando pelo ar e é tomado\n" +
                     "por uma forte nausea.\n"
                     ,
                    "Fim"
                },
                TxtCarisma = personagem.Carisma,
                TxtInteligencia = personagem.Inteligencia,
                TxtResistencia = personagem.Restencia,
                TxtForca = personagem.Forca,
                TxtSabedoria = personagem.Magia,
                TxtAgilidade = personagem.Agilidade,
                TxtSaude = personagem.Saude,
                TxtDinheiro = personagem.Dinheiro
            };

            TelaJogo tela = new TelaJogo(dadosTela);
            Application.Run(tela);
        }

        public void Tela2R2(Personagem personagem)
        {
            DadosTelaJogo dadosTela = new DadosTelaJogo()
            {
                EstadoBtAvancar = true,
                EstadoBtOp1 = false,
                EstadoBtOp2 = false,
                EstadoBtOp3 = false,
                EstadoBtMenu = true,
                EstadoTxtDesc = true,
                EstadoPainelStat = true,
                EstadoCarisma = true,
                EstadoInteligencia = true,
                EstadoResistencia = true,
                EstadoForca = true,
                EstadoSabedoria = true,
                EstadoAgilidade = true,
                EstadoSaude = true,
                EstadoDinheiro = true,
                ImgFundo = new List<string>()
                {
                    @"Prologo\Laboratorio.jpg"
                    ,
                    @"Prologo\Clarao.jpg"
                },
                ImgBtOp1 = @"Genericas\Fundo_Op.png",
                ImgBtOp2 = @"Genericas\Fundo_Op.png",
                ImgBtOp3 = @"Genericas\Fundo_Op.png",
                ImgTxtDesc = @"Genericas\FundoText.png",
                ImgPainelStat = @"Genericas\Painel_Stat.jpg",
                TxtBtOp1 = "",
                TxtBtOp2 = "",
                TxtBtOp3 = "",
                TxtTxtDesc = new List<string>()
                {
                    "Voce chega ao seu laboratorio e inicia os \n" +
                     "preparativos para dar continuidade nos testes \n"+
                     "de materiais supercondutores, quando...\n"
                     ,
                     "img"
                     ,
                     "Escuta um som metalico e ao se virar\n"+
                     "é surpreendido por um clarão ofuscante!\n" +
                     "Por um momento tudo fica escuro e voce sente \n"+
                     " uma forte nausea."
                     ,
                    "Fim"
                },
                TxtCarisma = personagem.Carisma,
                TxtInteligencia = personagem.Inteligencia,
                TxtResistencia = personagem.Restencia,
                TxtForca = personagem.Forca,
                TxtSabedoria = personagem.Magia,
                TxtAgilidade = personagem.Agilidade,
                TxtSaude = personagem.Saude,
                TxtDinheiro = personagem.Dinheiro
            };

            TelaJogo tela = new TelaJogo(dadosTela);
            Application.Run(tela);
        }

        public void Tela2R3(Personagem personagem)
        {
            DadosTelaJogo dadosTela = new DadosTelaJogo()
            {
                EstadoBtAvancar = true,
                EstadoBtOp1 = false,
                EstadoBtOp2 = false,
                EstadoBtOp3 = false,
                EstadoBtMenu = true,
                EstadoTxtDesc = true,
                EstadoPainelStat = true,
                EstadoCarisma = true,
                EstadoInteligencia = true,
                EstadoResistencia = true,
                EstadoForca = true,
                EstadoSabedoria = true,
                EstadoAgilidade = true,
                EstadoSaude = true,
                EstadoDinheiro = true,
                ImgFundo = new List<string>()
                {
                    @"Prologo\Clarao.jpg"
                },
                ImgBtOp1 = @"Genericas\Fundo_Op.png",
                ImgBtOp2 = @"Genericas\Fundo_Op.png",
                ImgBtOp3 = @"Genericas\Fundo_Op.png",
                ImgTxtDesc = @"Genericas\FundoText.png",
                ImgPainelStat = @"Genericas\Painel_Stat.jpg",
                TxtBtOp1 = "",
                TxtBtOp2 = "",
                TxtBtOp3 = "",
                TxtTxtDesc = new List<string>()
                {
                    "Voce anda sem rumo pelos corredores e...\n" +
                     "Ve um clarão ofuscante!\n" +
                     "Logo tudo fica escuro e voce perde a conciencia... \n" +
                     "É o fim...\n"
                     ,
                    "Fim"
                },
                TxtCarisma = personagem.Carisma,
                TxtInteligencia = personagem.Inteligencia,
                TxtResistencia = personagem.Restencia,
                TxtForca = personagem.Forca,
                TxtSabedoria = personagem.Magia,
                TxtAgilidade = personagem.Agilidade,
                TxtSaude = personagem.Saude,
                TxtDinheiro = personagem.Dinheiro
            };

            TelaJogo tela = new TelaJogo(dadosTela);
            Application.Run(tela);
        }
        #endregion

    }
}
