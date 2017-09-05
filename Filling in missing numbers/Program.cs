using System;

namespace Filling_in_missing_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initalizing the array with the given int variables to be used in the program
            int[] number = {3, 8, 9, 13, 20};
            int length = 0, missingSize = 0;
            int max = 0, min = 21;
            //This will iderate through the entire array 
            for (int i = 0; i < number.Length; i++)
            {
                //determines if a the number length is greater then i. If not the max variable will be replace by the standing i variable.
                if (number[i] > max)
                {
                    max = number[i];
                }
                //determines if a the number length is less then i. If not the min variable will be replace by the standing i variable.
                if (number[i] < min)
                {
                    min = number[i];
                }
            }
            //Subracts the current max and min and adds 1.  Then tells the console to output the current count of the statues missing.
            length = (max - min) + 1;
            missingSize = length - number.Length;
            Console.WriteLine("need {0} Statues", missingSize);

        }
    }
}