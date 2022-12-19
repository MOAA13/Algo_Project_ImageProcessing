using System;
using System.Collections.Generic;
using System.Text;

namespace ImageFilters
{
    class AlphaTrimFilter
    {
        public static Byte[,] ApplyFilter(Byte[,] ImageMatrix, int MaxWindowSize, int UsedAlgorithm, int TrimValue)
        {
            //TODO: Implement alpha trim filter
            // For each pixel in the image:
            // 1) Store the values of the neighboring pixels in an array. The array is called the window, and it should be odd sized.
            // 2) Sort the values in the window in ascending order (Quick Sort or Counting Sort)
            // 3) Exclude the first T values (smallest) and the last T values (largest) from the array.
            // 4) Calculate the average of the remaining values as the new pixel value 
            // 5) Place the new value in the center of the window in the new matrix

            // Remove the next line
            throw new NotImplementedException();
        }
    }
}
