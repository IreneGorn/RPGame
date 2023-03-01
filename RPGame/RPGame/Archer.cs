using System;

namespace RPGame
{
    public class Archer : Unit
    {
        public override int Hp { get; set; } = 10;

        public override string Weapon { get; set; } = "Longbow"; // Авто-свойство. Можно не создавать отдельную переменную для хранения значения

        public override void Attack()
        {
            Console.WriteLine("I'm shooting an arrow!");
        }
    }
}