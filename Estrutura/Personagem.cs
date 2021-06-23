using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Estrutura
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float CarismaBase { get; set; }
        public float InteligenciaBase { get; set; }
        public float RestenciaBase { get; set; }
        public int Carisma { get; set; }
        public int Inteligencia { get; set; }
        public int Restencia { get; set; }
        public float ForcaBase { get; set; }
        public float MagiaBase { get; set; }
        public float VelocidadeBase { get; set; }
        public float VitalidadeBase { get; set; }
        public int Forca { get; set; }
        public int Magia { get; set; }
        public int Agilidade { get; set; }
        public int Saude { get; set; }
        public int SaudeAtual { get; set; }
        public int Dinheiro { get; set; }
        public int UltimaR { get; set; }
        public bool Estado { get; set; }
        public string Etapa { get; set; }

        public Decisao Escolhas = new Decisao();
        private Classe Classe = new Classe();

        public Classe getClasse()
        {
            return this.Classe;
        }

        public string setClasse(Classe classeP)
        {

            List<Classe> classes = new List<Classe>();
            Classe cla = new Classe();
            classes = cla.criaClasses();
            string erro = "falha";

            foreach (Classe C in classes)
            {
                if (classeP.Nome.Equals(C.Nome))
                {
                    this.Classe = classeP;
                    erro = "sucesso";
                }
            }

            return erro;
        }

        public void defineAtributos()
        {
            this.Carisma = Convert.ToInt32(this.CarismaBase * this.Classe.BonusCarisma);
            this.Inteligencia = Convert.ToInt32(this.InteligenciaBase * this.Classe.BonusInteligencia);
            this.Restencia = Convert.ToInt32(this.RestenciaBase * this.Classe.BonusRestencia);
            this.Forca = Convert.ToInt32(this.ForcaBase * this.Classe.BonusForca + (this.Restencia * 0.3f));
            this.Magia = Convert.ToInt32(this.MagiaBase * this.Classe.BonusMagia + (this.Inteligencia * 0.3f));
            this.Agilidade = Convert.ToInt32(this.VelocidadeBase * this.Classe.BonusVelocidade + (this.Carisma * 0.3f));
            this.Saude = Convert.ToInt32(this.VitalidadeBase * this.Classe.BonusVitalidade + (this.Restencia * 0.1f) + (this.Inteligencia * 0.1f) + (this.Carisma * 0.1f));
            this.SaudeAtual = this.Saude;
        }

        public void calculaVitalidade(int valor)
        {
            this.SaudeAtual = +valor;
            if (this.SaudeAtual > this.Saude)
            {
                this.SaudeAtual = this.Saude;
            }
        }
    }
}
