using Adventure.FuncoesJogo;
using Adventure.PartesJogo;
using Adventure.Telas;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure.Estrutura
{
    public class Jogo
    {
        #region Objetos
        Personagem personagem = new Personagem();
        public int resposta = 0;
        public string PastaSom { get; set; }
        #endregion

        #region Jogo
        public void Inicia()
        {
            PastaSom = Application.StartupPath + @"\Audio\trilha.wav";

            Audio trilha = new Audio();
            trilha.Play(PastaSom);

            TelaPrincipal telaPrincipal = new TelaPrincipal();
            Application.Run(telaPrincipal);


            switch (telaPrincipal.Resposta)
            {
                case 1:
                    NovoJogo();
                    break;
                case 2:
                    ContinuarJogo();
                    break;
            }
        }

        public void NovoJogo()
        {
            CriaPersonagem criaP = new CriaPersonagem();
            personagem = criaP.criarP();
            personagem.defineAtributos();

            TelaNovoP telaNovoP = new TelaNovoP();
            Application.Run(telaNovoP);
            personagem.Nome = telaNovoP.nome;

            switch (telaNovoP.resposta)
            {
                case 1:
                    Jogar();
                    break;
                case 2:
                    Inicia();
                    break;
            }            
        }

        public void ContinuarJogo()
        {
            Jogar();
        }

        public void FimJogo(string fim)
        {
            TelaFimJogo tela = new TelaFimJogo(fim);
            Application.Run(tela);

            Inicia();
        }

        public void Jogar()
        {
            switch (personagem.Etapa)
            {
                case "prologo":
                    etapaPrologo();
                    break;
                case "inicio":
                    etapaInicio();
                    break;
                case "fimDemo":
                    FimJogo("FimDemo");
                    break;
                case "fim":
                    FimJogo("Fim");
                    break;
                default:
                    Inicia();
                    break;
            }
        }
        #endregion

        #region Prologo
        public void etapaPrologo()
        {
            Prologo prologo = new Prologo();
            personagem = prologo.cap1(personagem);

            switch (prologo.Resposta)
            {
                case 0:
                    Inicia();
                    break;
                default:
                    Jogar();
                    break;
            }  
        }
        #endregion

        #region Inicio
        public void etapaInicio()
        {
            Inicio inicio = new Inicio();
            personagem = inicio.cap1(personagem);

            switch (inicio.Resposta)
            {
                case 0:
                    Inicia();
                    break;
                case 9:
                    FimJogo("Fim");
                    break;
                default:
                    Jogar();
                    break;
            }
        }
        #endregion
    }
}
