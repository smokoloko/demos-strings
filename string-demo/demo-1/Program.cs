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

            //Concatenation
            //Slow method
            string result = "snow" + "ball";
            Console.WriteLine(result);
            //Fast method - using StringBuilder - for more accurate performace comparison - check presentation slide 16
            StringBuilder sb = new StringBuilder();
            sb.Append("Telerik");
            sb.Append(" Academy");
            string sbResult = sb.ToString();
            Console.WriteLine(sbResult);

            //Searching
            Console.WriteLine("Test".IndexOf('T'));
            Console.WriteLine("Telerik".IndexOf("eri"));
        }
    }
}
