using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comparison
            var name = "Pesho";
            bool check = name.Equals("pesho", StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine(check);
        }
    }
}
