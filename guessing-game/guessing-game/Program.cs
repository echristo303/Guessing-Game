// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, cool cats and kittens welcome to Michael and Emily's guessing game.");
// Declare a variable (a number between 1-10) that is going to act as the number you will be guessing
Random Random = new Random();
int num = Random.Next(1, 10);
int attemptNumber = 1;

while (attemptNumber <= 3)
{
    Console.WriteLine("Guess a number between 1-10:");
    string userNum = Console.ReadLine();
    int userNumber = Convert.ToInt32(userNum);

    if (userNumber == num)
    {
        Console.WriteLine("Wow, I'm surprised you got it right");
        break;
    }
    else if (userNumber >= 1 && userNumber <= 10)
    {
        int dif = Math.Abs(num - userNumber); 
        Console.WriteLine("No surprise you're WRONG!");
        Console.WriteLine("You were " + dif + " off!");
    }
    else
    {
        Console.WriteLine("No, you can't do that!");
    }
    attemptNumber++;
}