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
        int resposta = 0;
        Boolean avanca = false;

        public void Jogar()
        {
            //partes do jogo
            //CriaPersonagem criarPersonagem = new CriaPersonagem();

            Application.Run(new TelaPrincipal());
            Application.Run(new TelaJogo("teste"));
        }
    }

    


}
