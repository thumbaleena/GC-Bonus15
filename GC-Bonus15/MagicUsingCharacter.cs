namespace GC_Bonus15
{
    internal class MagicUsingCharacter : GameCharacter
    {
        private int magicalEnergy;

        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEnergy)
            : base(name, strength, intelligence)
        {
            getMagicalEnergy = magicalEnergy;
        }

        public int getMagicalEnergy { get; set; }


        public override string ToString()
        {
            return "Game Character: " + getName + ", strength: " + getStrength + ", intelligence: " + getInt +
                   ", magical energy: " + getMagicalEnergy;
        }
    }
}