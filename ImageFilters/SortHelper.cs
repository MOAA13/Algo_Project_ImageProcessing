using System;
using System.Collections.Generic;
using System.Text;

namespace ImageFilters
{
    class SortHelper
    {
        public static byte Kth_element(byte[] Array, int T)
        {
            int k = T;
            byte min = 255, max = 0;
            //TODO: Implement Kth smallest/largest element
            // 1) Search the input array for the MIN and MAX elements without sorting
            int arrayLength = Array.Length;
            List<byte> list = new List<byte>(Array);

            while (k < arrayLength && k != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (max < list[i])
                        max = list[i];
                    if (min > list[i])
                        min = list[i];
                }

                list.Remove(min);
                list.Remove(max);

                k--;
            }
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            int avg = sum / list.Count;
            return (byte)avg;

        }


        public static byte[] CountingSort(byte[] Array)
        {
            // TODO: Implement the Counting Sort alogrithm on the input array

            //Find Max value in array as well as Array length
            int size = Array.Length;
            int max = Array[0];
            int[] sorted = new int[size];
            for (int i = 1; i < size; i++)
            {
                if (Array[i] > max)
                {
                    max = Array[i];
                }
            }
            //Test Passed
            //Console.Write(max);
            // Console.Write(size);

            int[] countArr = new int[max + 1];
            //Initialising Count Array with 'Zeros'
            for (int i = 0; i <= max; i++)
            {
                countArr[i] = 0;
            }

            //Storig Count of each value in 'Array' in 'CountArr'
            for (int i = 0; i < size; i++)
            {
                countArr[Array[i]]++;
            }

            //Test Passed
            //for (int i = 0; i < countArr.Length; ++i)
            // Console.Write(countArr[i]);

            //Finding index of each value in 'countArr' in 'Array'
            //and storing the value in 'sorted' 
            //Test Passed
            //Instead of i=0 --> i=1 &
            //i <max --> i <= max
            for (int i = 1; i <= max; ++i)
            {
                countArr[i] += countArr[i - 1];
            }
            //Test Passed
            //Change i = size --> i = size-1 because then only we reach zero
            //Change i > 0 --> i >= 0 to include last record

            for (int i = size - 1; i >= 0; i--)
            {
                sorted[countArr[Array[i]] - 1] = Array[i];
                countArr[Array[i]]--;
            }

            //Filling Oringinal Array with sorted Array
            for (int i = 0; i < size; i++)
            {
                Array[i] = (byte)sorted[i];
            }

            return Array;

        }

        private static int partition(Byte[] Array, int start, int end)
        {
            byte pivot = Array[end];
            int j = start;
            for (int i = start; i < end; i++)
            {
                if (Array[i] < pivot)
                {
                    byte Temp = Array[i];
                    Array[i] = Array[j];
                    Array[j] = Temp;
                    j++;
                }
            }
            byte temp = Array[end];
            Array[end] = Array[j];
            Array[j] = temp;
            return j;
        }

        public static Byte[] QuickSort(Byte[] Array, int start, int end)
        {
            // TODO: Implement the Quick Sort alogrithm on the input array
            if (start < end)
            {
                int pivotindex = partition(Array, start, end);
                // Separately sort elements before
                // partition and after partition
                QuickSort(Array, start, pivotindex - 1);
                QuickSort(Array, pivotindex + 1, end);
            }
            return Array;
        }
    }
}
