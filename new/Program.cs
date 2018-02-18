using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @new
{
    class Tima
    {

        public static int a = 0;
        public Tima()
        {
            a++;
        }

        static void grup()
        {
            Console.WriteLine("User:" + a);
        }

        class Program
        {

            static void Main(string[] args)
            {
                Tima t1 = new Tima();
                Tima t2 = new Tima();
                Tima t3 = new Tima();
                Tima t4 = new Tima();
                
                Console.Read();
            }
        }
    }
}
