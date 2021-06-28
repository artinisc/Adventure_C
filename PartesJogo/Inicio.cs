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

            if (this.Resposta != 0 && personagem.Estado == true)
            {
                Tela4(personagem);
            }

            if (this.Resposta != 0 && personagem.Estado == true)
            {
                personagem.Etapa = "fimDemo";
            }

            return personagem; 
        }
        #endregion

        #region Tela1
        public void Tela1(Personagem personagem)
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
                    @"Inicio\MosteiroDesfoque.jpg"
                    ,
                    @"Inicio\Mosteiro.jpg"
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
                    "Felismente essa sensação logo passa,\n" +
                     "sua visão parece estar estabilizando.\n"+
                     "Mas para um laboratorio voce sente\n"+
                     "uma estranha brisa que carrega com sigo\n" +
                     "o cheiro fresco do orvalho da manhã...\n"+
                     "Aos poucos sua visão vai clareando e!!!\n"
                    ,
                    "img"
                    ,
                    "QUE!!! ONDE ESTOU!!!\n" +
                     "Voce se ve no alto de uma montanha aos pes \n"+
                     "do que parece um castelo ou monasterio,\n"+
                     "mas antes que possa observar melhor percebe\n"+
                     "que voce não esta com suas roupas tão pouco \n" +
                     "se parece com voce mesmo!\n" +
                     "Estou vestido como um...\n"
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
                    @"Genericas\Conselheiro.jpg"
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
                    "Parabens! Voce acabou de selecionar sua\n" +
                    "classe. \n" +
                     "Conforme o decorrer do jogo voce vai se \n"+
                     "deparar com situações e escolhas.\n" +
                     "Escolha com sabedoria, pois o rumo do jogo \n"+
                     "pode ser alterado drasticamente conforme sua \n" +
                     "   decisão."
                    ,
                    "Apos algumas decisões e etapas do jogo \n" +
                     "voce tambem recebera rescompensas e muitas \n"+
                     "veses podera escolher entre algumas opções, \n" +
                     "podendo variar entre atributos para o seu \n"+
                     "personagem, equipamentos, entre outros.\n" +
                     "A seguir voce tera sua primeira escolha de\n"+
                     "   recompensas."
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

            this.Resposta = tela.Resposta;
        }
        #endregion

        #region Tela3
        public void Tela3(Personagem personagem)
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
                    @"Inicio\Mosteiro.jpg"
                    ,
                    @"Inicio\MongesG.jpg"
                },
                ImgBtOp1 = @"Genericas\Fundo_Op.png",
                ImgBtOp2 = @"Genericas\Fundo_Op.png",
                ImgBtOp3 = @"Genericas\Fundo_Op.png",
                ImgTxtDesc = @"Genericas\FundoText.png",
                ImgPainelStat = @"Genericas\Painel_Stat.jpg",
                TxtBtOp1 = "Espere, eu não fasso ideia!",
                TxtBtOp2 = "Eu agiria com mais cautela no \nseu lugar!",
                TxtBtOp3 = "Ficar em silencio",
                TxtTxtDesc = new List<string>()
                {
                    "Voce continua sem entender nada, \n" +
                     "principalmente por parecer lembrar e fazer \n"+
                     "coisas as quais nunca fez ou viveu antes.\n" +
                     "Sua cabeça esta uma confuzão e doi um pouco.\n"+
                     "Mas antes mesmo de ter tempo para raciocinar\n" +
                     "sente algo espetar suas costas, e uma voz \n"+
                     "   aguda gritando:"
                    ,
                    "Não se mova e identifique-se!\n" +
                     "Apesar de a voz falar em um dialeto que voce \n"+
                     "não conhece, de alguma forma voce entende \n" +
                     "cada palavra.\n"
                    ,
                    "img"
                    ,
                    "opt"
                    ,
                    "Voce vira rapidamente e ve o que parecem \n" +
                    "ser tres estranhos monges em posição de batalha\n"
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

            if (!personagem.getClasse().PoderPrincipal.Equals(""))
            {
                dadosTela.TxtBtOp3 = personagem.getClasse().PoderPrincipal;
            }

            TelaJogo tela = new TelaJogo(dadosTela);
            Application.Run(tela);

            this.Resposta = tela.Resposta;
        }
        #endregion

        #region Tela4
        public void Tela4(Personagem personagem)
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
                    @"Inicio\MongesG.jpg"
                },
                ImgBtOp1 = @"Genericas\Fundo_Op.png",
                ImgBtOp2 = @"Genericas\Fundo_Op.png",
                ImgBtOp3 = @"Genericas\Fundo_Op.png",
                ImgTxtDesc = @"Genericas\FundoText.png",
                ImgPainelStat = @"Genericas\Painel_Stat.jpg",
                TxtBtOp1 = "Espere, eu não fasso ideia!",
                TxtBtOp2 = "Eu agiria com mais cautela no seu lugar!",
                TxtBtOp3 = "Ficar em silencio",
                TxtTxtDesc = new List<string>()
                {
                    ""
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

            switch (this.Resposta)
            {
                case 1:
                    dadosTela.TxtTxtDesc[0] =
                        "Espere, não fasso ideia, \n" +
                        "não lembro de nada...\n";
                    break;
                case 2:
                    dadosTela.TxtTxtDesc[0] =
                        "Eu agiria com mais cautela no seu lugar. \n" +
                         "Voce sabe a quem esta ameaçando!\n";
                    break;
                case 3:
                    if (!personagem.getClasse().PoderPrincipal.Equals(""))
                    {
                        if (personagem.getClasse().Nome == "Guerreiro")
                        {
                            dadosTela.TxtTxtDesc[0] =
                                "Voce avança em furia contra os \n" +
                                 "individuos.\n";
                        }
                        else if (personagem.getClasse().Nome == "Mago")
                        {
                            dadosTela.TxtTxtDesc[0] =
                                "Voce cria um vortice de labaredas entre \n" +
                                 "suas mãos e arremeça contra os individuos \n";
                        }
                        else if (personagem.getClasse().Nome == "Arqueiro")
                        {
                            dadosTela.ImgFundo[0] = @"Inicio\MongesG.jpg";
                            dadosTela.TxtTxtDesc[0] =
                                "Voce salta velosmente para longe \n";
                        }
                    }
                    else
                    {
                        dadosTela.TxtTxtDesc[0] =
                                "Voce permanece em silencio\n";
                    }
                    break;
            }

            TelaJogo tela = new TelaJogo(dadosTela);
            Application.Run(tela);

            this.Resposta = tela.Resposta;
        }
        #endregion
    }
}
