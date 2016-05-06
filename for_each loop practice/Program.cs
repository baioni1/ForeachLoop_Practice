using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_each_loop_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] cities = { "New York", "London", "Paris" };
            foreach (string city in cities)
            {
                Console.WriteLine("I Love " + city);
            }*/


            /*for (int i = 1; i <= 2; i++)
            {
                for (int x = 1; x <= 4; x++)
                {
                    Console.Write(x);
                }

                Console.WriteLine();*/
            //MAKING A PYRAMID
            /*int userNumberInput = int.Parse(Console.ReadLine());
            for (int row = 1; row <= userNumberInput; row++) 
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write(column + " ");
                }

                Console.WriteLine();
            }*/

            // program for 1 to unspecified that are not divisible by 3 AND 7
            /*Console.WriteLine("Please pick a number:");
            int number = int.Parse(Console.ReadLine());
            for (int counter = 1; counter <= number; counter++)
            {
                if (counter % 3 == 0 && counter % 7 == 0)
                {
                    continue;
                }
                else
                Console.WriteLine(counter);*/

            
            /*for (int rows = 1; rows <=4; rows++)
            {
                for (int columns = 0; columns <=3; columns++)
                {
                    Console.Write(rows+ columns);
                    
                }
                Console.WriteLine();*/
            
               

            }
            

        }
    }
}
