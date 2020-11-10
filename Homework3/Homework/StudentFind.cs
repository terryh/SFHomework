using System;
using System.Collections.Generic;

namespace Homework
{
    public class Student
    {
        // 學號
        public readonly string Id;
        // 姓名
        public readonly string Name;

        public Student(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class StudentFind
    {
        private static int _maxNameLength = 32;
        private static int _maxSutdentsLength = 500;

        // 
        public string Find(string name, List<Student> students)
        {
            // check specification
            if (name.Length > _maxNameLength)
            {
                throw new System.ArgumentException($"The length of name not greater than {_maxNameLength}");
            }

            if (students.Count > _maxSutdentsLength)
            {
                throw new System.ArgumentException($"The length of students not greater than {_maxSutdentsLength}");
            }

            foreach (var item in students)
            {
                if (item.Name == name)
                {
                    return item.Id;
                }
            }
            return "";
        }
    }
}
