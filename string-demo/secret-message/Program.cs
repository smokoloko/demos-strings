using System;
using System.Collections.Generic;


namespace secret_message
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "o2hs123o6g0olle42H";
            char[] array = input.ToCharArray();
            List<char> result = new List<char>();
            
            for (int i = array.Length - 1; i > -1; i--)
            {
                bool flag;
                if (!bool.TryParse(array[i].ToString(), out flag))
                {
                    
                        result.Add(array[i]);
                    
                }
                
            }
            Console.WriteLine(string.Join(null,result.ToArray()));
        }
    }
}
