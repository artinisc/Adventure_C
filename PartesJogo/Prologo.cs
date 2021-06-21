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
        public int resposta { get; set; }
        public Personagem cap1(Personagem personagem)
        {

            DadosTelaJogo dadosTela1 = new DadosTelaJogo()
            {
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
                ImgFundo = @"Genericas\Fundo_Basico.jpg",
                ImgBtOp1 = @"Genericas\Fundo_Op.png",
                ImgBtOp2 = @"Genericas\Fundo_Op.png",
                ImgBtOp3 = @"Genericas\Fundo_Op.png",
                ImgTxtDesc = @"Genericas\Fundo_Basico.jpg",
                ImgPainelStat = @"Genericas\Painel_Stat.jpg",
                TxtBtOp1 = "Teste 1",
                TxtBtOp2 = "Teste 2",
                TxtBtOp3 = "Teste 3",
                TxtTxtDesc = "Teste 4",
                TxtCarisma = "Teste 5",
                TxtInteligencia = "Teste 6",
                TxtResistencia = " Teste 7",
                TxtForca = "Teste 8",
                TxtSabedoria = " Teste 9",
                TxtAgilidade = "Teste 10",
                TxtSaude = "Teste 11",
                TxtDinheiro = "Teste 12"
            };

            TelaJogo tela1 = new TelaJogo(dadosTela1);
            Application.Run(tela1);


            //Informacoes inf = new Informacoes();
            Boolean avanca = false;

            Console.Clear();
            //inf.infP(personagem);
            Console.WriteLine("PROLOGO\n\n");
            Console.WriteLine("O dia é 6 de agosto de 1945...");
            Console.WriteLine("Voce caminha tranquilamento pelos corredores do Instituto Nacional de Pesquisas Energeticas de Hiroshima no Japão");
            Console.WriteLine("\n\n\nPrecione qualquer tecla para continuar...");
            Console.ReadLine();

            Console.Clear();
            //inf.infP(personagem);
            Console.WriteLine("Dr." + personagem.Nome + " espere!");
            Console.WriteLine("\n\n\nPrecione: \n 1 Para olhar para traz \n 2 Para continuar até seu laboratorio\n 3 Para gritar e sair correndo...");
            try { resposta = Int32.Parse(Console.ReadLine()); } catch (Exception x) { }

            do
            {
                if (resposta == 1 || resposta == 2 || resposta == 3)
                {
                    avanca = true;
                }
                else
                {
                    Console.WriteLine("\n\n\nOpção " + resposta + " Invalida! Selecione outro valor ...");
                    try { resposta = Int32.Parse(Console.ReadLine()); } catch (Exception x) { }
                }
            } while (avanca == false);

            switch (resposta)
            {
                case 1:
                    personagem.escolhas.RecebeuInformacoesLaboratorio = true;
                    Console.Clear();
                    //inf.infP(personagem);
                    Console.WriteLine("Voce vira e ve uma jovem garota vindo em sua direção...");
                    Console.WriteLine("Professor que bom que encontrei o senhor!");
                    Console.WriteLine("O general Yamamoto veio essa manhã ao laboratorio com um artefato bastante interessante.");
                    Console.WriteLine("Acredito que pode ajudar em muito nossa pesquisa com super condutores...");
                    Console.WriteLine("Segundo ele o artefato foi recuperado de um navio da marinha americana vindo do pacifico sul, proximo a Antartida.");
                    Console.WriteLine("Fiz alguns testes iniciais e ao dar uma discarga eletrica o objeto manteve a corrente eletrica circulando ao seu redor,");
                    Console.WriteLine("aparentemente sem perdas, como se estivesse suspença por alguma força eletromagnetica.");
                    Console.WriteLine("Enfim, bom proveito, vou levar o relatorio até a direção.");
                    Console.WriteLine("\n\n\nPrecione qualquer tecla para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    //inf.infP(personagem);
                    Console.WriteLine("Voce segue ao laboratorio, e ve sobre a mesa de testes uma esfera flutuando e rodeada por uma corrente eletrica.");
                    Console.WriteLine("Ao me aproximar percebo que éla parece feita em um materia metalico,");
                    Console.WriteLine("porem diferente dos que conhesso, este é um pouco fosco,");
                    Console.WriteLine("como se tivesse um fino revestimento ceramico.");
                    Console.WriteLine("Porem voce não consegue observar por muito tempo...");
                    Console.WriteLine("Repentinamente o objeto começa a emitir um som metalico e a sala é tomada por um clarão ofuscante!");
                    Console.WriteLine("Por um momento tudo fica escuro e voce sente como se estivece girando pelo ar e é tomado por uma forte nausea.");
                    personagem.estado = true;
                    personagem.ultimaR = 1;
                    Console.WriteLine("\n\n\nPrecione qualquer tecla para continuar...");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    //inf.infP(personagem);
                    Console.WriteLine("Voce chega ao seu laboratorio e inicia os preparativos para dar continuidade nos testes de materiais supercondutores...");
                    Console.WriteLine("Escuta um som metalico e ao se virar é surpreendido por um clarão ofuscante!");
                    Console.WriteLine("Por um momento tudo fica escuro e voce sente um forte nausea");
                    personagem.estado = true;
                    personagem.ultimaR = 2;
                    Console.WriteLine("\n\n\nPrecione qualquer tecla para continuar...");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    //inf.infP(personagem);
                    Console.WriteLine("Voce anda sem rumo pelos corredores e...");
                    Console.WriteLine("Ve um clarão ofuscante!");
                    Console.WriteLine("Logo tudo fica escuro e voce perde a conciencia... É o fim...");
                    personagem.estado = false;
                    Console.WriteLine("\n\n\nPrecione qualquer tecla para continuar...");
                    Console.ReadLine();
                    break;
            }
            return personagem;
        }
    }
}
