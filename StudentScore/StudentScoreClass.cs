using System;
using System.Collections.Generic;
using System.Text;

namespace StudentScore
{
    class StudentScoreClass
    {
        public int Score { get; set; }
        public int[] arScore = new int[3];
        public int highest = 0;
        public int lowest = 0;
        public int aver = 0;
        public void stu
        public void myCalculation(int score)
        {

           
            for (int j = 0; j < 3; j++)
            {
              if (Score > 0 & Score < 100)
                {
                    arScore[j] = Score;
                    for (int i = 1; i < arScore.Length; i++)
                    {
                        int pos = 0;
                        if (arScore[i] > arScore[pos])
                        {
                            highest = arScore[i];
                        }
                        else
                        {
                            lowest = arScore[i];
                        }
                    }


                }
                else
                {
                    Console.WriteLine($"Score must be between 0-100 not{Score}");
                }
                aver += arScore[j] / arScore.Length;
            }
           
        }
        public void display()
        {
            Console.WriteLine($"Highest Score Is:{highest}");
            Console.WriteLine($"Lowest Score Is:{lowest}");
            Console.WriteLine($"average Score Is:{aver}");
        }
    }
}
