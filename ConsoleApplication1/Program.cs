using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static bool IsPrime(string x)
        {
            int a = int.Parse(x);

            int cnt = 0; 

            for (int i=1; i<=a; ++i)
            {
                if(a%i==0)
                {
                    cnt++;
                }
            }

            if (cnt == 2) return true;

            return false;
        }

        static void Main(string[] args)
        {
            for (int i=0; i<args.Length; ++i)
            {
                if (IsPrime(args[i]))
                {
                    Console.WriteLine(args[i]);
                }
            }
        }
    }
}
