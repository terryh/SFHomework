using System;
using Xunit;

using Homework;

namespace Homework.Tests
{
    /// <summary>
    /// 需要測試的行號: ../Homework/StudentFind 48 50 52 55
    /// </summary>
    public class LineCoverageTest
    {
        private readonly StudentFind _studentFind;

        public LineCoverageTest()
        {
            _studentFind = new StudentFind();
        }

        /// <summary>
        /// test case 1
        /// 1) Input values: name: "Terry"
        /// 2) expected result: "4094W008"
        /// 3) test program's result: "4094W008"
        /// Line coverage:   ../Homework/StudentFind 48 50 52
        /// </summary>
        [Theory,
         InlineData("Terry", "4094W008")]
        public void NameShouldBeFound(string name, string expectValue)
        {
            var result = _studentFind.Find(name);
            Assert.Equal(result, expectValue);
        }

        /// <summary>
        /// test case 2
        /// 1) Input values: name: "John"
        /// 2) expected result: ""
        /// 3) test program's result: ""
        /// Line coverage:   ../Homework/StudentFind 48 50 55
        /// </summary>
        [Theory, InlineData("John", "")]
        public void NameShouldNotBeFound(string name, string expectValue)
        {
            var result = _studentFind.Find(name);
            Assert.Equal(result, expectValue);
        }
    }
    
    public class StudentFindTest
    {
        private readonly StudentFind _studentFind;

        public StudentFindTest()
        {
            _studentFind = new StudentFind();
        }

        [Theory,
        InlineData("Nick", "4094W007"),
        InlineData("Aven", "4094W010"),
        InlineData("Totti", "4094W011"),
        InlineData("Jeff", "4094W012"),
        InlineData("Terry", "4094W008"),
        ]
        public void NameShouldBeFound(string name, string expectValue)
        {
            var result = _studentFind.Find(name);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("John", ""), InlineData("Jack", "")]
        public void NameShouldNotBeFound(string name, string expectValue)
        {
            var result = _studentFind.Find(name);
            Assert.Equal(result, expectValue);
        }
    }
}