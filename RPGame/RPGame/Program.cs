namespace RPGame
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var knightUnit = new Knight();
            knightUnit.Attack();

            var archerUnit = new Archer();
            archerUnit.Attack();

            var mageUnit = new Mage();
            mageUnit.Attack();
            mageUnit.Attack();
            mageUnit.Attack();
            mageUnit.Attack();
            mageUnit.Attack();
        }
    }
}