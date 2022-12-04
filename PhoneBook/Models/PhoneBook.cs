using System;
using System.Collections.Generic;

namespace PhoneBook
{
  class PhoneBook
  {
    public static Dictionary<string,string> phoneNumbers = new Dictionary<string,string>();

    public static void AddContact()
    {
      Console.WriteLine("\nNEW CONTACT");
      Console.WriteLine("\nEnter a New Contact name\n");
      string name = Console.ReadLine();
      Console.WriteLine("\nEnter a new contact phone number\n");
      string number = Console.ReadLine();
      if(phoneNumbers.ContainsKey(name))
      {
        Console.WriteLine("\nThat person is already in your phonebook. their number is " + phoneNumbers[name] + "\n");
      }
      else
      {
        phoneNumbers.Add(name, number);
      }
    }

    public static void LookUpContact()
    {
      Console.WriteLine("\nCONTACT LOOKUP");
      Console.WriteLine("\nWhose number would you like to look up?\n");
      string friend = Console.ReadLine();
      if (phoneNumbers.ContainsKey(friend))
      {
        string value = phoneNumbers[friend];
        Console.WriteLine("\n" + friend + "\'s phone number is " + value +"\n");
      }
      else
      {
        Console.WriteLine("\nThat person is not in your phone book.\n");
      }
    }
  }
}

