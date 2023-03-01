using System;

namespace RPGame
{
    public class Knight : Unit
    {
        public override int Hp { get; set; } = 10;

        public override string Weapon { get; set; } = "Longsword"; // Авто-свойство. Можно не создавать отдельную переменную для хранения значения

        public override void Attack()
        {
            Console.WriteLine("I strike with a sword!");
        }
    }
}