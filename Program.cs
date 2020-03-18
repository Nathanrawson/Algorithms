using System;
using System.Linq;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] testy1 = Enumerable.Range(1, 1000000000).ToArray();
            int z = 1;
                
            int x = 0;
            int y = testy1.Length -1;
            var test3 = LinearSearchIterative(testy1, z);
            Console.WriteLine(test3);
            Console.ReadLine();
            Array.Sort(testy1);
            var test = binarySearchRecursive(testy1,z, x, y);
            //var test2 = county(100000000);
           // Console.WriteLine(test2);
            Console.WriteLine(test);
            Console.ReadLine();
        }
     
        public static Boolean binarySearchRecursive(int[] array, int x, int left, int right)
        {
            if (left > right)
            {
                return false;
            }
            int mid = (left + right) / 2;
            if (array[mid] == x)
            {
                return true;
            } else if (x < array[mid])
            {
                return binarySearchRecursive(array, x, left, mid - 1);

            } else

            {
                return binarySearchRecursive(array, x, mid + 1, right);
            }
            
        }
        public static Boolean LinearSearchIterative(int[] array, int x)
        {
            var n = array.Length - 1;
            while (n >= 0)
            {
                if (array[n] == x)
                {
                    return true;
                }
                n = (n - 1);
            }
            return false;
        }
    

        public static Boolean linearSearchRecursive(int[] array, int x, int n)
        {
            if (n <= 0)
            {
                return false;
            }
            if (array[n] == x)
            {
                return true;
            }
            else
            {
                n = n - 1;

                return linearSearchRecursive(array, x, n);
            }
           

        }


        public static int county (int x)
        {
            if (x <= 0)
            {
                return 1;
            }
            else
            {
                Console.WriteLine(x);
                x = x - 1;
                return county(x);
            }
          
        }
    
          
        
    }
}
