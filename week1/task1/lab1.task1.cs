using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            string s1 = Console.ReadLine();
            int a = int.Parse(s1);
            int[] arr = new int[a];
            int b;
            // entering elements of array
            for(int i=0; i<a; i++)
            {
                string s2 =Console.ReadLine();
                b = int.Parse(s2);
                arr[i] = b;
            }
            // running through all the elements of array
            for (int i = 0; i < a; i++)
            {
                if (arr[i] == 2)
                {
                    list.Add(arr[i]);
                }
                else
                {
                    // cycle for checking for prime number
                    for (int j = 2; j < arr[i]; j++)
                    {
                        if (arr[i] % j == 0)
                        {
                            break;
                        }
                        if (j == arr[i] - 1)
                        {
                            list.Add(arr[i]);
                        }
                    }

                }
            }
            //writing to the screen all the elements in list 
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                Console.Write(" ");
            }
        }
    }
}
