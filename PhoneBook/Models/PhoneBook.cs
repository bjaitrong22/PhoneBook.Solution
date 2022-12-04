using System;
using System.Collections.Generic;

namespace PhoneBook
{
  class PhoneBook
  {
    public static Dictionary<string,string> phoneNumbers = new Dictionary<string,string>();

    static void AddContact()
    {
      Console.WriteLine("New Contact");
      Console.WriteLine("Enter a New Contact name");
      string name = Console.ReadLine();
      Console.WriteLine("Enter a new contact phone number");
      string number = Console.ReadLine();
      if(phoneNumbers.ContainsKey(name))
      {
        Console.WriteLine("That person is already in your phonebook. their number is " + phoneNumbers[name]);
      }
      else
      {
        phoneNumbers.Add(name, number);
      }
    }
  }

}

