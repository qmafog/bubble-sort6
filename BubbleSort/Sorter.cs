using System;

// ReSharper disable InconsistentNaming
namespace BubbleSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with bubble sort algorithm.
        /// </summary>
        public static void BubbleSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            int n = array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive bubble sort algorithm.
        /// </summary>
        public static void RecursiveBubbleSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            RecursiveBubbleSort(array, array.Length);
        }

        public static void RecursiveBubbleSort(this int[]? array, int length)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (length <= 1)
            {
                return;
            }

            for (int i = 0; i < length - 1; i++)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }

            RecursiveBubbleSort(array, length - 1);
        }
    }
}
