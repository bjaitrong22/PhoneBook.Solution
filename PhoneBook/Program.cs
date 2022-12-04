using System;

namespace PhoneBook
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("\nMAIN MENU");
      Console.WriteLine("\nWould you like to add a person to your phone book? [ 'Y' for yes, 'Enter' for no]\n");
      string answer = Console.ReadLine();

      if ((answer == "Y" )|| (answer == "y"))
      {
        PhoneBook.AddContact();
      }
      else
      {
        Console.WriteLine("\nWould you like to lookup a number in your phone book? ['Y' for yes, 'Enter' for no]\n");
        string lookUpAnswer = Console.ReadLine();

        if (lookUpAnswer == "Y" || lookUpAnswer == "y")
        {
          PhoneBook.LookUpContact();
        }
        else
        {
          Console.WriteLine("\nAre you finished with this program? ['Y' for yes, 'Enter' for no]\n");
          string finishedAnswer = Console.ReadLine();

          if (finishedAnswer == "Y" || finishedAnswer == "y")
          {
            Console.WriteLine("\nGoodbye.\n");
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


