using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartSequence();
            }
            //catch error
            catch (Exception)
            {
                Console.WriteLine("Something goofed =O");
                throw;
            }
            finally
            {
             //sequence complete
                Console.WriteLine("End");
            }
        }
        static void StartSequence()
        {
         
                //user input
                Console.WriteLine("Please input a number greater than 0");
                int userInput = Convert.ToInt32(Console.ReadLine());

                int[] userArray = new int[userInput];

                //call PopulateMethod
                PopulateMethod(userArray);
                //call GetSum, show
                int theSum = GetSum(userArray);
                Console.WriteLine("The sum of your array is {0}", theSum);
                // GetProduct, show
                int theProd = GetProduct(userArray, theSum);
                Console.WriteLine("The product of your array is {0}", theProd);
                //GetQuotient, show
                decimal quote = GetQuotient(theProd);
                Console.WriteLine("The quotient of your array is {0}", quote);

        }
        static int[] PopulateMethod(int[] userArray)
        {
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine($"input a number: {i+1} of {userArray.Length} input(s)");
                userArray[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The array length is: {userArray.Length}");

            }
            return userArray;
        }
        /*
        static int GetSum(int[])
        {

        }

        static int GetProduct(int[], intSum)
        {

        }

        static decimal GetQuotient([])
        {

        }
        */
    }
}
