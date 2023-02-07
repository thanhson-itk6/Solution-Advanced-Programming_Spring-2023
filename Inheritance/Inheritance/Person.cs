using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Person
    {

        //Field mặc định là private
        string name;
        int age;
        //Property 
        public string Name { get => name; set => name = value; }
        public int Age
        {
            get => age;
            set
            {
                if (value > 0) age = value;
                else System.Console.WriteLine("Age cannot negative ");
            }
        }

        //Auto Property
        // public string Name { get; set; }
        // public string Name { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + "; Age: " + Age;
        }
    }
    }

