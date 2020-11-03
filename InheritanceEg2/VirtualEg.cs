using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEg2
{
    class InterviewRound1
    {
        internal virtual void Result()
        {
                Console.WriteLine("Round1 cleared:8/10");
        }
        public int Score()
        {
            return 8;
        }
    }
    class InterviewRound2: InterviewRound1

    {
        internal override void Result()
        {
            base.Result();
            Console.WriteLine("Round2 cleared:7/10");
        }
        public new int Score()
        {
            return 7;
        }
    }
    class InterviewRound3 : InterviewRound2
    {
        internal override void Result()
        {
            base.Result();           
                Console.WriteLine("Round3 not cleared:4/10");            
        }
        public new int Score()
        {
            return 4;
        }
    }

    class VirtualEg
    {
        static void Main()
        {
            InterviewRound1 r1 = new InterviewRound1();
            Console.WriteLine("Round 1 score:{0}", r1.Score());
            InterviewRound2 r2 = new InterviewRound2();
            Console.WriteLine("Round 2 score:{0}", r2.Score());

            InterviewRound3 r3 = new InterviewRound3();
            Console.WriteLine("Round 3 score:{0}", r3.Score());

            r3.Result();
            Console.Read();
        }
    }
}
