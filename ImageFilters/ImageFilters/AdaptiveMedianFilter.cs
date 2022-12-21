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
            // For each pixel in the image:
            // 0) Start by window size 3×3
            // 1) Chose a non-noise median value (true median)
            // 2) Replace the center with the median value if not noise, or leave it and move to the next pixel
            // 3) Repeat the process for the next pixel starting from step 0 again
            
            // Remove the next line
            throw new NotImplementedException();
        }
    }
}
