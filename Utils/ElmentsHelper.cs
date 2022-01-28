using System;
using System.Collections.Generic;
using System.Text;

namespace Utils
{
    public class ElmentsHelper
    {
        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }

}
