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

            if (this.Resposta != 0 && this.Resposta != 9)
            {
                switch (Resposta)
                {
                    case 1:
                        personagem.Escolhas.RecebeuInformacoesLaboratorio = true;
                        Tela2R1(personagem);
                        break;
                    case 2:
                        //Jogar();
                        break;
                    case 3:
                        //FimJogo();
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
                    //      Limites linha 1/7                  //
                    "O dia é 6 de agosto de 1945...\n" +
                    //           Limites  linha 2/6               //
                     "Voce caminha tranquilamento pelos corredores \n"+
                    //           Limites  linha 3/6               //
                     "do Instituto Nacional de Pesquisas Energeticas \n"+
                    //           Limites  linha 4/6               //
                     "de Hiroshima no Japão.\n" +
                    //           Limites  linha 5/6               //
                     "Dr." + personagem.Nome + " espere!\n"+
                    //           Limites  linha 6/6              //
                     "\n"+
                     //           Limites  linha 7/7            //
                     ""
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
                    @"Prologo\Corredor.jpg"
                    ,
                    @"Prologo\Fundo_Basico.jpg"
                    ,
                    @"Prologo\Corredor.jpg"
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
                    //      Limites linha 1/7                  //
                    "Voce vira e ve uma jovem garota vindo em \n" +
                    //           Limites  linha 2/7               //
                     "sua direção...\n"+
                    //           Limites  linha 3/7               //
                     "Professor que bom que encontrei o senhor!\n" +
                    //           Limites  linha 4/7               //
                     "O general Yamamoto veio essa manhã ao \n"+
                    //           Limites  linha 5/7               //
                     "laboratorio com um artefato bastante \n" +
                    //           Limites  linha 6/7              //
                     "interessante.\n"+
                     //           Limites  linha 7/7            //
                     " "
                    ,
                    //      Limites linha 1/7                 //
                    "Acredito que pode ajudar em muito nossa \n" +
                    //           Limites  linha 2/7               //
                     "pesquisa com super condutores...\n"
                    ,
                    "Segundo ele o artefato foi recuperado de um navio da marinha americana vindo do pacifico sul, proximo a Antartida.\n"+
                    "Fiz alguns testes iniciais e ao dar uma discarga eletrica o objeto manteve a corrente eletrica circulando ao seu redor,"+
                    "aparentemente sem perdas, como se estivesse suspença por alguma força eletromagnetica.\n"+
                    "Enfim, bom proveito, vou levar o relatorio até a direção."
                    ,
                    "img"
                    ,
                    "Voce segue ao laboratorio, e ve sobre a mesa de testes uma esfera flutuando e rodeada por uma corrente eletrica.\n"+
                    "Ao me aproximar percebo que éla parece feita em um materia metalico,"+
                    "porem diferente dos que conhesso, este é um pouco fosco,"+
                    "como se tivesse um fino revestimento ceramico.\n"+
                    "Porem voce não consegue observar por muito tempo...\n"
                    ,
                    "img"
                    ,
                    "Repentinamente o objeto começa a emitir um som metalico e a sala é tomada por um clarão ofuscante!"+
                    "Por um momento tudo fica escuro e voce sente como se estivece girando pelo ar e é tomado por uma forte nausea."
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

            this.Resposta = tela.Resposta;
        }

/*

        
        personagem.estado = true;
        personagem.ultimaR = 1;
        "\n\n\nPrecione qualquer tecla para continuar...");
        Console.ReadLine();
        break;




    case 2:
        Console.Clear();
        //inf.infP(personagem);
        "Voce chega ao seu laboratorio e inicia os preparativos para dar continuidade nos testes de materiais supercondutores...");
        "Escuta um som metalico e ao se virar é surpreendido por um clarão ofuscante!");
        "Por um momento tudo fica escuro e voce sente um forte nausea");
        personagem.estado = true;
        personagem.ultimaR = 2;
        "\n\n\nPrecione qualquer tecla para continuar...");
        Console.ReadLine();
        break;
    case 3:
        Console.Clear();
        //inf.infP(personagem);
        "Voce anda sem rumo pelos corredores e...");
        "Ve um clarão ofuscante!");
        "Logo tudo fica escuro e voce perde a conciencia... É o fim...");
        personagem.estado = false;
        "\n\n\nPrecione qualquer tecla para continuar...");
        Console.ReadLine();
        break;
}
*/
    }
}
