using System;
namespace ADF_202209_ClarkeEric
{
    public class Validation
    {
        public Validation()
        {
        }

        public String ValidateString(String stringValue)
        {
            while (string.IsNullOrWhiteSpace(stringValue))
            {
                // state the error
                Console.WriteLine("Cannot be null or blank");
                // state the message
                Console.WriteLine("Enter your response again");
                // user input
                stringValue = Console.ReadLine();
            }

            return stringValue;
        }

        public int ValidateInt(string intValue)
        {
            int value = 0;
            while (!int.TryParse(intValue, out value))
            {
                // state the error
                Console.WriteLine("Not a valid number");
                // state the message
                Console.WriteLine("Enter your number again");
                // user input
                intValue = Console.ReadLine();
            }
            return value;
        }
    }
}
