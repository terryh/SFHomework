# Homework2 
we use Homework1's code Graph 

```csharp
using System;
using System.Collections.Generic;

namespace Homework
{
    /// <summary>
    /// 學生
    /// </summary>
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
        private readonly List<Student> _students;

        public StudentFind()
        {
            _students = new List<Student>
            {
                new Student("4094W007", "Nick"),
                new Student("4094W010", "Aven"),
                new Student("4094W011", "Totti"),
                new Student("4094W012", "Jeff"),
                new Student("4094W008", "Terry"),
            };
        }

        /// <summary>
        /// 用名稱查詢學生學號
        /// 
        ///     受測試的 Function
        /// </summary>
        /// <param name="name">要查找的名字</param>
        /// <returns>返回查找的學生學號</returns>
        public string Find(string name)
        {
            foreach (var item in _students)
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

```

# Graph

![alt Graph](./graph.svg)

# Edge Coverage 

* [A B]
* [B C]
* [C D]
* [D F]
* [F B]
* [F H]
* [D E]
* [E G]


# Edge-Pair Coverage 

* [A B C]
* [B C D]
* [C D F]
* [D F B]
* [D F H]
* [D E G]
  
# Test Paths

* [A B C D E G]
* [A B C D F B C D F H]