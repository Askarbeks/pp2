using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp13
{    
    public class Program
    {
        static void Main(string[] args)
        {
            string pathstring = @"C:\CreatingFile";
            string path2 = @"C:\2file";
            string filename = "Just.txt";

            string loc = Path.Combine(pathstring, filename);           
       File.Create(loc);

            string loc2 = Path.Combine(path2, filename);
        
            File.Copy(loc, loc2, true);

            File.Delete(loc);
        }
        
    }
}
