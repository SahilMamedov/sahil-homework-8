using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    class Student:Person
    {

        protected int _point;


        

        public Student(string name, string surname, int age, int point) : base(name,surname, age)
        {
            Point = point;

        }



        public int Point 
        {
            get
            {
                return _point;
            }
            set
            {
                if(value >=0 && value <= 100)
                {
                    _point = value;
                    Console.WriteLine($"Point: {_point}");
                }
                else
                {
                    Console.WriteLine("The point must be minumum 0 and maxsimum 100");
                }
            }

            
        }


    }
}
