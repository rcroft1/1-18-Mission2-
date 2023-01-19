using System;

namespace _1_18_C
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring varibales for the number of rolls and the results (num2s is the number of times 2 is rolled)
            int numRolls = 0;
            int num2s = 0;
            int num3s = 0;
            int num4s = 0;
            int num5s = 0;
            int num6s = 0;
            int num7s = 0;
            int num8s = 0;
            int num9s = 0;
            int num10s = 0;
            int num11s = 0;
            int num12s = 0;

            //writing to the user and getting an input for number of rolls
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("\n" + "How many dice rolls would you like to simulate ? ");

            numRolls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n" + "DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls + "."+ "\n");

            // generating random numbers
            Random r = new Random();

            int[] rollResults = new int[numRolls];

            

            // populating an array with roll results and tallying the results
            for (int i = 0; i < numRolls; i++)
            {
                rollResults[i] = (r.Next(1, 7) + r.Next(1,7));

                if (rollResults[i] == 2)
                {
                    num2s++; 
                }
                if (rollResults[i] == 3)
                {
                    num3s++;
                }
                if (rollResults[i] == 4)
                {
                    num4s++;
                }
                if (rollResults[i] == 5)
                {
                    num5s++;
                }
                if (rollResults[i] == 6)
                {
                    num6s++;
                }
                if (rollResults[i] == 7)
                {
                    num7s++;
                }
                if (rollResults[i] == 8)
                {
                    num8s++;
                }
                if (rollResults[i] == 9)
                {
                    num9s++;
                }
                if (rollResults[i] == 10)
                {
                    num10s++;
                }
                if (rollResults[i] == 11)
                {
                    num11s++;
                }
                if (rollResults[i] == 12)
                {
                    num12s++;
                }
            }

            decimal[] outputNums = {num2s,num3s,num4s,num5s,num6s,num7s,num8s,num9s,num10s,num11s,num12s};
            string[] astrikArray = {"","", "", "", "", "", "", "", "", "", ""};

            // creating the output array of astiks

            for (int i = 0; i < 12-1; i++ )
            {
                outputNums[i] = (outputNums[i] / numRolls) * 100;
                while (outputNums[i] > 0)
                {
                    astrikArray[i] = astrikArray[i] + "*";
                    outputNums[i]--;
                }
            }

            // outputing the array
            for (int i =0; i < 12 - 1; i++)
            {
                int j = i + 2;
                Console.WriteLine(j + ": " + astrikArray[i]);
            }
            Console.WriteLine("\n" + "Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
