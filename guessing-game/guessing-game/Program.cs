// See https://aka.ms/new-console-template for more information
Console.WriteLine("hello, cool cats and kittens welcome to Michael and Emily's guessing game.");
// Declare a variable (a number between 1-10) that is going to act as the number you will be guessing
int num = 5;
Console.WriteLine("Guess a number between 1-10:");
string userNum = Console.ReadLine();
int userNumber = Convert.ToInt32(userNum);

if (userNumber == num)
{
    Console.WriteLine("Wow, I'm surprised you got it right");
}