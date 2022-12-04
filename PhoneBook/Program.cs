using System;

namespace PhoneBook
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("MAIN MENU");
      Console.WriteLine("\nWould you like to add a person to your phone book? [ 'Y' for yes, 'Enter' for no]");
      string answer = Console.ReadLine();

      if ((answer == "Y" )|| (answer == "y"))
      {
        PhoneBook.AddContact();
      }
      else
      {
        Console.WriteLine("\nWould you like to lookup a number in your phone book? ['Y' for yes, 'Enter' for no]");
        string lookUpAnswer = Console.ReadLine();

        if (lookUpAnswer == "Y" || lookUpAnswer == "y")
        {
          PhoneBook.LookUpContact();
        }
        else
        {
          Console.WriteLine("\nAre you finished with this program? ['Y' for yes, 'Enter' for no]");
          string finishedAnswer = Console.ReadLine();

          if (finishedAnswer == "Y" || finishedAnswer == "y")
          {
            Console.WriteLine("\nGoodbye.");
            return;
          }
          else
          {
            Main();
          }
        }
      }
      Main();
    }
  } 
}


