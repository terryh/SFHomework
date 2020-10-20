using System;
using System.Collections.Generic;

namespace Homework
{

    public class Student
    {
    //     public string ID { get; set; }
    //     public string Name { get; set; }

    //     public Student() { }
    public string ID;
    public string Name;

    public Student(string id, string name)
        {

            ID = id;
            Name = name;
        }
    }

    public class StudentFind
    {
        List<Student> _students = new List<Student>() ;
        public StudentFind () {
            _students = new List<Student>
            {
                new Student("4094W007", "Nick"),
                new Student("4094W010", "Aven"),
                new Student("4094W011", "Totti"),
                new Student("4094W012", "Jeff"),
                new Student("4094W008", "Terry"),
            };
        }

        public string Find(string name) 
        {
            // throw new NotImplementedException("No implemented");
            
            foreach(var item in _students)
            {
                if (item.Name == name) 
                {
                    return item.ID;
                }
            }
            return "";
        }
    }
}
