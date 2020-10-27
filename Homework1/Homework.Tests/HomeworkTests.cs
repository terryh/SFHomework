using System;
using System.Collections.Generic;
using Xunit;

using Homework;

namespace Homework.Tests
{
    /// <summary>
    /// 需要測試的行號: ../Homework/StudentFind line 32 ~ 43
    /// </summary>
    public class LineCoverageTest
    {
        private readonly StudentFind _studentFind;
        private readonly List<Student> _students;

        public LineCoverageTest()
        {
            _studentFind = new StudentFind();
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
        /// test case 1
        /// 1) Input values: name: "Terry"
        /// 2) expected result: "4094W008"
        /// 3) test program's result: "4094W008"
        /// Line coverage:   ../Homework/StudentFind 32 ~ 40
        /// </summary>
        [Theory, InlineData("Terry", "4094W008")]
        public void NameShouldBeFound(string name, string expectValue)
        {
            var result = _studentFind.Find(name, _students);
            Assert.Equal(result, expectValue);
        }

        /// <summary>
        /// test case 2
        /// 1) Input values: name: "John"
        /// 2) expected result: ""
        /// 3) test program's result: ""
        /// Line coverage:   ../Homework/StudentFind 40 ~ 43
        /// </summary>

        [Theory, InlineData("John", "")]
        public void NameShouldNotBeFound(string name, string expectValue)
        {
            var result = _studentFind.Find(name, _students);
            Assert.Equal(result, expectValue);
        }
    }
}