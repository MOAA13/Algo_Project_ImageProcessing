using System;

namespace testCountSort
{
    class Program
    {
        static void Main(string[] args)
        {
             static void CountingSort(byte[] Array)
            {
                // TODO: Implement the Counting Sort alogrithm on the input array

                //Find Max value in array
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

                int[] countArr = new int[max+1];
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

                for (int i = size-1 ; i >= 0 ; i--)
                {
                    sorted[countArr[Array[i]] - 1] = Array[i];
                    countArr[Array[i]]--;
                }
                //Filling Oringinal Array with sorted Array
                for (int i = 0; i < size; i++)
                {
                    Array[i] = (byte)sorted[i];
                }
            }

            var byteItems = new byte[] { 5, 4, 5, 3, 0, 1, 2 };
            CountingSort(byteItems);
            Console.Write("Sorted character array is ");
            for (int i = 0; i < byteItems.Length; ++i)
                Console.Write(byteItems[i]);
        }
    }
}
