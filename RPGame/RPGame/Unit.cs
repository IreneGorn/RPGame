namespace RPGame
{
    public abstract class Unit
    {
        public abstract int Hp { get; set; }
        public abstract string Weapon { get; set; }
        public abstract void Attack();
    }
}