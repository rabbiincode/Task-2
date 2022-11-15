namespace guessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Number Guessing Game");

          Random num = new Random();
          bool playAgain = true;
          int number;
          int min = 1;
          int max = 100;
          int guess;
          string input;
          int trials;

          while (playAgain)
          {
            guess = 0;
            trials = 0;
            number = num.Next(min, max + 1);

            while (guess != number)
            {
              Console.Write($"guess a number between {min} and {max} : ");

              input = Console.ReadLine();
              guess = Convert.ToInt32(input);

              Console.WriteLine($"Guess: {guess}");

              if (guess > number)
              {
                Console.WriteLine($"{guess} is too large");
              } 
              else if (guess < number)
              {
                Console.WriteLine($"{guess} is too small");
              }

                trials++;
              }
              Console.WriteLine($"Number: {number}");
              Console.WriteLine($"No Of Tries: {trials}");

              Console.Write("Do you want to continue playing? y / n : ");
              input = Console.ReadLine();

              if (input == "n")
              {
                Console.WriteLine("Thanks For Playing");
                break;
              }
     
            }
        }
    }
}