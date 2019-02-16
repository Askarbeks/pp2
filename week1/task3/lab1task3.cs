using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            int a = int.Parse(s1);
            int[] arr = new int[a];
            for (int i = 0; i < a; i++)                
            {
                string s2 = Console.ReadLine();
                int b = int.Parse(s2);
                arr[i] = b;
            }
            for(int i=0; i<a; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
                Console.Write(arr[i]);
                Console.Write(" ");
            }
        }
    }
}
