using JogoRPG.src.Entities;
using System;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new("Arus", 23, "Knight");            
            Wizard wizard = new("Alice", 24, "Mage");
            
            Console.WriteLine(arus.ToString() + "\n" + arus.Attack() + "\n");
            Console.WriteLine(wizard.ToString() + "\n" + wizard.Attack() + "\n" + wizard.Attack(2));
        }

    }
}
