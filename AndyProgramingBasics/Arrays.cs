using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndyProgramingBasics
{
    class Arrays
    {

        public static void Main(string[] aargs)
        {

            int[] a = { 1, 2, 3, 4, 5,6,7,8,9,10};

            char[] c = { 'a', 'b', 'c', 'd' };

            int[] b = new int[5];

            String[] s = { "java", "selenium", "c#","python" };


            // Console.WriteLine("last value    "+s[3]);





            
            for(int i = 9; i >=0 ; i--)
            {
                Console.WriteLine(a[i]);
                
            }

            

            

            Console.ReadLine();
            
            
        }
    }
}
