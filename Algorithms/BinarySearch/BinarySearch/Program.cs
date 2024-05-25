using System;
namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -23, -1, 2, 3, 101 };
            var targetToFind = 3;

            var index = FindIndexOf(arr, targetToFind);

            Console.WriteLine($"element {targetToFind} is finded at index: {index}");

            var index2 = FindIndexWithRecursive(arr, targetToFind);
            Console.WriteLine($"element {targetToFind} is finded at index: {index2}");
            Console.ReadLine();
        }

        private static int FindIndexOf(int[] array, int targetElement)
        {
            var left = 0;
            var right = array.Length - 1;

            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (array[middle] == targetElement)
                {
                    return middle;
                }

                if (array[middle] < targetElement)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1;
        }

        private static int FindIndexWithRecursive(int[] array, int targetElement)
        {
            return RecursiveFindIndexOf(array, targetElement, 0, array.Length - 1);
        }

        private static int RecursiveFindIndexOf(int[] array, int targetElement, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }
            var middle = (left + right) / 2;
            if (array[middle] == targetElement)
            {
                return middle;
            }

            return array[middle] < targetElement ? 
                RecursiveFindIndexOf(array, targetElement, middle + 1, right):
                RecursiveFindIndexOf(array, targetElement, left, right - 1);
        }
    }
}
