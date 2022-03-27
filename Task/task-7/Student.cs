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


        public Student()
        {

        }

        public Student(string name,int age,int point):base(name,age)
        {
            _point = point;
            
        }

        

        public int point 
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
                }
                else
                {
                    Console.WriteLine("The point must be minumum 0 and maxsimum 100");
                }
            }

            
        }


    }
}
