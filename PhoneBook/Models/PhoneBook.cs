using System;
using System.Collections.Generic;

namespace PhoneBook
{
  class PhoneBook
  {
    public static Dictionary<string,string> phoneNumbers = new Dictionary<string,string>();

    public static void AddContact()
    {
      Console.WriteLine("NEW CONTACT");
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

    public static void LookUpContact()
    {
      Console.WriteLine("CONTACT LOOKUP");
      Console.WriteLine("Whose number would you like to look up?");
      string friend = Console.ReadLine();
      if (phoneNumbers.ContainsKey(friend))
      {
        string value = phoneNumbers[friend];
        Console.WriteLine(friend + "\'s phone number is " + value);
      }
      else
      {
        Console.WriteLine("That person is not in your phone book.");
      }
    }
  }
}

