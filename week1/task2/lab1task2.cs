using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public String name;
        public String id;
        public int yearOfStudy;
      // constructor with two parameters
        public Student(String name, String id)
        {
            this.name = name;
            this.id = id;
            yearOfStudy = 1;
        }

        public String getname()
        {
            return name;
        }

        public string getid()
        {
            return id;
        }
        //printing info usng getinfo()
        public void getInfo()
        {
            Console.Write(this.getname() + " " + this.getid() + " " + yearOfStudy);
        }
        // function for incrementing yearofstudy
        public void imp()
        {
            yearOfStudy++;
        }
    }


        class Program
        {
            static void Main(string[] args)
            {
                Student s = new Student("Dias", "18BD");
                Console.WriteLine(s.name + " " + s.id + " " + s.yearOfStudy);         
                
             s.imp();
             s.getInfo();

            Console.ReadKey();                
            }
        }
    }
