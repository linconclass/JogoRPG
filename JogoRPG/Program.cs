using JogoRPG.src.Entities;
using System;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new("Arus", 23, "Knight", 469, 72, 749, 72);
            Ninja ninja = new("Wedge", 42, "Ninja", 292, 89, 574, 89);
            WhiteWizard wizard = new("Alice", 24, "White Wizard", 325, 474, 601, 482);
            BlackWizard bWizard = new("Alice", 24, "White Wizard", 106, 611, 385, 641);

            Console.WriteLine("Enter the Bonus attack value of the " + wizard.Name+ " : ");
            int attackBonus = int.Parse(Console.ReadLine()+"\n");

            Console.WriteLine("\n" + arus.ToString() + "\n" + arus.Attack() + "\n");
            Console.WriteLine(wizard.ToString() + "\n" + wizard.Attack() + "\n" + wizard.Attack(attackBonus) + "\n");
            Console.WriteLine(ninja.ToString() + "\n" + ninja.Attack() + "\n" + ninja.Attack(attackBonus) + "\n");
            Console.WriteLine(bWizard.ToString() + "\n" + bWizard.Attack() + "\n" + bWizard.Attack(attackBonus) + "\n");
        }                        
    }
}
