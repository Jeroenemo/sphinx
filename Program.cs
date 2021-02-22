using System;
using System.Collections.Generic;
using Sphinx.questions;


namespace Sphinx
{
  public class Program
  {
      static void Main()
      {
        int counter = 0;

          foreach(KeyValuePair<string, string> riddlePair in Question.AllRiddles)
          {
              Console.WriteLine(riddlePair.Value);
              string userAnswer = (Console.ReadLine()).ToLower();
              if(userAnswer == riddlePair.Key)
              {
                  Console.WriteLine("Correct");
                  counter ++;
              } 
              else 
              {
                  Console.WriteLine("incorrect. You were eaten. Sorry!");
                  break;
              }
          }
          if (counter == 3)
          {
              Console.WriteLine("Three in a row correct! You beat the sphinx!");
          }
          
      }
  }
}