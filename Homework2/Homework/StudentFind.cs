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
        /// <summary>
        /// 用名稱查詢學生學號
        ///
        ///     受測試的 Function
        /// </summary>
        /// <param name="name">要查找的名字</param>
        /// <returns>返回查找的學生學號</returns>
        public string Find(string name, List<Student> students)
        {
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