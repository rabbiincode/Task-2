namespace guessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Check The Next 20 Leap Years From Any Year");

          int year;
          string input;
          int years;


          Console.Write("Enter Year : ");
          input = Console.ReadLine();

          year = Convert.ToInt32(input);

          for (int i = year; i < year + 80; i++)
          {
            years = i;

            //A leap year should be divisible by 4 but not by 100
            //And also should be divisible by 400

            if ( (years % 4 == 0 && years % 100 != 0) || (years % 400 == 0) )
            {
              Console.WriteLine($"{years}");
            }

          }
          Console.WriteLine($"...These are the next 20 leap years from {year}");

          Console.ReadKey();
        }
    }
}