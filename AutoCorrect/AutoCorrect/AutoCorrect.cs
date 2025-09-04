namespace AutoCorrect
{
    class AutoCorrect
    {
        static void Main(string[] args)
        {
            string[] words = { "hello", "world", "java", "python" };

            Console.Write("Enter a word: ");
            string input = Console.ReadLine();

            bool found = false;
            foreach (string w in words)
            {
                if (w.Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Word found: " + w);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Word not found. Did you mean: " + words[0] + "?");
            }

        }
    }
}
