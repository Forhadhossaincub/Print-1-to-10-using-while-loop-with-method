using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_1_to_10_using_while_loop_with_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print 1 to 10");

            Print();

            Console.ReadKey();

        }//Main


        public static void Print()
        {
            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine($"{i} \t");
                i++;
            }
        }
    }//Class
}//Namespace
