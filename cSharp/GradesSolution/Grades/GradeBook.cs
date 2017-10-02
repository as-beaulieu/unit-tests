using System;
using System.Collections.Generic;
using System.Text;

namespace Grades
{
    //Class Accessibility
    //public: Everywhere
    //private: only in the same class
    //internal: only in the same assembly/project
    public class GradeBook
    {
        //Code snippet for Constructor: ctor, (hit TAB twice)
        public GradeBook() //Constructors are the same name as the class
        {
            //Constructors allow you to take explicit control over the initialization of your class
            grades = new List<float>();
        }

        //If return type is another class that has less accessibility than current class,
        //Then this function will call an error
        public GradesStatistics ComputeStatistics()
        {
            GradesStatistics stats = new GradesStatistics();

            float sum = 0; //All grades in gradebook\
            //Foreach: will execute once for every item in a collection
            foreach (float grade in grades)
            {
                //if(grade > stats.HighestGrade)
                //{
                //    stats.HighestGrade = grade;
                //}
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade); //Sets to highest of two variables passed
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade); //Sets to lowest of two variables
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;




            return stats;
        }

        //Inside () : Parameters
        public void AddGrade(float grade)
        {
            //Inside the curly braces is the "Scope"

            grades.Add(grade);
        }
       
        private List<float> grades = new List<float>();
    }
}
