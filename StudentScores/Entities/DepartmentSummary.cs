﻿namespace StudentScores.Entities
{
    public class DepartmentSummary
    {
        public string Department { get; set; }

        public int NumberOfStudents { get; set; }

        public int MaxGrade { get; set; }

        public override string ToString()
        {
            return $"{Department} - number of students: {NumberOfStudents} - max grade: {MaxGrade}";
        }
    }
}