using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Homework
{
    public class Student
    {
        public string Id;
        public string Name;

        public Student(string id)
        {
            Id = id;
        }
    }

    public class StudentName
    {
        private static string letter = @"^[a-z]{1}";
        private static string letterAndNumber = @"^[a-zA-Z0-9]+$";
        private static int _maxNameLength = 12;
        private static int _minNameLength = 3;

        public bool SetName(string id, string name, List<Student> students)
        {
            foreach (var item in students)
            {
                if (item.Id == id)
                {
                    if (! Regex.IsMatch(name, letter))
                    {
                        throw new System.FormatException($"The name should begin with lower case letter");
                    }

                    if (! Regex.IsMatch(name, letterAndNumber))
                    {
                        throw new System.FormatException($"The name should only contain letter and number");
                    }

                    if (name.Length > _maxNameLength || name.Length < _minNameLength)
                    {
                        throw new System.FormatException($"The length of name not greater than {_maxNameLength} and greater than {_minNameLength}");
                    }

                    
                    item.Name = name;
                    return true;
                }
            }
            return false;
        }
    }
}
