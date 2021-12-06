using System;

namespace passwordCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a password containing at least 1 uppercase letter and no symbols:");
            string password = Console.ReadLine();
            char passwordChar = new char();
            bool correctSymbols = false;
            int containsUpper = 0;

            for (int i = 0; i <= password.Length-1; i++)
            {
                passwordChar = password[i];
                if (Char.IsLetterOrDigit(passwordChar) == true)
                {
                    correctSymbols = true;
                    if (Char.IsUpper(passwordChar) == true)
                    {
                        containsUpper++;
                    }

                }


            }
            if (correctSymbols == true && containsUpper >= 1)
            {
                Console.WriteLine("The password contains all correct symbols and at least 1 uppercase letter.");
            }
            else
            {
                Console.WriteLine("Your password is either missing any uppercase letters or it's using an invalid symbol");
            }
        }
    }
}
