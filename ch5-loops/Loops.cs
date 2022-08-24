using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1730ch5Loops
{
    public class Loops
    {
        public static string Calc01()
        {
            int i = 1, sum = 0;
            while (i < 5)
            {
                sum += i;
                i++;
            }
            return sum.ToString();
        }

        public static string Calc02(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInterestRate = double.Parse(strMonthlyInterestRate);
                int i = 1;
                while (i <= months)
                {
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);
                    i++;
                }
            }
            catch
            {
                return "Invalid input";
            }

            return futureValue.ToString("n2");
        }
    }
}
