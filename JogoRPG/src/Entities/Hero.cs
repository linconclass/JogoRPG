using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG.src.Entities
{
    public abstract class Hero
    {

        public Hero(string Name, int Level, string HeroType, int HP, int MP, int hpFull, int mpFull)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.hpFull = hpFull;
            this.MP = MP;
            this.mpFull = mpFull;
        }
               
        public string Name;
        public int Level;
        public string HeroType;
        public int HP;
        public int hpFull;
        public int MP;
        public int mpFull;

        //overrid => sobrescreve o método ToString() padrão
        public override string ToString()
        {
            return this.Name + "\n" + "lv.   "+this.Level + " " + this.HeroType + "\n" +"HP    "+ this.HP+" /  "+hpFull + "\n" +"MP    "+ this.MP +" /  "+mpFull+"\n";
        }

        public virtual string? Attack()
        {
            return null;
        }
    }
}
