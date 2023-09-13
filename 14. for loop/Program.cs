using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 7 ; i++)
            {

                Console.WriteLine(i);
                Console.WriteLine("hell0");
            }
            Console.WriteLine("****FOR LOOP FOR AN ARRAY STORING NAMES******");

            string[] names = { "jeff", "nokwanda", "mufasa"};
            for (int i = 0; i < names.Length; i++) {

                Console.WriteLine(names[i]);
            }

            Console.WriteLine("****FOR LOOP FOR AN ARRAY STORING CARS******");

           string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.ReadLine();
        }
    }
}
