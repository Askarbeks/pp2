using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\admin\Documents\infos.txt");
         

            bool b = true;
            string[] chars = text.Split();
            for (int i = 0; i < text.Length / 2; i++)
            {
              
                if (text[i] == text[text.Length - 1-i])
                {
                    b = true;
                }
                else
                {
                    b = false;
                }
            }
                if (b)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }

            }
         }
    }
