using Adventure.FuncoesJogo;
using Adventure.PartesJogo;
using Adventure.Telas;
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
        Boolean avanca = false;
        #endregion

        #region Jogo
        public void Inicia()
        {
           
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

        }

        public void FimJogo()
        {

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
                case "primeirasDescobertas":
                    etapaPrimeirasDescobertas();
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
                case 9:
                    FimJogo();
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

            switch (inicio.resposta)
            {
                case 0:
                    Inicia();
                    break;
                case 9:
                    FimJogo();
                    break;
                default:
                    Jogar();
                    break;
            }
        }
        
        public void etapaPrimeirasDescobertas()
        {
            Inicio inicio = new Inicio();
            personagem = inicio.cap2(personagem);

            switch (inicio.resposta)
            {
                case 0:
                    Inicia();
                    break;
                case 9:
                    FimJogo();
                    break;
                default:
                    Jogar();
                    break;
            }
        }
        #endregion
    }
}
