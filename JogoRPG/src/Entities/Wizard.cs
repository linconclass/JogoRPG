using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return Name + ": lançou magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return Name + ": Lançou magia super efetiva com bonus de " + Bonus;
            }
            else
            {
                return Name + ": Lançou uma magia fraca com bonus de " + Bonus;
            }            
        }
    }
}
