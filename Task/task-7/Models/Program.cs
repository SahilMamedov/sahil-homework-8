using System;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Person class

              - Name
              - Surname
              - Age 

              Name və Age təyin olunmamış bir Person obyekti yaratmaq olmaz.
              Name və Surname dəyərləri mütləq böyük hərf ilə başlamalıdı.
              Name dəyəri minumum 3 maximum 30 hərfdən ibarət ola bilər.
              Surname dəyəri minumum 3 maximum 35 hərfdən ibarət ola bilər.

              Student class (Person-dan miras alır)
              Point

              Point təyin olunmamış bir Student obyekti yaratmaq olmaz.

              Point dəyəri minimum 0 maximum 100 ola bilər. */


            

            Console.WriteLine("Please enter your Name:");
            string name= Console.ReadLine();
           
            Console.WriteLine("Please enter your Surname:");
           
             string surname = Console.ReadLine();
            Console.WriteLine("Please enter your Age:");
          
             int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your Point:");
           
             int point = Convert.ToInt32(Console.ReadLine());
             Student student = new Student(name,surname, age, point);

            





        }
    }
}
