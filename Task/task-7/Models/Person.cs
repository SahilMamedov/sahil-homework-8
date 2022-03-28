using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    class Person
    {
        protected string _name;
        protected string _surName;
        
        public int _age { get; set; }

        public Person(string name,string surname, int age)
        {
            Name = name;
            Surname = surname;
            _age = age;

            Console.WriteLine($"Age: {age}");
        }
        public string Name
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
                        Console.WriteLine($"Name: {_name}");
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
        public string Surname
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
                        Console.WriteLine($"SurName: {_surName} ");
                    }
                    else
                    {
                        Console.WriteLine("Surname must be minumum 3 and maxsimum 35 characters");
                    }
                }
                else
                {
                    
                    Console.WriteLine("Surname must start with Uppercase");
                }
            }
        }

       
       












    }
}
