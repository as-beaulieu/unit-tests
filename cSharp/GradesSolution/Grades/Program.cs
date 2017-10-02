using System;


namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f); //Ending float types with 'f' to indicate float
            book.AddGrade(62.4f);

            GradesStatistics stats = book.ComputeStatistics();
            //Console.Writeline code snippet: 'cw' (TAB x2)
            Console.WriteLine("Average: " + stats.AverageGrade);
            Console.WriteLine("Highest: " + stats.HighestGrade);
            Console.WriteLine("Lowest: " + stats. LowestGrade);

            //Ctrl + F5 allows for a pause on console before closing when
            //Program is done (Press any key to continue ... )
        }
    }
}
