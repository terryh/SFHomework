using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Homework
{
    public class Student
    {
        public string Id;
        public float Score;


        public Student(string id)
        {
            Id = id;
        }
    }

    public class StudentScore
    {
        private static float _maxScore = 100.0f;
        private static float _minScore = 0.0f;
        private static int _maxStudentsLength = 500;

        public bool SetStudentScore(string id, float score, List<Student> students)
        {
            if (students.Count > _maxStudentsLength)
            {
                throw new System.ArgumentException($"The length of students not greater than {_maxStudentsLength}");
            }

            foreach (var item in students)
            {
                if (item.Id == id)
                {
                    if (score < _minScore)
                    {
                        throw new System.ArgumentException($"No score less than {_minScore}");
                    }

                    if (score > _maxScore)
                    {
                        throw new System.ArgumentException($"No score greater than {_maxScore}");
                    }

                    
                    item.Score = score;
                    return true;
                }
            }
            return false;
        }
    }
}
