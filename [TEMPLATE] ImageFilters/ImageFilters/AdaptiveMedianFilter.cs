using System;
using System.Collections.Generic;
using System.Text;

namespace ImageFilters
{
    class AdaptiveMedianFilter
    {

        public static Byte[,] ApplyFilter(Byte[,] ImageMatrix, int MaxWindowSize, int UsedAlgorithm)
        {

            //TODO: Implement adaptive median filter
            // For each pixel in the image
            // 0) Start by window size 3×3
                // 1) Chose a non-noise median value (true median)
                // 2) Replace the center with the median value if not noise, or leave it and move to the next pixel
                // 3) Repeat the process for the next pixel starting from step 0 again
                for(int  i = 0; i < ImageMatrix.GetLength(0);i++)
            {
                int win_size = 3;
                for (int j =0; j < ImageMatrix.GetLength(1); j++)
                {
                    
                    byte[] array = {0};
                    int temp_i = i;
                    int temp_j = j;
                    int index = 0;
                    for (int x = 0; x < win_size; x++)
                    {
                        for (int u = 0; u < win_size; u++)
                        {
                            array[index++] = ImageMatrix[temp_i, temp_j++];
                        }
                        temp_i++;
                    }
                    if (UsedAlgorithm == 1)
                    {
                        array = SortHelper.QuickSort(array, 0, index); 
                    }
                    else
                    {
                        array = SortHelper.CountingSort(array);

                    }
                    int value_min = array[0];
                    int value_max = array[index];
                    int value_mid = array[index/2];
                    int first = value_mid - value_min;
                    int second = value_max - value_min;
                    if(first <= 0 || second <= 0)
                    {
                        win_size += 2;
                        if (win_size <= MaxWindowSize)
                            j--;
                        else
                            ImageMatrix[i, j] = (byte) value_mid;
                        continue;
                    }
                    first = ImageMatrix[i, j] - value_min;
                    second = value_max - ImageMatrix[i, j];
                    if(first<=0  || second <= 0)
                    {
                        ImageMatrix[i, j] = (byte)value_mid;
                    }
                    win_size = 3;
                }
            }

            //Remove the next line
            //throw new NotImplementedException();
            return ImageMatrix;
        }
    }
}
