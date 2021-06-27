using Adventure.Estrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.FuncoesJogo
{
    public class CriaPersonagem
    {
        public Personagem criarP()
        {
            //personagm
            Personagem personagem = new Personagem();

            //seta id e nome do personagem
            personagem.Id = 1;
            personagem.Nome = "";

            personagem.CarismaBase = 10;
            personagem.InteligenciaBase = 10;
            personagem.RestenciaBase = 10;
            personagem.ForcaBase = 10;
            personagem.MagiaBase = 10;
            personagem.VelocidadeBase = 10;
            personagem.VitalidadeBase = 50;
            personagem.Dinheiro = 0;
            personagem.Estado = true;
            personagem.Etapa = "prologo";

            return personagem;
        }

        public Personagem escolherC(Personagem personagem, string nome)
        {
            List<Classe> classes = new List<Classe>();
            Classe classe = new Classe();

            classes = classe.criaClasses();

            classe = classes.Where(f => f.Nome.Equals(nome)).FirstOrDefault();

            personagem.setClasse(classe);

            personagem.defineAtributos();

            return personagem;
        }
    }
}
