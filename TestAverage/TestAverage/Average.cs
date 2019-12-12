using System;
using System.Collections.Generic;
using System.Text;

namespace TestAverage
{
    public class Average
    {
        public int GetTotalTests(int total)
        {
            return total;
        }
        public int GetSum(int total , int num2)
        {
            return total + num2;
        }
        public int GetAverage(int sum, int totalTests)
        {
            decimal decSum = Convert.ToDecimal(sum);
            decimal decTotal = Convert.ToDecimal(totalTests);
            decimal avg = decSum / decTotal;
            int rounder = Convert.ToInt32(Math.Round(avg));

            return rounder;

        }
    }
}
