using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Basics_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //question 1
            //if(NoModule(8, 4) == true)
            //{
            //    Console.WriteLine("No module");
            //}
            //else
            //{
            //    Console.WriteLine("Some module");
            //}

            //question 2
            //int a = 3;
            //int b = 5;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Question2(ref a,ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //question 3
            //int a;
            //int b;
            //Question3(out a, out b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //question 4
            //Console.WriteLine(Question4(2, 5, 4, 3));

            //question 5
            //Console.WriteLine(Question5(5));
            //Console.WriteLine(Question5(4, 6));
            //Console.WriteLine(Question5(7, 4, 2));

            //question 6
            //Console.WriteLine(Question5(1, c:10));

            //question7
            //int[] array = { 4, -2, -6, 5, 78, -3, 9, 0, -1, 3 };
            //Question7(array, out int[] positives, out int[] negatives);
            //for (int i = 0; i < positives.Length; i++)
            //{
            //    Console.Write(positives[i] + " ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < negatives.Length; i++)
            //{
            //    Console.Write(negatives[i] + " ");
            //}
            //Console.WriteLine();
        }

        private static void Question7(int[] array, out int[] positives, out int[] negatives)
        {
            int plus = 0; //0 will count as a positive
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] >= 0)
                {
                    plus++;
                }
            }
            positives = new int[plus];
            int posCounter = 0;
            int negCounter = 0;
            negatives = new int[array.Length - plus];
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] >= 0)
                {
                    positives[posCounter] = array[i];
                    posCounter++;
                }
                else
                {
                    negatives[negCounter] = array[i];
                    negCounter++;
                }
            }
        }

        private static int Question5(int a, int b = 1, int c = -1)
        {
            return a * b * c;
        }
        
        private static int Question4(params int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Math.Pow(numbers[i], i + 1);

            }
            return (int)sum;
        }

        private static void Question3(out int a,out int b)
        {
            Console.WriteLine("Enter a's value: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b's value: ");
            b = int.Parse(Console.ReadLine());
        }

        private static void Question2(ref int a, ref int b)
        {
            a++;
            b *= 2;
        }

        private static bool NoModule(int a, int b)
        {
            if(a % b == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
