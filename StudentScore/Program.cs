using System;

namespace StudentScore
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentScoreClass objStudent = new StudentScoreClass();
           
                Console.WriteLine($"Enter Your Score for student:");

            int score = int.Parse(Console.ReadLine());
            objStudent.myCalculation(score);

            objStudent.display();

            //foreach (var item in arScore)
            //{
            //    Console.WriteLine(item);
            //}

           



        }
    }
}
