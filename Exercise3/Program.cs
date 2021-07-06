using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class UserString
    {
        string uString, rString;

        public void getString()
        {
            Console.WriteLine("Enter a string of text and I will show it reversed!");
            uString = Console.ReadLine();
        }
        public void displayString()
        {
            Console.WriteLine(uString);
        }
        public void reverseString()
        {
            rString = new string(uString.Reverse().ToArray());
            Console.WriteLine(rString);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            UserString userString = new UserString();
            userString.getString();
            userString.displayString();
            userString.reverseString();
        }
    }
}
