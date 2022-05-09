using JogoRPG.src.Entities;
using System;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new("Arus", 23, "Knight");
            Wizard wizard = new("Alice", 24, "Mage");

            Console.WriteLine("Digite o valor de ataque Bonus da " +wizard.Name+ " : ");
            int attackBonus = int.Parse(Console.ReadLine()+"\n");

            Console.WriteLine("\n" + arus.ToString() + "\n" + arus.Attack() + "\n");
            Console.WriteLine(wizard.ToString() + "\n" + wizard.Attack() + "\n" + wizard.Attack(attackBonus) + "\n");
        }                        
    }
}
