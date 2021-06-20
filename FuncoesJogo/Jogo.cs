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
        Personagem personagem = new Personagem();
        public int resposta = 0;
        Boolean avanca = false;

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
            switch (personagem.etapa)
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

        public void etapaPrologo()
        {
            Prologo prologo = new Prologo();
            personagem = prologo.cap1(personagem);

            switch (prologo.resposta)
            {
                case 1:
                    Jogar();
                    break;
                case 2:
                    Inicia();
                    break;
                case 3:
                    FimJogo();
                    break;
            }  
        }

        public void etapaInicio()
        {
            Inicio inicio = new Inicio();
            personagem = inicio.cap1(personagem);

            switch (inicio.resposta)
            {
                case 1:
                    Jogar();
                    break;
                case 2:
                    Inicia();
                    break;
                case 3:
                    FimJogo();
                    break;
            }
        }

        public void etapaPrimeirasDescobertas()
        {
            Inicio inicio = new Inicio();
            personagem = inicio.cap2(personagem);

            switch (inicio.resposta)
            {
                case 1:
                    Jogar();
                    break;
                case 2:
                    Inicia();
                    break;
                case 3:
                    FimJogo();
                    break;
            }
        }
    }

    


}
