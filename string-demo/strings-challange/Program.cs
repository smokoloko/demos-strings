using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_challange
{
    class Program
    {
        static void Main(string[] args)
        {
            string given = "git is a <<source control>> system for tracking changes in <<computer programs>> and coordinating work on those files between multiple developers";
            bool test = true;
            while (test)
            {
                
                int indexStart = given.IndexOf("<<");
                if(indexStart == -1)
                {
                    test = false;
                }
                else
                { 
                int indexEnd = given.IndexOf(">>") + 1;
                string toBeChanged = given.Substring(indexStart, indexEnd - indexStart +1);
                string change = given.Substring(indexStart + 2, indexEnd - indexStart - 3).ToUpper();
                given = given.Replace(toBeChanged, change);
                }
            }
            Console.WriteLine(given);
        }
    }
}
