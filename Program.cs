using System;
Main();

void Main()
    {
    Console.WriteLine("Come guess the secret number!");

    GetAnswer();
    }

void GetAnswer()
{
  
    int chances = 3;
    // user gets 4 chances to guess the number


    while (chances > -1)
    {
         Console.WriteLine("What is your guess?!");
         string answer = Console.ReadLine();
         //accept user input as the answer

            Random rnd = new Random();
           int secretNumber = rnd.Next(1, 101);
           //generates secret number between 1 and 100

        if (secretNumber == int.Parse(answer))
        {
            Console.WriteLine("That is correct!");
            chances = 0;
        } 
        //if answer matches secret number display success message and exit while loop

        else if (secretNumber > int.Parse(answer))
        {
            Console.WriteLine($"Your guess is too low. You have {chances} guesses left. Try again");
            //use string interpolation to display number of remaining guesses
            chances--;
        }

        else if (secretNumber < int.Parse(answer))
        {
            Console.WriteLine($"Your guess is too high. You have {chances} guesses left. Try again");
            chances--;
        }
        //if answer is too high or low display appropriate message and decrement number of chances/guesses
    }
}
