using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        Console.Write("Enter your name: ");
        Console.ReadLine();

        string name = "Hifza Waheed";
        int age = 20;
        Console.WriteLine("My name is " + name + " and my age is " + age);

// taking text and number input from user 

        string userName = Console.ReadLine();
        int userAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("user name is "+userName);
        Console.WriteLine("user age is "+userAge);
    }
}