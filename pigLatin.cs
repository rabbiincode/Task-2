namespace guessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Pig Latin Translator");
          Console.Write("Enter a sentence here : ");

          string[] words;
          string text;
          string firstLetter;
          string remainingLetters;
          string pigLatin;
          string join;
          string input;


          text = Console.ReadLine();
          words = text.Split();

          foreach (string word in words)
          {
            firstLetter = word.Substring(0, 1);
            remainingLetters = word.Substring(1);
            pigLatin = $"{remainingLetters}{firstLetter}ay ";
            join = string.Join(" ", pigLatin);

            Console.Write(join);
          }

          Console.Write($"{Environment.NewLine}Translate back to English? y / n : ");
          input = Console.ReadLine();

          if (input == "y")
          {
            Console.WriteLine(text);
            Console.WriteLine("...Thanks, Have a nice day");
          }
          else
          {
            Console.WriteLine("...Have a Nice day");
          }

           Console.ReadKey();
        }
    }
}