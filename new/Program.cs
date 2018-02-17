using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @new
{
    class Program
    {
        struct Group 
            {
            public int kurs;
            public string Name;
            }

        static void Main(string[] args)
        {
            Program p = new Program();
            Group g = new Group();
            List<Group> gr = new List<Group>();
            string s = "tima";
            try
            {
                int a = s;
            }catch(Exception e)
            {
                Console.WriteLine("error " + e);
            }

            Console.Read();
        }
    }
}
