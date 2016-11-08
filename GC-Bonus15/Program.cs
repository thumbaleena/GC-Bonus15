using System;
using System.Collections;

namespace GC_Bonus15
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var gameCharacters = new ArrayList();
            gameCharacters.Add(new Wizard("Gandalf", 420, 999, 579, 42));
            gameCharacters.Add(new Orc("Lurbuk", 999, 99, "war hammer", "wrecking blow"));
            gameCharacters.Add(new Warrior("Jon Snow", 800, 432, "broadsword"));
            gameCharacters.Add(new MagicUsingCharacter("Ronald Weasley", 2, 350, 130));

            for (var i = 0; i < gameCharacters.Count; i++)
                Console.WriteLine(gameCharacters[i]);
        }
    }
}