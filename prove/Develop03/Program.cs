using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        scriptures.Add(new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them."));
        scriptures.Add(new Scripture(new Reference("Romans", 8, 16, 17), "The Spirit itself beareth witness with our spirit, that we are the children of God: And if children, then heirs; heirs of God, and joint-heirs with Christ; if so be that we suffer with him, that we may be also glorified together."));

        Random random = new Random();
        int randomScripture = random.Next(0, scriptures.Count);

        string input = "";

        while (input != "quit" && scriptures[randomScripture].GetRemainingWords() > 0)
        {
            Console.Clear();
            Console.WriteLine(scriptures[randomScripture].GetScriptureString());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();
            scriptures[randomScripture].HideRandomWords();
        }
    }
}