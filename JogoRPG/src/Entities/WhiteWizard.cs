using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG.src.Entities
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string Name, int Level, string HeroType, int HP, int MP, int hpFull, int mpFull) : base(Name, Level, HeroType, HP, MP, hpFull, mpFull)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.hpFull = hpFull;
            this.MP = MP;
            this.mpFull = mpFull;
        }

        public override string Attack()
        {
            return Name + ": cast magic";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return Name + ": cast super effective magic with bonus " + Bonus;
            }
            else
            {
                return Name + ": cast a weak spell with bonus " + Bonus;
            }            
        }
    }
}
