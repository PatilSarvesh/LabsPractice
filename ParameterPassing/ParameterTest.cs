using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterPassing
{
    internal class ParameterTest
    {
        int X;  
        public void Value(int x)
        {
            this.X = x;
            Console.WriteLine(X);
        }
        public void Swap(ref int a, ref int b)
        { 
            a =a + b;
            b = a - b;
            a = a - b;   
            
        }

        public void MinMax(int[] a, out int min, out int max)
        {
            min= a[0];
            max = a[a.Length-1];

            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] > max)
                {
                    max= a[i];
                }
                if(a[i] < min)
                {
                    min = a[i];
                }
            }


        }
        
    }

    class Driver
    {
        public static void Main()
        {
           ParameterTest test = new ParameterTest();
            test.Value(5);
            int a = 5;
            int b = 6;
            test.Swap(ref a,ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("--------");

            int[] arr = new int[5];

            Console.WriteLine("Enter Array elements");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int min, max;
            test.MinMax(arr, out min, out max);
            Console.WriteLine($"Min Value {min}");
            Console.WriteLine($"Max Value {max}");
            //Console.WriteLine(max);
        }
    }
}
