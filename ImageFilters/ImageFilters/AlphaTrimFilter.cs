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

            int imageHeight = ImageMatrix.GetLength(0);
            int imageWidth = ImageMatrix.GetLength(1);
            Byte[,] FilteredImageMatrix = new Byte[imageHeight, imageWidth];

            // Determine the window size to use based on the MaxWindowSize parameter
            int windowSize = MaxWindowSize;
            if (MaxWindowSize > imageHeight || MaxWindowSize > imageWidth)
            {
                windowSize = Math.Min(imageHeight, imageWidth);
            }

            // Make sure the window size is odd
            if (windowSize % 2 == 0)
            {
                windowSize--;
            }

            // For each pixel in the image:
            for (int y = 0; y < imageHeight; y++)
            {
                for (int x = 0; x < imageWidth; x++)
                {
                    // Store the values of the neighboring pixels in an array.
                    Byte[] window = new Byte[windowSize * windowSize];
                    int windowIndex = 0;
                    for (int i = y - windowSize / 2; i <= y + windowSize / 2; i++)
                    {
                        for (int j = x - windowSize / 2; j <= x + windowSize / 2; j++)
                        {
                            // Check if the current index is within the bounds of the image
                            if (i >= 0 && i < imageHeight && j >= 0 && j < imageWidth)
                            {
                                window[windowIndex] = ImageMatrix[i, j];
                            }
                            windowIndex++;
                        }
                    }

                    // 2) Sort the values in the window in ascending order (Quick Sort or Counting Sort)
                    if (UsedAlgorithm == 0)
                    {
                        // Use QuickSort to sort the window
                        SortHelper.QuickSort(window, y - windowSize, y + windowSize);
                    }
                    else
                    {
                        // Use CountingSort to sort the window
                        SortHelper.CountingSort(window);
                    }

                    // 3) Exclude the first T values (smallest) and the last T values (largest) from the array.
                    SortHelper.Kth_element(window, TrimValue);

                    // 4) Calculate the average of the remaining values as the new pixel value 
                    int sum = 0;
                    for (int i = TrimValue; i < windowSize * windowSize - TrimValue; i++)
                    {
                        sum += window[i];
                    }
                    int average = sum / (windowSize * windowSize - 2 * TrimValue);

                    // 5) Place the new value in the center of the window in the new matrix
                    FilteredImageMatrix[y, x] = (Byte)average;
                }
            }

            return FilteredImageMatrix;
        }
    }
}
