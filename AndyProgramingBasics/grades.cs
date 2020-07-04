using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndyProgramingBasics
{
   
    class grades
    {

        int score;

       string studentName;

       char grade;

        public static void Main3(string[] args)
        {
            grades student1 = new grades();

            student1.studentName = "john";

            student1.score = 56;

          Console.WriteLine(student1.studentName+" your grade is " + student1.calculateGrade(student1.score)+ " and your score is "+ student1.score);

            Console.ReadLine();

        }

      // score >=80--A, score >=70--B, score>=50--c, score>=30--D, score<30--F

       char calculateGrade(int studentScore)
        {

            // score = 86

            if (score>=80)
            {
                grade = 'A';

            }else if (score>=70)
            {
                grade = 'B';

            }else 

            if (score >= 50)
            {
                grade = 'C';

            }else

            if (score >= 30)
            {
                grade = 'D';

            }else

            if (score < 30)
            {
                grade = 'F';

            }

            return grade;



        }
    }
}
