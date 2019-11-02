using System;
using System.Collections.Generic;

namespace HelloDIProject
{
    public class UtilityService
    {
        private readonly List<string> colors;
        private readonly Random random;

        public UtilityService()
        {
            colors = new List<string>
        {
            "red",
            "blue",
            "lime",
            "orange",
            "magenta"
        };

            random = new Random();
        }

        public string RandomColor()
        {
            return colors[random.Next(colors.Count)];
        }

        public string ValidateEmail(String email)
        {
            string response = "";

            if (email.Contains('.') && email.Contains('@'))
            {
                response = "<p style=\"color:green\">" + email + " is a valid email address.</p>";
            }
            else
            {
                response = "<p style=\"color:red\">" + email + " is not a valid email address.</p>";
            }
            return response;
        }

        public string Caesar(string text, int number)
        {
            if (number < 0)
            {
                number = number + 26;
            }

            string result = "";

            foreach (var character in text)
            {
                var offset = char.IsUpper(character) ? 'A' : 'a';
                result += (char)((character + number - offset) % 26 + offset);
            }

            return result;
        }

    }

}
