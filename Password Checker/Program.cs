// See https://aka.ms/new-console-template for more information
using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
        int minLength = 8;
        string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowercase = "abcdefghijklmnopqrstuvwxyz";
        string digits = "0123456789";
        string specialChars = "!@#$%^&*()_+-={}[];:'\"|\\,.<>?/~`";

        Console.WriteLine("Please enter a password:");
        string password = Console.ReadLine();

        int score = 0;

        if (password.Length >= minLength)
        {
            score++;
        }

        if (Tools.Contains(password, uppercase))
        {
            score++;
        }

        if (Tools.Contains(password, lowercase))
        {
            score++;
        }

        if (Tools.Contains(password, digits))
        {
            score++;
        }  

        if (Tools.Contains(password, specialChars))
        {
            score++;
        }

        if (password == "password" || password == "1234")
        {
            score = 0;
        }

        switch (score){
            case 5:
            case 4:
                Console.WriteLine("The password is extremely strong.");
                break;
            case 3:
                Console.WriteLine("The password is strong.");
                break;
            case 2:
                Console.WriteLine("The password is medium.");
                break;
            case 1:
                Console.WriteLine("The password is weak.");
                break;
            default:
                Console.WriteLine("The password doesn't meet the requirements.");
                break;
        }

    }
  }
}