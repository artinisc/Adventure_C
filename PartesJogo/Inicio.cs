using Adventure.Estrutura;
using Adventure.FuncoesJogo;
using Adventure.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure.PartesJogo
{
    public class Inicio
    {
        public int Resposta { get; set; }

        #region Controle
        public Personagem cap1(Personagem personagem)
        {
            CriaPersonagem criar = new CriaPersonagem();

            Tela1(personagem);

            if (this.Resposta != 0 && personagem.Estado == true)
            {
                TelaEscolheClasse(personagem);
            }

            switch (Resposta)
            {
                case 1:
                    personagem = criar.escolherC(personagem, "Guerreiro");
                    break;
                case 2:
                    personagem = criar.escolherC(personagem, "Mago");
                    break;
                case 3:
                    personagem = criar.escolherC(personagem, "Arqueiro");
                    break;
            }

            if(this.Resposta != 0 && personagem.Estado == true)
            {
                Tela2(personagem);
            }

            if (this.Resposta != 0 && personagem.Estado == true)
            {
                TelaRecompensa1(personagem);
            }

            if (this.Resposta != 0 && personagem.Estado == true)
            {
                Tela3(personagem);
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
                    "Felismente essa sensação estranha logo passa, \n" +
                     "as coisas parecem estar se estabilizando.\n"+
                     "Para um laboratorio voce sente uma estranha \n"+
                     "brisa que carrega com sigo um cheiro fresco \n" +
                     "do orvalho da manhã...\n"+
                     "Aos poucos sua visão vai ficando mais clara e!!!\n"
                    ,
                    "img"
                    ,
                    "QUE!!! ONDE ESTOU!!!\n" +
                     "Voce se ve no que parece ser o topo de uma \n"+
                     "montanha, e logo percebe que voce não esta com \n"+
                     "suas roupas tão pouco se parece com voce mesmo!\n" +
                     "Estou vestido como um...\n"
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

        #region Tela Escolha de Classe
        public void TelaEscolheClasse(Personagem personagem)
        {
            TelaNovaC tela = new TelaNovaC();
            Application.Run(tela);

            this.Resposta = tela.Resposta;
        }
        #endregion

        #region Tela2
        public void Tela2(Personagem personagem)
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
                    "Parabens! Voce acabou de selecionar sua classe.\n" +
                     "Conforme o decorrer do jogo voce vai se deparar \n"+
                     "com situações e escolhas.\n" +
                     "Escolha com sabedoria, pois o rumo do jogo pode \n"+
                     "ser alterado drasticamente conforme sua decisão.\n"
                    ,
                    "Apos algumas decisões e etapas do jogo voce \n" +
                     "tambem recebera rescompensas e muitas veses \n"+
                     "podera escolher entre algumas opções, podendo \n" +
                     "variar entre atributos para o seu personagem, \n"+
                     "equipamentos, entre outros.\n" +
                     "A seguir voce tera sua primeira escolha de\n"+
                     "   recompensas."
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

        #region Tela Recompensa 1
        public void TelaRecompensa1(Personagem personagem)
        {
            DadosTelaRecompensa dadosRecompensa = new DadosTelaRecompensa()
            {
                EstadoBt1 = true,
                EstadoBt2 = true,
                EstadoBt3 = true,
                EstadoDesc1 = false,
                EstadoDesc2 = false,
                EstadoDesc3 = false,
                txtBt1 = "",
                txtBt2 = "",
                txtBt3 = "",
                txtDesc1 = "",
                txtDesc2 = "",
                txtDesc3 = ""
            };

            if (personagem.Escolhas.RecebeuInformacoesLaboratorio == true)
            {
                if (personagem.getClasse().Nome == "Guerreiro")
                {
                    dadosRecompensa.EstadoDesc3 = true;
                    dadosRecompensa.txtBt1 = "+5 Força";
                    dadosRecompensa.txtBt2 = "+5 Resistencia";
                    dadosRecompensa.txtBt3 = "Investida";
                    dadosRecompensa.txtDesc3 = "Libera tecnica que permite avançar contra o oponente causando dano com probabilidade de derrubar.";
                }
                else if (personagem.getClasse().Nome == "Mago")
                {
                    dadosRecompensa.EstadoDesc3 = true;
                    dadosRecompensa.txtBt1 = "+5 Sabedoria";
                    dadosRecompensa.txtBt2 = "+5 Inteligencia";
                    dadosRecompensa.txtBt3 = "Bola de Fogo";
                    dadosRecompensa.txtDesc3 = "Libera tecnica que permite lançar uma bola de fogo sobre o oponente causando dano com probabilidade de cegueira.";
                }
                else if (personagem.getClasse().Nome == "Arqueiro")
                {
                    dadosRecompensa.EstadoDesc3 = true;
                    dadosRecompensa.txtBt1 = "+5 Agilidade";
                    dadosRecompensa.txtBt2 = "+5 Carisma";
                    dadosRecompensa.txtBt3 = "Evadir";
                    dadosRecompensa.txtDesc3 = "Libera tecnica que permite saltar para loge da ameaça esquivando de qualquer ataque com probabilidade de confundir.";
                }
            }
            else
            {
                dadosRecompensa.txtBt1 = "+5 Inteligencia";
                dadosRecompensa.txtBt2 = "+5 Carisma";
                dadosRecompensa.txtBt3 = "+5 Resistencia";
            }

            TelaRecompensa tela = new TelaRecompensa(dadosRecompensa);
            Application.Run(tela);

            if (personagem.Escolhas.RecebeuInformacoesLaboratorio == true)
            {
                if (personagem.getClasse().Nome == "Guerreiro")
                {
                    switch (tela.Resposta)
                    {
                        case 1:
                            personagem.ForcaBase = +5;
                            break;
                        case 2:
                            personagem.RestenciaBase = +5;
                            break;
                        case 3:
                            personagem.getClasse().PoderPrincipal = "Investida";
                            break;
                    }
                    personagem.defineAtributos();
                }
                else if (personagem.getClasse().Nome == "Mago")
                {
                    switch (tela.Resposta)
                    {
                        case 1:
                            personagem.MagiaBase = +5;
                            break;
                        case 2:
                            personagem.InteligenciaBase = +5;
                            break;
                        case 3:
                            personagem.getClasse().PoderPrincipal = "Bola de Fogo";
                            break;
                    }
                    personagem.defineAtributos();
                }
                else if (personagem.getClasse().Nome == "Arqueiro")
                {
                    switch (tela.Resposta)
                    {
                        case 1:
                            personagem.VelocidadeBase = +5;
                            break;
                        case 2:
                            personagem.CarismaBase = +5;
                            break;
                        case 3:
                            personagem.getClasse().PoderPrincipal = "Evadir";
                            break;
                    }
                    personagem.defineAtributos();
                }
            }
            else
            {
                switch (tela.Resposta)
                {
                    case 1:
                        personagem.InteligenciaBase = +5;
                        break;
                    case 2:
                        personagem.CarismaBase = +5;
                        break;
                    case 3:
                        personagem.RestenciaBase = +5;
                        break;
                }
                personagem.defineAtributos();
            }
        }
        #endregion

        #region Tela3
        public void Tela3(Personagem personagem)
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
                    "Voce continua sem entender nada, \n" +
                     "principalmente por parecer lembrar e fazer \n"+
                     "coisas as quais nunca fez ou viveu antes.\n" +
                     "Sua cabeça esta uma confuzão e doi um pouco.\n"+
                     "Mas antes mesmo de ter tempo para raciocinar \n" +
                     "sente algo espetar suas costas, e uma voz \n"+
                     "   aguda gritando:"
                    ,
                    "Não se mova e identifique-se!\n" +
                     "Apesar de a voz falar em um dialeto que voce \n"+
                     "não conhece, de alguma forma voce entende \n" +
                     "cada palavra.\n"
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

        /*

            Console.Clear();
            //inf.infPC(personagem, personagem.getClasse());
            if (!personagem.getClasse().PoderPrincipal.Equals(""))
            {
                Console.WriteLine("\n\n\nPrecione: \n 1 Para 'Espere, eu não fasso ideia, quando me dei por si ja estava aqui, não lembro de nada...'\n 2 Para 'Eu agiria com mais cautela no seu lugar. Voce sabe a quem esta ameaçando!'\n 3 Para usar tecnica " + personagem.getClasse().PoderPrincipal);
                nResposta = 3;
            }
            else
            {
                Console.WriteLine("\n\n\nPrecione: \n 1 Para 'Espere, eu não fasso ideia, quando me dei por si ja estava aqui, não lembro de nada...'\n 2 Para 'Eu agiria com mais cautela no seu lugar. Voce sabe a quem esta ameaçando!'");
                nResposta = 2;
            }
            try { resposta = Int32.Parse(Console.ReadLine()); } catch (Exception x) { }

            do
            {
                if (resposta >= 1 && resposta <= nResposta)
                {
                    avanca = true;
                    switch (resposta)
                    {
                        case 1:
                            Console.Clear();
                            //inf.infPC(personagem, personagem.getClasse());
                            Console.WriteLine("Espere, não fasso ideia, não lembro de nada...");
                            Console.WriteLine("\n\n\nPrecione qualquer tecla para continuar...");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();
                            //inf.infPC(personagem, personagem.getClasse());
                            Console.WriteLine("Eu agiria com mais cautela. Voce sabe a quem esta ameaçando!");
                            Console.WriteLine("\n\n\nPrecione qualquer tecla para continuar...");
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            //inf.infPC(personagem, personagem.getClasse());
                            if (personagem.getClasse().Nome == "Guerreiro")
                            {
                                Console.WriteLine("Voce vira e rapidamente avança em furia contra o que parecem ser 3 monges armados e um senhor de idade bastante avançada.");
                            }
                            else if (personagem.getClasse().Nome == "Mago")
                            {
                                Console.WriteLine("Voce cria um vortice de labaredas entre suas mãos e arremeça contra o que parecem ser 3 monges armados e um senhor de idade bastante avançada.");
                            }
                            else if (personagem.getClasse().Nome == "Arqueiro")
                            {
                                Console.WriteLine("Voce salta velosmente para longe e vo o que  parecem ser 3 monges armados e um senhor de idade bastante avançada.");
                            }
                            Console.WriteLine("\n\n\nPrecione qualquer tecla para continuar...");
                            Console.ReadLine();
                            break;
                    }
                    personagem.defineAtributos();
                }
                else
                {
                    Console.WriteLine("\n\n\nOpção " + resposta + " Invalida! Selecione outro valor ...");
                    try { resposta = Int32.Parse(Console.ReadLine()); } catch (Exception x) { }
                }
            } while (avanca == false);

         */
    }
}
