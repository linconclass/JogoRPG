using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG.src.Entities
{
    internal class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HP, int MP, int hpFull, int mpFull) : base(Name, Level, HeroType, HP, MP, hpFull, mpFull)
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
            return Name + ": attacked with his dagger";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 4)
            {
                return Name + ": activated your Velocity Hyper with a bonus of " + Bonus;
            }
            else
            {
                return Name + ": released your double dagger";
            }
        }
    }
}
