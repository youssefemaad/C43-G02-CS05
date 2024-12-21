using System;

namespace Assignment05
{
    class Program
    {
        public static void SumSub_Passing_by_value1(int a, int b, int c, int d)
        {
            int sum = a + b;
            int sub = c - d;
            Console.WriteLine($"Sum: {sum}, Sub: {sub}");
        }
        public static void SumSub_Passing_by_reference1(ref int a, ref int b, ref int c, ref int d)
        {
            int sum = a + b + c + d;
            int sub = a - b - c - d;
            Console.WriteLine($"Sum: {sum}, Sub: {sub}");
        }
        public static void SumSub_Passing_by_value2(int[] arr)
        {
            int sum = 0, sub = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                sub -= arr[i];
            }
            Console.WriteLine($"Sum: {sum}, Sub: {sub}");
        }
        public static void SumSub_Passing_by_reference2(ref int[] arr)
        {
            int sum = 0, sub = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                sub -= arr[i];
            }
            Console.WriteLine($"Sum: {sum}, Sub: {sub}");
        }
        public static void SumDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine($"Sum of digits: {sum}");
        }
        public static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void MinMaxArray(ref int[] arr, ref int min, ref int max)
        {
            min = arr[0];
            max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
        }
        public static int factorial(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }
        public static string ChangeChar(ref string str, int idx, char ch)
        {
            char[] arr = str.ToCharArray();
            arr[idx] = ch;
            str = new string(arr);
            return str;
        }

        static void Main(string[] args)
        {
            #region 1. Explain the difference between passing (Value type parameters) by value and by reference then write a suitable C# example
            int a = 10, b = 20, c = 30, d = 40;
            Console.WriteLine("Passing by value:");
            SumSub_Passing_by_value1(a, b, c, d);
            SumSub_Passing_by_reference1(ref a, ref b, ref c, ref d);
            #endregion

            #region 2. Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable C# example.
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Passing by value:");
            SumSub_Passing_by_value2(arr);
            SumSub_Passing_by_reference2(ref arr);
            #endregion

            #region 3. Write a C# Function that accepts 4 parameters from user and returns result of summation and subtraction of two numbers.
            int x, y, z, w;
            Console.WriteLine("Enter 4 numbers:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            w = int.Parse(Console.ReadLine());
            SumSub_Passing_by_value1(x, y, z, w);
            #endregion

            #region 4. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            int num;
            Console.WriteLine("Enter a number:");
            num = int.Parse(Console.ReadLine());
            SumDigits(num);
            #endregion

            #region 5. Create a function named "IsPrime", which receives an integer number and returns true if it is prime, or false if it is not.
            int num5 = int.Parse(Console.ReadLine());
            if (IsPrime(num5))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
            #endregion

            #region 6. Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters.
            int[] arr6 = { 1, 2, 3, 4, 5 };
            int min = 0, max = 0;
            MinMaxArray(ref arr6, ref min, ref max);
            Console.WriteLine($"Min: {min}, Max: {max}");
            #endregion

            #region 7. Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter.
            int num7 = int.Parse(Console.ReadLine());
            int fact = factorial(num7);
            Console.WriteLine(fact);
            #endregion

            #region 8. Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter.
            int idx = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            char ch = char.Parse(Console.ReadLine());
            string newStr = ChangeChar(ref str, idx, ch);
            Console.WriteLine(newStr);
            #endregion
        }
    }
}
