using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumNameSpace;

namespace SumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5.5;
            double b = 3.0;
            Sum s = new Sum();
            double result = s.sum(a, b);
            System.Console.WriteLine(result.ToString());
        }
    }
}
