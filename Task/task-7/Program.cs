using System;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Please enter your Name:");
            //string name= Console.ReadLine();
            student.name = Console.ReadLine();
            Console.WriteLine("Please enter your Surname:");
            student.surname = Console.ReadLine();
            // string surname = Console.ReadLine();
            Console.WriteLine("Please enter your Age:");
            student._age = Convert.ToInt32(Console.ReadLine());
            // int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your Point:");
            student.point = Convert.ToInt32(Console.ReadLine());
            // int point = Convert.ToInt32(Console.ReadLine());
            // Student student = new Student(name, age, point);



            Console.WriteLine("Thansk");

            Console.WriteLine($"Name: {student.name} \n" +
                $"surName: {student.surname} \n" +
                $"Age: {student._age} \n" +
                $"Point: {student.point}");

           
        }
    }
}
