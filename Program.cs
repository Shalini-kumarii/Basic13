using System;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 3, 5, 7, 9 };
            int[] numbers1 = new int[] { -3, -5, -7 };
            int[] numbers2 = new int[] { 4, 8, 10 };
            int[] numbers3 = new int[] { 1, 2, 10, 5 };
            int[] numbers4 = new int[] { 15, 2, -10, 5 };
            PrintNumbers();
            PrintOdds();
            PrintSum();
            LoopArray(numbers);
            int maxnumber = FindMax(numbers1);
            Console.WriteLine(maxnumber);
            GetAverage(numbers2);
            int[] Oddarr = OddArray();
            for (int i = 0; i < Oddarr.Length; i++)
            {
                Console.WriteLine("odd numbers are:" + Oddarr[i]);
            }
            int total = GreaterThanY(numbers, 3);
            Console.WriteLine("Greater than y=" + total);

            SquareArrayValues(numbers3);
            EliminateNegatives(numbers4);
            MinMaxAverage(numbers4);
            ShiftValues(numbers4);
            NumToString(numbers4);
        }


        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine("numbers are:" + i);
            }
        }

        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (int odd = 1; odd <= 255; odd++)
            {
                if (odd % 2 != 0)
                {
                    Console.WriteLine("odd numbers:" + odd);
                }
            }

        }

        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:

            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
            int sum = 0;
            for (int j = 1; j <= 255; j++)
            {
                sum += j;

            }
            Console.WriteLine("sum of numbers are:" + sum);
        }

        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            for (int num = 0; num < numbers.Length; num++)
            {
                Console.WriteLine("The array values is:" + numbers[num]);
            }

        }

        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            for (int num = 0; num < numbers.Length; num++)
            {
                Console.WriteLine("The array values is:" + numbers[num]);
                if (numbers[num] > max)
                {
                    max = numbers[num];
                }

            }

            return max;
        }

        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                Console.WriteLine("sum is" + sum);
            }
            //Console.WriteLine(sum);
            Console.WriteLine(numbers.Length);
            float avg = sum / numbers.Length;
            Console.WriteLine("average is=" + avg);
        }

        public static int[] OddArray()
        {
            int idx = 0;
            int[] arr = new int[255];
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            for (int odd = 1; odd <= 255; odd++)
            {
                if (odd % 2 != 0)
                {

                    //Console.WriteLine("odd numbers:"+odd);
                    arr[idx] = odd;
                    idx++;
                }
            }
            return arr;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] > y)
                {
                    count++;
                }

            }
            return count;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            int[] val = new int[4];
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for (int i = 0; i < numbers.Length; i++)
            {
                val[i] = numbers[i] * numbers[i];
                Console.Write(val[i] + ",");
            }

        }


        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            int[] val = new int[4];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] <= 0)
                {
                    val[i] = 0;
                }
                else
                {
                    val[i] = numbers[i];
                }
                Console.WriteLine();
                Console.Write(val[i] + ",");
            }
        }

        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                sum += numbers[i];

            }
            Console.WriteLine("maxiumum number is:" + max);
            Console.WriteLine("miniumum number is:" + min);
            float avg = sum / numbers.Length;
            Console.WriteLine("average is=" + avg);
        }

        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].

            int i = 0;
            while (i != numbers.Length - 1)
            {
                numbers[i] = numbers[i + 1];
                i++;
            }
            numbers[i] = 0;
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine(numbers[j]);
            }

        }

        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            object[] arr = new object[4];
            int min = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    arr[i] = (string)"Dojo";
                }
                else
                {
                    arr[i] = numbers[i];
                }
            }

            foreach (var item in arr)
            {
                if (item is int)
                {
                    Console.WriteLine("Unbox int is: " + (int)item);
                }
                if (item is string)
                {
                    Console.WriteLine("Unbox string is: " + (string)item);
                }

            }
            return arr;
        }


    }
}
