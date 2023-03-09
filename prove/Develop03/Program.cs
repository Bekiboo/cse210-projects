using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("John", 3, 16);
        Scripture scripture1 = new Scripture(ref1, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        Reference ref2 = new Reference("John", 3, 16, 17);
        Scripture scripture2 = new Scripture(ref2, "For God did not send his Son into the world to condemn the world, but to save the world through him.");

        // Console.WriteLine(scripture1.GetScriptureString());
        // Console.WriteLine(scripture2.GetScriptureString());

        string input = "";

        while (input != "quit" && scripture1.GetRemainingWords() > 0)
        {
            Console.Clear();
            Console.WriteLine(scripture1.GetScriptureString());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();
            scripture1.HideRandomWords();
        }
    }
}