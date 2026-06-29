namespace searchtask2
{
    internal class Program
    {
        static void CheckVowels(string text)
        {
            string vowels = "aeiouAEIOU";

            foreach (char c in text)
            {
                if (vowels.Contains(c))
                {
                    Console.WriteLine("The string contains vowels.");
                    return;
                }
            }

            Console.WriteLine("The string does not contain vowels.");
        }
        static void Main(string[] args)
        {

            Console.Write("Enter a string: ");
            string? text = Console.ReadLine();

            CheckVowels(text);
        }

        
    }
}
