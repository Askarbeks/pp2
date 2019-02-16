using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            int a = int.Parse(s1);
            for(int i=0; i<a; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    
                        Console.Write("[*]");                  
                }
                Console.WriteLine();
            }
        }
    }
}
