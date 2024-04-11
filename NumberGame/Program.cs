namespace NumberGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string? response;



            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine($"Guess a number between {min} - {max}:");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");
                    }
                    guesses++;
                }
                string text = @"
                                        __     __          __          ___         _  
                                        \ \   / /          \ \        / (_)       | | 
                                         \ \_/ /__  _   _   \ \  /\  / / _ _ __   | | 
                                          \   / _ \| | | |   \ \/  \/ / | | '_ \  | | 
                                           | | (_) | |_| |    \  /\  /  | | | | | |_| 
                                           |_|\___/ \__,_|     \/  \/   |_|_| |_| (_) ";

                Console.WriteLine(text);
                Console.WriteLine("Number: " + number);
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again? Y/N: ");
                response = Console.ReadLine();
                response = response?.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }



            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        }
    }
}