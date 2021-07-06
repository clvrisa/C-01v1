using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Arithmetic
    {
        int a = 25, b = 5, add, sub, mult, div;

        public void AddNum()
        {
            add = a + b;
            Console.WriteLine(add);
        }
        public void SubNum()
        {
            sub = a - b;
            Console.WriteLine(sub);
        }
        public void MultNum()
        {
            mult = a * b;
            Console.WriteLine(mult);
        }
        public void DivNum()
        {
            div = a / b;
            Console.WriteLine(div);
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("Enter 1 if you want addition");
            Console.WriteLine("Enter 2 if you want subtraction");
            Console.WriteLine("Enter 3 if you want multiplication");
            Console.WriteLine("Enter 4 if you want division");
            choice = Convert.ToInt32(Console.ReadLine());

            Arithmetic arithmetic = new Arithmetic();

            switch(choice) { 
                case 1: arithmetic.AddNum();
                    break;
                case 2: arithmetic.SubNum();
                    break;
                case 3: arithmetic.MultNum();
                    break;
                case 4: arithmetic.DivNum();
                    break;
                default: Console.WriteLine("Invalid Entry");
                    break;
            }
           
        }
    }
}
