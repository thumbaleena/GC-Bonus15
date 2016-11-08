namespace GC_Bonus15
{
    internal class Warrior : GameCharacter
    {
        private string weaponType;

        public Warrior(string name, int strength, int intelligence, string weaponType)
            : base(name, strength, intelligence)
        {
            getWeaponType = weaponType;
        }

        public string getWeaponType { get; set; }


        public override string ToString()
        {
            return "Game Character: " + getName + ", strength: " + getStrength + ", intelligence: " + getInt +
                   ", weapon type: " + getWeaponType;
        }
    }
}