using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Homework
{
    public class Student
    {
        public string Id;
        public int Score;


        public Student(string id)
        {
            Id = id;
        }
    }

    public class StudentScore
    {
        private static int _maxScore = 100;
        private static int _minScore = 0;
        private static int _maxStudentsLength = 500;
        private static int _minStudentsLength = 1;

        public bool SetStudentScore(string id, int score, List<Student> students)
        {
            if (students.Count > _maxStudentsLength || students.Count < _minStudentsLength)
            {
                throw new System.ArgumentException($"The length of students limit from {_minStudentsLength} to {_maxStudentsLength}");
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
