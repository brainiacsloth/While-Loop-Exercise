using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 0;

            Console.WriteLine("This is the while loop");
            while (index <= 5)
            {
                Console.WriteLine("This is the do while Loop");

                int index2 = 0;
                do
                {
                    Console.WriteLine(index2);
                    index++;
                }

                while (index <= 5);
            }
        }
    }
}
