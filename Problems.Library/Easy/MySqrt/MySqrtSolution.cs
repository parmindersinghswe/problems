﻿namespace Problems.Library.Easy.MySqrt
{
    public class MySqrtSolution
    {
        public int Find(int x)
        {
            if (x <= 1)
            {
                return x;
            }

            int left = 1, right = x / 2;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                long square = (long)mid * mid;

                if (square == x)
                {
                    return mid;
                }
                else if (square < x)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return right;
        }
    }
}