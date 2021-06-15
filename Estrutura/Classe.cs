using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Estrutura
{
    public class Classe
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public float BonusForca { get; set; }
        public float BonusMagia { get; set; }
        public float BonusVelocidade { get; set; }
        public float BonusVitalidade { get; set; }

        public float BonusCarisma { get; set; }
        public float BonusInteligencia { get; set; }
        public float BonusRestencia { get; set; }

        public string Vantagem { get; set; }

        public string PoderPrincipal { get; set; }
        public string PoderSecundario { get; set; }
        public string PoderDefencivo { get; set; }
        public string PoderReativo { get; set; }

        public List<Classe> criaClasses()
        {

            List<Classe> classes = new List<Classe>();

            for (int id = 0; id <= 3; id++)
            {
                Classe modelo = new Classe();
                switch (id)
                {
                    case 1:
                        modelo.Id = id;
                        modelo.Nome = "Guerreiro";
                        modelo.BonusForca = 1.5f;
                        modelo.BonusMagia = 1.0f;
                        modelo.BonusVelocidade = 1.2f;
                        modelo.BonusVitalidade = 1.3f;
                        modelo.BonusCarisma = 1.0f;
                        modelo.BonusInteligencia = 1.0f;
                        modelo.BonusRestencia = 1.3f;
                        modelo.Vantagem = "";
                        modelo.PoderPrincipal = "";
                        modelo.PoderSecundario = "";
                        modelo.PoderDefencivo = "";
                        modelo.PoderReativo = "";
                        classes.Add(modelo);
                        break;
                    case 2:
                        modelo.Id = id;
                        modelo.Nome = "Mago";
                        modelo.BonusForca = 1.0f;
                        modelo.BonusMagia = 1.5f;
                        modelo.BonusVelocidade = 1.3f;
                        modelo.BonusVitalidade = 1.2f;
                        modelo.BonusCarisma = 1.0f;
                        modelo.BonusInteligencia = 1.3f;
                        modelo.BonusRestencia = 1.0f;
                        modelo.Vantagem = "";
                        modelo.PoderPrincipal = "";
                        modelo.PoderSecundario = "";
                        modelo.PoderDefencivo = "";
                        modelo.PoderReativo = ""; ;
                        classes.Add(modelo);
                        break;
                    case 3:
                        modelo.Id = id;
                        modelo.Nome = "Arqueiro";
                        modelo.BonusForca = 1.3f;
                        modelo.BonusMagia = 1.0f;
                        modelo.BonusVelocidade = 1.5f;
                        modelo.BonusVitalidade = 1.2f;
                        modelo.BonusCarisma = 1.3f;
                        modelo.BonusInteligencia = 1.0f;
                        modelo.BonusRestencia = 1.0f;
                        modelo.Vantagem = "";
                        modelo.PoderPrincipal = "";
                        modelo.PoderSecundario = "";
                        modelo.PoderDefencivo = "";
                        modelo.PoderReativo = "";
                        classes.Add(modelo);
                        break;
                }
            }
            return classes;
        }
    }
}
