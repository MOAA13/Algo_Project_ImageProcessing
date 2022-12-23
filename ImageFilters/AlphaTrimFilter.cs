using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using ZGraphTools;
using System.Drawing;

namespace ImageFilters
{
    
    class AlphaTrimFilter
    {
       static List<double> time_Count_Alpha = new List<double>();
        static List<double> window_Count_Alpha = new List<double>();
        static List<double> time_Kth_Alpha = new List<double>();
        static List<double> window_Kth_Alpha = new List<double>();
        public static Byte[,] ApplyFilter(Byte[,] ImageMatrix, int MaxWindowSize, int UsedAlgorithm, int TrimValue)
        {
            var watch = Stopwatch.StartNew();
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

                        window = SortHelper.CountingSort(window);


                        int sum = 0;
                        for (int i = TrimValue; i < windowSize * windowSize - TrimValue; i++)
                        {
                            sum += window[i];
                        }
                        int average = sum / (windowSize * windowSize - 2 * TrimValue);

                        FilteredImageMatrix[y, x] = (Byte)average;


                        watch.Stop();

                        Console.WriteLine(
                       $"The Execution time of the program is {watch.ElapsedMilliseconds}ms");
                        time_Count_Alpha.Add((double)watch.ElapsedMilliseconds);
                        window_Count_Alpha.Add(windowSize);
                    }
                    else
                    {
                        // Use CountingSort to sort the window
                        FilteredImageMatrix[y, x] = SortHelper.Kth_element(window, TrimValue);


                        watch.Stop();

                        Console.WriteLine(
                       $"The Execution time of the program is {watch.ElapsedMilliseconds}ms");
                        time_Kth_Alpha.Add( (double) watch.ElapsedMilliseconds);
                        window_Kth_Alpha.Add( windowSize);

                    }

                    // 3) Exclude the first T values (smallest) and the last T values (largest) from the array.
                    // 4) Calculate the average of the remaining values as the new pixel value 

                    // 5) Place the new value in the center of the window in the new matrix
                }
            }


            ZGraphForm graph_Alpha = new ZGraphForm("WindowSizeVsTime", "WindowSize", "Time");
            graph_Alpha.add_curve("Count", window_Count_Alpha.ToArray(), time_Count_Alpha.ToArray(), Color.Red);
            graph_Alpha.add_curve("Kth", window_Kth_Alpha.ToArray(), time_Kth_Alpha.ToArray(), Color.Blue);
            graph_Alpha.Show();
            return FilteredImageMatrix;
        }

       
         
    }

}

