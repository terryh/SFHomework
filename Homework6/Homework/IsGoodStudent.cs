using System;
using System.Collections.Generic;

namespace Homework
{
    public class Student
    {
        public readonly string Name;
        public readonly float Score;
        public readonly float Bmi;

        public Student(string name, float score, float bmi)
        {
            Name = name;
            Score = score;
            Bmi = bmi;
        }
    }

    public class GoodStudentFind
    {
        public string IsGoodStudent(string name, List<Student> students)
        {
            foreach (var item in students)
            {
                if (item.Name == name && (
                    (item.Bmi >= 18.5f && item.Bmi < 24.0f) || 
                    item.Score >= 80.0f))
                {
                    return "YES";
                } else if (item.Name == name) 
                {
                    return "NO";
                }
            }
            // no found
            return "";
        }
    }

    public class GoodStudentFindMuted
    {
        public string IsGoodStudent(string name, List<Student> students)
        {
            foreach (var item in students)
            {
                if (item.Name == name && (
                    (item.Bmi >= 18.5f && item.Bmi < 24.0f) || 
                    item.Score > 80.0f))
                {
                    return "YES";
                } else if (item.Name == name) 
                {
                    return "NO";
                }
            }
            // no found
            return "";
        }
    }
}
