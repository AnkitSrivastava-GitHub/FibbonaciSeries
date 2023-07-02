using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, t2 = 1, t1 = 0, i,t3;
            Console.WriteLine("enter the numbers to fibonacci series should be printeed:");
            n = int.Parse(Console.ReadLine());
            //Console.WriteLine("series :"+t1+"  "+t2);
            for (i = 1; i <=n; i++)
            {
              //  Console.Write(t1)
                t3= t1+t2;
                Console.Write(" "+t1);
                t1= t2;
                t2 = t3;
                
            }

            Console.ReadKey();
        }
    }
}
