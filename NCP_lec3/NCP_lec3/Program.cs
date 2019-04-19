using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NCP_lec3
{
    class Program
    {
        static void Main(string[] args)
        {
            int output = int.MinValue;
            Console.WriteLine(output);
            Console.WriteLine(-1 * output);
            Console.WriteLine(-2147483648);
            Console.WriteLine((long)-1 * -2147483648);

            long output2 = long.MinValue;
            Console.WriteLine(output2);
            Console.WriteLine(-1 * output2);
            Console.WriteLine(-9223372036854775808);
            Console.WriteLine((float) -1 * -9223372036854775808);
            Console.WriteLine((double)-1 * -9223372036854775808);
        }
    }
}
