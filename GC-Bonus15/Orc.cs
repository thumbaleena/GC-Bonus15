namespace GC_Bonus15
{
    internal class Orc : Warrior
    {
        private string powerMove;

        public Orc(string name, int strength, int intelligence, string weaponType, string powerMove)
            : base(name, strength, intelligence, weaponType)
        {
            getPowerMove = powerMove;
        }

        public string getPowerMove { get; set; }


        public override string ToString()
        {
            return "Game Character: " + getName + ", strength: " + getStrength + ", intelligence: " + getInt +
                   ", weapon type: " + getWeaponType + ", power move: " + getPowerMove;
        }
    }
}