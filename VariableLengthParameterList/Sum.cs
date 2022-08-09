using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableLengthParameterList
{
    internal class Sum
    {
        int sum;
        void Process(String prefix, params int[] values)
        {
            sum = 0;
            for (int i = 0; i < values.Length; i++)
                sum = sum + values[i];
            Console.WriteLine($"Sum: {sum}");
        }
        void Test()
        {
            Process("data");
            Process("data",1);
            Process("data",1,2,3);
            Process("data", new int[] {1,2,3,4,5});
        }

        public static void Main()
        {
            Sum sum = new Sum();
            sum.Test();
        }
    }
}
