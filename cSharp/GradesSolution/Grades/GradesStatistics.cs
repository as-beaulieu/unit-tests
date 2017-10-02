using System;
using System.Collections.Generic;
using System.Text;

namespace Grades
{
    //Class members define: 1) State, 2) Behavior
    //State: the grades for a user
    //Behavior: 1) Add a new grade, 2) Calculate statistics
    public class GradesStatistics
    {

        //If access is not declared, the default is 'private'
        //float AverageGrade;

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        public GradesStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
    }
}
