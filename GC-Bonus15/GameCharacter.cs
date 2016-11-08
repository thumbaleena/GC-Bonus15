namespace GC_Bonus15
{
    internal class GameCharacter
    {
        private int intelligence;
        private string name;
        private int strength;

        public GameCharacter(string name, int strength, int intelligence)
        {
            getName = name;
            getStrength = strength;
            getInt = intelligence;
        }

        public string getName { get; }
        public int getStrength { get; }
        public int getInt { get; }

        public override string ToString()
        {
            return "Game Character: " + getName + ", strength: " + getStrength + ", intelligence: " + getInt;
        }
    }
}