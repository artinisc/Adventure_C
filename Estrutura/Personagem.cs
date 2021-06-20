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
        public int Velocidade { get; set; }
        public int Vitalidade { get; set; }
        public int VitalidadeAtual { get; set; }
        public int ultimaR { get; set; }
        public bool estado { get; set; }
        public string etapa { get; set; }

        public Decisao escolhas = new Decisao();
        private Classe classe = new Classe();

        public Classe getClasse()
        {
            return this.classe;
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
                    this.classe = classeP;
                    erro = "sucesso";
                }
            }

            return erro;
        }

        public void defineAtributos()
        {
            this.Carisma = Convert.ToInt32(this.CarismaBase * this.classe.BonusCarisma);
            this.Inteligencia = Convert.ToInt32(this.InteligenciaBase * this.classe.BonusInteligencia);
            this.Restencia = Convert.ToInt32(this.RestenciaBase * this.classe.BonusRestencia);
            this.Forca = Convert.ToInt32(this.ForcaBase * this.classe.BonusForca + (this.Restencia * 0.3f));
            this.Magia = Convert.ToInt32(this.MagiaBase * this.classe.BonusMagia + (this.Inteligencia * 0.3f));
            this.Velocidade = Convert.ToInt32(this.VelocidadeBase * this.classe.BonusVelocidade + (this.Carisma * 0.3f));
            this.Vitalidade = Convert.ToInt32(this.VitalidadeBase * this.classe.BonusVitalidade + (this.Restencia * 0.1f) + (this.Inteligencia * 0.1f) + (this.Carisma * 0.1f));
            this.VitalidadeAtual = this.Vitalidade;
        }

        public void calculaVitalidade(int valor)
        {
            this.VitalidadeAtual = +valor;
            if (this.VitalidadeAtual > this.Vitalidade)
            {
                this.VitalidadeAtual = this.Vitalidade;
            }
        }
    }
}
