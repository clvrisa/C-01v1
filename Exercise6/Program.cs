using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Diamond
    {
        int rows, cols;

        public void getRows()
        {
            Console.WriteLine("Enter number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());
        }
        public void displayDiamond()
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int x = 1; x <= cols; x++)
                {
                    Console.WriteLine(" ");
                    cols--;
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
