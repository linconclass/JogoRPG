using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG.src.Entities
{
    internal class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType, int HP, int MP, int hpFull, int mpFull) : base(Name, Level, HeroType, HP, MP, hpFull, mpFull)
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
            if (Bonus > 9)
            {
                return Name + ": Cast the Time Tunnel spell with bonus " + Bonus;
            }
            else
            {
                return Name + ": Cast a weak spell with bonus " + Bonus;
            }
        }
    }
}
