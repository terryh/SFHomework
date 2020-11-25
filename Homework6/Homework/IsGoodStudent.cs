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
                if (item.Name == name && ( (item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score >= 80.0f))
                {
                    return "YES";
                } else if (item.Name == name) 
                {
                    return "NO";
                }
            }
            return "";
        }
    }

    public class GoodStudentFindLine1
    {
        public string IsGoodStudent(string name, List<Student> students)
        {
            //foreach (var item in students)
            foreach (var item in students.GetRange(0,1))
            {
                if (item.Name == name && ( (item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score >= 80.0f))
                {
                    return "YES";
                } else if (item.Name == name) 
                {
                    return "NO";
                }
            }
            return "";
        }
    }

    public class GoodStudentFindLine2
    {
        public string IsGoodStudent(string name, List<Student> students)
        {
            foreach (var item in students)
            {
                //if (item.Name == name && ( (item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score >= 80.0f))
                if (item.Name == name && ( (item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score > 80.0f))
                {
                    return "YES";
                } else if (item.Name == name) 
                {
                    return "NO";
                }
            }
            return "";
        }
    }

    public class GoodStudentFindLine3
    {
        public string IsGoodStudent(string name, List<Student> students)
        {
            foreach (var item in students)
            {
                if (item.Name == name && ( (item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score >= 80.0f))
                {
                    //return "YES";
                    return "NO";
                } else if (item.Name == name) 
                {
                    return "NO";
                }
            }
            return "";
        }
    }

    public class GoodStudentFindLine4
    {
        public string IsGoodStudent(string name, List<Student> students)
        {
            foreach (var item in students)
            {
                if (item.Name == name && ( (item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score >= 80.0f))
                {
                    return "YES";
                //} else if (item.Name == name) 
                } else if (item.Name != name) 
                {
                    return "NO";
                }
            }
            return "";
        }
    }

    public class GoodStudentFindLine5
    {
        public string IsGoodStudent(string name, List<Student> students)
        {
            foreach (var item in students)
            {
                if (item.Name == name && ( (item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score >= 80.0f))
                {
                    return "YES";
                } else if (item.Name == name) 
                {
                    //return "NO";
                    return "YES";
                }
            }
            return "";
        }
    }

    public class GoodStudentFindLine6
    {
        public string IsGoodStudent(string name, List<Student> students)
        {
            foreach (var item in students)
            {
                if (item.Name == name && ( (item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score >= 80.0f))
                {
                    return "YES";
                } else if (item.Name == name) 
                {
                    return "NO";
                }
            }
            // return "";
            return "YES";
        }
    }
}
