using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Binary
    {
        int rows, display;

        public void getRows()
        {
            Console.WriteLine("Enter the Number of Rows: ");
            rows = Convert.ToInt32(Console.ReadLine());
        }
        public void displayRows()
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    if (display ==1)
                    {
                        Console.Write("0");
                        display = 0;
                    }
                    else if (display == 0)
                    {
                        Console.Write("1");
                        display = 1;
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Binary binary = new Binary();
            binary.getRows();
            binary.displayRows();
        }
    }
}
