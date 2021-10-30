using LibMas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIb_4
{
    public static class Solution
    {
        public static string GetSquareRoot(this MyArray myarray)
        {
            string result = string.Empty;

            for (int i = 0; i < myarray.Length; i++)
            {
                if (myarray[i] > 0)
                {
                    result += $"{myarray[i]} - " + Math.Round(Math.Sqrt(Convert.ToDouble(myarray[i])), 2) + "\n";
                }
            }
            return result != string.Empty ? result : "Нет чисел > 0!";
        }
    }
}
