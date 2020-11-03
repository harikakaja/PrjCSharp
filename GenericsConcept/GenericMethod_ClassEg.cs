using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConcept
{
    class Sample<T>
    {
        T oil;
        internal Sample(T oil)
        {
            this.oil = oil;
        }

        //normal method to swap
        void SwapofNumber(int n1, int n2)
        {
            int t;
            t = n1;
            n1 = n2;
            n2 = t;
        }
        //Generic method

        internal static void Swap<T>(T n1, T n2)
        {
            T t;
            t = n1;
            n1 = n2;
            n2 = t;
            Console.WriteLine("n1:{0}||n2:{1}", n1, n2);
        }
    }
    class GenericMethod_ClassEg
    {
            static void Main()
            {
                Sample<string> sample = new Sample<string>("10liters");
                Sample<int> s1 = new Sample<int>(10);
                Sample.Swap<int>(5, 6);
                Sample.Swap<string>("You", "Me");
                Console.Read();
            }
            
    }
}
