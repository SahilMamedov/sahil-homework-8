using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    class Person
    {
        private string _name;
        private string _surName;
        private int _age;

        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public string name
        {
            get
            {
                return _name;
            }

            set
            {
                if (char.IsUpper(value[0]))
                {
                    if (value.Length >= 3 && value.Length <= 30)
                    {
                        _name = value;
                    }
                    else
                    {
                        Console.WriteLine("Name must be minumum 3 and maxsimum 30 characters");
                    }
                }
                else
                {
                    Console.WriteLine("Name must start with Uppercase");
                }

            }

        }
        public string surname
        {
            get
            {
                return _surName;
            }

            set
            {
                if (char.IsUpper(value[0]))
                {
                    if (value.Length >= 3 && value.Length <= 35)
                    {
                        _surName = value;
                    }
                    else
                    {
                        Console.WriteLine("Name must be minumum 3 and maxsimum 35 characters");
                    }
                }
                else
                {
                    Console.WriteLine("Name must start with Uppercase");
                }
            }
        }
        public Person()
        {

        }
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }
       











    }
}
