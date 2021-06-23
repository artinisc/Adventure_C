using Adventure.Estrutura;
using Adventure.FuncoesJogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.PartesJogo
{
    public class Inicio
    {
        public int resposta { get; set; }
        public Personagem cap1(Personagem personagem)
        {

            CriaPersonagem criacao = new CriaPersonagem();
            //Informacoes inf = new Informacoes();
            Boolean avanca = false;

            Console.Clear();
            //inf.infP(personagem);
            Console.WriteLine("CAPITULO I - UMA JORNADA INESPERADA\n\n");
            Console.WriteLine("Felismente essa sensação estranha logo passa, as coisas parecem estar se estabilizando.");
            Console.WriteLine("Para um laboratorio voce sente uma estranha brisa que carrega com sigo um cheiro fresco do orvalho da manhã...");
            Console.WriteLine("Aos poucos sua visão vai ficando mais clara e!!!");
            Console.WriteLine("\n\n\nPrecione qualquer tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
            //inf.infP(personagem);
            Console.WriteLine("QUE!!! ONDE ESTOU!!!");
            Console.WriteLine("\n\n\nPrecione qualquer tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
            //inf.infP(personagem);
            Console.WriteLine("Voce se ve no que parece ser o topo de uma montanha,");
            Console.WriteLine("e logo percebe que voce não esta com suas roupas tão pouco se parece com voce mesmo!.");
            Console.WriteLine("Estou vestido como um...");
            Console.WriteLine("\n\n\nPrecione qualquer tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
            //inf.infP(personagem);

            personagem = criacao.escolherC(personagem);

            Console.Clear();
            //inf.infPC(personagem, personagem.getClasse());
            Console.WriteLine("Parabens! Voce acabou de selecionar sua classe.");
            Console.WriteLine("Conforme o decorrer do jogo voce vai se deparar com situações e escolhas.");
            Console.WriteLine("Escolha com sabedoria, pois o rumo do jogo pode ser alterado drasticamente conforme sua decisão.");
            Console.WriteLine("Apos algumas decisões e etapas do jogo voce tambem recebera rescompensas");
            Console.WriteLine("e muitas veses podera escolher entre algumas opções,");
            Console.WriteLine("podendo variar entre atributos para o seu personagem, equipamentos, entre outros.");
            Console.WriteLine("A seguir voce tera sua primeira escolha de recompensas.");
            Console.WriteLine("\n\n\nPrecione qualquer tecla para continuar...");
            Console.ReadLine();
            Console.Clear();

            if (personagem.Escolhas.RecebeuInformacoesLaboratorio == true)
            {
                if (personagem.getClasse().Nome == "Guerreiro")
                {
                    Console.Clear();
                    //inf.infPC(personagem, personagem.getClasse());
                    Console.WriteLine("\n\n\nPrecione: \n 1 Para +5 Força \n 2 Para +5 Resistencia\n 3 Para Investida (Libera tecnica que permite avançar contra o oponente causando dano com probabilidade de derrubar)");
                    try { resposta = Int32.Parse(Console.ReadLine()); } catch (Exception x) { }
                    do
                    {
                        if (resposta == 1 || resposta == 2 || resposta == 3)
                        {
                            avanca = true;
                            switch (resposta)
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
                        else
                        {
                            Console.WriteLine("\n\n\nOpção " + resposta + " Invalida! Selecione outro valor ...");
                            try { resposta = Int32.Parse(Console.ReadLine()); } catch (Exception x) { }
                        }
                    } while (avanca == false);
                }
                else if (personagem.getClasse().Nome == "Mago")
                {
                    Console.Clear();
                    //inf.infPC(personagem, personagem.getClasse());
                    Console.WriteLine("\n\n\nPrecione: \n 1 Para +5 Magia\n 2 Para +5 Inteligencia\n 3 Para Bola de Fogo (Libera tecnica que permite lançar uma bola de fogo sobre o oponente causando dano com probabilidade de cegueira)");
                    try { resposta = Int32.Parse(Console.ReadLine()); } catch (Exception x) { }
                    do
                    {
                        if (resposta == 1 || resposta == 2 || resposta == 3)
                        {
                            avanca = true;
                            switch (resposta)
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
                        else
                        {
                            Console.WriteLine("\n\n\nOpção " + resposta + " Invalida! Selecione outro valor ...");
                            try { resposta = Int32.Parse(Console.ReadLine()); } catch (Exception x) { }
                        }
                    } while (avanca == false);
                }
                else if (personagem.getClasse().Nome == "Arqueiro")
                {
                    Console.Clear();
                    //inf.infPC(personagem, personagem.getClasse());
                    Console.WriteLine("\n\n\nPrecione: \n 1 Para +5 Velocidade \n 2 Para +5 Carisma\n 3 Para Evadir (Libera tecnica que permite saltar para loge da ameaça esquivando de qualquer ataque com probabilidade de confundir)");
                    try { resposta = Int32.Parse(Console.ReadLine()); } catch (Exception x) { }
                    do
                    {
                        if (resposta == 1 || resposta == 2 || resposta == 3)
                        {
                            avanca = true;
                            switch (resposta)
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
                        else
                        {
                            Console.WriteLine("\n\n\nOpção " + resposta + " Invalida! Selecione outro valor ...");
                            try { resposta = Int32.Parse(Console.ReadLine()); } catch (Exception x) { }
                        }
                    } while (avanca == false);
                }
            }
            else
            {
                Console.Clear();
                //inf.infPC(personagem, personagem.getClasse());
                Console.WriteLine("\n\n\nPrecione: \n 1 Para +5 Inteligencia \n 2 Para +5 Carisma\n 3 Para +5 Resistencia");
                try { resposta = Int32.Parse(Console.ReadLine()); } catch (Exception x) { }
                do
                {
                    if (resposta == 1 || resposta == 2 || resposta == 3)
                    {
                        avanca = true;
                        switch (resposta)
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
                    else
                    {
                        Console.WriteLine("\n\n\nOpção " + resposta + " Invalida! Selecione outro valor ...");
                        try { resposta = Int32.Parse(Console.ReadLine()); } catch (Exception x) { }
                    }
                } while (avanca == false);
            }

            return personagem;
        }

        public Personagem cap2(Personagem personagem)
        {

            CriaPersonagem criacao = new CriaPersonagem();
            //Informacoes inf = new Informacoes();
            int resposta = 0;
            Boolean avanca = false;
            int nResposta = 0;

            Console.Clear();
            //inf.infPC(personagem, personagem.getClasse());
            Console.WriteLine("CAPITULO I PARTE II - PRIMEIRAS DESCOBERTAS\n\n");
            Console.WriteLine("Voce continua sem entender nada, principalmente por parecer lembrar e fazer coisas as quais nunca fez ou viveu antes.");
            Console.WriteLine("Sua cabeça esta uma confuzão e doi um pouco.");
            Console.WriteLine("Mas antes mesmo de ter tempo para raciocinar sente algo espetar suas costas, e uma voz aguda gritando:");
            Console.WriteLine("Não se mova e identifique-se!");
            Console.WriteLine("Apesar de a voz falar em um dialeto que voce não conhece, de alguma forma voce entende cada palavra.");
            Console.WriteLine("\n\n\nPrecione qualquer tecla para continuar...");
            Console.ReadLine();

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

            return personagem;
        }
    }
}
