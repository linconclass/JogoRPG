using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG.src.Entities
{
    public abstract class Hero
    {

        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
               
        public string Name;
        public int Level;
        public string HeroType;

        //overrid => sobrescreve o método ToString() padrão
        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string? Attack()
        {
            return null;
        }
    }
}
