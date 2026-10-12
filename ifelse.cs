using System;

class Program
{
    static void Main (string[]args)
    {
        int marks = 70;
        if (marks >= 70)
        {
            Console.WriteLine("PASS");
        }
        else
        {
            Console.WriteLine("FAIL");
        }

        // check the number is even or odd
        int number = 5;
        if (number % 2 ==0)
        {
            Console.WriteLine("Even number");
        }
        else
        {
            Console.WriteLine("Odd number");
        }

        // check if number is positive or negative

        int n = -4;
        if (n<0)
        {
            Console.WriteLine("negative number");
        }
        else
        {
            Console.WriteLine("Positive number");
        }
        
        // find the greater number
        int a = 6;
        int b = 5;
        if (a>b)
        {
            Console.WriteLine("a is greater");
        }
        else
        {
            Console.WriteLine("b is greater");
        }

        // Calculating grade of student
        int marks1 = 85;
        if (marks1 >= 90)
        {
            Console.WriteLine("A+");
        }
        else if (marks1 >=80)
        {
            Console.WriteLine("A");
        }
        else if (marks1 >=70)
        {
            Console.WriteLine("B");
        }
        else if (marks1 >=60)
        {
            Console.WriteLine("C");
        }
        else
        {
            Console.WriteLine("FAIL");
        }
        
        // check divisibility by 3 and 5
        int num = 10;
        if (num % 3 == 0 && num % 5 == 0)
        {
            Console.WriteLine("number is divisible by 3 and 5");
        }
        else if (num % 5 == 0)
        {
            Console.WriteLine("Number is only divible by 5");
        }
        else
        {
            Console.WriteLine("Number is divible by only 3");
        }
    }
}
