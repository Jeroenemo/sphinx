using System;
// using System.Collections.Generic;


public class Program
{
    

    static void Main()
    {
        Console.WriteLine("What can you catch but never throw?");
        string userAnswer = (Console.ReadLine()).ToLower();

        if(userAnswer == "a cold"){
            Console.WriteLine("Correct! You beat the sphinx!");
        } 
        else
        {
            Console.WriteLine("You were eaten. Sorry!");
        }
    }
}
