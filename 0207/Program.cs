using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0207
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] regions = new string[] { "район 1", "район 2", "район 3" };
            City newcity = new City("город1", "страна1", 200000, 012, regions);
            newcity.Print();
        }
    }
}
