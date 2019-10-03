using System;
using System.Collections.Generic;

namespace SumNamespace
{
    public class SumClass
    {
        public static int Sum(List<int> list)
        {
            int numbersSum = new int();

            try
            {
                foreach (var item in list)
                {
                    numbersSum += item;
                }
                return numbersSum;
            }
            catch (Exception)
            {
                return 0;

            }
        }
    }
}
