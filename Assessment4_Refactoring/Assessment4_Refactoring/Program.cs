using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] array1 = { 1, 2, 3, 4, 5, 6 };
            int result = program.GetSum(array1);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        private int GetSum(int[] array1)
        {
            int sum = 0;
            foreach (int item in array1)
            {
                sum = sum + item;
            }
            return sum;
        }
    }

    /* i removed the for loop because it added 1 to every number in the array
     * and the task just calls to refactor to get the program to get an output of 21. 
     * I also set som to equal 0 off the bat so the end result is now 21. its much simpler
     * and cleaner which is what refactoring is all about */
}

