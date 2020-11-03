using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional
{
    class DellLaptop
    {
        public string Laptopname { get; private set; }
        public string ram { get; set; }
        internal DellLaptop(string Laptopname, string ram)
        {
            this.Laptopname = Laptopname;
            this.ram = ram;
        }

    }
    class student
    {
        static void Main()
        {
            DellLaptop d = new DellLaptop("Inspiron13", "8gb");
            Console.WriteLine("name:{0}", d.Laptopname);
            d.ram = "16gb";
            Console.WriteLine("ram:{0}",d.ram);
            Console.Read();
        }
    }
    class PropertyEg
    {
    }
}
