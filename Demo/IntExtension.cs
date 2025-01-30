using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class IntExtension
    {
        public static int Reverse(this int Number)
        {
            int ReversedNumber = 0;
            while (Number != 0)
            {
                ReversedNumber = ReversedNumber * 10 + Number % 10;
                Number = Number / 10;
            }
            return ReversedNumber;
        }
    }
}
