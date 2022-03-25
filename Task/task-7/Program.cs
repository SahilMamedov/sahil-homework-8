using System;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {


            Student student = new Student();

            Console.WriteLine("Please enter your Name:");
            student.name = Console.ReadLine();
            Console.WriteLine("Please enter your Surname:");
            student.surname = Console.ReadLine();
            Console.WriteLine("Please enter your Age:");
            student.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your Point:");
            student.point = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thansk");
            Console.WriteLine($"Name: {student.name} \n" +
                $"surName: {student.surname} \n" +
                $"Age: {student.age} \n" +
                $"Point: {student.point}");

            // Muellim student objectine deyerleri readline ile vermek ucun bele yazdim 
            // yeni classlarda anlashilmiyan kod gorsez bilinki stundent objectinin constructuruna gondereceyimiz deyere gore yazmisham.
        }
    }
}
