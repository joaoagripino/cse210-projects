using System;

class Program
{
    static void Main(string[] args)
    {
        //string response = "yes";

        //while (response == "yes")
        //{
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        //}

        // string response;
        // do
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // } while (response == "yes");

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // for (int i = 2; i <= 20; i = i + 2)
        // {
        //     Console.WriteLine(i);
        // }

        // foreach (string color in colors)
        // {
        //     Console.WriteLine(color);
        // }

        // Console.Write("What is the magic number? ");
        // int number = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 5);

        int guess = -1;
        int guessCount = 0;
        string userResponse = "";

        do
        {
            
            
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());


                if (guess == number)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher!");
                }
                else
                {
                    Console.WriteLine("Lower!");
                }
                
                guessCount ++;
                

            } while (guess != number);

            Console.WriteLine($"You tried to guess {guessCount} time(s).");

            Console.Write("Do you want to play again? ");
            userResponse = Console.ReadLine();
            guessCount = 0;


        } while (userResponse == "yes");
            
    }
}