namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            GetAppInfo(); // App info

            GreetUser(); // Ask for name, and greet



            while (true)
            {

                // Random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //int guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // while guess is not correct
                while (guess != correctNumber)
                {


                    // get users input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // keep going
                        continue;
                    }




                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct answer
                    if (guess != correctNumber)
                    {
                        // Print error Message
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number, please try again");

                        //RESET TEXT COLOR
                        Console.ResetColor();

                    }

                }

                PrintColorMessage(ConsoleColor.Yellow, "You are correct!!!");

                //RESET TEXT COLOR
                Console.ResetColor();

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();
                if(answer == "Y")
                {
                    continue;
                } 
                else if(answer == "N")
                {
                    return;
                }

            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Daniel Fraga";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version:{1} by {2}", appName, appVersion, appAuthor);

            //RESET TEXT COLOR
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask user name
            Console.WriteLine("What is your name?");

            // Get User input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game ...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message )
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            //RESET TEXT COLOR
            Console.ResetColor();  // Change text color
            Console.ForegroundColor = ConsoleColor.Red;

            // Tell user its not a number
            Console.WriteLine("Please enter an actual number");

            //RESET TEXT COLOR
            Console.ResetColor();
        }
    }
}