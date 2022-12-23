using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using ZGraphTools;
using System.Drawing;

namespace ImageFilters
{
    class AdaptiveMedianFilter
    {

        static List<double> time_Count = new List<double>();
        static List<double> window_Count = new List<double>();
        static List<double> time_quick = new List<double>();
        static List<double> window_quick = new List<double>();

        public static Byte[,] ApplyFilter(Byte[,] ImageMatrix, int MaxWindowSize, int UsedAlgorithm)
        {
            var watch_adap = Stopwatch.StartNew();
            //TODO: Implement adaptive median filter
            // For each pixel in the image
            // 0) Start by window size 3×3
            // 1) Chose a non-noise median value (true median)
            // 2) Replace the center with the median value if not noise, or leave it and move to the next pixel
            // 3) Repeat the process for the next pixel starting from step 0 again

            int imageHeight = ImageMatrix.GetLength(0);
            int imageWidth = ImageMatrix.GetLength(1);
            for (int i = 0; i < imageHeight; i++)
            {

                int windowSize = 3;
                for (int j = 0; j < imageWidth; j++)
                {


                    Byte[] window = new Byte[windowSize * windowSize];
                    int windowIndex = 0;
                    for (int x = i - windowSize / 2; x <= i + windowSize / 2; x++)
                    {
                        for (int u = j - windowSize / 2; u <= j + windowSize / 2; u++)
                        {
                            // Check if the current index is within the bounds of the image
                            if (x >= 0 && x < imageHeight && u >= 0 && u < imageWidth)
                            {
                                window[windowIndex] = ImageMatrix[x, u];
                            }
                            windowIndex++;
                        }
                    }
                    if (UsedAlgorithm == 0)
                    {
                        window = SortHelper.QuickSort(window, 0, windowIndex - 1);

                    }
                    else
                    {
                        window = SortHelper.CountingSort(window);


                    }
                    int value_min = window[0];
                    int value_max = window[windowIndex - 1];
                    int value_mid = window[(windowIndex - 1) / 2];
                    int first = value_mid - value_min;
                    int second = value_max - value_mid;
                    if (first <= 0 || second <= 0)
                    {
                        windowSize += 2;
                        if (windowSize <= MaxWindowSize)
                            j--;
                        else
                        {
                            ImageMatrix[i, j] = (byte)value_mid;
                            windowSize = 3;
                        }
                        continue;
                    }
                    first = ImageMatrix[i, j] - value_min;
                    second = value_max - ImageMatrix[i, j];
                    if (first <= 0 || second <= 0)
                    {
                        ImageMatrix[i, j] = (byte)value_mid;
                    }
                    windowSize = 3;
                }
            }
            watch_adap.Stop();

            Console.WriteLine(
           $"The Execution time of the program is {watch_adap.ElapsedMilliseconds}ms");
            if (UsedAlgorithm == 0)
            {


                time_quick.Add((double)watch_adap.ElapsedMilliseconds);
                window_quick.Add(MaxWindowSize);
            }
            else
            {

                time_Count.Add((double)watch_adap.ElapsedMilliseconds);
                window_Count.Add(MaxWindowSize);
            }
            ZGraphForm graph = new ZGraphForm("WindowSizeVsTime", "WindowSize", "Time");
            graph.add_curve("Quick", window_quick.ToArray(), time_quick.ToArray(), Color.Blue);
            graph.add_curve("Count", window_Count.ToArray(), time_Count.ToArray(), Color.Red);
            graph.Show();
            //Remove the next line
            //throw new NotImplementedException();
            return ImageMatrix;
        }
    }
}
