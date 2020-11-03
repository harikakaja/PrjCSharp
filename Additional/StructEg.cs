using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional
{
    /*Access_Modifier 
     * struct structure_name 
     * { // Fields //
     * Parameterized constructor 
     * // Constants // 
     * Properties // 
     * Indexers // 
     * Events // 
     * Methods etc. }*/
    public struct Pen
    {
        internal int penid;
        public string color;
        //error
        //string type="Foundation";
    }
    class StructEg
    {
        static void Main()
        {
            Pen p = new Pen();

        }
    }
}
