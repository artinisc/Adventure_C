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
           
            TelaPrincipal x = new TelaPrincipal();
            Application.Run(x);

            if (x.Resposta == 1)
            {
                NovoJogo();
            }
            else if (x.Resposta == 2)
            {
                ContinuarJogo();
            }

        }

        public void NovoJogo()
        {
            //partes do jogo
            //CriaPersonagem criarPersonagem = new CriaPersonagem();

            Application.Run(new TelaJogo("teste"));
        }

        public void ContinuarJogo()
        {

        }

        public void Jogar()
        {

        }
    }

    


}
