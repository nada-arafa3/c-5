namespace c_5
{
    internal class Program
    {
        static void swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void swap2(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }


        /*******************************************/

        static int SumArr(int[] Arr)
        {
            int sum = 0;
            if (Arr is not null)
            {
                // this will affect the numbers array because we deal with the reference or the address of the arr 

                Arr[0] = 20;

                for (int i = 0; i < Arr.Length; i++)
                {
                    sum += Arr[i];
                }
            }

            return sum;
        }

        static int SumArr2(ref int[] Arr)
        {
            int sum = 0;
            // this will affect the numbers array لbecause we sent the array it self
            Arr[0] = 200;
            for (int i = 0; i < Arr.Length; i++)
            {
                sum += Arr[i];
            }

            return sum;
        }
        /*******************************************/
        static int[] SumAndSub(int x, int z, int y, int a)
        {
            int sum = x + z;
            int sub = y - a;
            return new int[] { sum, sub };

        }
        /***************************************/

        static int CalculateSumOfDigits(int number)
        {
            int sum = 0;

            number = Math.Abs(number);

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        /******************************************/

        // Function to find the minimum and maximum values in an array
        static void MinMaxArray(int[] array, out int minValue, out int maxValue)
        {
            if (array == null || array.Length == 0)
            {
                minValue = 0; // Handle empty array case
                maxValue = 0; // Handle empty array case
                return;
            }

            // Initialize min and max to the first element of the array
            minValue = array[0];
            maxValue = array[0];

            // Loop through the array to find min and max
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i]; // Update min
                }
                if (array[i] > maxValue)
                {
                    maxValue = array[i]; // Update max
                }
            }
        }

        /****************************************************/

        static long Factorial(int n)
        {
            // Handle the base case for 0! which is 1
            if (n == 0)
            {
                return 1;
            }

            long result = 1;

            // Loop from 1 to n to calculate the factorial
            for (int i = 1; i <= n; i++)
            {
                result *= i; // Multiply result by the current number
            }

            return result; // Return the computed factorial
        }
        /************************************************************/

        static void Main(string[] args)
        {

            #region one
            int a = 10;
            int b = 20;


            //passing by value

            swap(a, b);
            //the value of a & b will not be changed in the main stack frame 
            //passing by reference
            Console.WriteLine(b);    //20
            Console.WriteLine(a);    //10
            swap2(ref a, ref b);
            Console.WriteLine(b);    //10
            Console.WriteLine(a);    //20
            //the value of a & b will be changed in the main stack frame 

            #endregion

            #region two
            int[] Numbers = { 1, 2, 3, 4 };
            SumArr(Numbers);
            Console.WriteLine(SumArr(Numbers));//29 =>20+2=3=4=29
            Console.WriteLine(Numbers[0]);//20
                                          /////////////////////passing by reference 
            SumArr2(ref Numbers);
            Console.WriteLine(SumArr2(ref Numbers));//209 =>200+2=3=4=209
            Console.WriteLine(Numbers[0]);//200




            //// the only difference is how it happens in the memory 
            #endregion

            #region three
            Console.WriteLine("enter first number to sum");
            int sum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second to sum");
            int sum2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter first number to sub");
            int sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second to sub");
            int sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the sum is" + SumAndSub(sum1, sum2, sub1, sub2)[0]);
            Console.WriteLine("the sub is" + SumAndSub(sum1, sum2, sub1, sub2)[1]);

            #endregion


            #region four

            Console.Write("enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                int sum = CalculateSumOfDigits(number);
                Console.WriteLine($"The sum of the digits of the number {number} is: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        ;


            #endregion


            #region six

            int min;
            int max;


            MinMaxArray(Numbers, out min, out max);

            // Display the results
            Console.WriteLine($"The minimum value in the array is: {min}");
            Console.WriteLine($"The maximum value in the array is: {max}");


            #endregion

            #region seven
            Console.Write("Enter a non-negative integer to calculate its factorial: ");

            if (int.TryParse(Console.ReadLine(), out int Number) && number >= 0)
            {
                long factorial = Factorial(number);
                Console.WriteLine($"The factorial of {number} is: {factorial}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }



            #endregion


        }

    }
}

