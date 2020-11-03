using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional
{
    class ConstEg
    {
        public const float pi = 3.14f;
        const int value = 10 + 20;
        int data = 80;
        internal void PerimeterofCircle(int radius)
        {
            const string name = "Jai";
            Console.WriteLine("Perimeter:{0}",(2*pi*radius));
        }
    }
    class ReadonlyEg
    {
        internal readonly string SchoolName;
        internal static readonly string OrgName = "lti";
        internal ReadonlyEg(string SchoolName)
        {
            this.SchoolName = SchoolName;
        }
        void DisplayStudent()
        {

        }
    }
    class const_ReadOnlyEg
    {
        static void Main()
        {
            ReadonlyEg readonlyEg = new ReadonlyEg("Zain");
            ReadonlyEg r2 = new ReadonlyEg("KV");
            ConstEg C = new ConstEg();
            C.PerimeterofCircle(4);
            Console.Read();

        }
    }
}
