using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int[] Galustyan(int[] numbers)
        {//0
            for (int i = 0; i < numbers.Length; i++) //1
            {
                if (numbers[i] % 3 == 0)//2
                {
                    numbers[i] = numbers[i] / 3;//3
                }
            }//4

            return numbers;//5
        }//6
    }
}
