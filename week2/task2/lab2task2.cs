using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\admin\Documents\lab2task2input.txt");

            

            string[] num = text.Split();
            List<int> list = new List<int>();
            

            for(int i=0; i<num.Count(); i++)
            {
                int a = int.Parse(num[i]);
            
                    if (a == 2)
                    {
                        list.Add(a);
                    }
                    else
                    {
                        for (int j = 2; j < a; j++)
                        {
                            if (a % j == 0)
                            {
                                break;
                            }
                            if (j == a - 1)
                            {
                                list.Add(a);
                            }
                        }

                    }
                }
            string res = "";
                for (int i = 0; i < list.Count; i++)
                {
                 res = res + list[i] + " ";
                          
                }System.IO.File.WriteAllText(@"C:\Users\admin\Documents\lab2task2output.txt", res);              
            }
        }
    }
