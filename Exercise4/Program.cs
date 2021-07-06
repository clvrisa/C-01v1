using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class UserValues
    {
        int valueOne, valueTwo, valueThree;
        public void getValues()
        { 
            Console.WriteLine("Enter first value: ");
            valueOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second value: ");
            valueTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third value: ");
            valueThree = Convert.ToInt32(Console.ReadLine());
        }
        public void getArmstrong()
        {
            double armstrongValueOne, armstrongValueTwo, armstrongValueThree, armstrongTotal;

            armstrongValueOne = Math.Pow(valueOne,3);
            armstrongValueTwo = Math.Pow(valueTwo, 3);
            armstrongValueThree = Math.Pow(valueThree, 3);
            armstrongTotal = armstrongValueOne + armstrongValueTwo + armstrongValueThree;

            Console.WriteLine(armstrongTotal);
        }
  
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three values and I will display the Armstrong numbers in between!");
            UserValues userValues = new UserValues();
            userValues.getValues();
            userValues.getArmstrong();
        }
    }
}
