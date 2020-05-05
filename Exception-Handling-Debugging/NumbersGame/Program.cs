using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nThe Number Game!\n");
        
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
                Console.WriteLine($"input a number: {i + 1} of {userArray.Length} input(s)");
                userArray[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The array length is: {userArray.Length}");

            }
            return userArray;
        }

        static int GetSum(int[] userArray)
        {
            int theSum = 0;
            for (int i = 0; i < userArray.Length; i++)
            {
                theSum += userArray[i];
            }
            if (theSum < 20)
            {
                Console.WriteLine("please enter higher numbers");
                return 0;
            }
            else
            {
                return theSum;
            }
        }

        static int GetProduct(int[] userArray, int theSum)
        {

            int prodInput = userArray.Length;
            Console.WriteLine("Please input a number {0}", prodInput);

            int magicNum = Convert.ToInt32(Console.ReadLine());
            int theProd = theSum * magicNum;

            return theProd;
        }

        static decimal GetQuotient(int theProd)
        {
            try
            {
                Console.WriteLine($"divide {theProd} by what number? ");
                int divNum = int.Parse(Console.ReadLine());
                decimal quote = decimal.Divide(theProd, divNum);
                return quote;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("never divide by 0 kid, you'll create a blackhole on earth");
                throw;
            }

        }
    }

