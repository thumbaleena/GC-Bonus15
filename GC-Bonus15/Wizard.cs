namespace GC_Bonus15
{
    internal class Wizard : MagicUsingCharacter
    {
        private int spellNumber;

        public Wizard(string name, int strength, int intelligence, int magicalEnergy, int spellNumber)
            : base(name, strength, intelligence, magicalEnergy)
        {
            getMagicalEnergy = magicalEnergy;
        }

        public int getSpellNumber { get; set; }


        public override string ToString()
        {
            return "Game Character: " + getName + ", strength: " + getStrength + ", intelligence: " + getInt +
                   ", magical energy: " + getMagicalEnergy + ", spell number: " + getSpellNumber;
        }
    }
}