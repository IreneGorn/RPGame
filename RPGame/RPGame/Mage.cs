using System;

namespace RPGame
{
    public class Mage : Unit
    {
        public override int Hp { get; set; } = 6;
        public override string Weapon { get; set; } = "Sickle"; // Авто-свойство. Можно не создавать отдельную переменную для хранения значения

        private int SpellSlots { get; set; } = 4;

        public override void Attack()
        {
            if (SpellSlots > 0)
            {
                Console.WriteLine("I'm casting a Fireball!");
                SpellSlots--;
            }
            else
            {
                Console.WriteLine("I'm hitting with a sickle!");
            }
        }
    }
}